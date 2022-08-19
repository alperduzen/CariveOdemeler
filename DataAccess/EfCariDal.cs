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
        public class EfCariDal
        {
            public static void Add(Cari cari)
            {
                using (var context = new ProjeDbContext())
                {
                    var eklenecekCari = context.Add(cari);
                    eklenecekCari.State = EntityState.Added;
                    context.SaveChanges();
                }
            }

            public void Delete(Cari cari)
            {
                using (var context = new ProjeDbContext())
                {
                    var silinecekCari = context.Remove(cari);
                    silinecekCari.State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            public void Update(Cari cari)
            {
                using (var context = new ProjeDbContext())
                {
                    var guncellenenCari = context.Update(cari);
                    guncellenenCari.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }

            public List<Cari> GetAll(Expression<Func<Cari, bool>> filter = null)
            {
                using (var context = new ProjeDbContext())
                {
                    if (filter == null)
                    {
                        return context.Set<Cari>().ToList();
                    }
                    else
                    {
                        return context.Set<Cari>().Where(filter).ToList();
                    }
                }
            }
            public Cari Get(Expression<Func<Cari, bool>> filter)
            {
                using (var context = new ProjeDbContext())
                {
                    return context.Set<Cari>().SingleOrDefault(filter);
                }
            }
        }
    }

