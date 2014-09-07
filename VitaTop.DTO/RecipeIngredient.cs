using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaTop.ServiceModel
{
    [Alias("recipe_ingredients")]
    public class RecipeIngredient
    {
        [AutoIncrement]
        public int Id { get; set; }

        [Alias("recipe_id")]
        [Reference]
        public int RecipeId { get; set; }

        [Alias("ing_id")]
        public int IngredientId { get; set; }
        public decimal Quantity { get; set; }
    }
}
