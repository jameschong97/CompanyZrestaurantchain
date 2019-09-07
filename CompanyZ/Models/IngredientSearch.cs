using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyZ.Models
{
    public class IngredientSearch
    {
        public List<Ingredients> Ingredient { get; set; }
        public SelectList Type { get; set; }
        public string IngredientType { get; set; }
        public string SearchString { get; set; }
    }
}
