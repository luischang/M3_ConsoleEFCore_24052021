using System;
using System.Collections.Generic;

#nullable disable

namespace M3_ConsoleEFCore.DatabaseFirst.Models
{
    public partial class Player
    {
        public Player()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Dorsal { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SoccerPositionId { get; set; }
        public string Country { get; set; }

        public virtual SoccerPosition SoccerPosition { get; set; }
        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
