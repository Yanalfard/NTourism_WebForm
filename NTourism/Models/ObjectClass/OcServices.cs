using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Models.ObjectClass
{
    public class OcServices:TblRoomHome
    {
        public TblClient Client { get; set; }
        public string City { get; set; }
        public List<TblComments> Comments { get; set; }
        public List<string> Images { get; set; }
        public List<int> ImagesId { get; set; }

        [MaxLength(100)]
        public List<string> ImagesName { get; set; }
        public List<SelectListItem> Facility { get; set; }
        public List<int> FacilityId { get; set; }

        public OcServices()
        {

        }
        public OcServices(TblRoomHome services)
        {
            id = services.id;
            Name = services.Name;
            MainImage = services.MainImage;
            City = new CityService().SelectCityById(services.CityId).Name;
            Client = new ClientService().SelectClientById(services.ClientId);
            PriceNormal = services.PriceNormal;
            PriceWeekend = services.PriceWeekend;
            DaysOccupaid = services.DaysOccupaid;
            OccupaidFrom = services.OccupaidFrom;
            OccupaidTo = services.OccupaidTo;
            IsReserved = services.IsReserved;
            Description = services.Description;
            IsSelected = services.IsSelected;
            Comments = new RoomHomeService().SelectCommentsByRoomHome(services.id);
            //Facility = new RoomHomeService().SelectFacilitiesByRoomHome(services.id);
            //Images = new RoomHomeService().SelectImagesByRoomHome(services.id);
            List<TblImages> imagesFromDb = new RoomHomeService().SelectImagesByRoomHome(services.id);
            if (imagesFromDb != null)
            {
                Images = new List<string>();
                ImagesName = new List<string>();
                foreach (TblImages image in imagesFromDb)
                {
                    Images.Add(image.Image);
                    ImagesName.Add(image.Name);
                }
                ImagesId = new List<int>();
                foreach (TblImages imageId in imagesFromDb)
                {
                    ImagesId.Add(imageId.id);

                }
            }

            List<TblFacility> facilityFromDb = new RoomHomeService().SelectFacilitiesByRoomHome(services.id);
            if (facilityFromDb != null)
            {
                Facility = new List<SelectListItem>();
                foreach (TblFacility facility in facilityFromDb)
                {
                    SelectListItem a = new SelectListItem();
                    a.Value = facility.Name;
                    Facility.Add(a);
                }
                FacilityId = new List<int>();
                foreach (TblFacility facilityId in facilityFromDb)
                {
                    FacilityId.Add(facilityId.id);
                }
            }
        }
    }
}