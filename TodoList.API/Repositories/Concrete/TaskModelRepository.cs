using TodoList.API.Context;
using TodoList.API.Repositories.Abstract;
using TodoList.API.Repositories.Concrete.Common;
using TodoList.Core.Models;

namespace TodoList.API.Repositories.Concrete
{
    public class TaskModelRepository : GenericRepository<TaskModel>, ITaskModelRepository
    {
        public TaskModelRepository(TodoListContext context) : base(context)
        {

        }
    }
}