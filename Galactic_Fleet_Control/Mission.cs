using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Fleet_Control
{
    public struct Mission
    {
        public int ID {  get; set; }
        public string MissionName { get; set; }
        public string Target { get; set; }
        public DateTime StartDate { get; set; }
        public Mission(int id, string missionName, string target, DateTime startDate)
        {
            ID = id;
            MissionName = missionName;
            Target = target;
            StartDate = startDate;
        }
    }
}
