using ParthsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParthsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
