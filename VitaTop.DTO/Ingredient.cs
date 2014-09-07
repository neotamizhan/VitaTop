using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitaTop.ServiceModel
{    
    [ServiceStack.DataAnnotations.Alias("ingredients")]
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Portion { get; set; }
        public string Units { get; set; }
        public double Calories { get; set; }
        public double Protien { get; set; }
        public double Fat { get; set; }
        public double Carb { get; set; }
        public double Fiber { get; set; }
        public double SatFat { get; set; }
        public DateTime Added { get; set; }
    }
}
