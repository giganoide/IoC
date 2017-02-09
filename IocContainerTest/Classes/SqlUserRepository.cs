namespace Ioc
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly ILogger logger;

        public SqlUserRepository(ILogger logger)
        {
            this.logger = logger;
        }

        public string GetById(int id)
        {
            var message = $"SqlUserRepository.GetById({id})";
            this.logger.Log(message);
            return message;
        }
    }
}