using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models;
using Attribute = Models.Attribute;
using Type = Models.Type;

namespace CRUD
{
    public class DbUtils
    {
        // Initialize Db is in WebApi app.config
        //  <add name="MyLocalDb" connectionString="Data Source=C:\SQLCompact\EFDataStore.sdf;" providerName="System.Data.SqlServerCe.4.0" />

        public static void InitDb()
        {
            using (var db = new ClassificationEF())
            {
                db.Database.CreateIfNotExists();
            }
        }

        public static void Init()
        {
            InitDb();

            // Get All by CRUD read
            var productList = CRUD.Db.ReadAll<Product>();//  "Startup Test", Environment.UserName);
            if (productList == null || !productList.Any())
            {
                Console.WriteLine("No records found in the database. Seeding Db with Test Data.");
                SeedDb();
            }

            // Display the direct Db read
            foreach (var product in productList)
            {
                // Use reflection to show each property of the product
                foreach (PropertyInfo prop in product.GetType().GetProperties())
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(product, null)}");
                }
            }
        }

        static void SeedDb()
        {


            //Seed Types
            CRUD.Db.Create(new Type { Name = "1 - Type A" });
            CRUD.Db.Create(new Type { Name = "1 - Type B" });
            CRUD.Db.Create(new Type { Name = "1 - Type C" });


            using (var db = new ClassificationEF())
            {
                // Create some dummy data
                var type = new Type { Name = "1 - Type" };
                var make = new Make { Name = "2 - Make" };
                var model = new Model { Name = "3 - Model" };
               
                var product = new Product
                {
                    Revision = "1.0",
                    Make = make,
                    Model = model,
                    Type = type
                };

                product.Attributes.Add(new Attribute { Name = "Attribute1", AttributeKeys = new AttributeKeys { Name = "Key1" } });
                product.Attributes.Add(new Attribute { Name = "Attribute2", AttributeKeys = new AttributeKeys { Name = "Key2" } });

                product.ProductImages.Add(new ProductImage { ImagePath = "path/to/image1.jpg", ImageDate = DateTime.Now });

                // Add the product to the database
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
    }
}
