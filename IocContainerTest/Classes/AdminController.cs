namespace Ioc
{
    public class AdminController : UserController
    {
        public AdminController(IUserRepository repository, ILogger logger) : base(repository, logger) { }

        public new string GetUserName(int userId)
        {
            var message = $"AdminController.GetUserName({userId})";
            this.logger.Log(message);
            return message + " -> " + this.repository.GetById(userId);
        }
    }
}