using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moga_Larisa_proiect.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Serviciu { get; set; }
        public string Telefon { get; set; }
        public DateTime PublishingDate { get; set; }
    }
}
