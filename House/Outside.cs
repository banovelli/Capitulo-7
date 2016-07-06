using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class Outside : Location
    {
        public Outside(bool hot, string name)
             :base(name)
        {
            this.hot = hot;
        }

        private bool hot;
        public bool Hot { get { return hot; } }
    }
}
