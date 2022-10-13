using ApiDcBell.Controllers;
using ApiDcBell.Models;
using ApiDcBell.Repositories;
using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Core.Misc;
using Moq;

namespace unitedTestDcBellMS
{
    [TestClass]
    public class ProductTesitingMs
    {
        private ProductController _controller;

        private Fixture _fixture;
        private Mock<IProductCollection> _product;

        public ProductTesitingMs()
        {
            _product = new Mock<IProductCollection>();
            _fixture = new Fixture();
        }

        
        public async void Get_Ok()
        {
            var productList = _fixture.CreateMany<Product>(3).ToList();
            _product.Setup(repo => repo.GetAllProducts());
            _controller = new ProductController(_product.Object);
            var result2 = await _controller.GetallProducts();
            var obj = result2 as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);

        }

        [TestMethod]
        public async Task Post_ReturningOk()
        {
            var productMock = _fixture.Create<Product>();

            _product.Setup(repo => repo.InsertProduct(It.IsAny<Product>()));
            _controller = new ProductController(_product.Object);
            var result2 = await _controller.GetallProducts();
            var obj = result2 as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);
        }

        public async Task async_ReturningOk()
        {

            _product.Setup(repo => repo.DeleteProduct(It.IsAny<string>()));
            _controller = new ProductController(_product.Object);
            var result2 = await _controller.GetallProducts();
            var obj = result2 as ObjectResult;
            Assert.AreEqual(200, obj.StatusCode);
        }
    }
}