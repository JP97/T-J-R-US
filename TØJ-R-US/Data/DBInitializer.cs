using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TØJ_R_US.Models;

namespace TØJ_R_US.Data
{
    public class DBInitializer
    {
        public void DbInitialize(TØJ_R_USContext context)
        {
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product { Name = "Kjole1",   Category = 2,
                    Type = "Kjole", Description = "blablabla1", Size = 30, Color = "white", Price = 1499 },
               
                new Product { Name = "Kjole2",   Category = 2,
                    Type = "Kjole", Description = "blablabla2", Size = 31, Color = "purple", Price = 249 },
                
                new Product { Name = "blazer1",   Category = 1,
                    Type = "Blazer", Description = "blablabla3", Size = 34, Color = "grey", Price = 349 },
                
                new Product { Name = "bukser1",   Category = 1,
                    Type = "Bukser", Description = "blablabla4", Size = 10, Color = "beige", Price = 299 },
                
                new Product { Name = "trøje1",   Category = 3,
                    Type = "Trøje", Description = "blablabla5", Size = 15, Color = "grey", Price = 249 },
                
                new Product { Name = "T-shirt1",   Category = 3,
                    Type = "T-shirt", Description = "blablabla6", Size = 5, Color = "green", Price = 99 },
                
                new Product { Name = "bukser2",   Category = 2,
                    Type = "Bukser", Description = "blablabla7", Size = 29, Color = "blue", Price = 399 },
                
                new Product { Name = "Blazer2",   Category = 3,
                    Type = "Blazer", Description = "blablabla8", Size = 30, Color = "black", Price = 199 },
            };

            foreach (Product p in products)
            {
                context.Product.Add(p);
            }
            context.SaveChanges();
        }
        
    }
}
