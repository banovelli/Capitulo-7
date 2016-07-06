using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class Room : Location
    {
        public Room(string decoration, string name)
             :base(name)
        {
            this.decoration = decoration;
        }

        private string decoration;
        public string Decoration { get { return decoration; } }
    }
}
