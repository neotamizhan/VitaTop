using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitaTop.ServiceModel;
using System.Data;
using ServiceStack.OrmLite;

namespace VitaTop.Repository
{
    public class IngredientRepository
    {
        public IDbConnection db = null;

        public IngredientRepository(string ConnectionString)
        {
            var dbFactory = new OrmLiteConnectionFactory(ConnectionString, ServiceStack.OrmLite.MySqlDialect.Provider);
            db = dbFactory.Open();
        }

        public Ingredient Find(int Id)
        {
            return this.db.SingleById<Ingredient>(Id);
        }

        public List<Ingredient> GetAll()
        {
            return this.db.Select<Ingredient>();
        }

        public Ingredient Add(Ingredient ingredient) 
        {
            this.db.Insert<Ingredient>(ingredient);
            ingredient.Id = (int) this.db.LastInsertId();

            return ingredient;
        }
    }
}
