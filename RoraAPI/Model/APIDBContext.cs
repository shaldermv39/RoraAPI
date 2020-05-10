using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoraAPI.Model
{
    public class APIDBContext  :DbContext 
    {
      public  APIDBContext(DbContextOptions<APIDBContext> options):base(options)
        { }
  public      DbSet<User>Users { get; set; }
    }
}
