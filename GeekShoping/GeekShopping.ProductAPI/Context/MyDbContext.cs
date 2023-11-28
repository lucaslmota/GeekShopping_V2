using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() {}
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}
    }
}
