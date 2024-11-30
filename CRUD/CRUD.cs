using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using System.Reflection;
using Type = System.Type;

namespace CRUD
{
    public static class Db
    {
        // Create method
        public static void Create<T>(T entity) where T : class
        {
            using (var db = new ClassificationEF())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        // Read method
        public static IEnumerable<T> Read<T>() where T : class
        {
            using (var db = new ClassificationEF())
            {
                return db.Set<T>().ToList();
            }
        }

        // Get by Id method
        public static T GetById<T>(long id) where T : class
        {
            using (var db = new ClassificationEF())
            {
                return db.Set<T>().Find(id);
            }
        }

        // Update method
        public static void Update<T>(T entity) where T : class
        {
            using (var db = new ClassificationEF())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Update by Id method
        public static void UpdateById<T>(long id, T updatedEntity) where T : class
        {
            using (var db = new ClassificationEF())
            {
                var existingEntity = db.Set<T>().Find(id);
                if (existingEntity != null)
                {
                    db.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
                    db.SaveChanges();
                }
            }
        }

        // Delete method
        public static void Delete<T>(T entity) where T : class
        {
            using (var db = new ClassificationEF())
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        // Delete by Id method
        public static void DeleteById<T>(long id) where T : class
        {
            using (var db = new ClassificationEF())
            {
                var entity = db.Set<T>().Find(id);
                if (entity != null)
                {
                    db.Set<T>().Remove(entity);
                    db.SaveChanges();
                }
            }
        }
    }
}