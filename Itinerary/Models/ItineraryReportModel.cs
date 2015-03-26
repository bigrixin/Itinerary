using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Itinerary.Models
{

    [Table("ItineraryReport")]
    public class ItineraryReportModel
    {
        public int ItineraryReportId { get; set; }
        public int TourId { get; set; }
        public int day { get; set; }
        public DateTime Date { get; set; }
        public string CityList { get; set; }
        public string Remarks { get; set; }

        public virtual List<ItineraryReportDetailModel> ItineraryReportDetail { get; set; }
    }

    [Table("ItineraryReportDetail")]
    public class ItineraryReportDetailModel
    {
        [Key]
        public int ItineraryReportDetailsId { get; set; }
        public int ItineraryReportId { get; set; }
        public string City { get; set; }
        public string ItineraryList { get; set; }
        public virtual ItineraryReportModel ItineraryReport { get; set; }
    }



    [Table("FlightReport")]
    public class FlightReportModel
    {
        public int FlightReportId { get; set; }
        public string TourId { get; set; }
        public string Remarks { get; set; }
        public virtual List<FlightReportDetailModel> FlightReportDetail { get; set; }
    }

    [Table("FlightReportDetail")]
    public class FlightReportDetailModel
    {
        [Key]
        public int FlightReportDetailsId { get; set; }
        public int FlightReportId { get; set; }
        public DateTime TourDate { get; set; }
        public string FlightNo { get; set; }
        public string DepartCity { get; set; }
        public DateTime DepartTime { get; set; }
        public string ArriveCity { get; set; }
        public DateTime ArriveTime { get; set; }
        public int CarryOnLuggage { get; set; }
        public int CheckinLuggage { get; set; }
        public virtual FlightReportModel FlightReport { get; set; }
    }


    [Table("HotelReport")]
    public class HotelReportModel
    {
        public int HotelReportId { get; set; }
        public string TourId { get; set; }
        public string Remarks { get; set; }
        public string Meals { get; set; }
        public string Tips { get; set; }
        public virtual List<HotelReportDetailModel> HotelReportDetail { get; set; }
    }

    [Table("HotelReportDetail")]
    public class HotelReportDetailModel
    {
        [Key]
        public int HotelReportDetailsId { get; set; }
        public int HotelReportId { get; set; }
        public string City { get; set; }
        public string HotelName { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public string Rooms { get; set; }

        public virtual HotelReportModel HotelReport { get; set; }
    }

    [Table("Tour")]
    public class TourModel
    {
        public int TourId { get; set; }
        public string TourCode { get; set; }
        public string PassengersName { get; set; }
        public string ContactTour { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CityContact { get; set; }
        public string EmergencyContact { get; set; }
        public string Remarks { get; set; }
    }


    [Table("State")]
    public class StateModel
    {
        public int StateId { get; set; }
        [Display(Name = "State Chinese Name")]
        public string StateCN { get; set; }
        [Display(Name = "State English Name")]
        public string StateEN { get; set; }
        public virtual ICollection<CityModel> City { get; set; }
    }

    [Table("City")]
    public class CityModel
    {
        [Key]
        public int CityId { get; set; }
        public int StateId { get; set; }
        [Display(Name = "City English")]
        public string CityEN { get; set; }
        [Display(Name = "City Chinese Name")]
        public string CityCN { get; set; }
        [Display(Name = "City Contact Number")]
        public string CityContact { get; set; }
        public virtual CityModel City { get; set; }
    }

    [Table("ItineraryRemark")]
    public class ItineraryRemarkModel
    {

        public int ItineraryRemarkId { get; set; }
        [Display(Name = "City Chinese Name")]
        public string CityCN { get; set; }
        public string Remark { get; set; }
    }

    [Table("ItineraryList")]
    public class ItineraryListModel
    {
        public int ItineraryListId { get; set; }
        [Display(Name = "City Chinese Name")]
        public string CityCN { get; set; }
        public string Attraction { get; set; }
        public string Itinerary { get; set; }
        public int Priority { get; set; }
    }

    [Table("Flight")]
    public class FlightModel
    {
        public int FlightId { get; set; }
        [Display(Name = "City Chinese Name")]
        public string CityCN { get; set; }
        public string Remark { get; set; }
    }

    [Table("Hotel")]
    public class HotelModel
    {
        public int HotelId { get; set; }
        [Display(Name = "City Chinese Name")]
        public string CityCN { get; set; }
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        [Display(Name = "Rooms style")]
        public string Rooms { get; set; }
        public string Remark { get; set; }
        public string Meals { get; set; }
    }

    [Table("HotelRemark")]
    public class HotelRemarkModel
    {
        public int HotelRemarkId { get; set; }
        public string Remark { get; set; }
        public string Tips { get; set; }
    }
}