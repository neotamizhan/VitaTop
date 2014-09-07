using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VitaTop.ServiceModel;
using ServiceStack;
using VitaTop.ServiceModel.Request;
//using Dapper;
//using DapperExtensions;
using MySql.Data;
using System.Configuration;
using NLog;
using ServiceStack.OrmLite.MySql;
using ServiceStack.OrmLite;
using VitaTop.Repository;

namespace VitaTop.WS
{
    public class VitaTopServices: Service
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        IngredientRepository ingRepos = new IngredientRepository(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        RecipeRepository recipeRepos = new RecipeRepository(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public List<Ingredient> Get(FetchAllIngredients request)
        {
            return ingRepos.GetAll();
        }

        public Ingredient Get(GetIngredient request)
        {            
            return ingRepos.Find(request.Id);
        }


        public object Post(CreateIngredient request)
        {
            long Id = 0;
            try
            {
                var ing = ingRepos.Add(request as Ingredient);

                Id = ing.Id;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message + ex.StackTrace);
                return new HttpResult(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }

            return new HttpResult(System.Net.HttpStatusCode.Created, "Ingredient Created:" + Id);
        }


        public List<Recipe> Get(FetchAllRecipes request)
        {
            return recipeRepos.GetAll();
        }

        /*
         * Seeding Methods.
         */

        //public List<string> Get(SeedIngredients request)
        //{
        //    return DataSeeder.IngSeedSql();
        //}

        //public HttpResult Post(SeedIngredients request)
        //{
        //    var sqls = DataSeeder.IngSeedSql();

        //    using (MySql.Data.MySqlClient.MySqlConnection cn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user=root;password=papaloona;database=vitatop"))
        //    {
        //        foreach (var sql in sqls)
        //        {
        //            cn.Execute(sql);
        //        }                
        //    }

        //    return new HttpResult(System.Net.HttpStatusCode.Created, "Ingredients Seeded");
        //}
    }
}