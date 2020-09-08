using Microsoft.Extensions.DependencyInjection;
using problem1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace problem1.Repo
{
    public interface IProductService
    {
        int GetTotalPrice(List<Product> products);
    }
}
