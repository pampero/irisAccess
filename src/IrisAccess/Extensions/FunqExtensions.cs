using Model;
using Model.Repositories.Interfaces;
using Services.Interfaces;
using ServiceStack.Logging;

public static class FunqExtensions
{
    public static void InitializeContainer(this Funq.Container container)
    {
        container.Register(c => LogManager.GetLogger("LogFile"));
        container.Register(new AppDbContext());

        container.RegisterAutoWiredAs<UnitOfWork, IUnitOfWork>();
    }
}