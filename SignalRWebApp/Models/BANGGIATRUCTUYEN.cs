using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace SignalRWebApp.Models
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BANGGIATRUCTUYEN : EntityBase
    {
        [DataMember]
        [Display(Name = "Mã CP")]
        public string MACP { get; set; }

        [DataMember]
        [Display(Name = "Mua 3")]
        public double? GIAMUA3 { get; set; }

        [DataMember]
        [Display(Name = "KL 3")]
        public int? KLMUA3 { get; set; }

       
        [DataMember]
        [Display(Name = "Mua 2")]
        public double? GIAMUA2 { get; set; }

        [DataMember]
        [Display(Name = "KL 2")]
        public int? KLMUA2 { get; set; }

        [DataMember]
        [Display(Name = "Mua 1")]
        public double? GIAMUA1 { get; set; }

        [DataMember]
        [Display(Name = "KL 1")]
        public int? KLMUA1 { get; set; }

        [DataMember]
        [Display(Name = "giá Khớp")]
        public double? KHOPLENHGIA { get; set; }

        [DataMember]
        [Display(Name = "KL Khớp")]
        public int? KHOPLENHKL { get; set; }

        [DataMember]
        [Display(Name = "Bán 1")]
        public double? GIABAN1 { get; set; }

        [DataMember]
        [Display(Name = "KL B 1")]
        public int? KLBAN1 { get; set; }

        [DataMember]
        [Display(Name = "Bán 2")]
        public double? GIABAN2 { get; set; }

        [DataMember]
        [Display(Name = "KL B 2")]
        public int? KLBAN2 { get; set; }

        [DataMember]
        [Display(Name = "Bán 3")]
        public double? GIABAN3 { get; set; }

        [DataMember]
        [Display(Name = "KL B 3")]
        public int? KLBAN3 { get; set; }

        [DataMember]
        [Display(Name = "TỔNG KL")]
        public int? TONG { get; set; }




    }

}