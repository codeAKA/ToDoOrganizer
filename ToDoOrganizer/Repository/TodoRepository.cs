using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class TodoRepository : RepositoryBase<Todo>, ITodoRepository
    {
        public TodoRepository(ApplicationDbContext aplicationContext): base(aplicationContext)
        {

        }
    }
}
