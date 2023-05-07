﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalem 1",
                Price = 100,
                Stoct = 20,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem 2",
                Price = 200,
                Stoct = 30,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Kalem 3",
                Price = 600,
                Stoct = 60,
                CreatedDate = DateTime.Now
            },
             new Product
             {
                 Id = 4,
                 CategoryId = 2,
                 Name = "Kitap 1",
                 Price = 600,
                 Stoct = 60,
                 CreatedDate = DateTime.Now
             },

             new Product
             {
                 Id = 5,
                 CategoryId = 2,
                 Name = "Kitap 2",
                 Price = 6600,
                 Stoct = 320,
                 CreatedDate = DateTime.Now
             });           
        }
    }
}
