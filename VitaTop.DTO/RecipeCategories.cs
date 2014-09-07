using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaTop.ServiceModel
{
    [Alias("recipe_categories")]
    public class RecipeCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime Added { get; set; }
    }
}
