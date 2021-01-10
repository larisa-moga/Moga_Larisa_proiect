using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moga_Larisa_proiect.Models;

namespace Moga_Larisa_proiect.Data
{
    public class Moga_Larisa_proiectContext : DbContext
    {
        public Moga_Larisa_proiectContext (DbContextOptions<Moga_Larisa_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<Moga_Larisa_proiect.Models.Appointment> Appointment { get; set; }
    }
}
