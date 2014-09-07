using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VitaTop.ServiceModel;
using VitaTop.ServiceModel.Request;
using ServiceStack;

namespace VitaTop.Desktop
{
    public class StaticDataManager
    {
        public static List<Ingredient> IngredientsList = new List<Ingredient>();

        public static void FillIngredients()
        {
            var client = new JsonServiceClient("http://localhost:49178/");

           IngredientsList = client.Get<List<Ingredient>>(new FetchAllIngredients());
        }


    }
}
