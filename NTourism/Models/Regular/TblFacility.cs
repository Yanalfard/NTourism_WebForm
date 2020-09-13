namespace NTourism.Models.Regular
{
    public class TblFacility
    {
        public int id { get; set; }

        public string Name { get; set; }

        public TblFacility(int id)
        {
            this.id = id;
        }

        public TblFacility(string name)
        {
            Name = name;
        }

        public TblFacility(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public TblFacility()
        {
        }
    }
}