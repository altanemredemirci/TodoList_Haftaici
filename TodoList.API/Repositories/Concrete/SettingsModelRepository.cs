using TodoList.API.Context;
using TodoList.API.Repositories.Abstract;
using TodoList.API.Repositories.Concrete.Common;
using TodoList.Core.Models;

namespace TodoList.API.Repositories.Concrete
{
    public class SettingsModelRepository : GenericRepository<SettingsModel>, ISettingsModelRepository
    {
        public SettingsModelRepository(TodoListContext context) : base(context)
        {
            
        }
    }
}
