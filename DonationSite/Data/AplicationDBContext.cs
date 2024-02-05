
using Donation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Donation.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }

        public DbSet<DoacaoModel> Doacoes { get; set; }
       

    }
}
