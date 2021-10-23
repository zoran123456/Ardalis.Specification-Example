using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Infrastructure.Repositories.GenericRepoExample
{
    public abstract class BaseRepository<T> where T : class
    {
        public DbContext _dbContext;
        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public abstract Task<List<T>> Search();

    }

}
