using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if(Debugger.IsAttached)
            {
                //Empty Database
                using (var db = new ClassificationEF())
                {
                    if(db.Database.Exists())  db.Database.Delete();
                }
            }

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
            using (var db = new ClassificationEF())
            {
                // Check if the database is already seeded
                if (!db.Types.Any() && !db.Makes.Any() && !db.Models.Any() && !db.Products.Any())
                {
                    // Seed Types
                    var types = new List<Type>
                    {
                        new Type { Name = "1 - Type A" },
                        new Type { Name = "1 - Type B" },
                        new Type { Name = "1 - Type C" }
                    };
                    db.Types.AddRange(types);

                    // Seed Makes
                    var makes = new List<Make>
                    {
                        new Make { Name = "2 - Make A" },
                        new Make { Name = "2 - Make B" },
                        new Make { Name = "2 - Make C" }
                    };
                    db.Makes.AddRange(makes);

                    // Seed Models
                    var models = new List<Model>
                    {
                        new Model { Name = "3 - Model A" },
                        new Model { Name = "3 - Model B" },
                        new Model { Name = "3 - Model C" }
                    };
                    db.Models.AddRange(models);

                    // Seed Products
                    var products = new List<Product>
                    {
                        new Product
                        {
                            Type = types[0],
                            Make = makes[0],
                            Model = models[0],
                            Revision = "1.0"
                        },
                        new Product
                        {
                            Type = types[1],
                            Make = makes[1],
                            Model = models[1],
                            Revision = "1.0"
                        },
                        new Product
                        {
                            Type = types[2],
                            Make = makes[2],
                            Model = models[2],
                            Revision = "1.0"
                        }

                    };

                    db.Products.AddRange(products);
                    
                    db.SaveChanges();

                    foreach (var p in db.Products)
                    {
                        int index = 0;
                        p.Attributes.Add(new Attribute { Name = $"Attribute {index}", AttributeKeys = new AttributeKeys { Name = $"Key {index}" } });
                        p.ProductImages.Add(new ProductImage { ImagePath = $"path/to/image{index}.jpg", ImageDate = DateTime.Now });
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}
