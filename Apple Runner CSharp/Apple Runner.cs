﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;

namespace Apple_Runner_CSharp
{
    public partial class Apple_Runner : Form
    {

        // Creates variables for use in moving sprite
        int ypos;
        int xpos;
        // Creates variable for use in detecting collision
        Boolean collision;
        // Creates variable for holding score
        int current_score = 0;
        //  Used for golden apple collison which stops the game
        Boolean Golden_Apple;
        int timercountdown = 50;

        public Apple_Runner()
        {
            InitializeComponent();
        }

        public void Apple_Runner_Load(object sender, EventArgs e)
        {
            // Reports X and Y details
            xpos = PicSprite.Location.X;
            ypos = PicSprite.Location.Y;


        }
        private void PlayAppleBumpSound()
        {
            // New Sound
            SoundPlayer audio = new SoundPlayer(Apple_Runner_CSharp.Properties.Resources.Mario_Coin);
            // Play
            audio.Play();
            Convert.ToInt32(xpos);



        }
        private void PlayGoldenAppleSound()
        {
            // New Sound
            SoundPlayer audio = new SoundPlayer(Apple_Runner_CSharp.Properties.Resources.mario_level_complete);
            // Play
            audio.Play();

        }
        private void Move_Sprite_Left()
        {
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = xpos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves left by 3
            xpos = xpos - 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_left);
            // // Debug Show Xpos in box
            //LabelTimeLeft.Text = xpos.ToString();
        }
        private void Move_Sprite_Right()
        {
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = xpos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves right by 3
            xpos = xpos + 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_right);
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = xpos.ToString();
        }
        private void Move_Sprite_Up()
        {
            // Debug Show Ypos in box
            // LabelTimeLeft.Text = ypos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves up by 3
            ypos = ypos - 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_up);
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = ypos.ToString();
        }
        private void Move_Sprite_Down()
        {
            // Debug Show Ypos in box
            // LabelTimeLeft.Text = ypos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves down by 3
            ypos = ypos + 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_down);
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = ypos.ToString();
        }


        public void TextBoxKeyInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (PicSprite.Bounds.IntersectsWith(PictureBox1.Bounds))
            {
                // Run method for general purposes
                isAppleHit();
                // Move box out of range
                PictureBox1.Top = 10000000;
                // Make box invisible
                PictureBox1.Visible = false;

            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox2.Bounds))
            {
                isAppleHit();
                PictureBox2.Top = 10000000;
                PictureBox2.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox3.Bounds))
            {
                isAppleHit();
                PictureBox3.Top = 10000000;
                PictureBox3.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox4.Bounds))
            {
                isAppleHit();
                PictureBox4.Top = 10000000;
                PictureBox4.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox5.Bounds))
            {
                isAppleHit();
                PictureBox5.Top = 10000000;
                PictureBox5.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox6.Bounds))
            {
                isAppleHit();
                PictureBox6.Top = 10000000;
                PictureBox6.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox7.Bounds))
            {
                isAppleHit();
                PictureBox7.Top = 10000000;
                PictureBox7.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox8.Bounds))
            {
                isAppleHit();
                PictureBox8.Top = 10000000;
                PictureBox8.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox9.Bounds))
            {
                isAppleHit();
                PictureBox9.Top = 10000000;
                PictureBox9.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox10.Bounds))
            {
                isAppleHit();
                PictureBox10.Top = 10000000;
                PictureBox10.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox11.Bounds))
            {
                isAppleHit();
                PictureBox11.Top = 10000000;
                PictureBox11.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox12.Bounds))
            {
                isAppleHit();
                PictureBox12.Top = 10000000;
                PictureBox12.Visible = false;
            }
            // Call methods for moving sprites
            if (e.KeyCode == Keys.Left)
            {
                Move_Sprite_Left();
            }
            if (e.KeyCode == Keys.Right)
            {
                Move_Sprite_Right();
            }
            if (e.KeyCode == Keys.Up)
            {
                Move_Sprite_Up();
            }
            if (e.KeyCode == Keys.Down)
            {
                Move_Sprite_Down();
            }
            if (e.KeyCode == Keys.W)
            {
                Move_Sprite_Up();
            }
            if (e.KeyCode == Keys.A)
            {
                Move_Sprite_Left();

            }
            if (e.KeyCode == Keys.S)
            {
                Move_Sprite_Down();
            }
            if (e.KeyCode == Keys.D)
            {
                Move_Sprite_Right();

            }
            // Handle textbox cursor
            HideCaret(TextBoxKeyInput.Handle);
        }

        private void TimerRemaining_Tick(object sender, EventArgs e)
        {
            // When time is over the timer is disabled, message is displayed and app exits
            TimerRemaining.Enabled = false;
            MessageBox.Show("Out of Time");
            Application.Exit();

        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {

            //  'Uses TimerCountDown variable to minus 1 at a rate of every second to give the illusion of a countdown, Default Value is 50 in the form which means it counts down from 50
            timercountdown = timercountdown - 1;
            //  'Outputs Timer Countdown to Label
            LabelTimeLeft.Text = timercountdown.ToString();
            //'Stops timerdown when countdown reaches 0 and disables it
            if (timercountdown == 0)
            {
                TimerDown.Enabled = false;
                TimerDown.Stop();
            }

            // 'Stops timerdown when Golden_Apple = True, also disables timer
            if (Golden_Apple == true)
            {
                TimerDown.Enabled = false;
                TimerDown.Stop();
            }


        }

        private void Apple_Runner_FormClosing(object sender, FormClosingEventArgs e)
        {
            // App Exit on close handle
            Application.Exit();
        }
        private void isAppleHit()
        {
            // Set collision to true
            collision = true;
            // Increment Score
            current_score = current_score + 100;
            // Display score in Label
            LabelScore.Text = current_score.ToString();
            // Use sound method
            PlayAppleBumpSound();
        }
        // Used for hiding cursor in textbox
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        
    }

}
       

   


