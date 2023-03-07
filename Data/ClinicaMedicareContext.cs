using Microsoft.EntityFrameworkCore;
using ClinicaMedicare.Models;

namespace ClinicaMedicare.Data{
    public class ClinicaMedicareContext: DbContext{
        public ClinicaMedicareContext(DbContextOptions<ClinicaMedicareContext> options)
        :base(options){
        }
       public DbSet<Doctor> Doctor {get; set;}
    }
}



