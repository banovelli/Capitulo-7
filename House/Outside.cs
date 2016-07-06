using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class Outside : Location
    {
        public Outside(string name, bool hot)
             :base(name)
        {
            this.hot = hot;
        }

        private bool hot;
        public bool Hot { get { return hot; } }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += " É muito quente.";
                return NewDescription;
            }
        }
    }
}
