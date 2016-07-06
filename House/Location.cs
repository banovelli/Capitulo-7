using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public abstract class Location
    {
        public Location(string name)
        {
            this.name = name;
        }
        private string name;
        public string Name
        {
            get { return name; }
        }
        public Location [] Exits;

        public virtual string Description
        {
            get {
                string description = "Você está em " + name
                    + ". Você tem saídas para os seguintes locais: ";
                for (int i = 0; i < Exits.Length; i++) {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
