namespace OnlineShop.Dto
{
    public class ProductDto
    {
        public int IdKategori { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string Gambar { get; set; } = string.Empty;
        public double Harga { get; set; }
        public string Deskripsi { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Stok { get; set; }
        public string TanggalRilis { get; set; } = string.Empty;
        public string TanggalKadaluarsa { get; set; } = string.Empty;
    }
}