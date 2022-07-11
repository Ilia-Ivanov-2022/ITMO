using System;
using System.Windows.Forms;
using AnimatedWindow;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            // Hiding the window
            this.Hide();
            // Start animation. The second parameter in brackets is
            // the animation time in milliseconds 
            WinAPIClass.AnimateWindow(this, 3000,
                WinAPIClass.AnimateWindowFlags.AW_ACTIVATE |
                WinAPIClass.AnimateWindowFlags.AW_BLEND);
            // Display buttons after animation
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000,
                WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE |
                WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000,
                WinAPIClass.AnimateWindowFlags.AW_CENTER |
                WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }
    }
}
