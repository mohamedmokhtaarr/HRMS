
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HRMS.Infrastructure.Persistence
{
   public class HRMSContext : DbContext
    {



        #region onConfig
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=HRMS;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        #endregion



    }
}
