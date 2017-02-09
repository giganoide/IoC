namespace Ioc
{
    public class UserController : IUserController
    {
        protected readonly IUserRepository repository;
        protected readonly ILogger logger;

        public UserController(IUserRepository repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public string GetUserName(int userId)
        {
            var message = $"UserController.GetUserName({userId})";
            this.logger.Log(message);
            return message + " -> " + this.repository.GetById(userId);
        }
    }
}