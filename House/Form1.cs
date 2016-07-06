using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        Outside Garden;
        OutsideWithDoor BackYard;
        OutsideWithDoor FrontYard;
        RoomWithDoor LivingRoom;
        Room DinningRoom;
        RoomWithDoor Kitchen;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(LivingRoom);
        }

        private void CreateObjects()
        {
            LivingRoom = new RoomWithDoor("Living Room", "an antique carpet",
                   "an oak door with a brass knob");
            DinningRoom = new Room("Dining Room", "a crystal chandelier");
            Kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
                "a screen door");

            FrontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            BackYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            Garden = new Outside( "Garden",false);

            LivingRoom.Exits = new Location[] { DinningRoom };
            DinningRoom.Exits = new Location[] { LivingRoom, Kitchen };
            Kitchen.Exits = new Location[] { DinningRoom };
            FrontYard.Exits = new Location[] { BackYard, Garden };
            BackYard.Exits = new Location[] { FrontYard, Garden };
            Garden.Exits = new Location[] { BackYard, FrontYard };

            LivingRoom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = LivingRoom;
            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;

            descricao.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
