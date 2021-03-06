using System;
using System.Collections.Generic;

#nullable disable

namespace M3_ConsoleEFCore.DatabaseFirst.Models
{
    public partial class Team
    {
        public Team()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }

        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
