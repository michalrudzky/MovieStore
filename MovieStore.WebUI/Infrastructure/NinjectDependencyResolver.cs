using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using MovieStore.Domain.Abstract;
using MovieStore.Domain.Concrete;
using MovieStore.Domain.Entities;

namespace MovieStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            /*
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product { Name = "Apocalypse Now", Price = 80 },
                new Product { Name = "Fight Club", Price = 70 },
                new Product { Name = "The Silence of the Lambs", Price = 75 }
            });
            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
            */
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}