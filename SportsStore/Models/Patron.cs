using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Patron
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите Имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите Фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите номер телефона")]
        public string Telephone { get; set; }
        public string CardId { get; set; }
        public decimal Bonus { get; set; }
    }
}
