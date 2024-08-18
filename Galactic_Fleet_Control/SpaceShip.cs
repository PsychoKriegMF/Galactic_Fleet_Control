using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Fleet_Control
{
    public struct SpaceShip
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Model {  get; set; }
        public decimal Cost {  get; set; }
        public SpaceShip(int id, string name, string model, decimal cost) 
        {
            ID = id;
            Name = name;
            Model = model;
            Cost = cost;
        }
    }
}
