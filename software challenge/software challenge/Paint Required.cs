using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_challenge
{
    public partial class Form1 : Form
    {

        //Variable names.
        double FloorWidth, WallWidth, FloorDepth, WallHeight, WindowWidth, WindowHeight, RoomWidth, RoomHeight, RoomDepth;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            {
                //Run all functions when button is clicked.
                CalculateFloorArea();
                CalculatePaintNeeded();
                CalculateRoomVolume();
            }


            try
            {
                int temp = Convert.ToInt32(txtFloorLength.Text);
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFloorWidth_TextChanged(object sender, EventArgs e)
        {
            
        }


        
        private void txtFloorLength_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtWallLength_TextChanged(object sender, EventArgs e)
        {
            {
                // input validation to ensure no incorrect data types or values can be entered.
               
            }
        }

        private void txtWallHeight_TextChanged(object sender, EventArgs e)
        {
            
                // input validation to ensure no incorrect data types or values can be entered.
              
        }

        private void txtLengthOfWindow_TextChanged(object sender, EventArgs e)
        {
            // input validation to ensure no incorrect data types or values can be entered.
            
        }

        private void txtHeightOfWindow_TextChanged(object sender, EventArgs e)
        {
            // input validation to ensure no incorrect data types or values can be entered.
            {
            }
        }

        double WallArea, WindowArea, DoorArea;
        int NumberOfWindows, NumberOfDoors, NumberOfWalls, CoatsRequired;
        double Area, PaintRequired, PaintRecommended, RoomVolume, RoomAreaFeet, VolumeFeet;
        public Form1()
        


        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                //Reset all variables to 0 upon form load.
                FloorWidth = 0;
                FloorDepth = 0;
                WallWidth = 0;
                WallHeight = 0;
                WindowWidth = 0;
                WindowHeight = 0;
                RoomWidth = 0;
                RoomHeight = 0;
                RoomDepth = 0;
            }
        }




        //This function is used to calculate the area of the floor.
        void CalculateFloorArea()
        {
            //Setting my local variables, converting to double.
            FloorWidth = Convert.ToDouble(txtFloorWidth.Text);
            FloorDepth = Convert.ToDouble(txtFloorWidth.Text);

            //Calculate and print the value entered.
            Area = FloorWidth * FloorDepth;
            RoomAreaFeet = FloorWidth * FloorDepth * 10.764;

            lblAreaOfFloor.Text = Area + " m²";
            lblAreaFeet.Text = RoomAreaFeet + "ft²";
        }





        //This is responsible for calculating the Paint Needed per coat of paint selected.
        void CalculatePaintNeeded()
        {
            //local variables set, converting to double.
            WallWidth = Convert.ToDouble(txtWallLength.Text);
            WallHeight = Convert.ToDouble(txtWallHeight.Text);
            WindowWidth = Convert.ToDouble(txtLengthOfWindow.Text);
            WindowHeight = Convert.ToDouble(txtHeightOfWindow.Text);

            //Find basic areas. DoorArea = Meters
            WallArea = WallWidth * WallHeight;
            WindowArea = WindowWidth * WindowHeight;
            DoorArea = 1.981 * 0.762;



            NumberOfWalls = Convert.ToInt32(NudAmountOfWalls.Value);
            NumberOfWindows = Convert.ToInt32(nudNumberOfWindows.Value);
            NumberOfDoors = Convert.ToInt32(nudAmountOfDoors.Value);
            CoatsRequired = Convert.ToInt32(nudCoatsRequired.Value);

            //Multiply areas with the amount entered.
            WallArea = WallArea * NumberOfWalls;
            WindowArea = WindowArea * NumberOfWindows;
            DoorArea = DoorArea * NumberOfDoors;


            double PaintNeeded;
            //Minus window and door areas and divide by 10(m² that the paint can cover per litre) to get the amount that you need.
            // improvment to be made to allow user to enter area covered per litre of paint on the specific paint they have.
            WallArea = WallArea - (WindowArea + DoorArea);
            PaintRequired = WallArea / 10;
            PaintNeeded = PaintRequired * CoatsRequired;
            PaintRecommended = Convert.ToInt32(PaintNeeded) + 1; //Added a recommended value with a litre over to allow for slight margin of error.

            //Output paint values.

            lblPaintRequired.Text = "~" + Convert.ToInt32(PaintNeeded) + " Litres | Recommended - " + PaintRecommended + " Litres.";

        }




        //This is responsible for calculating the Volume of the room .
        void CalculateRoomVolume()
        {
            //Local variables set, converted to double.
            RoomWidth = Convert.ToDouble(txtFloorWidth.Text);
            RoomHeight = Convert.ToDouble(txtWallHeight.Text);
            RoomDepth = Convert.ToDouble(txtFloorLength.Text);

            //Calculate and output values.
            RoomVolume = RoomWidth * RoomHeight * RoomDepth;
            VolumeFeet = RoomWidth * RoomHeight * RoomDepth * 10.764;
            lblVolumeOfRoom.Text = RoomVolume + " m²";
            lblVolumeFeet.Text = VolumeFeet + " ft²";
        }
    }
}
