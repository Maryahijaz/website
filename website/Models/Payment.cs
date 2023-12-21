using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CardId { get; set; }
        public int TotalAmount { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/yy}")]
        [Required(ErrorMessage = "Lütfen geçerli bir tarih seçiniz.")]
        public DateTime CardDate { get; set; }

        [StringLength(3)]
        public int CVV { get; set; }
    }
}
