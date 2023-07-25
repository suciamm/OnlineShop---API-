using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnlineShop.Models
{
    public class DetailProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Deskripsi { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Stok { get; set; }
        public string TanggalRilis { get; set; } = string.Empty;
        public string TanggalKadaluarsa { get; set; } = string.Empty;
    }
}