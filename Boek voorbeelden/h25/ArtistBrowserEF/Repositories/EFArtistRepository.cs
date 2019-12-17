using System;
using System.Collections.Generic;
using ArtistBrowserEF.Models;
using System.Linq;

namespace ArtistBrowserEF.Repositories
{
    public class EFArtistRepository : IArtistRepository
    {
        private MusicSalesContext context = new MusicSalesContext();

        public IList<Artist> GetAll()
        {
            return context.Artists.ToList<Artist>();
        }

        public void Update(Artist artist)
        {
            context.SaveChanges();
        }
    }
}
