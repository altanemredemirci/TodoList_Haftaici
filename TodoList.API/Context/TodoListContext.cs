using Microsoft.EntityFrameworkCore;
using TodoList.Core.Models;
using TodoList.Core.Models.Common;

namespace TodoList.API.Context
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<SettingsModel> Settings { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseModel>(); //DbContext üzerinde yapılan tüm değişiklikleri takip eden bir koleksiyonu temsil eder. 
            foreach (var data in datas)
            {
                _ = data.State switch //data.State ifadesi, değişiklik takip girişinin mevcut durumunu belirtir.
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now
                };
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
