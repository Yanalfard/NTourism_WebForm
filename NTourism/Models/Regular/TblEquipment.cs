namespace NTourism.Models.Regular
{
    public class TblEquipment
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public TblEquipment(int id)
        {
            this.id = id;
        }

        public TblEquipment(string name, string logo)
        {
            Name = name;
            Logo = logo;
        }

        public TblEquipment(int id, string name, string logo)
        {
            this.id = id;
            Name = name;
            Logo = logo;
        }

        public TblEquipment()
        {
        }
    }
}