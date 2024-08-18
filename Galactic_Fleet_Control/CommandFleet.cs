using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Fleet_Control
{
    public class CommandFleet : Fleet
    {
        public string CommanderName { get; set; }
        public string Rank {  get; set; }
        public int Experience {  get; set; }
        public CommandFleet(string commanderName,  string rank, int experience)
        {
            CommanderName = commanderName;
            Rank = rank;
            Experience = experience;
        }
    }
}
