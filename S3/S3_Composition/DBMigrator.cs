namespace Course_OOP.S3.S3_Composition
{
    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Migrating database");
        }
    }
}
