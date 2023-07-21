namespace Gestore_Sim
{
    internal class ClasseSim
    {
        private int id;
        private long iccid;
        private long sim;
        private string stato;

        public ClasseSim(long iccid, long sim)
        {
            this.iccid = iccid;
            this.sim = sim;
        }
        public ClasseSim(int id, long iccid, long sim, string stato)
        {
            this.id = id;
            this.iccid = iccid;
            this.sim = sim;
            this.stato = stato;
        }

        public int getId() { return id; }
        public long getIccid() { return iccid; }
        public long getSim() { return sim; }
        public string getStato() { return stato; }


        public override string ToString()
        {
            return "\t" + id + "\t| \t"
                + iccid + "\t | \t"
                + sim;
        }
    }
}
