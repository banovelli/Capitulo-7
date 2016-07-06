using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
