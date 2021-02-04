using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace All_Range_Market.Models
{
    public enum GenderPref
    {
        Men,
        Women,
        Kids,
        Unisex
    }
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Укажите название товара")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Добавьте описание")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Цена должна быть больше 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Необходимо добавить категорию")]
        public string Category { get; set; }

        public GenderPref gender { get; set; }
        public string GenToString()
        {  
            switch (gender)
            {
                case GenderPref.Kids: return "Детям"; break;
                case GenderPref.Men: return "Мужчинам"; break;
                case GenderPref.Women: return "Женщинам"; break;
                case GenderPref.Unisex: return "Для всех"; break;
                default: return "";
            }
        }
        public List<ProductSize> AvaibleSizes { get; set; }
        [Required]
        public Vendor Vendor { get; set; }
        [Required]
        public int VendorId { get; set; }
        [Required]
        public List<Image> Images { get; set; }
    }
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Image(string path)
        {
            Path = path;
        }
    }
    public class ProductSize
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public ProductSize(string size)
        {
            Size = size;
        }
        public ProductSize()
        {

        }
    }
}