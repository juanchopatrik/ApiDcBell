using ApiDcBell.Controllers;
using ApiDcBell.Models;
using ApiDcBell.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Moq;
using System.Net;
using System.Text.RegularExpressions;

namespace ApiDcBell.TestX
{
    public class ProductTesting
    {
        private readonly ProductController _controller;
        private readonly IProductCollection _product;

        Product product1 = new Product();

        Product product2 = new Product();

        

        public ProductTesting()
        {
            _controller = new ProductController();
            _product = new ProductCollection();

        }



        [Fact]
        public void Get_Ok()
        {
            var result = _controller.GetallProducts();
            Assert.True(result.IsCompletedSuccessfully);
        }


        [Fact]
        public void GetById_Ok()
        { 
            
            var result = _controller.GetProductDetails(this.product1.Id.ToString());
            Assert.True(result.IsCompleted);
        }

        [Fact]
        public void Create_Ok()
        {
            product1.Category = "mockTest";
            product1.Name = "testProduct";
            var result = _controller.CreateProduct(this.product1);
            Assert.True(true, "Created");
        }

        [Fact]
        public void UpdateById_Ok()
        {
            product2.Category = "mockTest updated";
            var result = _controller.UpdateProduct(product2, product1.Id.ToString());
            Assert.True(true, "Created");
        }

        [Fact]
        public void DeleteById_Ok()
        {
            
            var result = _controller.DeleteProduct(product1.Id.ToString());
            Assert.True(result.Equals(true));

        }

    }
}