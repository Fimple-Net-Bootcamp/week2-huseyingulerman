using Autofac;
using System.Reflection;
using week2_huseyingulerman.Core.Repositories;
using week2_huseyingulerman.Core.Services;
using week2_huseyingulerman.Core.UnitOfWork;
using week2_huseyingulerman.Repository.Repositories;
using week2_huseyingulerman.Repository.UnitOfWork;
using week2_huseyingulerman.Repository;
using week2_huseyingulerman.Service.Mapping;
using week2_huseyingulerman.Service.Services;

namespace week2_huseyingulerman.Api.Modules
{
    public class RepoServiceModule:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {



            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<,,>)).As(typeof(IService<,,>)).InstancePerLifetimeScope();


            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
