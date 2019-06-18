namespace software_challenge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAreaOfRoom = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFloorLength = new System.Windows.Forms.TextBox();
            this.txtFloorWidth = new System.Windows.Forms.TextBox();
            this.lblRoomLength = new System.Windows.Forms.Label();
            this.lblRoomWidth = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblPaintRequired = new System.Windows.Forms.Label();
            this.lblPaintAnswer = new System.Windows.Forms.Label();
            this.lblVolumeFeet = new System.Windows.Forms.Label();
            this.lblVolumeFeetAnswer = new System.Windows.Forms.Label();
            this.lblAreaFeetAnswer = new System.Windows.Forms.Label();
            this.lblVolumeOfRoom = new System.Windows.Forms.Label();
            this.lblVolumeAnswer = new System.Windows.Forms.Label();
            this.lblAreaFeet = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.lblAreaOfFloor = new System.Windows.Forms.Label();
            this.grpWallsAndWindows = new System.Windows.Forms.GroupBox();
            this.nudAmountOfDoors = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfWindows = new System.Windows.Forms.NumericUpDown();
            this.NudAmountOfWalls = new System.Windows.Forms.NumericUpDown();
            this.nudCoatsRequired = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfDoors = new System.Windows.Forms.Label();
            this.lblNumOfWindows = new System.Windows.Forms.Label();
            this.lblCoatsNeeded = new System.Windows.Forms.Label();
            this.lblNumOfWalls = new System.Windows.Forms.Label();
            this.lblHeightOfWindows = new System.Windows.Forms.Label();
            this.lblLengthOfWindows = new System.Windows.Forms.Label();
            this.txtHeightOfWindow = new System.Windows.Forms.TextBox();
            this.txtLengthOfWindow = new System.Windows.Forms.TextBox();
            this.lblWallHeight = new System.Windows.Forms.Label();
            this.lblWallLength = new System.Windows.Forms.Label();
            this.txtWallHeight = new System.Windows.Forms.TextBox();
            this.txtWallLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAreaOfRoom.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpWallsAndWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfDoors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmountOfWalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoatsRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAreaOfRoom
            // 
            this.grpAreaOfRoom.Controls.Add(this.btnCalculate);
            this.grpAreaOfRoom.Controls.Add(this.txtFloorLength);
            this.grpAreaOfRoom.Controls.Add(this.txtFloorWidth);
            this.grpAreaOfRoom.Controls.Add(this.lblRoomLength);
            this.grpAreaOfRoom.Controls.Add(this.lblRoomWidth);
            this.grpAreaOfRoom.Location = new System.Drawing.Point(7, 37);
            this.grpAreaOfRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAreaOfRoom.Name = "grpAreaOfRoom";
            this.grpAreaOfRoom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAreaOfRoom.Size = new System.Drawing.Size(137, 164);
            this.grpAreaOfRoom.TabIndex = 0;
            this.grpAreaOfRoom.TabStop = false;
            this.grpAreaOfRoom.Text = "Area of Room";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 132);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 29);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFloorLength
            // 
            this.txtFloorLength.Location = new System.Drawing.Point(73, 77);
            this.txtFloorLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFloorLength.Name = "txtFloorLength";
            this.txtFloorLength.Size = new System.Drawing.Size(56, 20);
            this.txtFloorLength.TabIndex = 4;
            this.txtFloorLength.TextChanged += new System.EventHandler(this.txtFloorLength_TextChanged);
            // 
            // txtFloorWidth
            // 
            this.txtFloorWidth.Location = new System.Drawing.Point(73, 46);
            this.txtFloorWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFloorWidth.Name = "txtFloorWidth";
            this.txtFloorWidth.Size = new System.Drawing.Size(56, 20);
            this.txtFloorWidth.TabIndex = 3;
            this.txtFloorWidth.TextChanged += new System.EventHandler(this.txtFloorWidth_TextChanged);
            // 
            // lblRoomLength
            // 
            this.lblRoomLength.AutoSize = true;
            this.lblRoomLength.Location = new System.Drawing.Point(3, 80);
            this.lblRoomLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomLength.Name = "lblRoomLength";
            this.lblRoomLength.Size = new System.Drawing.Size(66, 13);
            this.lblRoomLength.TabIndex = 1;
            this.lblRoomLength.Text = "Floor Length";
            // 
            // lblRoomWidth
            // 
            this.lblRoomWidth.AutoSize = true;
            this.lblRoomWidth.Location = new System.Drawing.Point(3, 47);
            this.lblRoomWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomWidth.Name = "lblRoomWidth";
            this.lblRoomWidth.Size = new System.Drawing.Size(58, 13);
            this.lblRoomWidth.TabIndex = 0;
            this.lblRoomWidth.Text = "Floor width";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblPaintRequired);
            this.grpOutput.Controls.Add(this.lblPaintAnswer);
            this.grpOutput.Controls.Add(this.lblVolumeFeet);
            this.grpOutput.Controls.Add(this.lblVolumeFeetAnswer);
            this.grpOutput.Controls.Add(this.lblAreaFeetAnswer);
            this.grpOutput.Controls.Add(this.lblVolumeOfRoom);
            this.grpOutput.Controls.Add(this.lblVolumeAnswer);
            this.grpOutput.Controls.Add(this.lblAreaFeet);
            this.grpOutput.Controls.Add(this.lblAreaAnswer);
            this.grpOutput.Controls.Add(this.lblAreaOfFloor);
            this.grpOutput.Location = new System.Drawing.Point(7, 199);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOutput.Size = new System.Drawing.Size(609, 96);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Results";
            // 
            // lblPaintRequired
            // 
            this.lblPaintRequired.AutoSize = true;
            this.lblPaintRequired.Location = new System.Drawing.Point(115, 81);
            this.lblPaintRequired.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaintRequired.Name = "lblPaintRequired";
            this.lblPaintRequired.Size = new System.Drawing.Size(25, 13);
            this.lblPaintRequired.TabIndex = 9;
            this.lblPaintRequired.Text = "......";
            // 
            // lblPaintAnswer
            // 
            this.lblPaintAnswer.AutoSize = true;
            this.lblPaintAnswer.Location = new System.Drawing.Point(3, 81);
            this.lblPaintAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaintAnswer.Name = "lblPaintAnswer";
            this.lblPaintAnswer.Size = new System.Drawing.Size(77, 13);
            this.lblPaintAnswer.TabIndex = 8;
            this.lblPaintAnswer.Text = "Paint Required";
            // 
            // lblVolumeFeet
            // 
            this.lblVolumeFeet.AutoSize = true;
            this.lblVolumeFeet.Location = new System.Drawing.Point(280, 52);
            this.lblVolumeFeet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeFeet.Name = "lblVolumeFeet";
            this.lblVolumeFeet.Size = new System.Drawing.Size(25, 13);
            this.lblVolumeFeet.TabIndex = 7;
            this.lblVolumeFeet.Text = "......";
            // 
            // lblVolumeFeetAnswer
            // 
            this.lblVolumeFeetAnswer.AutoSize = true;
            this.lblVolumeFeetAnswer.Location = new System.Drawing.Point(177, 52);
            this.lblVolumeFeetAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeFeetAnswer.Name = "lblVolumeFeetAnswer";
            this.lblVolumeFeetAnswer.Size = new System.Drawing.Size(95, 13);
            this.lblVolumeFeetAnswer.TabIndex = 6;
            this.lblVolumeFeetAnswer.Text = "Volume of room Ft²";
            // 
            // lblAreaFeetAnswer
            // 
            this.lblAreaFeetAnswer.AutoSize = true;
            this.lblAreaFeetAnswer.Location = new System.Drawing.Point(190, 25);
            this.lblAreaFeetAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaFeetAnswer.Name = "lblAreaFeetAnswer";
            this.lblAreaFeetAnswer.Size = new System.Drawing.Size(82, 13);
            this.lblAreaFeetAnswer.TabIndex = 5;
            this.lblAreaFeetAnswer.Text = "Area of Floor Ft²";
            // 
            // lblVolumeOfRoom
            // 
            this.lblVolumeOfRoom.AutoSize = true;
            this.lblVolumeOfRoom.Location = new System.Drawing.Point(115, 52);
            this.lblVolumeOfRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeOfRoom.Name = "lblVolumeOfRoom";
            this.lblVolumeOfRoom.Size = new System.Drawing.Size(25, 13);
            this.lblVolumeOfRoom.TabIndex = 4;
            this.lblVolumeOfRoom.Text = "......";
            // 
            // lblVolumeAnswer
            // 
            this.lblVolumeAnswer.AutoSize = true;
            this.lblVolumeAnswer.Location = new System.Drawing.Point(3, 52);
            this.lblVolumeAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeAnswer.Name = "lblVolumeAnswer";
            this.lblVolumeAnswer.Size = new System.Drawing.Size(95, 13);
            this.lblVolumeAnswer.TabIndex = 3;
            this.lblVolumeAnswer.Text = "Volume of room M²";
            // 
            // lblAreaFeet
            // 
            this.lblAreaFeet.AutoSize = true;
            this.lblAreaFeet.Location = new System.Drawing.Point(280, 25);
            this.lblAreaFeet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaFeet.Name = "lblAreaFeet";
            this.lblAreaFeet.Size = new System.Drawing.Size(25, 13);
            this.lblAreaFeet.TabIndex = 2;
            this.lblAreaFeet.Text = "......";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Location = new System.Drawing.Point(3, 25);
            this.lblAreaAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(82, 13);
            this.lblAreaAnswer.TabIndex = 1;
            this.lblAreaAnswer.Text = "Area of Floor M²";
            // 
            // lblAreaOfFloor
            // 
            this.lblAreaOfFloor.AutoSize = true;
            this.lblAreaOfFloor.Location = new System.Drawing.Point(115, 25);
            this.lblAreaOfFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaOfFloor.Name = "lblAreaOfFloor";
            this.lblAreaOfFloor.Size = new System.Drawing.Size(28, 13);
            this.lblAreaOfFloor.TabIndex = 0;
            this.lblAreaOfFloor.Text = ".......";
            // 
            // grpWallsAndWindows
            // 
            this.grpWallsAndWindows.Controls.Add(this.nudAmountOfDoors);
            this.grpWallsAndWindows.Controls.Add(this.nudNumberOfWindows);
            this.grpWallsAndWindows.Controls.Add(this.NudAmountOfWalls);
            this.grpWallsAndWindows.Controls.Add(this.nudCoatsRequired);
            this.grpWallsAndWindows.Controls.Add(this.lblNumOfDoors);
            this.grpWallsAndWindows.Controls.Add(this.lblNumOfWindows);
            this.grpWallsAndWindows.Controls.Add(this.lblCoatsNeeded);
            this.grpWallsAndWindows.Controls.Add(this.lblNumOfWalls);
            this.grpWallsAndWindows.Controls.Add(this.lblHeightOfWindows);
            this.grpWallsAndWindows.Controls.Add(this.lblLengthOfWindows);
            this.grpWallsAndWindows.Controls.Add(this.txtHeightOfWindow);
            this.grpWallsAndWindows.Controls.Add(this.txtLengthOfWindow);
            this.grpWallsAndWindows.Controls.Add(this.lblWallHeight);
            this.grpWallsAndWindows.Controls.Add(this.lblWallLength);
            this.grpWallsAndWindows.Controls.Add(this.txtWallHeight);
            this.grpWallsAndWindows.Controls.Add(this.txtWallLength);
            this.grpWallsAndWindows.Location = new System.Drawing.Point(154, 46);
            this.grpWallsAndWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWallsAndWindows.Name = "grpWallsAndWindows";
            this.grpWallsAndWindows.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWallsAndWindows.Size = new System.Drawing.Size(469, 155);
            this.grpWallsAndWindows.TabIndex = 1;
            this.grpWallsAndWindows.TabStop = false;
            this.grpWallsAndWindows.Text = "Walls and Windows";
            // 
            // nudAmountOfDoors
            // 
            this.nudAmountOfDoors.Location = new System.Drawing.Point(315, 115);
            this.nudAmountOfDoors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAmountOfDoors.Name = "nudAmountOfDoors";
            this.nudAmountOfDoors.Size = new System.Drawing.Size(65, 20);
            this.nudAmountOfDoors.TabIndex = 20;
            // 
            // nudNumberOfWindows
            // 
            this.nudNumberOfWindows.Location = new System.Drawing.Point(315, 86);
            this.nudNumberOfWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNumberOfWindows.Name = "nudNumberOfWindows";
            this.nudNumberOfWindows.Size = new System.Drawing.Size(65, 20);
            this.nudNumberOfWindows.TabIndex = 19;
            // 
            // NudAmountOfWalls
            // 
            this.NudAmountOfWalls.Location = new System.Drawing.Point(108, 83);
            this.NudAmountOfWalls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NudAmountOfWalls.Name = "NudAmountOfWalls";
            this.NudAmountOfWalls.Size = new System.Drawing.Size(65, 20);
            this.NudAmountOfWalls.TabIndex = 18;
            // 
            // nudCoatsRequired
            // 
            this.nudCoatsRequired.Location = new System.Drawing.Point(108, 115);
            this.nudCoatsRequired.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCoatsRequired.Name = "nudCoatsRequired";
            this.nudCoatsRequired.Size = new System.Drawing.Size(65, 20);
            this.nudCoatsRequired.TabIndex = 17;
            // 
            // lblNumOfDoors
            // 
            this.lblNumOfDoors.AutoSize = true;
            this.lblNumOfDoors.Location = new System.Drawing.Point(214, 115);
            this.lblNumOfDoors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumOfDoors.Name = "lblNumOfDoors";
            this.lblNumOfDoors.Size = new System.Drawing.Size(87, 13);
            this.lblNumOfDoors.TabIndex = 16;
            this.lblNumOfDoors.Text = "Number of Doors";
            // 
            // lblNumOfWindows
            // 
            this.lblNumOfWindows.AutoSize = true;
            this.lblNumOfWindows.Location = new System.Drawing.Point(188, 86);
            this.lblNumOfWindows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumOfWindows.Name = "lblNumOfWindows";
            this.lblNumOfWindows.Size = new System.Drawing.Size(103, 13);
            this.lblNumOfWindows.TabIndex = 13;
            this.lblNumOfWindows.Text = "Number of Windows";
            this.lblNumOfWindows.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCoatsNeeded
            // 
            this.lblCoatsNeeded.AutoSize = true;
            this.lblCoatsNeeded.Location = new System.Drawing.Point(22, 115);
            this.lblCoatsNeeded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoatsNeeded.Name = "lblCoatsNeeded";
            this.lblCoatsNeeded.Size = new System.Drawing.Size(75, 13);
            this.lblCoatsNeeded.TabIndex = 14;
            this.lblCoatsNeeded.Text = "Coats required";
            // 
            // lblNumOfWalls
            // 
            this.lblNumOfWalls.AutoSize = true;
            this.lblNumOfWalls.Location = new System.Drawing.Point(13, 83);
            this.lblNumOfWalls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumOfWalls.Name = "lblNumOfWalls";
            this.lblNumOfWalls.Size = new System.Drawing.Size(85, 13);
            this.lblNumOfWalls.TabIndex = 12;
            this.lblNumOfWalls.Text = "Number of Walls";
            // 
            // lblHeightOfWindows
            // 
            this.lblHeightOfWindows.AutoSize = true;
            this.lblHeightOfWindows.Location = new System.Drawing.Point(200, 57);
            this.lblHeightOfWindows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeightOfWindows.Name = "lblHeightOfWindows";
            this.lblHeightOfWindows.Size = new System.Drawing.Size(92, 13);
            this.lblHeightOfWindows.TabIndex = 9;
            this.lblHeightOfWindows.Text = "Height of Window";
            // 
            // lblLengthOfWindows
            // 
            this.lblLengthOfWindows.AutoSize = true;
            this.lblLengthOfWindows.Location = new System.Drawing.Point(198, 22);
            this.lblLengthOfWindows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLengthOfWindows.Name = "lblLengthOfWindows";
            this.lblLengthOfWindows.Size = new System.Drawing.Size(94, 13);
            this.lblLengthOfWindows.TabIndex = 8;
            this.lblLengthOfWindows.Text = "Length of Window";
            // 
            // txtHeightOfWindow
            // 
            this.txtHeightOfWindow.Location = new System.Drawing.Point(315, 55);
            this.txtHeightOfWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeightOfWindow.Name = "txtHeightOfWindow";
            this.txtHeightOfWindow.Size = new System.Drawing.Size(56, 20);
            this.txtHeightOfWindow.TabIndex = 7;
            this.txtHeightOfWindow.TextChanged += new System.EventHandler(this.txtHeightOfWindow_TextChanged);
            // 
            // txtLengthOfWindow
            // 
            this.txtLengthOfWindow.Location = new System.Drawing.Point(315, 20);
            this.txtLengthOfWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLengthOfWindow.Name = "txtLengthOfWindow";
            this.txtLengthOfWindow.Size = new System.Drawing.Size(56, 20);
            this.txtLengthOfWindow.TabIndex = 6;
            this.txtLengthOfWindow.TextChanged += new System.EventHandler(this.txtLengthOfWindow_TextChanged);
            // 
            // lblWallHeight
            // 
            this.lblWallHeight.AutoSize = true;
            this.lblWallHeight.Location = new System.Drawing.Point(39, 57);
            this.lblWallHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWallHeight.Name = "lblWallHeight";
            this.lblWallHeight.Size = new System.Drawing.Size(60, 13);
            this.lblWallHeight.TabIndex = 5;
            this.lblWallHeight.Text = "Wall height";
            // 
            // lblWallLength
            // 
            this.lblWallLength.AutoSize = true;
            this.lblWallLength.Location = new System.Drawing.Point(8, 24);
            this.lblWallLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWallLength.Name = "lblWallLength";
            this.lblWallLength.Size = new System.Drawing.Size(91, 13);
            this.lblWallLength.TabIndex = 3;
            this.lblWallLength.Text = "Total Wall Length";
            // 
            // txtWallHeight
            // 
            this.txtWallHeight.Location = new System.Drawing.Point(108, 55);
            this.txtWallHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWallHeight.Name = "txtWallHeight";
            this.txtWallHeight.Size = new System.Drawing.Size(56, 20);
            this.txtWallHeight.TabIndex = 2;
            this.txtWallHeight.TextChanged += new System.EventHandler(this.txtWallHeight_TextChanged);
            // 
            // txtWallLength
            // 
            this.txtWallLength.Location = new System.Drawing.Point(108, 22);
            this.txtWallLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWallLength.Name = "txtWallLength";
            this.txtWallLength.Size = new System.Drawing.Size(56, 20);
            this.txtWallLength.TabIndex = 0;
            this.txtWallLength.TextChanged += new System.EventHandler(this.txtWallLength_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter input in Meters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(483, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Created by Ryan Kings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(538, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpWallsAndWindows);
            this.Controls.Add(this.grpAreaOfRoom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Software Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAreaOfRoom.ResumeLayout(false);
            this.grpAreaOfRoom.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpWallsAndWindows.ResumeLayout(false);
            this.grpWallsAndWindows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfDoors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmountOfWalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoatsRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAreaOfRoom;
        private System.Windows.Forms.TextBox txtFloorLength;
        private System.Windows.Forms.TextBox txtFloorWidth;
        private System.Windows.Forms.Label lblRoomLength;
        private System.Windows.Forms.Label lblRoomWidth;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.GroupBox grpWallsAndWindows;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblWallHeight;
        private System.Windows.Forms.Label lblWallLength;
        private System.Windows.Forms.TextBox txtWallHeight;
        private System.Windows.Forms.TextBox txtWallLength;
        private System.Windows.Forms.Label lblHeightOfWindows;
        private System.Windows.Forms.Label lblLengthOfWindows;
        private System.Windows.Forms.TextBox txtHeightOfWindow;
        private System.Windows.Forms.TextBox txtLengthOfWindow;
        private System.Windows.Forms.Label lblNumOfWindows;
        private System.Windows.Forms.Label lblNumOfWalls;
        private System.Windows.Forms.Label lblCoatsNeeded;
        private System.Windows.Forms.Label lblNumOfDoors;
        private System.Windows.Forms.Label lblAreaFeetAnswer;
        private System.Windows.Forms.Label lblVolumeOfRoom;
        private System.Windows.Forms.Label lblVolumeAnswer;
        private System.Windows.Forms.Label lblAreaFeet;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.Label lblAreaOfFloor;
        private System.Windows.Forms.Label lblVolumeFeet;
        private System.Windows.Forms.Label lblVolumeFeetAnswer;
        private System.Windows.Forms.Label lblPaintRequired;
        private System.Windows.Forms.Label lblPaintAnswer;
        private System.Windows.Forms.NumericUpDown nudAmountOfDoors;
        private System.Windows.Forms.NumericUpDown nudNumberOfWindows;
        private System.Windows.Forms.NumericUpDown NudAmountOfWalls;
        private System.Windows.Forms.NumericUpDown nudCoatsRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

