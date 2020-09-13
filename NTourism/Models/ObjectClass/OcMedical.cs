using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Models.ObjectClass
{
    public class OcMedical : TblMedicalService
    {

        [Display(Name = "ImageName")]
        public string ImageName { get; set; }
        public List<string> Images { get; set; }
        public List<int> ImagesId { get; set; }
        public OcMedical()
        {

        }
        public OcMedical(TblMedicalService medical)
        {
            id = medical.id;
            FirstName = medical.FirstName;
            LastName = medical.LastName;
            SicknessName = medical.SicknessName;
            SicknessDesc = medical.SicknessDesc;
            PassNo = medical.PassNo;
            ImageName = new ImagesService().SelectImageById(medical.PassportImageId).Image;
            List<TblImages> imagesFromDb = new MedicalServiceService().SelectImagessByMedicalServiceId(medical.id);
            if (imagesFromDb != null)
            {
                Images = new List<string>();
                foreach (TblImages image in imagesFromDb)
                {
                    Images.Add(image.Image);
                }
                ImagesId = new List<int>();
                foreach (TblImages imageId in imagesFromDb)
                {
                    Images.Add(imageId.Image);
                }
            }
        }
    }
}