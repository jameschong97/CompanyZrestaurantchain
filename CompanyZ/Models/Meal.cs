using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyZ.Models
{
    public class Meal
    {
        public int Id { get; set; }

        [Display(Name = "Meal Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string MealName { get; set; }

        [Display(Name = "Meal Type")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string MealType { get; set; }

        [Display(Name = "Meal Description")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string MealDesc { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

       
    }
}
