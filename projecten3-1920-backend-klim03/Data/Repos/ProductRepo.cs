﻿using Microsoft.EntityFrameworkCore;
using projecten3_1920_backend_klim03.Domain.Models.Domain;
using projecten3_1920_backend_klim03.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Data.Repos
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Product> _producten;

        public ProductRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _producten = dbContext.Producten;
        }

        public void Add(Product obj)
        {
            _producten.Add(obj);
        }

        public ICollection<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product obj)
        {
            _producten.Remove(obj);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
