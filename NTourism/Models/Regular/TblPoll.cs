namespace NTourism.Models.Regular
{
    public class TblPoll
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Vote { get; set; }

        public TblPoll(int id)
        {
            this.id = id;
        }

		public TblPoll(int id, string name, int vote)
        {
            this.id = id;
            Name = name;
            Vote = vote;
        }
        public TblPoll(string name, int vote)
        {
            Name = name;
            Vote = vote;
        }

        public TblPoll()
        {
            
        }
    }
}