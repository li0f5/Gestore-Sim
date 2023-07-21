namespace Gestore_Sim
{
    internal class ClasseSimUsate
    {
        int id;
        string presoDa;
        string presoA;
        string presoPer;
        public ClasseSimUsate(int id, string presoDa, string presoA, string presoPer)
        {
            this.id = id;
            this.presoDa = presoDa;
            this.presoA = presoA;
            this.presoPer = presoPer;
        }

        public int getId() { return id; }
        public string getPresoDa() { return presoDa; }
        public string getPresoA() { return presoA; }
        public string getPresoPer() { return presoPer; }

        public override string ToString()
        {
            return id + " | " +
                presoDa + " | " +
                presoA + " | " +
                presoPer;
        }
    }
}
