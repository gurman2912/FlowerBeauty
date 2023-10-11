using Microsoft.EntityFrameworkCore;
using FlowerBeauty.Models;

namespace FlowerBeauty.Data
{
    public class FlowerBeautyContext : DbContext
    {
        public FlowerBeautyContext(DbContextOptions<FlowerBeautyContext> options)
            : base(options)
        {
        }

        public DbSet<Flower> Flower{ get; set; }

    }
}