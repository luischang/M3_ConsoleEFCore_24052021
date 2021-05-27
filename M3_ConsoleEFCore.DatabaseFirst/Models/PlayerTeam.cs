using System;
using System.Collections.Generic;

#nullable disable

namespace M3_ConsoleEFCore.DatabaseFirst.Models
{
    public partial class PlayerTeam
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
