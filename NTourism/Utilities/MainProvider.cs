using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using NTourism.Models.Regular;
//###############################################check point
namespace NTourism.Utilities
{
    public class MainProvider
    {
        private static readonly string ConnectionString = Config.ConnectionString;
        private SqlConnection _connection;
        private SqlCommand _command;
        private string _commandText = "";

        public MainProvider()
        {
            _connection = new SqlConnection(ConnectionString);
            _connection.Open();
        }

        private void _disconnect()
        {
            _connection.Close();
        }

        public enum Tables
        {
            TblAttraction,
            TblAttractionCommentsRel,
            TblAttractionEquipmentRel,
            TblAttractionPollRel,
            TblAd,
            TblCity,
            TblCountry,
            TblPoll,
            TblClient,
            TblComments,
            TblEquipment,
            TblFacility,
            TblRoomHome,
            TblRoomHomeCommentsRel,
            TblRoomHomeFacilityRel,
            TblRoomHomeImageRel,
            TblImages,
            TblNews,
            TblResume,
            TblText,
            TblTourGuide,
            TblTourGuideEquipmentRel,
            TblTourGuideImagesRel,
            TblTourGuideResumeRel,
            TblTripStoryCommentRel,
            TblTripStory,
            TblTicket,
            TblMedicalService,
            TblMedicalServiceImagesRel,
            TblFirstPage,
            TblCityAttractionRel,
            Services4
        }

        public enum AttractionCommentsRel
        {
            AttractionId,
            CommentId
        }

        public enum AttractionPollRel
        {
            AttractionId,
            PollId
        }

        public enum AttractionEquipmentRel
        {
            AttractionId,
            EquipmentId
        }

        public enum HotelCommentsRel
        {
            RoomHomeId,
            CommentId
        }

        public enum HotelFacilityRel
        {
            RoomHomeId,
            FacilityId
        }

        public enum RoomHomeImageRel
        {
            RoomHomeId,
            ImageId
        }

        public enum TourGuideEquipmentRel
        {
            TourGuideId,
            EquipmentId
        }

        public enum TourGuideImagesRel
        {
            TourGuideId,
            ImageId
        }

        public enum TourGuideResumeRel
        {
            TourGuideId,
            ResumeId
        }

        public enum TripStoryCommentRel
        {
            TripStoryId,
            CommentId
        }

        public enum MedicalServiceImagesRel
        {
            MedicalServiceId,
            ImageId
        }

        public enum CityAttractionRel
        {
            AttractionId,
            RoomHomeId,
            CityId
        }

        public object Add<T>(T table)
        {
            //try
            //{
            object tableObj = table;
            SqlCommand command;
            if (table.GetType() == typeof(TblAttraction))
            {
                TblAttraction attraction = (TblAttraction)tableObj;
                if (!MethodRepo.ExistInDb("TblAttraction", "Title", attraction.Title))
                {
                    _commandText = $"insert into TblAttraction (Name , Title , TextId , ImageId , IsText , CityId , Score , OrderId , Status , IsSelected) values (N'{attraction.Name}' , N'{attraction.Title}' , N'{attraction.TextId}' , N'{attraction.ImageId}' , N'{attraction.IsText}' , N'{attraction.CityId}' , N'{attraction.Score}' , N'{attraction.OrderId}' , N'{attraction.Status}' , N'{attraction.IsSelected}' )";
                    command = new SqlCommand($"select TOP (1) * from TblAttraction where Title = N'{attraction.Title}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblAttraction(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Score"].ToString() != "" ? Convert.ToInt32(reader["Score"]) : 0, reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false);
                }
                else return new TblAttraction(-1);
            }
            else if (table.GetType() == typeof(TblCityAttractionRel))
            {
                TblCityAttractionRel cityAttractionRel = (TblCityAttractionRel)tableObj;

                _commandText = $"insert into TblCityAttractionRel (AttractionId , RoomHomeId , CityId) values (N'{cityAttractionRel.AttractionId}' , N'{cityAttractionRel.RoomHomeId}' , N'{cityAttractionRel.CityId}' )";
                command = new SqlCommand($"select TOP (1) * from TblCityAttractionRel where id = '{cityAttractionRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblCityAttractionRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0, reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0, reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0);
            }
            else if (table.GetType() == typeof(TblTourGuide))
            {
                TblTourGuide tourGuide = (TblTourGuide)tableObj;
                if (!MethodRepo.ExistInDb("TblTourGuide", "Username", tourGuide.Username))
                {
                    _commandText = $"insert into TblTourGuide (FirstName , LastName , TellNo , Email , MainImage , Description , Username , Password , CityId , Rate , Discount , Price) values (N'{tourGuide.FirstName}' , N'{tourGuide.LastName}' , N'{tourGuide.TellNo}' , N'{tourGuide.Email}' , N'{tourGuide.MainImage}' , N'{tourGuide.Description}' , N'{tourGuide.Username}' , N'{tourGuide.Password}' , N'{tourGuide.CityId}' , N'{tourGuide.Rate}' , N'{tourGuide.Discount}' , N'{tourGuide.Price}')";
                    command = new SqlCommand($"select TOP (1) * from TblTourGuide where Username = N'{tourGuide.Username}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0);
                }
                else return new TblTourGuide(-1);
            }

            else if (table.GetType() == typeof(TblImages))
            {
                TblImages images = (TblImages)tableObj;
                _commandText = $"insert into TblImages (Image , Name) values (N'{images.Image}' , N'{images.Name}' )";
                command = new SqlCommand($"select TOP (1) * from TblImages where Name = N'{images.Name}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblImages(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Image"].ToString(), reader["Name"].ToString());
            }

            else if (table.GetType() == typeof(TblMedicalService))
            {
                TblMedicalService medicalService = (TblMedicalService)tableObj;

                _commandText = $"insert into TblMedicalService (FirstName , LastName , SicknessName , SicknessDesc , PassNo , PassportImageId) values (N'{medicalService.FirstName}' , N'{medicalService.LastName}' , N'{medicalService.SicknessName}' , N'{medicalService.SicknessDesc}' , N'{medicalService.PassNo}' , N'{medicalService.PassportImageId}' )";
                command = new SqlCommand($"select TOP (1) * from TblMedicalService where FirstName = N'{medicalService.FirstName}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblMedicalService(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["SicknessName"].ToString(), reader["SicknessDesc"].ToString(), reader["PassNo"].ToString(), reader["PassportImageId"].ToString() != "" ? Convert.ToInt32(reader["PassportImageId"]) : 0);
            }
            else if (table.GetType() == typeof(TblMedicalServiceImagesRel))
            {
                TblMedicalServiceImagesRel medicalServiceImagesRel = (TblMedicalServiceImagesRel)tableObj;

                _commandText = $"insert into TblMedicalServiceImagesRel (MedicalServiceId , Image) values (N'{medicalServiceImagesRel.MedicalServiceId}' , N'{medicalServiceImagesRel.Image}' )";
                command = new SqlCommand($"select TOP (1) * from TblMedicalServiceImagesRel where id = N'{medicalServiceImagesRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblMedicalServiceImagesRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["MedicalServiceId"].ToString() != "" ? Convert.ToInt32(reader["MedicalServiceId"]) : 0, reader["Image"].ToString());
            }
            else if (table.GetType() == typeof(TblText))
            {
                TblText text = (TblText)tableObj;

                _commandText = $"insert into TblText (Text , Rtf) values (N'{text.Text}' , N'{text.Rtf}' )";
                command = new SqlCommand($"select TOP (1) * from TblText where Text = N'{text.Text}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblText(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Text"].ToString(), reader["Rtf"].ToString());
            }
            else if (table.GetType() == typeof(TblTripStoryCommentRel))
            {
                TblTripStoryCommentRel tripStoryCommentRel = (TblTripStoryCommentRel)tableObj;

                _commandText = $"insert into TblTripStoryCommentRel (TripStoryId , CommentId) values (N'{tripStoryCommentRel.TripStoryId}' , N'{tripStoryCommentRel.CommentId}' )";
                command = new SqlCommand($"select TOP (1) * from TblTripStoryCommentRel where id = N'{tripStoryCommentRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblTripStoryCommentRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["TripStoryId"].ToString() != "" ? Convert.ToInt32(reader["TripStoryId"]) : 0, reader["CommentId"].ToString() != "" ? Convert.ToInt32(reader["CommentId"]) : 0);
            }
            else if (table.GetType() == typeof(TblTripStory))
            {
                TblTripStory tripStory = (TblTripStory)tableObj;
                if (!MethodRepo.ExistInDb("TblTripStory", "Title", tripStory.Title))
                {
                    _commandText = $"insert into TblTripStory (Title , CityId , MainImage , TextId , imageId , DatePosted) values (N'{tripStory.Title}' , N'{tripStory.CityId}' , N'{tripStory.MainImage}' , N'{tripStory.TextId}' , N'{tripStory.imageId}' , N'{tripStory.DatePosted}' )";
                    command = new SqlCommand($"select TOP (1) * from TblTripStory where Title = N'{tripStory.Title}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblTripStory(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Title"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["MainImage"].ToString(), reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["imageId"].ToString() != "" ? Convert.ToInt32(reader["imageId"]) : 0, reader["DatePosted"].ToString());
                }
                else return new TblTripStory(-1);
            }

            else if (table.GetType() == typeof(TblRoomHome))
            {
                TblRoomHome roomHome = (TblRoomHome)tableObj;
                if (!MethodRepo.ExistInDb("TblRoomHome", "Name", roomHome.Name))
                {
                    _commandText = $"insert into TblRoomHome (Name , MainImage , ClientId , CityId , PriceNormal , PriceWeekend , DaysOccupaid , OccupaidFrom , OccupaidTo , IsReserved , Description , IsSelected) values (N'{roomHome.Name}' , N'{roomHome.MainImage}' , N'{roomHome.ClientId}' , N'{roomHome.CityId}' , N'{roomHome.PriceNormal}' , N'{roomHome.PriceWeekend}' , N'{roomHome.DaysOccupaid}' , N'{roomHome.OccupaidFrom}' , N'{roomHome.OccupaidTo}' , N'{roomHome.IsReserved}' , N'{roomHome.Description}' , N'{roomHome.IsSelected}' )";
                    command = new SqlCommand($"select TOP (1) * from TblRoomHome where Name = N'{roomHome.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblRoomHome(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["MainImage"].ToString(), reader["ClientId"].ToString() != "" ? Convert.ToInt32(reader["ClientId"]) : 0, reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["PriceNormal"].ToString() != "" ? long.Parse(reader["PriceNormal"].ToString()) : 0, reader["PriceWeekend"].ToString() != "" ? long.Parse(reader["PriceWeekend"].ToString()) : 0, reader["DaysOccupaid"].ToString() != "" ? Convert.ToInt32(reader["DaysOccupaid"]) : 0, reader["OccupaidFrom"].ToString(), reader["OccupaidTo"].ToString(), reader["IsReserved"].ToString() != "" ? Convert.ToBoolean(reader["IsReserved"]) : false, reader["Description"].ToString(), reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false);
                }
                else return new TblRoomHome(-1);
            }

            else if (table.GetType() == typeof(TblFirstPage))
            {
                TblFirstPage firstPage = (TblFirstPage)tableObj;
                if (!MethodRepo.ExistInDb("TblFirstPage", "Image", firstPage.Image))
                {
                    _commandText = $"insert into TblFirstPage (Sign , Image , Text , IsText) values (N'{firstPage.Sign}' , N'{firstPage.Image}' , N'{firstPage.Text}' , N'{firstPage.IsText}' )";
                    command = new SqlCommand($"select TOP (1) * from TblFirstPage where Image = N'{firstPage.Image}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblFirstPage(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Sign"].ToString(), reader["Image"].ToString(), reader["Text"].ToString(), reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false);
                }
                else return new TblFirstPage(-1);
            }

            else if (table.GetType() == typeof(TblPoll))
            {
                TblPoll poll = (TblPoll)tableObj;
                if (!MethodRepo.ExistInDb("TblPoll", "Name", poll.Name))
                {
                    _commandText = $"insert into TblPoll (Name , Vote) values (N'{poll.Name}' , N'{poll.Vote}' )";
                    command = new SqlCommand($"select TOP (1) * from TblPoll where Name = N'{poll.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblPoll(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Vote"].ToString() != "" ? Convert.ToInt32(reader["Vote"]) : 0);
                }
                else return new TblPoll(-1);
            }

            else if (table.GetType() == typeof(TblAttractionPollRel))
            {
                TblAttractionPollRel attractionPollRel = (TblAttractionPollRel)tableObj;

                _commandText = $"insert into TblAttractionPollRel (AttractionId , PollId) values (N'{attractionPollRel.AttractionId}' , N'{attractionPollRel.PollId}' )";
                command = new SqlCommand($"select TOP (1) * from TblAttractionPollRel where id = N'{attractionPollRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblAttractionPollRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0, reader["PollId"].ToString() != "" ? Convert.ToInt32(reader["PollId"]) : 0);
            }
            else if (table.GetType() == typeof(TblAttractionEquipmentRel))
            {
                TblAttractionEquipmentRel attractionEquipmentRel = (TblAttractionEquipmentRel)tableObj;

                _commandText = $"insert into TblAttractionEquipmentRel (AttractionId , EquipmentId) values (N'{attractionEquipmentRel.AttractionId}' , N'{attractionEquipmentRel.EquipmentId}' )";
                command = new SqlCommand($"select TOP (1) * from TblAttractionEquipmentRel where id = N'{attractionEquipmentRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblAttractionEquipmentRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0, reader["EquipmentId"].ToString() != "" ? Convert.ToInt32(reader["EquipmentId"]) : 0);
            }
            else if (table.GetType() == typeof(TblComments))
            {
                TblComments comments = (TblComments)tableObj;

                _commandText = $"insert into TblComments (Text , ClientId , IsValid) values (N'{comments.Text}' , N'{comments.ClientId}' , N'{comments.IsValid}' )";
                command = new SqlCommand($"select TOP (1) * from TblComments where Text = N'{comments.Text}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblComments(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Text"].ToString(), reader["ClientId"].ToString() != "" ? Convert.ToInt32(reader["ClientId"]) : 0, reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false);
            }
            else if (table.GetType() == typeof(TblAttractionCommentsRel))
            {
                TblAttractionCommentsRel attractionCommentsRel = (TblAttractionCommentsRel)tableObj;

                _commandText = $"insert into TblAttractionCommentsRel (AttractionId , CommentId) values (N'{attractionCommentsRel.AttractionId}' , N'{attractionCommentsRel.CommentId}' )";
                command = new SqlCommand($"select TOP (1) * from TblAttractionCommentsRel where id = N'{attractionCommentsRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblAttractionCommentsRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0, reader["CommentId"].ToString() != "" ? Convert.ToInt32(reader["CommentId"]) : 0);
            }
            else if (table.GetType() == typeof(TblCountry))
            {
                TblCountry country = (TblCountry)tableObj;
                if (!MethodRepo.ExistInDb("TblCountry", "Name", country.Name))
                {
                    _commandText = $"insert into TblCountry (Name) values (N'{country.Name}' )";
                    command = new SqlCommand($"select TOP (1) * from TblCountry where Name = N'{country.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblCountry(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString());
                }
                else return new TblCountry(-1);
            }

            else if (table.GetType() == typeof(TblCity))
            {
                TblCity city = (TblCity)tableObj;
                if (!MethodRepo.ExistInDb("TblCity", "Name", city.Name))
                {
                    _commandText = $"insert into TblCity (Name , CountryId , Data , MapLink, MainImage , IsValid) values (N'{city.Name}' , N'{city.CountryId}' , N'{city.Data}' , N'{city.MapLink}' , N'{city.MainImage}' , N'{city.IsValid}')";
                    command = new SqlCommand($"select TOP (1) * from TblCity where Name = N'{city.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblCity(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["CountryId"].ToString() != "" ? Convert.ToInt32(reader["CountryId"]) : 0, reader["Data"].ToString(), reader["MapLink"].ToString(), reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false);
                }
                else return new TblCity(-1);
            }

            else if (table.GetType() == typeof(TblTicket))
            {
                TblTicket ticket = (TblTicket)tableObj;
                if (!MethodRepo.ExistInDb("TblTicket", "Title", ticket.Title))
                {
                    _commandText = $"insert into TblTicket (Name , Email , ReciverId , Title , Text , DateSended) values (N'{ticket.Name}' , N'{ticket.Email}' , N'{ticket.ReciverId}' , N'{ticket.Title}' , N'{ticket.Text}' , N'{ticket.DateSended}' )";
                    command = new SqlCommand($"select TOP (1) * from TblTicket where Title = N'{ticket.Title}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblTicket(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Email"].ToString(), reader["ReciverId"].ToString() != "" ? Convert.ToInt32(reader["ReciverId"]) : 0, reader["Title"].ToString(), reader["Text"].ToString(), reader["DateSended"].ToString());
                }
                else return new TblTicket(-1);
            }

            else if (table.GetType() == typeof(TblFacility))
            {
                TblFacility facility = (TblFacility)tableObj;
                if (!MethodRepo.ExistInDb("TblFacility", "Name", facility.Name))
                {
                    _commandText = $"insert into TblFacility (Name) values (N'{facility.Name}' )";
                    command = new SqlCommand($"select TOP (1) * from TblFacility where Name = N'{facility.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblFacility(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString());
                }
                else return new TblFacility(-1);
            }

            else if (table.GetType() == typeof(TblNews))
            {
                TblNews news = (TblNews)tableObj;
                if (!MethodRepo.ExistInDb("TblNews", "Title", news.Title))
                {
                    _commandText = $"insert into TblNews (Name , Title , OrderId , TextId , ImageId , IsText , IsSelected , MainImage , IsValid , IsPinned) values (N'{news.Name}' , N'{news.Title}' , N'{news.OrderId}' , N'{news.TextId}' , N'{news.ImageId}' , N'{news.IsText}' , N'{news.IsSelected}' , N'{news.MainImage}' , N'{news.IsValid}' , N'{news.IsPinned}')";
                    command = new SqlCommand($"select TOP (1) * from TblNews where Title = N'{news.Title}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false);
                }
                else return new TblNews(-1);
            }

            else if (table.GetType() == typeof(TblRoomHomeCommentsRel))
            {
                TblRoomHomeCommentsRel roomHomeCommentsRel = (TblRoomHomeCommentsRel)tableObj;

                _commandText = $"insert into TblRoomHomeCommentsRel (RoomHomeId , CommentId) values (N'{roomHomeCommentsRel.RoomHomeId}' , N'{roomHomeCommentsRel.CommentId}' )";
                command = new SqlCommand($"select TOP (1) * from TblRoomHomeCommentsRel where id = N'{roomHomeCommentsRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblRoomHomeCommentsRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0, reader["CommentId"].ToString() != "" ? Convert.ToInt32(reader["CommentId"]) : 0);
            }
            else if (table.GetType() == typeof(TblAd))
            {
                TblAd ad = (TblAd)tableObj;
                if (!MethodRepo.ExistInDb("TblAd", "Image", ad.Image))
                {
                    _commandText = $"insert into TblAd (Image , Link , PositionId , IsAvailable) values (N'{ad.Image}' , N'{ad.Link}' , N'{ad.PositionId}' , N'{ad.IsAvailable}' )";
                    command = new SqlCommand($"select TOP (1) * from TblAd where Image = N'{ad.Image}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblAd(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Image"].ToString(), reader["Link"].ToString(), reader["PositionId"].ToString(), reader["IsAvailable"].ToString() != "" ? Convert.ToBoolean(reader["IsAvailable"]) : false);
                }
                else return new TblAd(-1);
            }

            else if (table.GetType() == typeof(TblRoomHomeFacilityRel))
            {
                TblRoomHomeFacilityRel roomHomeFacilityRel = (TblRoomHomeFacilityRel)tableObj;

                _commandText = $"insert into TblRoomHomeFacilityRel (RoomHomeId , FacilityId) values (N'{roomHomeFacilityRel.RoomHomeId}' , N'{roomHomeFacilityRel.FacilityId}' )";
                command = new SqlCommand($"select TOP (1) * from TblRoomHomeFacilityRel where RoomHomeId = N'{roomHomeFacilityRel.RoomHomeId}' and FacilityId = N'{roomHomeFacilityRel.FacilityId}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblRoomHomeFacilityRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0, reader["FacilityId"].ToString() != "" ? Convert.ToInt32(reader["FacilityId"]) : 0);
            }
            else if (table.GetType() == typeof(TblRoomHomeImageRel))
            {
                TblRoomHomeImageRel roomHomeImageRel = (TblRoomHomeImageRel)tableObj;

                _commandText = $"insert into TblRoomHomeImageRel (RoomHomeId , ImageId) values (N'{roomHomeImageRel.RoomHomeId}' , N'{roomHomeImageRel.ImageId}' )";
                command = new SqlCommand($"select TOP (1) * from TblRoomHomeImageRel where RoomHomeId = N'{roomHomeImageRel.RoomHomeId}' and ImageId = N'{roomHomeImageRel.ImageId}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblRoomHomeImageRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0);
            }
            else if (table.GetType() == typeof(TblEquipment))
            {
                TblEquipment equipment = (TblEquipment)tableObj;
                if (!MethodRepo.ExistInDb("TblEquipment", "Name", equipment.Name))
                {
                    _commandText = $"insert into TblEquipment (Name , Logo) values (N'{equipment.Name}' , N'{equipment.Logo}' )";
                    command = new SqlCommand($"select TOP (1) * from TblEquipment where Name = N'{equipment.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblEquipment(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Logo"].ToString());
                }
                else return new TblEquipment(-1);
            }

            else if (table.GetType() == typeof(TblResume))
            {
                TblResume resume = (TblResume)tableObj;
                if (!MethodRepo.ExistInDb("TblResume", "Name", resume.Name))
                {
                    _commandText = $"insert into TblResume (Name) values (N'{resume.Name}' )";
                    command = new SqlCommand($"select TOP (1) * from TblResume where Name = N'{resume.Name}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblResume(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString());
                }
                else return new TblResume(-1);
            }

            else if (table.GetType() == typeof(TblClient))
            {
                TblClient client = (TblClient)tableObj;
                if (!MethodRepo.ExistInDb("TblClient", "Username", client.Username))
                {
                    _commandText = $"insert into TblClient (FirstName , LastName , TellNo , Email , Username , Password , Status) values (N'{client.FirstName}' , N'{client.LastName}' , N'{client.TellNo}' , N'{client.Email}' , N'{client.Username}' , N'{client.Password}' , N'{client.Status}' )";
                    command = new SqlCommand($"select TOP (1) * from TblClient where Username = N'{client.Username}' ORDER BY id DESC", _connection);
                    _command = new SqlCommand(_commandText, _connection);
                    _command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    return new TblClient(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["Username"].ToString(), reader["Password"].ToString(), reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0);
                }
                else return new TblClient(-1);
            }

            else if (table.GetType() == typeof(TblTourGuideEquipmentRel))
            {
                TblTourGuideEquipmentRel tourGuideEquipmentRel = (TblTourGuideEquipmentRel)tableObj;

                _commandText = $"insert into TblTourGuideEquipmentRel (TourGuideId , EquipmentId) values (N'{tourGuideEquipmentRel.TourGuideId}' , N'{tourGuideEquipmentRel.EquipmentId}' )";
                command = new SqlCommand($"select TOP (1) * from TblTourGuideEquipmentRel where id = N'{tourGuideEquipmentRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblTourGuideEquipmentRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["TourGuideId"].ToString() != "" ? Convert.ToInt32(reader["TourGuideId"]) : 0, reader["EquipmentId"].ToString() != "" ? Convert.ToInt32(reader["EquipmentId"]) : 0);
            }
            else if (table.GetType() == typeof(TblTourGuideResumeRel))
            {
                TblTourGuideResumeRel tourGuideResumeRel = (TblTourGuideResumeRel)tableObj;

                _commandText = $"insert into TblTourGuideResumeRel (TourGuideId , ResumeId) values (N'{tourGuideResumeRel.TourGuideId}' , N'{tourGuideResumeRel.ResumeId}' )";
                command = new SqlCommand($"select TOP (1) * from TblTourGuideResumeRel where id = N'{tourGuideResumeRel.id}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblTourGuideResumeRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["TourGuideId"].ToString() != "" ? Convert.ToInt32(reader["TourGuideId"]) : 0, reader["ResumeId"].ToString() != "" ? Convert.ToInt32(reader["ResumeId"]) : 0);
            }
            else if (table.GetType() == typeof(TblTourGuideImagesRel))
            {
                TblTourGuideImagesRel tourGuideImagesRel = (TblTourGuideImagesRel)tableObj;

                _commandText = $"insert into TblTourGuideImagesRel (TourGuideId , ImageId) values (N'{tourGuideImagesRel.TourGuideId}' , N'{tourGuideImagesRel.ImageId}' )";
                command = new SqlCommand($"select TOP (1) * from TblTourGuideImagesRel where TourGuideId = N'{tourGuideImagesRel.TourGuideId}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblTourGuideImagesRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["TourGuideId"].ToString() != "" ? Convert.ToInt32(reader["TourGuideId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0);
            }
            else
            {
                return false;
            }
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //    finally
            //    {
            //        _disconnect();
            //    }
        }

        public bool Update<T>(T table, int logId)
        {
            try
            {
                object tableObj = table;
                if (table.GetType() == typeof(TblAttraction))
                {
                    TblAttraction attraction = (TblAttraction)tableObj;
                    _commandText = $"update TblAttraction set Name = N'{attraction.Name}' , Title = N'{attraction.Title}' , TextId = N'{attraction.TextId}' , ImageId = N'{attraction.ImageId}' , IsText = N'{attraction.IsText}' , CityId = N'{attraction.CityId}' , Score = N'{attraction.Score}' , OrderId = N'{attraction.OrderId}' , Status = N'{attraction.Status}' , IsSelected = N'{attraction.IsSelected}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTourGuide))
                {
                    TblTourGuide tourGuide = (TblTourGuide)tableObj;
                    _commandText = $"update TblTourGuide set FirstName = N'{tourGuide.FirstName}' , LastName = N'{tourGuide.LastName}' , TellNo = N'{tourGuide.TellNo}' , Email = N'{tourGuide.Email}' , MainImage = N'{tourGuide.MainImage}' , Description = N'{tourGuide.Description}' , Username = N'{tourGuide.Username}' , Password = N'{tourGuide.Password}' , CityId = N'{tourGuide.CityId}' , Rate = N'{tourGuide.Rate}' , Discount = N'{tourGuide.Discount}' , Price = N'{tourGuide.Price}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblCityAttractionRel))
                {
                    TblCityAttractionRel cityAttractionRel = (TblCityAttractionRel)tableObj;
                    _commandText = $"update TblCityAttractionRel set AttractionId = N'{cityAttractionRel.AttractionId}' , RoomHomeId = N'{cityAttractionRel.RoomHomeId}' , CityId = N'{cityAttractionRel.CityId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblImages))
                {
                    TblImages images = (TblImages)tableObj;
                    _commandText = $"update TblImages set Image = N'{images.Image}' , Name = N'{images.Name}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblMedicalService))
                {
                    TblMedicalService medicalService = (TblMedicalService)tableObj;
                    _commandText = $"update TblMedicalService set FirstName = N'{medicalService.FirstName}' , LastName = N'{medicalService.LastName}' , SicknessName = N'{medicalService.SicknessName}' , SicknessDesc = N'{medicalService.SicknessDesc}' , PassNo = N'{medicalService.PassNo}' , PassportImageId = N'{medicalService.PassportImageId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblMedicalServiceImagesRel))
                {
                    TblMedicalServiceImagesRel medicalServiceImagesRel = (TblMedicalServiceImagesRel)tableObj;
                    _commandText = $"update TblMedicalServiceImagesRel set MedicalServiceId = N'{medicalServiceImagesRel.MedicalServiceId}' , Image = N'{medicalServiceImagesRel.Image}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblText))
                {
                    TblText text = (TblText)tableObj;
                    _commandText = $"update TblText set Text = N'{text.Text}' , Rtf = N'{text.Rtf}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTripStoryCommentRel))
                {
                    TblTripStoryCommentRel tripStoryCommentRel = (TblTripStoryCommentRel)tableObj;
                    _commandText = $"update TblTripStoryCommentRel set TripStoryId = N'{tripStoryCommentRel.TripStoryId}' , CommentId = N'{tripStoryCommentRel.CommentId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTripStory))
                {
                    TblTripStory tripStory = (TblTripStory)tableObj;
                    _commandText = $"update TblTripStory set Title = N'{tripStory.Title}' , CityId = N'{tripStory.CityId}' , MainImage = N'{tripStory.MainImage}' , TextId = N'{tripStory.TextId}' , imageId = N'{tripStory.imageId}' , DatePosted = N'{tripStory.DatePosted}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblRoomHome))
                {
                    TblRoomHome roomHome = (TblRoomHome)tableObj;
                    _commandText = $"update TblRoomHome set Name = N'{roomHome.Name}' , MainImage = N'{roomHome.MainImage}' , ClientId = N'{roomHome.ClientId}' , CityId = N'{roomHome.CityId}' , PriceNormal = N'{roomHome.PriceNormal}' , PriceWeekend = N'{roomHome.PriceWeekend}' , DaysOccupaid = N'{roomHome.DaysOccupaid}' , OccupaidFrom = N'{roomHome.OccupaidFrom}' , OccupaidTo = N'{roomHome.OccupaidTo}' , IsReserved = N'{roomHome.IsReserved}' , Description = N'{roomHome.Description}' , IsSelected = N'{roomHome.IsSelected}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblPoll))
                {
                    TblPoll poll = (TblPoll)tableObj;
                    _commandText = $"update TblPoll set Name = N'{poll.Name}' , Vote = N'{poll.Vote}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblAttractionPollRel))
                {
                    TblAttractionPollRel attractionPollRel = (TblAttractionPollRel)tableObj;
                    _commandText = $"update TblAttractionPollRel set AttractionId = N'{attractionPollRel.AttractionId}' , PollId = N'{attractionPollRel.PollId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblAttractionEquipmentRel))
                {
                    TblAttractionEquipmentRel attractionEquipmentRel = (TblAttractionEquipmentRel)tableObj;
                    _commandText = $"update TblAttractionEquipmentRel set AttractionId = N'{attractionEquipmentRel.AttractionId}' , EquipmentId = N'{attractionEquipmentRel.EquipmentId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblComments))
                {
                    TblComments comments = (TblComments)tableObj;
                    _commandText = $"update TblComments set Text = N'{comments.Text}' , ClientId = N'{comments.ClientId}' , IsValid = N'{comments.IsValid}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblAttractionCommentsRel))
                {
                    TblAttractionCommentsRel attractionCommentsRel = (TblAttractionCommentsRel)tableObj;
                    _commandText = $"update TblAttractionCommentsRel set AttractionId = N'{attractionCommentsRel.AttractionId}' , CommentId = N'{attractionCommentsRel.CommentId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblCountry))
                {
                    TblCountry country = (TblCountry)tableObj;
                    _commandText = $"update TblCountry set Name = N'{country.Name}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblCity))
                {
                    TblCity city = (TblCity)tableObj;
                    _commandText = $"update TblCity set Name = N'{city.Name}' , CountryId = N'{city.CountryId}' , Data = N'{city.Data}' , MapLink = N'{city.MapLink}' , MainImage = N'{city.MainImage}' , IsValid = '{city.IsValid}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTicket))
                {
                    TblTicket ticket = (TblTicket)tableObj;
                    _commandText = $"update TblTicket set Name = N'{ticket.Name}' , Email = N'{ticket.Email}' , ReciverId = N'{ticket.ReciverId}' , Title = N'{ticket.Title}' , Text = N'{ticket.Text}' , DateSended = N'{ticket.DateSended}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblFacility))
                {
                    TblFacility facility = (TblFacility)tableObj;
                    _commandText = $"update TblFacility set Name = N'{facility.Name}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblNews))
                {
                    TblNews news = (TblNews)tableObj;
                    _commandText = $"update TblNews set Name = N'{news.Name}' , Title = N'{news.Title}' , OrderId = N'{news.OrderId}' , TextId = N'{news.TextId}' , ImageId = N'{news.ImageId}' , IsText = N'{news.IsText}' , IsSelected = N'{news.IsSelected}' , MainImage = N'{news.MainImage}' , IsValid = '{news.IsValid}' , IsPinned = N'{news.IsPinned}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblRoomHomeCommentsRel))
                {
                    TblRoomHomeCommentsRel roomHomeCommentsRel = (TblRoomHomeCommentsRel)tableObj;
                    _commandText = $"update TblRoomHomeCommentsRel set RoomHomeId = N'{roomHomeCommentsRel.RoomHomeId}' , CommentId = N'{roomHomeCommentsRel.CommentId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblAd))
                {
                    TblAd ad = (TblAd)tableObj;
                    _commandText = $"update TblAd set Image = N'{ad.Image}' , Link = N'{ad.Link}' , PositionId = N'{ad.PositionId}' , IsAvailable = N'{ad.IsAvailable}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblRoomHomeFacilityRel))
                {
                    TblRoomHomeFacilityRel roomHomeFacilityRel = (TblRoomHomeFacilityRel)tableObj;
                    _commandText = $"update TblRoomHomeFacilityRel set RoomHomeId = N'{roomHomeFacilityRel.RoomHomeId}' , FacilityId = N'{roomHomeFacilityRel.FacilityId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblRoomHomeImageRel))
                {
                    TblRoomHomeImageRel roomHomeImageRel = (TblRoomHomeImageRel)tableObj;
                    _commandText = $"update TblRoomHomeImageRel set RoomHomeId = N'{roomHomeImageRel.RoomHomeId}' , ImageId = N'{roomHomeImageRel.ImageId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblEquipment))
                {
                    TblEquipment equipment = (TblEquipment)tableObj;
                    _commandText = $"update TblEquipment set Name = N'{equipment.Name}' , Logo = N'{equipment.Logo}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblResume))
                {
                    TblResume resume = (TblResume)tableObj;
                    _commandText = $"update TblResume set Name = N'{resume.Name}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblClient))
                {
                    TblClient client = (TblClient)tableObj;
                    _commandText = $"update TblClient set FirstName = N'{client.FirstName}' , LastName = N'{client.LastName}' , TellNo = N'{client.TellNo}' , Email = N'{client.Email}' , Username = N'{client.Username}' , Password = N'{client.Password}' , Status = N'{client.Status}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTourGuideEquipmentRel))
                {
                    TblTourGuideEquipmentRel tourGuideEquipmentRel = (TblTourGuideEquipmentRel)tableObj;
                    _commandText = $"update TblTourGuideEquipmentRel set TourGuideId = N'{tourGuideEquipmentRel.TourGuideId}' , EquipmentId = N'{tourGuideEquipmentRel.EquipmentId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTourGuideResumeRel))
                {
                    TblTourGuideResumeRel tourGuideResumeRel = (TblTourGuideResumeRel)tableObj;
                    _commandText = $"update TblTourGuideResumeRel set TourGuideId = N'{tourGuideResumeRel.TourGuideId}' , ResumeId = N'{tourGuideResumeRel.ResumeId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblTourGuideImagesRel))
                {
                    TblTourGuideImagesRel tourGuideImagesRel = (TblTourGuideImagesRel)tableObj;
                    _commandText = $"update TblTourGuideImagesRel set TourGuideId = N'{tourGuideImagesRel.TourGuideId}' , ImageId = N'{tourGuideImagesRel.ImageId}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblFirstPage))
                {
                    TblFirstPage firstPage = (TblFirstPage)tableObj;
                    _commandText = $"update TblFirstPage set Sign = N'{firstPage.Sign}' , Image = N'{firstPage.Image}' , Text = N'{firstPage.Text}' , IsText = N'{firstPage.IsText}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(Tbl4Services))
                {
                    Tbl4Services tbl = (Tbl4Services)tableObj;
                    _commandText = $"update Tbl4Services set Title = N'{tbl.Title}' , Text = N'{tbl.Text}' where id = N'{logId}'";
                }
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _disconnect();
            }
        }

        public bool Delete(Tables tableType, int id)
        {
            try
            {
                _commandText = $"delete from {tableType.ToString()} where id = N'{id}'";
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _disconnect();
            }
        }

        public IEnumerable SelectAll(Tables tableType)
        {
            try
            {
                if (tableType == Tables.Services4)

                {
                    _commandText = $"select * from Tbl4Services";

                }
                else
                    _commandText = $"select * from {tableType.ToString()}";
                _command = new SqlCommand(_commandText, _connection);
                SqlDataReader reader = _command.ExecuteReader();
                switch (tableType)
                {
                    case Tables.TblAttraction:
                        List<TblAttraction> Attractions = new List<TblAttraction>();
                        while (reader.Read())
                            Attractions.Add(new TblAttraction(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                                reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                                Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                                Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                                Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                                Convert.ToBoolean(reader["IsSelected"])));
                        return Attractions;
                    case Tables.Services4:
                        List<Tbl4Services> services4 = new List<Tbl4Services>();
                        while (reader.Read())
                            services4.Add(new Tbl4Services(Convert.ToInt32(reader["id"]), reader["Title"].ToString(),
                                reader["Text"].ToString(),
                                Convert.ToInt32(reader["Status"])));
                        return services4;
                    case Tables.TblCityAttractionRel:
                        List<TblCityAttractionRel> cityAttractionRels = new List<TblCityAttractionRel>();
                        while (reader.Read())
                            cityAttractionRels.Add(new TblCityAttractionRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0,
                                reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0,
                                reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0,
                                reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0));
                        return cityAttractionRels;
                    case Tables.TblAttractionCommentsRel:
                        List<TblAttractionCommentsRel> AttractionCommentsRels = new List<TblAttractionCommentsRel>();
                        while (reader.Read())
                            AttractionCommentsRels.Add(new TblAttractionCommentsRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["AttractionId"].ToString()),
                                Convert.ToInt32(reader["CommentId"].ToString())));

                        return AttractionCommentsRels;
                    case Tables.TblCity:

                        List<TblCity> cities = new List<TblCity>();
                        while (reader.Read())
                            cities.Add(new TblCity(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["CountryId"].ToString() != "" ? Convert.ToInt32(reader["CountryId"]) : 0, reader["Data"].ToString(), reader["MapLink"].ToString(), reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false));

                        return cities;
                    case Tables.TblClient:
                        List<TblClient> clients = new List<TblClient>();
                        while (reader.Read())
                            clients.Add(new TblClient(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                                reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),
                                reader["Username"].ToString(), reader["Password"].ToString(),
                                Convert.ToInt32(reader["Status"])));

                        return clients;
                    case Tables.TblComments:
                        List<TblComments> commentses = new List<TblComments>();
                        while (reader.Read())
                            commentses.Add(new TblComments(Convert.ToInt32(reader["id"]), reader["Text"].ToString(),
                                Convert.ToInt32(reader["ClientId"]), Convert.ToBoolean(reader["IsValid"])));

                        return commentses;
                    case Tables.TblCountry:
                        List<TblCountry> countries = new List<TblCountry>();
                        while (reader.Read())
                            countries.Add(new TblCountry(Convert.ToInt32(reader["id"]), reader["Name"].ToString()));

                        return countries;

                    case Tables.TblPoll:
                        List<TblPoll> polls = new List<TblPoll>();
                        while (reader.Read())
                            polls.Add(new TblPoll(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                                Convert.ToInt32(reader["Vote"])));

                        return polls;
                    case Tables.TblAttractionPollRel:
                        List<TblAttractionPollRel> AttractionPollRels = new List<TblAttractionPollRel>();
                        while (reader.Read())
                            AttractionPollRels.Add(new TblAttractionPollRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["AttractionId"]), Convert.ToInt32(reader["PollId"])));

                        return AttractionPollRels;
                    case Tables.TblEquipment:
                        List<TblEquipment> equipments = new List<TblEquipment>();
                        while (reader.Read())
                            equipments.Add(new TblEquipment(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                                reader["Logo"].ToString()));

                        return equipments;
                    case Tables.TblFacility:
                        List<TblFacility> facilities = new List<TblFacility>();
                        while (reader.Read())
                            facilities.Add(new TblFacility(Convert.ToInt32(reader["id"]), reader["Name"].ToString()));

                        return facilities;
                    case Tables.TblRoomHome:
                        List<TblRoomHome> roomHomes = new List<TblRoomHome>();
                        while (reader.Read())
                            roomHomes.Add(new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                                reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                                Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                                long.Parse(reader["PriceWeekend"].ToString()),
                                Convert.ToInt32(reader["DaysOccupaid"]), reader["OccupaidFrom"].ToString(),
                                reader["OccupaidTo"].ToString(), Convert.ToBoolean(reader["IsReserved"]),
                                reader["Description"].ToString(), Convert.ToBoolean(reader["IsSelected"])));

                        return roomHomes;
                    case Tables.TblRoomHomeCommentsRel:
                        List<TblRoomHomeCommentsRel> commentsRels = new List<TblRoomHomeCommentsRel>();
                        while (reader.Read())
                            commentsRels.Add(new TblRoomHomeCommentsRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["RoomHomeId"].ToString()),
                                Convert.ToInt32(reader["CommentId"])));

                        return commentsRels;
                    case Tables.TblRoomHomeFacilityRel:
                        List<TblRoomHomeFacilityRel> facilityRels = new List<TblRoomHomeFacilityRel>();
                        while (reader.Read())
                            facilityRels.Add(new TblRoomHomeFacilityRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["RoomHomeId"].ToString()),
                                Convert.ToInt32(reader["FacilityId"])));

                        return facilityRels;
                    case Tables.TblRoomHomeImageRel:
                        List<TblRoomHomeImageRel> hotelImageRels = new List<TblRoomHomeImageRel>();
                        while (reader.Read())
                            hotelImageRels.Add(new TblRoomHomeImageRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["RoomHomeId"].ToString()),
                                Convert.ToInt32(reader["ImageId"])));

                        return hotelImageRels;
                    case Tables.TblImages:
                        List<TblImages> imageses = new List<TblImages>();
                        while (reader.Read())
                            imageses.Add(new TblImages(Convert.ToInt32(reader["id"]),
                                reader["Image"].ToString(), reader["Name"].ToString()));

                        return imageses;
                    case Tables.TblNews:
                        List<TblNews> newses = new List<TblNews>();
                        while (reader.Read())
                            newses.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));

                        return newses;
                    case Tables.TblResume:
                        List<TblResume> resumes = new List<TblResume>();
                        while (reader.Read())
                            resumes.Add(new TblResume(Convert.ToInt32(reader["id"]), reader["Name"].ToString()));

                        return resumes;
                    case Tables.TblText:
                        List<TblText> texts = new List<TblText>();
                        while (reader.Read())
                            texts.Add(new TblText(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                                reader["Rtf"].ToString()));

                        return texts;
                    case Tables.TblTourGuide:
                        List<TblTourGuide> guides = new List<TblTourGuide>();
                        while (reader.Read())
                            guides.Add(new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0));

                        return guides;
                    case Tables.TblTourGuideEquipmentRel:
                        List<TblTourGuideEquipmentRel> tblTourGuideEquipmentRels = new List<TblTourGuideEquipmentRel>();
                        while (reader.Read())
                            tblTourGuideEquipmentRels.Add(new TblTourGuideEquipmentRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["TourGuideId"].ToString()),
                                Convert.ToInt32(reader["EquipmentId"])));

                        return tblTourGuideEquipmentRels;
                    case Tables.TblTourGuideImagesRel:
                        List<TblTourGuideImagesRel> guideImagesRels = new List<TblTourGuideImagesRel>();
                        while (reader.Read())
                            guideImagesRels.Add(new TblTourGuideImagesRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["TourGuideId"].ToString()),
                                Convert.ToInt32(reader["ImageId"])));

                        return guideImagesRels;
                    case Tables.TblTourGuideResumeRel:
                        List<TblTourGuideResumeRel> guideResumeRels = new List<TblTourGuideResumeRel>();
                        while (reader.Read())
                            guideResumeRels.Add(new TblTourGuideResumeRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["TourGuideId"].ToString()),
                                Convert.ToInt32(reader["ResumeId"])));

                        return guideResumeRels;
                    case Tables.TblAd:
                        List<TblAd> ads = new List<TblAd>();
                        while (reader.Read())
                            ads.Add(new TblAd(Convert.ToInt32(reader["id"]), reader["Image"].ToString(),
                                reader["Link"].ToString(), reader["PositionId"].ToString(),
                                Convert.ToBoolean(reader["IsAvailable"])));
                        return ads;
                    case Tables.TblAttractionEquipmentRel:

                        List<TblAttractionEquipmentRel> AttractionEquipmentRels = new List<TblAttractionEquipmentRel>();
                        while (reader.Read())
                            AttractionEquipmentRels.Add(new TblAttractionEquipmentRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["AttractionId"]),
                                Convert.ToInt32(reader["EquipmentId"])));
                        return AttractionEquipmentRels;
                    case Tables.TblTripStoryCommentRel:

                        List<TblTripStoryCommentRel> tripStoryCommentRels = new List<TblTripStoryCommentRel>();
                        while (reader.Read())
                            tripStoryCommentRels.Add(new TblTripStoryCommentRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["TripStoryId"]),
                                Convert.ToInt32(reader["CommentId"])));

                        return tripStoryCommentRels;
                    case Tables.TblTripStory:
                        List<TblTripStory> tripStories = new List<TblTripStory>();
                        while (reader.Read())
                            tripStories.Add(new TblTripStory(Convert.ToInt32(reader["id"]), reader["Title"].ToString(),
                                Convert.ToInt32(reader["CityId"]), reader["MainImage"].ToString(),
                                Convert.ToInt32(reader["TextId"]), Convert.ToInt32(reader["imageId"]),
                                reader["DatePosted"].ToString()));

                        return tripStories;
                    case Tables.TblTicket:
                        List<TblTicket> tickets = new List<TblTicket>();
                        while (reader.Read())
                            tickets.Add(new TblTicket(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                                reader["Email"].ToString(), Convert.ToInt32(reader["ReciverId"]),
                                reader["Title"].ToString(), reader["Text"].ToString(),
                                reader["DateSended"].ToString()));

                        return tickets;
                    case Tables.TblMedicalService:
                        List<TblMedicalService> medicalServices = new List<TblMedicalService>();
                        while (reader.Read())
                            medicalServices.Add(new TblMedicalService(Convert.ToInt32(reader["id"]),
                                reader["FirstName"].ToString(), reader["LastName"].ToString(),
                                reader["SicknessName"].ToString(), reader["SicknessDesc"].ToString(),
                                reader["PassNo"].ToString(), Convert.ToInt32(reader["PassportImageId"])));

                        return medicalServices;
                    case Tables.TblMedicalServiceImagesRel:
                        List<TblMedicalServiceImagesRel> medicalServiceImagesRels = new List<TblMedicalServiceImagesRel>();
                        while (reader.Read())
                            medicalServiceImagesRels.Add(new TblMedicalServiceImagesRel(Convert.ToInt32(reader["id"]),
                                Convert.ToInt32(reader["MedicalServiceId"]),
                                reader["Image"].ToString()));

                        return medicalServiceImagesRels;
                    case Tables.TblFirstPage:
                        List<TblFirstPage> firstPages = new List<TblFirstPage>();
                        while (reader.Read())
                            firstPages.Add(new TblFirstPage(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0,
                                reader["Sign"].ToString(), reader["Image"].ToString(), reader["Text"].ToString(),
                                reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false));

                        return firstPages;
                    default:
                        return new List<bool>();
                }
            }
            catch
            {
                return new List<bool>();
            }
            finally
            {
                _disconnect();
            }
        }

        public object SelectById(Tables table, int id)
        {
            try
            {
                string cmdTxt = "";
                if (table == Tables.Services4)
                {
                    _command = new SqlCommand($"select * from Tbl4Services where id = N'{id}'", _connection);
                }
                else
                    _command = new SqlCommand($"select * from {table.ToString()} where id = N'{id}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                if (table == Tables.TblAttraction)
                    return new TblAttraction(Convert.ToInt32(reader["id"]),
                        reader["Name"].ToString(),
                        reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                        Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                        Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                        Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                        Convert.ToBoolean(reader["IsSelected"]));
                else if (table == Tables.TblCityAttractionRel)
                    return new TblCityAttractionRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0,
                        reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0,
                        reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0,
                        reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0);
                else if (table == Tables.TblAttractionCommentsRel)
                    return new TblAttractionCommentsRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["AttractionId"].ToString()),
                        Convert.ToInt32(reader["CommentId"].ToString()));
                else if (table == Tables.TblCity)
                    return new TblCity(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["CountryId"].ToString() != "" ? Convert.ToInt32(reader["CountryId"]) : 0, reader["Data"].ToString(), reader["MapLink"].ToString(), reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false);
                else if (table == Tables.TblClient)
                    return new TblClient(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                        reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),//DONE
                        reader["Username"].ToString(), reader["Password"].ToString(),
                        Convert.ToInt32(reader["Status"]));
                else if (table == Tables.TblComments)
                    return new TblComments(Convert.ToInt32(reader["id"]), reader["Text"].ToString(),
                        Convert.ToInt32(reader["ClientId"]), Convert.ToBoolean(reader["IsValid"]));
                else if (table == Tables.TblCountry)
                    return new TblCountry(Convert.ToInt32(reader["id"]), reader["Name"].ToString());
                else if (table == Tables.TblEquipment)
                    return new TblEquipment(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["Logo"].ToString());
                else if (table == Tables.TblFacility)
                    return new TblFacility(Convert.ToInt32(reader["id"]), reader["Name"].ToString());
                else if (table == Tables.TblRoomHome)
                    return new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                        Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                        long.Parse(reader["PriceWeekend"].ToString()), Convert.ToInt32(reader["DaysOccupaid"]),
                        reader["OccupaidFrom"].ToString(), reader["OccupaidTo"].ToString(),
                        Convert.ToBoolean(reader["IsReserved"]), reader["Description"].ToString(),
                        Convert.ToBoolean(reader["IsSelected"]));
                else if (table == Tables.TblRoomHomeCommentsRel)
                    return new TblRoomHomeCommentsRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["RoomHomeId"].ToString()), Convert.ToInt32(reader["CommentId"]));
                else if (table == Tables.TblRoomHomeFacilityRel)
                    return new TblRoomHomeFacilityRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["RoomHomeId"].ToString()), Convert.ToInt32(reader["FacilityId"]));
                else if (table == Tables.TblRoomHomeImageRel)
                    return new TblRoomHomeImageRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["RoomHomeId"].ToString()), Convert.ToInt32(reader["ImageId"]));
                else if (table == Tables.TblPoll)
                    return new TblPoll(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        Convert.ToInt32(reader["Vote"]));
                else if (table == Tables.TblAttractionPollRel)
                    return new TblAttractionPollRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["AttractionId"]), Convert.ToInt32(reader["PollId"]));
                else if (table == Tables.TblImages)
                {
                    TblImages image = new TblImages(Convert.ToInt32(reader["id"]), reader["Image"].ToString(),
                        reader["Name"].ToString());
                    return image;
                }
                else if (table == Tables.TblNews)
                    return new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false);
                else if (table == Tables.TblResume)
                    return new TblResume(Convert.ToInt32(reader["id"]), reader["Name"].ToString());
                else if (table == Tables.TblText)
                    return new TblText(Convert.ToInt32(reader["id"]), reader["Text"].ToString(),
                        reader["Rtf"].ToString());
                else if (table == Tables.TblTourGuide)
                    return new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0);

                else if (table == Tables.TblTourGuideEquipmentRel)
                    return new TblTourGuideEquipmentRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TourGuideId"].ToString()),
                        Convert.ToInt32(reader["EquipmentId"]));
                else if (table == Tables.TblTourGuideImagesRel)
                    return new TblTourGuideImagesRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TourGuideId"].ToString()), Convert.ToInt32(reader["ImageId"]));
                else if (table == Tables.TblTourGuideResumeRel)
                    return new TblTourGuideResumeRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TourGuideId"].ToString()), Convert.ToInt32(reader["ResumeId"]));
                if (table == Tables.TblAd)
                    return new TblAd(Convert.ToInt32(reader["id"]), reader["Image"].ToString(),
                        reader["Link"].ToString(), reader["PositionId"].ToString(),
                        Convert.ToBoolean(reader["IsAvailable"]));
                else if (table == Tables.TblAttractionEquipmentRel)
                    return new TblAttractionEquipmentRel(Convert.ToInt32(reader["id"])
                        , Convert.ToInt32(reader["AttractionId"]), Convert.ToInt32(reader["EquipmentId"]));
                else if (table == Tables.TblTripStoryCommentRel)
                    return new TblTripStoryCommentRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TripStoryId"]), Convert.ToInt32(reader["CommentId"]));
                else if (table == Tables.TblTripStory)
                    return new TblTripStory(Convert.ToInt32(reader["id"]), reader["Title"].ToString(),
                        Convert.ToInt32(reader["CityId"]), reader["MainImage"].ToString(),
                        Convert.ToInt32(reader["TextId"]), Convert.ToInt32(reader["imageId"]),
                        reader["DatePosted"].ToString());
                else if (table == Tables.TblTicket)
                    return new TblTicket(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["Email"].ToString(), Convert.ToInt32(reader["ReciverId"]),
                        reader["Title"].ToString(), reader["Text"].ToString(),
                        reader["DateSended"].ToString());
                else if (table == Tables.TblMedicalService)
                    return new TblMedicalService(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                        reader["LastName"].ToString(), reader["SicknessName"].ToString(),
                        reader["SicknessDesc"].ToString(), reader["PassNo"].ToString(),
                        Convert.ToInt32(reader["PassportImageId"]));
                else if (table == Tables.TblMedicalServiceImagesRel)
                    return new TblMedicalServiceImagesRel(Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["MedicalServiceId"]), reader["Image"].ToString());
                else if (table == Tables.TblFirstPage)
                    return new TblFirstPage(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0,
                        reader["Sign"].ToString(), reader["Image"].ToString(), reader["Text"].ToString(),
                        reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false);
                else if (table == Tables.Services4)
                    return new Tbl4Services(Convert.ToInt32(reader["id"]), reader["Title"].ToString(),
                        reader["Text"].ToString(),
                        Convert.ToInt32(reader["Status"]));
                return null;
            }
            catch (Exception r)
            {
                throw r;
            }
            finally
            {
                _disconnect();
            }
        }

        #region TblCityAttractionRel

        public List<TblCityAttractionRel> SelectCityAttractionRel(int entry, CityAttractionRel entryType)
        {
            try
            {
                List<TblCityAttractionRel> ret = new List<TblCityAttractionRel>();
                if (entryType == CityAttractionRel.AttractionId)
                    _command = new SqlCommand($"select* from TblCityAttractionRel where AttractionId = N'{entry}'", _connection);
                else if (entryType == CityAttractionRel.RoomHomeId)
                    _command = new SqlCommand($"select* from TblCityAttractionRel where RoomHomeId = N'{entry}'", _connection);
                else if (entryType == CityAttractionRel.CityId)
                    _command = new SqlCommand($"select* from TblCityAttractionRel where CityId = N'{entry}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblCityAttractionRel(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["AttractionId"].ToString() != "" ? Convert.ToInt32(reader["AttractionId"]) : 0, reader["RoomHomeId"].ToString() != "" ? Convert.ToInt32(reader["RoomHomeId"]) : 0, reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0));
                return ret;
            }
            catch
            {
                return new List<TblCityAttractionRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblAttraction

        public List<TblAttraction> SelectAttractionByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                     new TblAttraction(Convert.ToInt32(reader["id"]),
                        reader["Name"].ToString(),
                        reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                        Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                        Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                        Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                        Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectAllEvents()
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where Status = 1", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectAllTripStories()
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where Status = 2", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectAttractionByIsSelected(bool isSelected)
        {
            try
            {
                int bools = 0;
                if (isSelected)
                {
                    bools = 1;
                }
                _command = new SqlCommand($"select * from TblAttraction where IsSelected = {bools} AND Status = 0", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectEventsByIsSelected(bool isSelected)
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where IsSelected = {isSelected} AND Status = 1", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectTripStoriesByIsSelected(bool isSelected)
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where IsSelected = {isSelected} AND Status = 2", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectAttractionByCityId(int cityId)
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where CityId = {cityId} AND Status = 2", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectEventsByCityId(int cityId)
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where CityId = {cityId} AND Status = 4", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectTripStoriesByIsCityId(int cityId)
        {
            try
            {
                _command = new SqlCommand($"select * from TblAttraction where CityId = {cityId} AND Status = 2", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblAttraction> Attractions = new List<TblAttraction>();
                while (reader.Read())
                    Attractions.Add(
                        new TblAttraction(Convert.ToInt32(reader["id"]),
                            reader["Name"].ToString(),
                            reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                            Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                            Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                            Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                            Convert.ToBoolean(reader["IsSelected"])));

                return Attractions;
            }
            catch
            {
                return new List<TblAttraction>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAttraction> SelectAttractionByStatus(int status)
        {
            //try
            //{
            _command = new SqlCommand($"select * from TblAttraction where Status = {status}", _connection);
            SqlDataReader reader = _command.ExecuteReader();
            List<TblAttraction> Attractions = new List<TblAttraction>();
            while (reader.Read())
                Attractions.Add(
                    new TblAttraction(Convert.ToInt32(reader["id"]),
                        reader["Name"].ToString(),
                        reader["Title"].ToString(), Convert.ToInt32(reader["TextId"].ToString()),
                        Convert.ToInt32(reader["ImageId"]), Convert.ToBoolean(reader["IsText"]),
                        Convert.ToInt32(reader["CityId"]), Convert.ToInt32(reader["Score"]),
                        Convert.ToInt32(reader["OrderId"]), Convert.ToInt32(reader["Status"]),

                        Convert.ToBoolean(reader["IsSelected"])));

            return Attractions;
            //}
            //catch
            //{
            //    return new List<TblAttraction>();
            //}
            //finally
            //{
            //    _disconnect();
            //}
        }
        #endregion

        #region TblAttractionCommentsRel
        public List<TblAttractionCommentsRel> SelectAttractionCommentsRel(int entry, AttractionCommentsRel entryType)
        {
            try
            {
                List<TblAttractionCommentsRel> ret = new List<TblAttractionCommentsRel>();
                if (entryType == AttractionCommentsRel.AttractionId)
                {
                    _command = new SqlCommand($"select * from TblAttractionCommentsRel where AttractionId = N'{entry}'", _connection);
                }
                else if (entryType == AttractionCommentsRel.CommentId)
                {
                    _command = new SqlCommand($"select * from TblAttractionCommentsRel where CommentId = N'{entry}'", _connection);
                }
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblAttractionCommentsRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["AttractionId"].ToString()),
                        Convert.ToInt32(reader["CommentId"].ToString())));
                }
                return ret;
            }
            catch
            {
                return new List<TblAttractionCommentsRel>();
            }
            finally
            {
                _disconnect();
            }
        }
        #endregion

        #region TblCity

        public List<TblCity> SelectCityByCountryId(int countryId)
        {
            try
            {
                List<TblCity> ret = new List<TblCity>();
                _command = new SqlCommand($"select * from TblCity where CountryId = N'{countryId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblCity(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["CountryId"].ToString() != "" ? Convert.ToInt32(reader["CountryId"]) : 0, reader["Data"].ToString(), reader["MapLink"].ToString(), reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false));
                return ret;
            }
            catch
            {
                return new List<TblCity>();
            }
            finally
            {
                _disconnect();
            }
        }

        public TblCity SelectCityByName(string name)
        {
            try
            {
                List<TblCity> ret = new List<TblCity>();
                _command = new SqlCommand($"select * from TblCity where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblCity(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["CountryId"].ToString() != "" ? Convert.ToInt32(reader["CountryId"]) : 0, reader["Data"].ToString(), reader["MapLink"].ToString(), reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false);

            }
            catch
            {
                return new TblCity(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        #endregion

        #region TblClient

        public TblClient SelectClientByFirstName(string firstName)
        {
            try
            {
                _command = new SqlCommand($"select * from TblClient where FirstName = N'{firstName}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblClient(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                    reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),
                    reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Status"]));
            }
            catch
            {
                return new TblClient(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblClient> SelectClientByLastName(string lastName)
        {
            try
            {
                _command = new SqlCommand($"select * from TblClient where LastName = N'{lastName}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblClient> list = new List<TblClient>();
                while (reader.Read())
                {
                    list.Add(new TblClient(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                        reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),
                        reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Status"])));
                }

                return list;
            }
            catch
            {
                return new List<TblClient>();
            }
            finally
            {
                _disconnect();
            }
        }

        public TblClient SelectClientByEmail(string email)
        {
            try
            {
                _command = new SqlCommand($"select * from TblClient where Email = N'{email}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblClient(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                    reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),
                    reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Status"]));
            }
            catch
            {
                return new TblClient(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public TblClient SelectClientByUsername(string username)
        {
            try
            {
                _command = new SqlCommand($"select * from TblClient where Username = N'{username}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblClient(Convert.ToInt32(Convert.ToInt32(reader["id"])), reader["FirstName"].ToString(),
                    reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),
                    reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Status"]));
            }
            catch
            {
                return new TblClient(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public TblClient SelectClientByUsernamePassword(string username, string password)
        {
            try
            {
                _command = new SqlCommand($"select * from TblClient where Username = N'{username}' and Password = N'{password}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblClient(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(),
                    reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(),
                    reader["Username"].ToString(), reader["Password"].ToString(), Convert.ToInt32(reader["Status"]));
            }
            catch
            {
                return new TblClient(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        #endregion

        #region TblComments

        public List<TblComments> SelectCommentsByClientId(int clientId)
        {
            try
            {
                _command = new SqlCommand($"select * from TblComments where ClientId = N'{clientId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblComments> comments = new List<TblComments>();
                while (reader.Read())
                    comments.Add(new TblComments(Convert.ToInt32(reader["id"]), reader["Text"].ToString(),
                        Convert.ToInt32(reader["ClientId"]), Convert.ToBoolean(reader["IsValid"])));
                return comments;
            }
            catch
            {
                return new List<TblComments>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblCountry

        public TblCountry SelectCountryByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblCountry where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblCountry(Convert.ToInt32(reader["id"]), reader["Name"].ToString());
            }
            catch
            {
                return new TblCountry(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblPoll

        public TblPoll SelectPollByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select* from TblPoll where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblPoll(Convert.ToInt32(reader["id"]), reader["Name"].ToString(), Convert.ToInt32(reader["Vote"]));
            }
            catch
            {
                return new TblPoll(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblAttractionPollRel

        public List<TblAttractionPollRel> SelectAttractionPollRel(int entry, AttractionPollRel entryType)
        {
            try
            {
                List<TblAttractionPollRel> ret = new List<TblAttractionPollRel>();
                if (entryType == AttractionPollRel.AttractionId)
                    _command = new SqlCommand($"select* from TblAttractionPollRel where AttractionId = N'{entry}'", _connection);
                else if (entryType == AttractionPollRel.PollId)
                    _command = new SqlCommand($"select* from TblAttractionPollRel where PollId = N'{entry}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblAttractionPollRel(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["AttractionId"]), Convert.ToInt32(reader["PollId"])));
                return ret;
            }
            catch
            {
                return new List<TblAttractionPollRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblEquipment

        public TblEquipment SelectEquipmentByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblEquipment where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblEquipment(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                    reader["Logo"].ToString());
            }
            catch
            {
                return new TblEquipment(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblFacility

        public TblFacility SelectFacilityByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblFacility where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblFacility(Convert.ToInt32(reader["id"]), reader["Name"].ToString());
            }
            catch
            {
                return new TblFacility(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblRoomHome

        public TblRoomHome SelectRoomHomeByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select* from TblRoomHome where Name = N'{name}'", _connection);

                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                    reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                    Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                    long.Parse(reader["PriceWeekend"].ToString()), Convert.ToInt32(reader["DaysOccupaid"]),
                    reader["OccupaidFrom"].ToString(), reader["OccupaidTo"].ToString(),
                    Convert.ToBoolean(reader["IsReserved"]), reader["Description"].ToString(),
                    Convert.ToBoolean(reader["IsSelected"]));
            }
            catch
            {
                return new TblRoomHome(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblRoomHome> SelectRoomHomeByClientId(int clientId)
        {
            try
            {
                List<TblRoomHome> ret = new List<TblRoomHome>();
                _command = new SqlCommand($"select* from TblRoomHome where ClientId = N'{clientId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                        Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                        long.Parse(reader["PriceWeekend"].ToString()),
                        Convert.ToInt32(reader["DaysOccupaid"]), reader["OccupaidFrom"].ToString(),
                        reader["OccupaidTo"].ToString(), Convert.ToBoolean(reader["IsReserved"]),
                        reader["Description"].ToString(), Convert.ToBoolean(reader["IsSelected"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblRoomHome>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblRoomHome> SelectRoomHomeByCityId(int cityId)
        {
            try
            {
                List<TblRoomHome> ret = new List<TblRoomHome>();
                _command = new SqlCommand($"select* from TblRoomHome where CityId = N'{cityId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                        Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                        long.Parse(reader["PriceWeekend"].ToString()),
                        Convert.ToInt32(reader["DaysOccupaid"]), reader["OccupaidFrom"].ToString(),
                        reader["OccupaidTo"].ToString(), Convert.ToBoolean(reader["IsReserved"]),
                        reader["Description"].ToString(), Convert.ToBoolean(reader["IsSelected"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblRoomHome>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblRoomHome> SelectRoomHomeByIsReserved(bool isReserved)
        {
            try
            {
                List<TblRoomHome> ret = new List<TblRoomHome>();
                _command = new SqlCommand($"select* from TblRoomHome where IsReserved = N'{isReserved}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                        Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                        long.Parse(reader["PriceWeekend"].ToString()),
                        Convert.ToInt32(reader["DaysOccupaid"]), reader["OccupaidFrom"].ToString(),
                        reader["OccupaidTo"].ToString(), Convert.ToBoolean(reader["IsReserved"]),
                        reader["Description"].ToString(), Convert.ToBoolean(reader["IsSelected"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblRoomHome>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblRoomHome> SelectRoomHomeByIsSelected(bool isSelected)
        {
            try
            {
                List<TblRoomHome> ret = new List<TblRoomHome>();
                _command = new SqlCommand($"select* from TblRoomHome where IsSelected = N'{isSelected}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblRoomHome(Convert.ToInt32(reader["id"]), reader["Name"].ToString(),
                        reader["MainImage"].ToString(), Convert.ToInt32(reader["ClientId"]),
                        Convert.ToInt32(reader["CityId"]), long.Parse(reader["PriceNormal"].ToString()),
                        long.Parse(reader["PriceWeekend"].ToString()),
                        Convert.ToInt32(reader["DaysOccupaid"]), reader["OccupaidFrom"].ToString(),
                        reader["OccupaidTo"].ToString(), Convert.ToBoolean(reader["IsReserved"]),
                        reader["Description"].ToString(), Convert.ToBoolean(reader["IsSelected"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblRoomHome>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblRoomHomeCommentsRel

        public List<TblRoomHomeCommentsRel> SelectHotelCommentsRel(int entry, HotelCommentsRel entryType)
        {
            try
            {
                List<TblRoomHomeCommentsRel> ret = new List<TblRoomHomeCommentsRel>();
                if (entryType == HotelCommentsRel.RoomHomeId)
                    _command = new SqlCommand($"select * from TblRoomHomeCommentsRel where RoomHomeId = N'{entry}'", _connection);
                else if (entryType == HotelCommentsRel.CommentId)
                    _command = new SqlCommand($"select * from TblRoomHomeCommentsRel where CommentId = N'{entry}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblRoomHomeCommentsRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["RoomHomeId"].ToString()),
                        Convert.ToInt32(reader["CommentId"].ToString())));
                return ret;
            }
            catch
            {
                return new List<TblRoomHomeCommentsRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblRoomHomeFacilityRel

        public List<TblRoomHomeFacilityRel> SelectRoomHomeFacilityRel(int entry, HotelFacilityRel entryType)
        {
            try
            {
                List<TblRoomHomeFacilityRel> ret = new List<TblRoomHomeFacilityRel>();
                if (entryType == HotelFacilityRel.RoomHomeId)
                {
                    _command = new SqlCommand($"select * from TblRoomHomeFacilityRel where RoomHomeId = N'{entry}'", _connection);
                }
                else if (entryType == HotelFacilityRel.FacilityId)
                {
                    _command = new SqlCommand($"select * from TblRoomHomeFacilityRel where FacilityId = N'{entry}'", _connection);
                }
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblRoomHomeFacilityRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["RoomHomeId"].ToString()),
                        Convert.ToInt32(reader["FacilityId"].ToString())));
                }
                return ret;
            }
            catch
            {
                return new List<TblRoomHomeFacilityRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblRoomHomeImageRel

        public List<TblRoomHomeImageRel> SelectRoomHomeImageRel(int entry, RoomHomeImageRel entryType)
        {
            try
            {
                List<TblRoomHomeImageRel> ret = new List<TblRoomHomeImageRel>();
                if (entryType == RoomHomeImageRel.RoomHomeId)
                {
                    _command = new SqlCommand($"select * from TblRoomHomeImageRel where RoomHomeId = N'{entry}'", _connection);
                }
                else if (entryType == RoomHomeImageRel.ImageId)
                {
                    _command = new SqlCommand($"select * from TblRoomHomeImageRel where ImageId = N'{entry}'", _connection);
                }
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblRoomHomeImageRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["RoomHomeId"].ToString()),
                        Convert.ToInt32(reader["ImageId"].ToString())));
                }
                return ret;
            }
            catch
            {
                return new List<TblRoomHomeImageRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblImages


        public List<TblImages> SelectImagesByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblImages where Name like '%{name}%' COLLATE SQL_Latin1_General_CP1_CI_AS", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblImages> iamges = new List<TblImages>();
                while (reader.Read())
                {
                    iamges.Add(new TblImages(Convert.ToInt32(reader["id"]),
                        reader["Image"].ToString(), reader["Name"].ToString()));
                }
                return iamges;
            }
            catch
            {
                return new List<TblImages>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblNews

        public List<TblNews> SelectNewsByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblNews where Name = N'{name}' order by OrderId desc", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblNews> news = new List<TblNews>();
                while (reader.Read())
                {
                    news.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));
                }
                return news;
            }
            catch
            {
                return new List<TblNews>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblNews> SelectNewsByOrder(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblNews where Name = N'{name}' order by OrderId desc", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblNews> news = new List<TblNews>();
                while (reader.Read())
                {
                    news.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));

                }

                return news;
            }
            catch
            {
                return new List<TblNews>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblNews> SelectNewsByTextId(int textId)
        {
            try
            {
                _command = new SqlCommand($"select * from TblNews where TextId = N'{textId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblNews> news = new List<TblNews>();
                while (reader.Read())
                {
                    news.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));

                }

                return news;
            }
            catch
            {
                return new List<TblNews>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblNews> SelectNewsByImageId(int imageId)
        {
            try
            {
                _command = new SqlCommand($"select * from TblNews where ImageId = N'{imageId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblNews> news = new List<TblNews>();
                while (reader.Read())
                {
                    news.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));

                }

                return news;
            }
            catch
            {
                return new List<TblNews>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblNews> SelectNewsByIsSelected(bool isSelected)
        {
            try
            {
                _command = new SqlCommand($"select * from TblNews where IsSelected = N'{isSelected}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<TblNews> news = new List<TblNews>();
                while (reader.Read())
                {
                    news.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));

                }

                return news;
            }
            catch
            {
                return new List<TblNews>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblNews> SelectTopRandomNews(int count)
        {
            try
            {
                List<TblNews> news = new List<TblNews>();
                SqlCommand command = new SqlCommand($"select * from TblNews where IsPinned = 1", _connection);
                SqlDataReader read = command.ExecuteReader();
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        if (read.Read())
                        {
                            news.Add(new TblNews(read["id"].ToString() != "" ? Convert.ToInt32(read["id"]) : 0, read["Name"].ToString(), read["Title"].ToString(), read["OrderId"].ToString() != "" ? Convert.ToInt32(read["OrderId"]) : 0, read["TextId"].ToString() != "" ? Convert.ToInt32(read["TextId"]) : 0, read["ImageId"].ToString() != "" ? Convert.ToInt32(read["ImageId"]) : 0, read["IsText"].ToString() != "" ? Convert.ToBoolean(read["IsText"]) : false, read["IsSelected"].ToString() != "" ? Convert.ToBoolean(read["IsSelected"]) : false, read["MainImage"].ToString(), read["IsValid"].ToString() != "" ? Convert.ToBoolean(read["IsValid"]) : false, read["IsPinned"].ToString() != "" ? Convert.ToBoolean(read["IsPinned"]) : false));
                        }
                        else
                        {
                            count -= i;
                            break;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
                read.Close();
                _command = new SqlCommand($"SELECT top {count} * FROM TblNews ORDER BY newid() ", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    bool c = false;
                    for (int i = 0; i < news.Count; i++)
                    {
                        if (news[i].id == Convert.ToInt32(reader["id"]))
                            c = true;
                    }
                    if (!c)
                        news.Add(new TblNews(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Title"].ToString(), reader["OrderId"].ToString() != "" ? Convert.ToInt32(reader["OrderId"]) : 0, reader["TextId"].ToString() != "" ? Convert.ToInt32(reader["TextId"]) : 0, reader["ImageId"].ToString() != "" ? Convert.ToInt32(reader["ImageId"]) : 0, reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false, reader["IsSelected"].ToString() != "" ? Convert.ToBoolean(reader["IsSelected"]) : false, reader["MainImage"].ToString(), reader["IsValid"].ToString() != "" ? Convert.ToBoolean(reader["IsValid"]) : false, reader["IsPinned"].ToString() != "" ? Convert.ToBoolean(reader["IsPinned"]) : false));
                    c = false;
                }

                return news;
            }
            catch
            {
                return new List<TblNews>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblResume

        public TblResume SelectResumeByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select * from TblResume where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblResume(Convert.ToInt32(reader["id"]), reader["Name"].ToString());
            }
            catch
            {
                return new TblResume(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblText

        //nothing

        #endregion

        #region TblTourGuide

        public TblTourGuide SelectTourGuideByTellNo(string tellNo)
        {
            try
            {
                _command = new SqlCommand($"select * from TblTourGuide where TellNo = N'{tellNo}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0);

            }
            catch
            {
                return new TblTourGuide(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblTourGuide> SelectTourGuideByCityId(int cityId)
        {
            try
            {
                List<TblTourGuide> list = new List<TblTourGuide>();
                _command = new SqlCommand($"select * from TblTourGuide where CityId = N'{cityId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    list.Add(new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0));
                return list;
            }
            catch
            {
                return new List<TblTourGuide>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblTourGuide> SelectTourGuideByDiscount(int cityId)
        {
            try
            {
                List<TblTourGuide> list = new List<TblTourGuide>();
                _command = new SqlCommand($"select * from TblTourGuide where (Discount is not null or Discount <> '0') and CityId = {cityId}", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    list.Add(new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0));
                return list;
            }
            catch
            {
                return new List<TblTourGuide>();
            }
            finally
            {
                _disconnect();
            }
        }

        public TblTourGuide SelectTourGuideByEmail(string email)
        {
            try
            {
                _command = new SqlCommand($"select * from TblTourGuide where Email = N'{email}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0);

            }
            catch
            {
                return new TblTourGuide(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public TblTourGuide SelectTourGuideByUsername(string username)
        {
            try
            {
                _command = new SqlCommand($"select * from TblTourGuide where Username = N'{username}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblTourGuide(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["TellNo"].ToString(), reader["Email"].ToString(), reader["MainImage"].ToString(), reader["Description"].ToString(), reader["CityId"].ToString() != "" ? Convert.ToInt32(reader["CityId"]) : 0, reader["Username"].ToString(), reader["Password"].ToString(), reader["Rate"].ToString() != "" ? Convert.ToInt32(reader["Rate"]) : 0, reader["Discount"].ToString() != "" ? Convert.ToInt32(reader["Discount"]) : 0, reader["Price"].ToString() != "" ? Convert.ToInt32(reader["Price"]) : 0);

            }
            catch
            {
                return new TblTourGuide(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblTourGuideEquipmentRel

        public List<TblTourGuideEquipmentRel> SelectTourGuideEquipmentRel(int entry, TourGuideEquipmentRel entryType)
        {
            try
            {
                List<TblTourGuideEquipmentRel> ret = new List<TblTourGuideEquipmentRel>();
                if (entryType == TourGuideEquipmentRel.TourGuideId)
                {
                    _command = new SqlCommand($"select * from TblTourGuideEquipmentRel where TourGuideId = N'{entry}'", _connection);
                }
                else if (entryType == TourGuideEquipmentRel.EquipmentId)
                {
                    _command = new SqlCommand($"select * from TblTourGuideEquipmentRel where EquipmentId = N'{entry}'", _connection);
                }
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTourGuideEquipmentRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TourGuideId"].ToString()),
                        Convert.ToInt32(reader["EquipmentId"].ToString())));
                }
                return ret;
            }
            catch
            {
                return new List<TblTourGuideEquipmentRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblTourGuideImagesRel

        public List<TblTourGuideImagesRel> SelectTourGuideImagesRel(int entry, TourGuideImagesRel entryType)
        {
            try
            {
                List<TblTourGuideImagesRel> ret = new List<TblTourGuideImagesRel>();
                if (entryType == TourGuideImagesRel.TourGuideId)
                {
                    _command = new SqlCommand($"select * from TblTourGuideImagesRel where TourGuideId = N'{entry}'", _connection);
                }
                else if (entryType == TourGuideImagesRel.ImageId)
                {
                    _command = new SqlCommand($"select * from TblTourGuideImagesRel where ImageId = N'{entry}'", _connection);
                }
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTourGuideImagesRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TourGuideId"].ToString()),
                        Convert.ToInt32(reader["ImageId"].ToString())));
                }
                return ret;
            }
            catch
            {
                return new List<TblTourGuideImagesRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblTourGuideResumeRel

        public List<TblTourGuideResumeRel> SelectTourGuideResumeRel(int entry, TourGuideResumeRel entryType)
        {
            try
            {
                List<TblTourGuideResumeRel> ret = new List<TblTourGuideResumeRel>();
                if (entryType == TourGuideResumeRel.TourGuideId)
                {
                    _command = new SqlCommand($"select * from TblTourGuideResumeRel where TourGuideId = N'{entry}'", _connection);
                }
                else if (entryType == TourGuideResumeRel.ResumeId)
                {
                    _command = new SqlCommand($"select * from TblTourGuideResumeRel where ResumeId = N'{entry}'", _connection);
                }
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTourGuideResumeRel(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToInt32(reader["TourGuideId"].ToString()),
                        Convert.ToInt32(reader["ResumeId"].ToString())));
                }
                return ret;
            }
            catch
            {
                return new List<TblTourGuideResumeRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblAd

        public TblAd SelectAdByImage(string image)
        {
            try
            {
                _command = new SqlCommand($"select* from TblAd where Image = N'{image}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblAd(Convert.ToInt32(reader["id"]), reader["Image"].ToString(), reader["Link"].ToString(), reader["PositionId"].ToString(), Convert.ToBoolean(reader["IsAvailable"]));
            }
            catch
            {
                return new TblAd(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAd> SelectAdByPositionId(int positionId)
        {
            try
            {
                List<TblAd> ret = new List<TblAd>();
                _command = new SqlCommand($"select* from TblAd where PositionId = N'{positionId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblAd(Convert.ToInt32(reader["id"]), reader["Image"].ToString(), reader["Link"].ToString(), reader["PositionId"].ToString(), Convert.ToBoolean(reader["IsAvailable"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblAd>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblAd> SelectAdByIsAvailable(bool isAvailable)
        {
            try
            {
                List<TblAd> ret = new List<TblAd>();
                _command = new SqlCommand($"select* from TblAd where IsAvailable = N'0'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblAd(Convert.ToInt32(reader["id"]), reader["Image"].ToString(), reader["Link"].ToString(), reader["PositionId"].ToString(), Convert.ToBoolean(reader["IsAvailable"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblAd>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblAttractionEquipmentRel

        public List<TblAttractionEquipmentRel> SelectAttractionEquipmentRel(int entry, AttractionEquipmentRel entryType)
        {
            try
            {
                List<TblAttractionEquipmentRel> ret = new List<TblAttractionEquipmentRel>();
                if (entryType == AttractionEquipmentRel.AttractionId)
                    _command = new SqlCommand($"select* from TblAttractionEquipmentRel where AttractionId = N'{entry}'", _connection);
                else if (entryType == AttractionEquipmentRel.EquipmentId)
                    _command = new SqlCommand($"select* from TblAttractionEquipmentRel where EquipmentId = N'{entry}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblAttractionEquipmentRel(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["AttractionId"]), Convert.ToInt32(reader["EquipmentId"])));
                return ret;
            }
            catch
            {
                return new List<TblAttractionEquipmentRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblTripStoryCommentRel

        public List<TblTripStoryCommentRel> SelectTripStoryCommentRel(int entry, TripStoryCommentRel entryType)
        {
            try
            {
                List<TblTripStoryCommentRel> ret = new List<TblTripStoryCommentRel>();
                if (entryType == TripStoryCommentRel.TripStoryId)
                    _command = new SqlCommand($"select* from TblTripStoryCommentRel where TripStoryId = N'{entry}'", _connection);
                else if (entryType == TripStoryCommentRel.CommentId)
                    _command = new SqlCommand($"select* from TblTripStoryCommentRel where CommentId = N'{entry}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblTripStoryCommentRel(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["TripStoryId"]), Convert.ToInt32(reader["CommentId"])));
                return ret;
            }
            catch
            {
                return new List<TblTripStoryCommentRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblTripStory

        public TblTripStory SelectTripStoryByTitle(string title)
        {
            try
            {
                _command = new SqlCommand($"select* from TblTripStory where Title = N'{title}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblTripStory(Convert.ToInt32(reader["id"]), reader["Title"].ToString(), Convert.ToInt32(reader["CityId"]), reader["MainImage"].ToString(), Convert.ToInt32(reader["TextId"]), Convert.ToInt32(reader["imageId"]), reader["DatePosted"].ToString());
            }
            catch
            {
                return new TblTripStory(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblTripStory> SelectTripStoryByCityId(int cityId)
        {
            try
            {
                List<TblTripStory> ret = new List<TblTripStory>();
                _command = new SqlCommand($"select* from TblTripStory where CityId = N'{cityId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTripStory(Convert.ToInt32(reader["id"]), reader["Title"].ToString(), Convert.ToInt32(reader["CityId"]), reader["MainImage"].ToString(), Convert.ToInt32(reader["TextId"]), Convert.ToInt32(reader["imageId"]), reader["DatePosted"].ToString()));
                }
                return ret;
            }
            catch
            {
                return new List<TblTripStory>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblTripStory> SelectTripStoryByTextId(int textId)
        {
            try
            {
                List<TblTripStory> ret = new List<TblTripStory>();
                _command = new SqlCommand($"select* from TblTripStory where TextId = N'{textId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTripStory(Convert.ToInt32(reader["id"]), reader["Title"].ToString(), Convert.ToInt32(reader["CityId"]), reader["MainImage"].ToString(), Convert.ToInt32(reader["TextId"]), Convert.ToInt32(reader["imageId"]), reader["DatePosted"].ToString()));
                }
                return ret;
            }
            catch
            {
                return new List<TblTripStory>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblTripStory> SelectTripStoryByimageId(int imageId)
        {
            try
            {
                List<TblTripStory> ret = new List<TblTripStory>();
                _command = new SqlCommand($"select* from TblTripStory where imageId = N'{imageId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTripStory(Convert.ToInt32(reader["id"]), reader["Title"].ToString(), Convert.ToInt32(reader["CityId"]), reader["MainImage"].ToString(), Convert.ToInt32(reader["TextId"]), Convert.ToInt32(reader["imageId"]), reader["DatePosted"].ToString()));
                }
                return ret;
            }
            catch
            {
                return new List<TblTripStory>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblTicket

        public List<TblTicket> SelectTicketBySenderId(int senderId)
        {
            try
            {
                List<TblTicket> ret = new List<TblTicket>();
                _command = new SqlCommand($"select* from TblTicket where SenderId = N'{senderId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTicket(Convert.ToInt32(reader["id"]), reader["Name"].ToString(), reader["Email"].ToString(), Convert.ToInt32(reader["ReciverId"]), reader["Title"].ToString(), reader["Text"].ToString(), reader["DateSended"].ToString()));
                }
                return ret;
            }
            catch
            {
                return new List<TblTicket>();
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblTicket> SelectTicketByReciverId(int reciverId)
        {
            try
            {
                List<TblTicket> ret = new List<TblTicket>();
                _command = new SqlCommand($"select* from TblTicket where ReciverId = N'{reciverId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblTicket(Convert.ToInt32(reader["id"]), reader["Name"].ToString(), reader["Email"].ToString(), Convert.ToInt32(reader["ReciverId"]), reader["Title"].ToString(), reader["Text"].ToString(), reader["DateSended"].ToString()));
                }
                return ret;
            }
            catch
            {
                return new List<TblTicket>();
            }
            finally
            {
                _disconnect();
            }
        }

        public TblTicket SelectTicketByTitle(string title)
        {
            try
            {
                _command = new SqlCommand($"select* from TblTicket where Title = N'{title}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblTicket(Convert.ToInt32(reader["id"]), reader["Name"].ToString(), reader["Email"].ToString(), Convert.ToInt32(reader["ReciverId"]), reader["Title"].ToString(), reader["Text"].ToString(), reader["DateSended"].ToString());
            }
            catch
            {
                return new TblTicket(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblMedicalService

        public TblMedicalService SelectMedicalServiceByFirstName(string firstName)
        {
            try
            {
                _command = new SqlCommand($"select* from TblMedicalService where FirstName = N'{firstName}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblMedicalService(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["SicknessName"].ToString(), reader["SicknessDesc"].ToString(), reader["PassNo"].ToString(), Convert.ToInt32(reader["PassportImageId"]));
            }
            catch
            {
                return new TblMedicalService(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public TblMedicalService SelectMedicalServiceByLastName(string lastName)
        {
            try
            {
                _command = new SqlCommand($"select* from TblMedicalService where LastName = N'{lastName}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblMedicalService(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["SicknessName"].ToString(), reader["SicknessDesc"].ToString(), reader["PassNo"].ToString(), Convert.ToInt32(reader["PassportImageId"]));
            }
            catch
            {
                return new TblMedicalService(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public TblMedicalService SelectMedicalServiceBySicknessName(string sicknessName)
        {
            try
            {
                _command = new SqlCommand($"select* from TblMedicalService where SicknessName = N'{sicknessName}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                return new TblMedicalService(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["SicknessName"].ToString(), reader["SicknessDesc"].ToString(), reader["PassNo"].ToString(), Convert.ToInt32(reader["PassportImageId"]));
            }
            catch
            {
                return new TblMedicalService(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblMedicalService> SelectMedicalServiceByPassportImageId(int passportImageId)
        {
            try
            {
                List<TblMedicalService> ret = new List<TblMedicalService>();
                _command = new SqlCommand($"select* from TblMedicalService where PassportImageId = N'{passportImageId}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    ret.Add(new TblMedicalService(Convert.ToInt32(reader["id"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["SicknessName"].ToString(), reader["SicknessDesc"].ToString(), reader["PassNo"].ToString(), Convert.ToInt32(reader["PassportImageId"])));
                }
                return ret;
            }
            catch
            {
                return new List<TblMedicalService>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblMedicalServiceImagesRel

        public List<TblMedicalServiceImagesRel> SelectMedicalServiceImagesRel(int entry, MedicalServiceImagesRel entryType)
        {
            try
            {
                List<TblMedicalServiceImagesRel> ret = new List<TblMedicalServiceImagesRel>();
                if (entryType == MedicalServiceImagesRel.MedicalServiceId)
                    _command = new SqlCommand($"select* from TblMedicalServiceImagesRel where MedicalServiceId = N'{entry}'", _connection);
                else if (entryType == MedicalServiceImagesRel.ImageId)
                    _command = new SqlCommand($"select* from TblMedicalServiceImagesRel where ImageId = N'{entry}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblMedicalServiceImagesRel(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["MedicalServiceId"]), reader["Image"].ToString()));
                return ret;
            }
            catch
            {
                return new List<TblMedicalServiceImagesRel>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region TblFirstPage

        public TblFirstPage SelectFirstPageByImage(string image)
        {
            try
            {
                _command = new SqlCommand($"select* from TblFirstPage where Image = N'{image}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblFirstPage(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Sign"].ToString(), reader["Image"].ToString(), reader["Text"].ToString(), reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false);
            }
            catch
            {
                return new TblFirstPage(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        public List<TblFirstPage> SelectFirstPageByIsText(bool isText)
        {
            try
            {
                List<TblFirstPage> ret = new List<TblFirstPage>();
                _command = new SqlCommand($"select* from TblFirstPage where IsText = N'ext'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                    ret.Add(new TblFirstPage(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Sign"].ToString(), reader["Image"].ToString(), reader["Text"].ToString(), reader["IsText"].ToString() != "" ? Convert.ToBoolean(reader["IsText"]) : false));
                return ret;
            }
            catch
            {
                return new List<TblFirstPage>();
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion

        #region Service4
        public List<Tbl4Services> Select4ServicesByStatus(int status)
        {
            try
            {
                _command = new SqlCommand($"select* from Tbl4Services where Status = N'{status}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                List<Tbl4Services> services4 = new List<Tbl4Services>();
                while (reader.Read())
                    services4.Add(new Tbl4Services(Convert.ToInt32(reader["id"]), reader["Title"].ToString(), reader["Text"].ToString(),
                        Convert.ToInt32(reader["Status"])));
                return services4;
            }
            catch
            {
                return new List<Tbl4Services>();
            }
            finally
            {
                _disconnect();
            }
        }
        #endregion
    }
}
