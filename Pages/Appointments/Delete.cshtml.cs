﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Moga_Larisa_proiect.Data.Moga_Larisa_proiectContext _context;

        public DeleteModel(Moga_Larisa_proiect.Data.Moga_Larisa_proiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment.FirstOrDefaultAsync(m => m.ID == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment.FindAsync(id);

            if (Appointment != null)
            {
                _context.Appointment.Remove(Appointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
