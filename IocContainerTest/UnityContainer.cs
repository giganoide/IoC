using Ioc;
using Microsoft.Practices.Unity;

namespace Unity
{
    public class UnityContainerTest
    {
        private UnityContainer _container;

        public void Init()
        {
            _container = new UnityContainer();
            _container.RegisterType<IUserController, UserController>();
            _container.RegisterType<IUserRepository, SqlUserRepository>();
            _container.RegisterType<ILogger, ConsoleLogger>();
        }

        public IUserController Run() { return _container.Resolve<IUserController>(); }
    }
}
