namespace NTourism.Models.Regular
{
    public class TblMedicalServiceImagesRel
    {
        public int id { get; set; }
        public int MedicalServiceId { get; set; }
        public string Image { get; set; }

        public TblMedicalServiceImagesRel(int id)
        {
            this.id = id;
        }

		public TblMedicalServiceImagesRel(int id, int medicalServiceId, string image)
        {
            this.id = id;
            MedicalServiceId = medicalServiceId;
            Image = image;
        }

        public TblMedicalServiceImagesRel(int medicalServiceId, string image)
        {
            MedicalServiceId = medicalServiceId;
            Image = image;
        }

        public TblMedicalServiceImagesRel()
        {
            
        }
    }
}