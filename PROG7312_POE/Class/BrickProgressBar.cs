using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE.Class
{
    public class BrickProgressBar : ProgressBar
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Set brick width and height
            int brickWidth = 20; // Width of each brick (you can adjust this)
            int brickHeight = this.Height; // Height of the brick, same as the progress bar height

            // Calculate the total number of bricks that can fit in the progress bar width
            int totalBricks = this.Width / brickWidth;

            // Calculate the number of bricks to fill based on the progress value
            int numBricksFilled = (int)((float)this.Value / this.Maximum * totalBricks);

            // Create a brush for the bricks (you can change the color if you like)
            using (Brush brickBrush = new SolidBrush(Color.MidnightBlue))
            {
                // Draw the filled bricks
                for (int i = 0; i < numBricksFilled; i++)
                {
                    e.Graphics.FillRectangle(brickBrush, i * brickWidth, 0, brickWidth, brickHeight);
                }
            }

            // Draw the background of the ProgressBar if needed (for unfilled bricks)
            if (numBricksFilled < totalBricks)
            {
                using (Brush backgroundBrush = new SolidBrush(Color.Gainsboro))
                {
                    e.Graphics.FillRectangle(backgroundBrush, numBricksFilled * brickWidth, 0, (totalBricks - numBricksFilled) * brickWidth, brickHeight);
                }
            }
        }
    }
}
