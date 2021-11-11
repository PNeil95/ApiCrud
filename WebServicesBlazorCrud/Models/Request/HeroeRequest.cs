using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServicesBlazorCrud.Models.Request
{
    public class HeroeRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Poder { get; set; }
        public string Universo { get; set; }
    }
}
