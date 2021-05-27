using System;
using System.Collections.Generic;

#nullable disable

namespace M3_ConsoleEFCore.DatabaseFirst.Models
{
    public partial class Prueba
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? DoB { get; set; }
    }
}
