using Ioc;

namespace SimpleInjector
{
    public class SimpleInjectorTest
    {
        private Container _container;

        public void Init()
        {
            _container = new Container();
            _container.Register<IUserController, UserController>(Lifestyle.Transient);
            _container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Transient);
            _container.Register<ILogger, LowerLogger>(Lifestyle.Singleton);
            _container.Verify();
        }

        public IUserController Run() { return _container.GetInstance<IUserController>(); }
    }
}
