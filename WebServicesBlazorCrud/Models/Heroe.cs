using System;
using System.Collections.Generic;

#nullable disable

namespace WebServicesBlazorCrud.Models
{
    public partial class Heroe
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Poder { get; set; }
        public string Universo { get; set; }
    }
}
