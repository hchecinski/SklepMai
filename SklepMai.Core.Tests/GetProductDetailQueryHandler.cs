using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using SklepMai.Core.Functions.Products.Queries.GetProductDetail;
using SklepMai.Domain.Repositories;
using AutoMapper;
using System.Reflection.Metadata;
using SklepMai.Core.Mapper;

namespace SklepMai.Core.Tests
{
    public class GetProductDetailQueryHandlerTests
    {
        ProductRepository _repo = new ProductRepository();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Get_GetProductDetailQueryHandler()
        {
            var product = _repo.List.FirstOrDefault(i => i.Id == 1);

            var config = new AutoMapperConfiguration().Configure();

            GetProductDetailQueryHandler test = new GetProductDetailQueryHandler(_repo, config.CreateMapper());
            GetProductDetailQuery getProductDetailQuery = new GetProductDetailQuery(){Id = 1};


            var result = await test.Handle(getProductDetailQuery, new CancellationToken());


            Assert.That(result.Name, Is.EqualTo(product?.Name));
        }
    }
}