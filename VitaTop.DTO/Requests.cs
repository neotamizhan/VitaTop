using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace VitaTop.ServiceModel.Request
{
    [Route("/ingredients", "POST")]
    public class CreateIngredient : Ingredient { }



   [Route("/ingredients/all", "GET")]
   public class FetchAllIngredients {}

    [Route("/ingredient/{Id}")]
   public class GetIngredient
   {
       public int Id { get; set; }
   }

   [Route("/api/seed/ingredients","GET")]
   public class SeedIngredients { }

}