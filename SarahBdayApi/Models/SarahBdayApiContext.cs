using Microsoft.EntityFrameworkCore;

namespace SarahBdayApi.Models
{
  public class SarahBdayApiContext : DbContext
  {
    public DbSet<Attendant> Attendants { get; set; }
    public SarahBdayApiContext(DbContextOptions<SarahBdayApiContext> options) : base(options) {}
  }
}