using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Dto;
using OnlineShop.Interface;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product : ControllerBase
    {
        private readonly IProduct _productRepo;
        private readonly IDetailProduct _detailProductRepo;
        private readonly ICategory _categoryRepo;

        public Product(IProduct productRepo, IDetailProduct detailProductRepo, ICategory categoryRepo)
        {
            _productRepo = productRepo;
            _detailProductRepo = detailProductRepo;
            _categoryRepo = categoryRepo;
        }

        [HttpPost("create")]
        public IActionResult CreateProduct(ProductDto productDto)
        {
            var idKategori = _categoryRepo.GetCategoryById(productDto.IdKategori);

            if(idKategori == null)
            {
                return BadRequest("IdKategori Not Found!!");
            }
            else
            {
                var createProduct = new DetailProduct
                {
                    Product = new Models.Product
                    {
                        Nama = productDto.Nama,
                        Gambar = productDto.Gambar,
                        Harga = productDto.Harga,
                        Category = idKategori,
                    },
                    Deskripsi = productDto.Deskripsi,
                    Brand = productDto.Brand,
                    Stok = productDto.Stok,
                    TanggalRilis = productDto.TanggalRilis,
                    TanggalKadaluarsa = productDto.TanggalKadaluarsa
                };
                _detailProductRepo.CreateDetailProduct(createProduct);
                return Ok("Create Product Succsess");
            }
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepo.GetAllProducts());
        }
    }
}
