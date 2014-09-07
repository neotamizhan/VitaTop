using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace VitaTop.ServiceModel
{
    [Alias("recipes")]
    public class Recipe
    {
        public int Id { get; set; }

        [Alias("category_id")]
        [References(typeof(RecipeCategory))]
        public int CategoryId { get; set; }

        [Alias("name_english")]
        public string EnglishName { get; set; }

        [Alias("name_arabic")]
        public string ArabicName { get; set; }

        [Alias("portion_amt")]
        public int PortionAmount { get; set; }

        [Alias("portion_units")]
        public string PortionUnits { get; set; }

        [Reference]
        public List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
