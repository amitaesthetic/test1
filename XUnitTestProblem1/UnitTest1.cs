using problem1.Model;
using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using problem1.Helper;
using problem1.Repo;
using Microsoft.Extensions.DependencyInjection;

namespace XUnitTestProblem1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_A_B_C__equ_100()
        {
            //Arrange
            List<Product> _newProduct = new List<Product>();
            Product p = new Product("A");
            _newProduct.Add(p);

            p = new Product("B");
            _newProduct.Add(p);
            p = new Product("C");
            _newProduct.Add(p);

            ServiceProvider serviceProvider;
            IProductService service;
            DIHelper.DIForConsoleProgram(out serviceProvider, out service);

            //Act
            int totalPrice = service.GetTotalPrice(_newProduct);

            //Assert
            Assert.Equal(100, totalPrice);
        }
    }
}
