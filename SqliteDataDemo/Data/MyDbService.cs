using Microsoft.EntityFrameworkCore;

namespace SqliteDataDemo.Data
{
    public partial class MyDbService
    {
        private readonly MyDbContext _dbContext;

        public MyDbService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}