using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace CRUD
{
    internal class DbUtils
    {
        //Initalise Db
        //  <add name="MyLocalDb" connectionString="Data Source=C:\SQLCompact\EFDataStore.sdf;" providerName="System.Data.SqlServerCe.4.0" />
        
        public static void InitDb()
        {
            using (var db = new ClassificationEF())
            {
                db.Database.CreateIfNotExists();
            }
        }
    }
}
