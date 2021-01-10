using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moga_Larisa_proiect.Data;
using Moga_Larisa_proiect.Models;

namespace Moga_Larisa_proiect.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly Moga_Larisa_proiect.Data.Moga_Larisa_proiectContext _context;

        public IndexModel(Moga_Larisa_proiect.Data.Moga_Larisa_proiectContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; }

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointment.ToListAsync();
        }
    }
}
