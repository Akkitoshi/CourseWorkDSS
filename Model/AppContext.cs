using System.Data.Entity;

namespace Model
{
    public class DBCourseWorkContext : DbContext
    {
        public DBCourseWorkContext() : base("DBCourseWorkContext")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            _ =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Executor> Executors { set; get; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Complexity> Complexities { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
