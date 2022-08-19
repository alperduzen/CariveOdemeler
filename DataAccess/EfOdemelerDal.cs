using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfOdemelerDal
    {
        public void Add(Odemeler odemeler)
        {
            using (var context = new ProjeDbContext())
            {
                var eklenecekOdemeler = context.Add(odemeler);
                eklenecekOdemeler.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Odemeler odemeler)
        {
            using (var context = new ProjeDbContext())
            {
                var silinecekOdemeler = context.Remove(odemeler);
                silinecekOdemeler.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Odemeler odemeler)
        {
            using (var context = new ProjeDbContext())
            {
                var guncellenenOdemeler = context.Update(odemeler);
                guncellenenOdemeler.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Odemeler> GetAll(Expression<Func<Odemeler, bool>> filter = null)
        {
            using (var context = new ProjeDbContext())
            {
                if (filter == null)
                {
                    return context.Set<Odemeler>().ToList();
                }
                else
                {
                    return context.Set<Odemeler>().Where(filter).ToList();
                }
            }
        }
        public Odemeler Get(Expression<Func<Odemeler, bool>> filter)
        {
            using (var context = new ProjeDbContext())
            {
                return context.Set<Odemeler>().SingleOrDefault(filter);
            }
        }
    }
}
