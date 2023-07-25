using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int Id { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Gambar { get; set; } = string.Empty;
        public double Harga { get; set; }
        public Category Category { get; set; }
    }
}