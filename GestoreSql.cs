using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using System.Data;

namespace Gestore_Sim
{
    internal class GestoreSql
    {
        public static ServerConnection ConnesioneServer()//crea la connesione al server sql
        {
            string[] credenziali = GetConnesione().Split("-");

            ServerConnection connesione = new ServerConnection(credenziali[2]);
            connesione.LoginSecure = false;
            connesione.Login = credenziali[0];
            connesione.Password = credenziali[1];
            return connesione;
        }
        //--------------------------------------------------------------------------------------------------------------------------


        public static string GetConnesione()//impostazioni di connesione
        {
            string credenziali;
            DirectoryInfo dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pratoallarmi\\GesstoreSim");
            string docPath = dir.FullName;
            if (File.Exists(Path.Combine(docPath, "Credenziali.txt")))
            {
                StreamReader sr = new StreamReader(Path.Combine(docPath, "Credenziali.txt"));
                credenziali = sr.ReadLine();
                sr.Close();
            }
            else
            {
                string id = "test";
                string psw = "Password.1";
                string server = "192.168.100.227";
                SetConnesione(id, psw, server);
                credenziali = id + "-" + psw + "-" + server;
            }
            return credenziali;
        }
        public static void SetConnesione(string id, string psw, string server)
        {
            string credenziali = id + "-" + psw + "-" + server;
            DirectoryInfo dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pratoallarmi\\GesstoreSim");
            string docPath = dir.FullName;
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(docPath, "Credenziali.txt"));
                sw.Write(credenziali);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore: " + e.Message);
            }
        }
        //--------------------------------------------------------------------------------------------

        public static void ImportSim(ClasseSim[] sims)//importa le sim sulla tabella sim
        {
            string commandText = "BEGIN IF EXISTS (SELECT * FROM sim WHERE iccid=@iccid)" +
                    " BEGIN UPDATE sim SET iccid = @iccid, nTell = @sim, stato = 1 where iccid =@iccid; END " +
                    " ELSE  BEGIN insert into sim (iccid, nTell, stato) VALUES (@iccid,@sim,1); end END";
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandText, new SqlConnection(con.ConnectionString));
            command.Parameters.Add("@iccid", SqlDbType.BigInt);
            command.Parameters.Add("@sim", SqlDbType.BigInt);
            for (int i = 0; i < sims.Length; i++)
            {
                command.Parameters["@iccid"].Value = sims[i].getIccid();
                command.Parameters["@sim"].Value = sims[i].getSim();
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                SqlDataReader reader = con.ExecuteReader("select id from sim where iccid=" + sims[i].getIccid());
                reader.Read();
                Log("sim inserito in sim", reader.GetInt32(0));
                reader.Close();
            }
            con.Disconnect();
        }
        //--------------------------------------------------------------------------------

        public static List<ClasseSim> ExportSim()//esporta nella lista
        {
            List<ClasseSim> sims = new List<ClasseSim>();
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select sim.id,iccid,nTell,sim.stato from sim left join simUsate sU on sim.id = sU.id where sU.id is null");
            while (reader.Read())
            {
                sims.Add(new ClasseSim(reader.GetInt32(0), reader.GetInt64(1), reader.GetInt64(2), reader.GetInt32(3).ToString()));
            }
            reader.Close();
            con.Disconnect();
            return sims;
        }
        //------------------------------------------------------------

        public static ClasseSim SimByIndice(int id)//restituisce la sim con l'indice corrispondente a quello dato
        {
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select id,iccid,nTell from sim where id='" + id + "'");
            reader.Read();
            ClasseSim i = new ClasseSim(reader.GetInt32(0), reader.GetInt64(1), reader.GetInt64(2), "");
            reader.Close();
            con.Disconnect();

            return i;
        }
        //--------------------------------------------------------------------------------------------------------

        public static void ImportSimUsate(int id, string consegnato, string cliente, string tecnnico)// importa le sim sulla tabella simUsate
        {
            int iCliente = IndiceCliente(cliente);
            int iTecnico = IndiceTecnico(tecnnico);
            string commandtext = "BEGIN IF EXISTS (SELECT * FROM simUsate WHERE id= @id)" +
                " BEGIN UPDATE simUsate SET [preso da] = @presoDa, [preso a] = @presoA, [preso per] = @presoPer, data = CURRENT_TIMESTAMP, stato = 1 where id = @id; END" +
                " ELSE  BEGIN insert into simUsate (id, [preso da], [preso a], [preso per], data, stato) VALUES (@id, @presoDa, @presoA, @presoPer, CURRENT_TIMESTAMP, 1); end  END";
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandtext, new SqlConnection(con.ConnectionString));

            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = Convert.ToInt32(id);

            command.Parameters.Add("@presoA", SqlDbType.Int);
            command.Parameters["@presoA"].Value = Convert.ToInt32(iTecnico);

            command.Parameters.Add("@presoPer", SqlDbType.Int);
            command.Parameters["@presoPer"].Value = Convert.ToInt32(iCliente);

            command.Parameters.AddWithValue("@presoDa", consegnato);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            MessageBox.Show("Fatto");
            Log("sim inserito in sim usate", id);
            con.Disconnect();
        }
        //---------------------------------------------------------------------------------------------------------------------------------

        public static List<ClasseSimUsate> ExportSimUsate()//esporta le sim presenti nella tabella simUsate
        {
            List<ClasseSimUsate> simsUsate = new List<ClasseSimUsate>();
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select id,[preso da],[preso a],[preso per] from simUsate");
            while (reader.Read())
            {
                simsUsate.Add(new ClasseSimUsate(reader.GetInt32(0), reader.GetString(1), GestoreSql.TecnicoByIndice(reader.GetInt32(2)), GestoreSql.ClienteByIndice(reader.GetInt32(3))));
            }
            reader.Close();
            con.Disconnect();
            return simsUsate;
        }
        //----------------------------------------------------------------------------------------------

        public static void DelSimUsate(int[] id)//rimuove una/delle sim dalla tabella simUsate
        {
            ServerConnection con = ConnesioneServer();
            for (int i = 0; i < id.Length; i++)
            {
                con.ExecuteNonQuery("delete from simUsate where id=" + id[i] + ";");
                Log("sim tolta da simUsate", id[i]);
            }
            MessageBox.Show("Fatto");
            con.Disconnect();
        }
        //-------------------------------------------------------------------------------------

        public static string[] ExportTecnici()//esporta il nome e cognome dei tecnici
        {
            List<string> tecnici = new List<string>();
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select nome, cognome, ditta from tecnici");
            while (reader.Read())
            {
                tecnici.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }
            reader.Close();
            con.Disconnect();

            return tecnici.ToArray();
        }
        //----------------------------------------------------------------------------

        public static void NuovoTecnico(string nome, string cognome, string ditta)//aggiunge il tecnico all'interno della tabella tecnici
        {
            string commandText = "BEGIN IF NOT EXISTS(SELECT * FROM tecnici WHERE nome=@nome AND cognome=@cognome AND ditta=@ditta)" +
                "BEGIN INSERT INTO tecnici(nome, cognome, ditta) VALUES(@nome,@cognome,@ditta); END END";
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandText, new SqlConnection(con.ConnectionString));
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@cognome", cognome);
            command.Parameters.AddWithValue("@ditta", ditta);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            SqlDataReader reader = con.ExecuteReader("select id from tecnici where nome=N'" + nome + "' AND cognome=N'" + cognome + "'");
            reader.Read();
            Log("tecnico inserito in tecnici", reader.GetInt32(0));
            reader.Close();
            con.Disconnect();
        }
        //------------------------------------------------------------------------------------------------------------------

        private static int IndiceTecnico(string nomecompleto)//restituisce l'indice del tecnico all'interno della tabella
        {
            string[] nomec = nomecompleto.Split(' ');
            string nome = nomec[0];
            string cognome = nomec[1];
            string ditta = nomec[2];
            int i = -1;
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select id from tecnici where nome=N'" + nome + "' and cognome=N'" + cognome + "' and ditta = N'" + ditta + "'");
            reader.Read();
            i = reader.GetInt32(0);

            reader.Close();
            con.Disconnect();

            return i;
        }
        //-----------------------------------------------------------------------------------------------------------------

        public static string TecnicoByIndice(int id)//restituisce nome e cognome tecnico dato l'indice
        {
            string i;
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select nome, cognome, ditta from tecnici where id='" + id + "'");
            reader.Read();
            i = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
            reader.Close();
            con.Disconnect();

            return i;
        }
        //-------------------------------------------------------------------------------------------

        public static void Cliente(string nome, string ragioneSociale, string indirizzo, string luogo)//aggiunge un cliente all'interno della tabella clienti
        {
            string commandText = "BEGIN IF NOT EXISTS(SELECT * FROM clienti WHERE nome= @nome)" +
                "BEGIN INSERT INTO clienti (nome,[ragione sociale],indirizzo,luogo) VALUES ( @nome, @ragioneSociale, @indirizzo, @luogo); END END";
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandText, new SqlConnection(con.ConnectionString));
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@ragioneSociale", ragioneSociale);
            command.Parameters.AddWithValue("@indirizzo", indirizzo);
            command.Parameters.AddWithValue("@luogo", luogo);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            SqlDataReader reader = con.ExecuteReader("select id from clienti where nome = '" + nome + "'");
            reader.Read();
            Log("cliente inserito in clienti", reader.GetInt32(0));
            reader.Close();
            con.Disconnect();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------

        private static int IndiceCliente(string nomecompleto)//restituisce l'indice del cliente all'interno della tabella
        {
            int i = -1;
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select id from clienti where nome='" + nomecompleto + "'");
            reader.Read();
            i = reader.GetInt32(0);
            reader.Close();
            con.Disconnect();

            return i;
        }
        //----------------------------------------------------------------------------------------------------------------

        public static string ClienteByIndice(int id)//restituisce nome e cognome cliente dato l'indice
        {
            string i;
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select nome from clienti where id='" + id + "'");
            reader.Read();
            i = reader.GetString(0);
            reader.Close();
            con.Disconnect();

            return i;
        }
        //-------------------------------------------------------------------------------------------

        public static void Log(string messaggio, int id)//registra le azzioni importanti all'interno della tabella log
        {
            ServerConnection con = ConnesioneServer();
            con.ExecuteNonQuery("insert into log (log,[id oggetto], data) VALUES ('" + messaggio + "', " + id + ", current_timestamp)");
            con.Disconnect();
        }
        //------------------------------------------------------------------------------------------------------------

        public static List<string> ExportLog()//esporta la tabella log
        {
            List<string> log = new List<string>();
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select id,log,[id oggetto],data from log");
            while (reader.Read())
            {
                log.Add("\t" + reader.GetInt32(0) + "\t | \t" + reader.GetString(1) + "\t | \t" + reader.GetInt32(2) + "\t | \t" + reader.GetDateTime(3));
            }
            reader.Close();
            con.Disconnect();
            return log;
        }
        //------------------------------------------------------------

        public static bool Accesso(string user, string psw)//controlla che user e password corrispondano per far accedere all'aplicazione
        {
            bool b = false;
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select utente from utenti where utente =N'" + user + "' and password =N'" + psw + "'");
            reader.Read();
            try
            {
                if (reader.GetString(0) != null) { b = true; }
            }
            catch (Exception ex) { }
            reader.Close();
            con.Disconnect();
            return b;
        }
        //-------------------------------------------------------------------------------------------------------------------------------

        public static void AggiungiUtente(string user, string psw)//agiunge un utente alla lista utenti
        {
            string commandText = "BEGIN IF NOT EXISTS(SELECT * FROM utenti WHERE utente=@utente and password=@psw)" +
                "BEGIN INSERT INTO utenti (utente,password,privilegi) VALUES ( @utente, @psw, 1); END END";
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandText, new SqlConnection(con.ConnectionString));
            command.Parameters.AddWithValue("@utente", user);
            command.Parameters.AddWithValue("@psw", psw);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            con.Disconnect();
            MessageBox.Show("Fatto");
        }
        //----------------------------------------------------------------------------------------------

        public static void Eliminautente(string user, string psw, int p)//elimina un utente dalla lista utenti
        {
            string commandText = "DELETE FROM utenti WHERE utente=@utente and password=@psw and privilegi<=" + p;
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandText, new SqlConnection(con.ConnectionString));
            command.Parameters.AddWithValue("@utente", user);
            command.Parameters.AddWithValue("@psw", psw);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            con.Disconnect();
            MessageBox.Show("Fatto");
        }
        //-----------------------------------------------------------------------------------------------------

        public static void ModificaUtente(string user, string psw, string vUser, string vPsw, int priv)//modifica un utente dalla lista utenti
        {
            string commandText = "UPDATE utenti SET ";
            if (user != "") { commandText += "utente=@utente, "; }
            if (psw != "") { commandText += "password=@psw, "; }
            if (priv != -1) { commandText += "privilegi=@priv "; }
            commandText += "WHERE utente=@vutente and password=@vpsw";
            ServerConnection con = ConnesioneServer();
            SqlCommand command = new SqlCommand(commandText, new SqlConnection(con.ConnectionString));
            command.Parameters.AddWithValue("@utente", user);
            command.Parameters.AddWithValue("@psw", psw);
            command.Parameters.AddWithValue("@vutente", vUser);
            command.Parameters.AddWithValue("@vpsw", vPsw);
            command.Parameters.Add("@priv", SqlDbType.Int);
            command.Parameters["@priv"].Value = priv;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            con.Disconnect();
            MessageBox.Show("Fatto");
        }
        //-----------------------------------------------------------------------------------------------------------

        public static List<string> ExportUtenti(int p)//esporta la tabella utenti
        {
            List<string> utenti = new List<string>();
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("select utente,password,privilegi from utenti where privilegi<=" + p);
            while (reader.Read())
            {
                utenti.Add("\t" + reader.GetString(0) + "\t | \t" + reader.GetString(1) + "\t | \t" + reader.GetInt32(2));
            }
            reader.Close();
            con.Disconnect();
            return utenti;
        }
        //----------------------------------------------------------------------

        internal static int GetPrivilegi(string utente, string psw)//estrae il dato privilegio corrispondente all'utente e password dalla tabella utenti 
        {
            int i;
            ServerConnection con = ConnesioneServer();
            SqlDataReader reader = con.ExecuteReader("SELECT privilegi FROM utenti WHERE utente=N'" + utente + "' AND password=N'" + psw + "'");
            reader.Read();
            i = reader.GetInt32(0);
            reader.Close();
            con.Disconnect();
            return i;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------
    }
}
