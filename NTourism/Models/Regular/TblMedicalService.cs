namespace NTourism.Models.Regular
{
    public class TblMedicalService
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SicknessName { get; set; }
        public string SicknessDesc { get; set; }
        public string PassNo { get; set; }
        public int PassportImageId { get; set; }

        public TblMedicalService(int id)
        {
            this.id = id;
        }

		public TblMedicalService(int id, string firstName, string lastName, string sicknessName, string sicknessDesc, string passNo, int passportImageId)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            SicknessName = sicknessName;
            SicknessDesc = sicknessDesc;
            PassNo = passNo;
            PassportImageId = passportImageId;
        }

        public TblMedicalService(string firstName, string lastName, string sicknessName, string sicknessDesc, string passNo, int passportImageId)
        {
            FirstName = firstName;
            LastName = lastName;
            SicknessName = sicknessName;
            SicknessDesc = sicknessDesc;
            PassNo = passNo;
            PassportImageId = passportImageId;
        }

        public TblMedicalService()
        {
            
        }
    }
}