using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitaTop.ServiceModel;
namespace VitaTop.Repository
{
    public class RecipeRepository
    {
        public IDbConnection db = null;
        

        public RecipeRepository(string ConnectionString)
        {
            var dbFactory = new OrmLiteConnectionFactory(ConnectionString, ServiceStack.OrmLite.MySqlDialect.Provider);
            db = dbFactory.Open();
        }

        public Recipe Add(Recipe recipe)
        {

            this.db.Save(recipe, references: true);
            recipe.Id = (int)this.db.LastInsertId();
            db.GetLastSql();
            return recipe;
        }

        public List<Recipe> GetAll()
        {
            return this.db.Select<Recipe>().ToList();
        }
    }
}
