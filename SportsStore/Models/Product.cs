using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models {

    public class Product {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите товар")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Пожалуйста, введите корректную цену")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите категорию")]
        public string Category { get; set; }
    }
}
