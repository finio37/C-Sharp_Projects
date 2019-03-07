using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class SimpleSunSetAnimation : Form
    {
        //angle variables
        float angle_earth_rotation;
        float angle_moon_rotation;

        //variable increments of angles
		float size_of_earth_rotation_change =0.05F;
        float size_of_moon_rotation_change =0.05F;

        //constants
        //sun radius
        const int SunR = 50;
        
        //earth radius
        const int EarthR = 25;
        
		//moon radius
        const int MoonR = 5;

        //earth track
        int earthTrack;
        //moon track
        int moonTrack;

        public SimpleSunSetAnimation()
        {
            InitializeComponent();
            this.Left = 10;
            this.Top = 10;

            //setting the width and height of the screen
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width*0.7F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height*0.7f);

            //background color setting
            this.BackColor = Color.RoyalBlue;

            //blocking the change of width and height
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);

            //disable window minimization and maximization
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            earthTrack = this.Width / 5;
            moonTrack = this.Width / 12;
        }
        private void SimpleSunSetAnimation_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, this.Width/2 - SunR,
                this.Height/2 - SunR,2*SunR,2*SunR);
            
            //determining the initial location of the land
            float earth_x = (float)(this.Width / 2 + earthTrack*Math.Cos(angle_earth_rotation));
            float earth_y = (float)(this.Height/2 + earthTrack*Math.Sin(angle_earth_rotation));

            e.Graphics.FillEllipse(Brushes.LimeGreen,earth_x-EarthR,earth_y-EarthR,
                2*EarthR,2*EarthR);

            //determining the initial position of the moon
            float moon_x = (float)(earth_x + moonTrack * Math.Cos(angle_moon_rotation));
            float moon_y = (float)(earth_y + moonTrack*Math.Sin(angle_moon_rotation));

            e.Graphics.FillEllipse(Brushes.LightYellow,moon_x-MoonR,moon_y-MoonR,
                2*MoonR,2*MoonR);
        }
        private void SunSetClock_Tick(object sender, EventArgs e)
        {
            this.SunSetClock.Enabled = true;
            this.angle_earth_rotation = this.angle_earth_rotation + this.size_of_earth_rotation_change ;
            if (angle_earth_rotation >= 360F)
                 this.angle_earth_rotation = 0;
            
            this.angle_moon_rotation = this.angle_moon_rotation - this.size_of_moon_rotation_change ;
            if (angle_moon_rotation >= 360F) this.angle_moon_rotation = 0;
            
            this.Invalidate();
        }
    }