using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SignalRWebApp.Models
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class LENHDAT : EntityBase
    {
        [DataMember]
        [Display(Name = "ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DataMember]
        [Display(Name = "Mã CP")]
        public string MACP { get; set; }

        [DataMember]
        [Display(Name = "Ngày Đặt")]
        public DateTime NGAYDAT { get; set; }

        [DataMember]
        [Display(Name = "Loại GD")]
        public string LOAIGD { get; set; }

        [DataMember]
        [Display(Name = "Loại Lệnh")]
        public string LOAILENH { get; set; }

        [DataMember]
        [Display(Name = "Số Lượng")]
        public int SOLUONG { get; set; }

        [DataMember]
        [Display(Name = "Gía Đặt")]
        public double GIADAT { get; set; }

        [DataMember]
        [Display(Name = "Trạng Thái")]
        public string TRANGTHAILENH { get; set; }







    }
}