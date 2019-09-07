using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyZ.Models
{
    public class Ingredients
    {
        public int Id { get; set; }

        [Display(Name = "Ingredient Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string IngredientName { get; set; }

        [Display(Name = "Ingredient Type")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string IngredientType { get; set; }

        [Display(Name = "Ingredient Description")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string IngredientDesc { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
    }
}
