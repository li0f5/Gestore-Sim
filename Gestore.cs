using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Gestore_Sim
{
    internal class Gestore
    {
        private static List<ClasseSim> simC = new();//lista sim completa

        public static ClasseSim[] Lettura(String path)
        {
            long numeroConto;
            long iccid;
            long sim;
            string profilo;
            string stato;
            string data;

            using (TextFieldParser csvReader = new TextFieldParser(path))
            {
                csvReader.Delimiters = new string[] { ";" };
                csvReader.HasFieldsEnclosedInQuotes = true;

                // salta la riga con i nomi delle colonne
                csvReader.ReadLine();
                while (!csvReader.EndOfData)
                {
                    // legge la riga corrente per poi spostare il puntatore a quella dopo
                    string[] fields = csvReader.ReadFields();
                    numeroConto = long.Parse(fields[0]);
                    iccid = long.Parse(fields[1]);
                    sim = long.Parse(fields[2]);
                    profilo = fields[3];
                    stato = fields[4];
                    data = fields[5];

                    simC.Add(new ClasseSim(iccid, sim));
                }
                return simC.ToArray();
            }
        }

        public static void Scrittura(String path, string sim)//crea un file testo contente i dati di una sim assegnata
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write(sim);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Fatto");
            }
        }

        public static async void Invio(string presoDa, string presoA, string presoPer, string iccid, string sim)//utilizzando un bot telegram invia un messaggio a una specifica chat 
        {
            try
            {
                var botClient = new TelegramBotClient(GetToken());
                string messagio = "<i>preso da:</i> \t" + presoDa + "\n" +
                                "<i>preso a:</i> \t" + presoA + "\n" +
                                "<i>preso per:</i> \t" + presoPer + "\n" +
                                "<i>iccid:</i> \t" + iccid + "\n" +
                                "<i>sim:</i> \t<b>[ <code>" + sim + "</code> ]</b>";

                await botClient.SendTextMessageAsync(GetChatId(), messagio, parseMode: ParseMode.Html, disableNotification: true);
                MessageBox.Show("inviato");
            }
            catch (Exception) { MessageBox.Show("bot non collegato"); }
        }

        public static string GetToken()//legge il token del bot precedentemente salvato in un file 
        {
            string token;
            DirectoryInfo dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pratoallarmi\\GesstoreSim");//C:\ProgramData\Pratoallarmi\GesstoreSim\
            string docPath = dir.FullName;
            if (System.IO.File.Exists(Path.Combine(docPath, "Token.txt")))
            {
                StreamReader sr = new StreamReader(Path.Combine(docPath, "Token.txt"));
                token = sr.ReadLine();
                sr.Close();
            }
            else//se il file non e` presente ne crea uno con all'interno un token di default
            {
                token = "6125171734:AAE28qtP6wtJYLvdD0X-FSGnJCRlksOGF20";
                SetToken(token);
            }
            return token;
        }
        public static void SetToken(string token)//dato un token lo salva nel file Token.txt del path C:\ProgramData\Pratoallarmi\GesstoreSim\
        {
            DirectoryInfo dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pratoallarmi\\GesstoreSim");//C:\ProgramData\Pratoallarmi\GesstoreSim
            string docPath = dir.FullName;
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(docPath, "Token.txt"));
                sw.Write(token);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore", "Errore Token: " + e.Message);
            }
        }

        public static List<string> GetChats()//restituisce gli id delle chat che hanno provato a comunicare con il bot tramite il comando /start
        {
            List<string> chats = new List<string>();
            try
            {
                var botClient = new TelegramBotClient(GetToken());
                var update = botClient.GetUpdatesAsync().Result;
                string chatName;

                foreach (var item in update)
                {
                    //per accettare solo messagi
                    if (item.Message is not { } message)
                        continue;
                    //per accetare solo messaggi testuali
                    if (message.Text is not { } messageText)
                        continue;
                    //per accettare il messagio testuola equivalente a '/start'
                    if (messageText != "/start")
                        continue;
                    //controlla il nome della chat o username che lo ha richiamato
                    if(message.Chat.Type == ChatType.Private)
                    {
                        chatName = message.Chat.Username;
                    }
                    else
                    {
                        chatName = message.Chat.Title;
                    }

                    chats.Add(message.Chat.Id.ToString() + "  -->-->-->  " + chatName);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Errore","Errore nel trovare chat su telegram: " + e.Message);
            }

            return chats;
        }
        public static string GetChatId()//legge il chat id del bot precedentemente salvato in un file 
        {
            string chatId;
            
            DirectoryInfo dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pratoallarmi\\GesstoreSim");//C:\ProgramData\Pratoallarmi\GesstoreSim\
            string docPath = dir.FullName;
            if (System.IO.File.Exists(Path.Combine(docPath, "ChatId.txt")))
            {
                StreamReader sr = new StreamReader(Path.Combine(docPath, "ChatId.txt"));
                chatId = sr.ReadLine();
                sr.Close();
            }
            else//se il file non e` presente ne crea uno con all'interno un id di default
            {
                chatId = "-907027658";
                SetChatId(chatId);
            }
            return chatId;
        }
        public static void SetChatId(string chat)//dato un id lo salva nel file ChatId.txt del path C:\ProgramData\Pratoallarmi\GesstoreSim\
        {
            String[] chatId = chat.Split("  -->-->-->  ");

            DirectoryInfo dir = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pratoallarmi\\GesstoreSim");//C:\ProgramData\Pratoallarmi\GesstoreSim\
            string docPath = dir.FullName;
            try
            {
                StreamWriter sw = new StreamWriter(Path.Combine(docPath, "ChatId.txt"));
                sw.Write(chatId[0]);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore", "Errore Chat: " + e.Message);
            }
        }
    }
}
