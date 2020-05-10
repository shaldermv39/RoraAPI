using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoraAPI.Model
{
    public class APIDBContext  :DbContext 
    {
        APIDBContext(DbContextOptions<APIDBContext> options):base(options)
        { }
        DbSet<User>Users { get; set; }
    }
}
