using Model;
using Model.Repositories.impl;
using Model.Repositories.interfaces;
using Services.impl;
using Services.interfaces;
using ServiceStack.Logging;

public static class FunqExtensions
{
    public static void InitializeContainer(this Funq.Container container)
    {
        container.Register(c => LogManager.GetLogger("LogFile"));
        container.Register(new AppDbContext());

        container.RegisterAutoWiredAs<UnitOfWork, IUnitOfWork>();
        container.RegisterAutoWiredAs<AttributesRepository, IAttributesRepository>();
        container.RegisterAutoWiredAs<AttributesService, IAttributesService>();      
    }
}