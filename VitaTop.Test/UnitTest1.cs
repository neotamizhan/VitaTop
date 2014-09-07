using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VitaTop.Repository;
using VitaTop.ServiceModel;
using System.Collections.Generic;

namespace VitaTop.Test
{
    [TestClass]
    public class RecipeTests
    {
        RecipeRepository repos = null;

        [TestInitialize]
        public void Setup()
        {
            repos = new RecipeRepository("server=localhost;user=root;password=papaloona;database=vitatop");
        }

        [TestMethod]
        public void CanAddRecipe()
        {
            var ings = new List<RecipeIngredient> { new RecipeIngredient {IngredientId = 1, Quantity = 10, RecipeId = 1},
                                                    new RecipeIngredient {IngredientId = 2, Quantity = 20, RecipeId = 1} 
                                                  };
            var recipe = new Recipe
            {
                CategoryId = 1,
                EnglishName = "Test Recipe 2",
                ArabicName = "Test Recipe 2",
                PortionAmount = 10,
                PortionUnits = "Pcs",
                RecipeIngredients = ings  
            };

            var added = repos.Add(recipe);

            Assert.IsTrue(added.Id == 1);
        }


        [TestMethod]
        public void CanSeeAllRecipes()
        {
            var recipes = repos.GetAll();

            Assert.IsTrue(recipes.Count == 1);
        }

    }
}
