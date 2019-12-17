using ArtistBrowserEF.Models;
using System.Data.Entity;

namespace ArtistBrowserEF.Repositories
{
    public class MusicSalesContext : DbContext
    {
        private const string ConnectionString =
            @"Data source=(localdb)\mssqllocaldb;" +
            @"Initial Catalog=MusicSales;Integrated Security=True";

        public MusicSalesContext() : base(ConnectionString) { }

        public DbSet<Artist> Artists { get; set; }
    }
}
