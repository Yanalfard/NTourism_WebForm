namespace NTourism.Models.Regular
{
    public class TblResume
    {
        public int id { get; set; }

        public string Name { get; set; }

        public TblResume(int id)
        {
            this.id = id;
        }

        public TblResume(string name)
        {
            Name = name;
        }

        public TblResume(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public TblResume()
        {
        }
    }
}