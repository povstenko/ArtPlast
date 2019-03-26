using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class PageHome : UserControl
    {
        List<string> imgs;
        int cntr;

        public PageHome()
        {
            InitializeComponent();

            imgs = new List<string>();
            imgs.Add(@"img\1.jpg");
            imgs.Add(@"img\2.jpg");
            imgs.Add(@"img\3.jpg");
            imgs.Add(@"img\4.jpg");

            cntr = 1;
        }
        private void PageHome_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        // Stop slideshow
        private void pbGallery_Click(object sender, EventArgs e)
        {
            ChangeGalleryImage();
        }
        private void pbGallery_MouseEnter(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void pbGallery_MouseLeave(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ChangeGalleryImage();
        }

        // Design
        private void ChangeGalleryImage()
        {
            pbGallery.Image = Image.FromFile(imgs[cntr]);
            cntr++;

            if (cntr > imgs.Count - 1)
                cntr = 0;
        }

        // New materials effect
        private void panel_MouseEnter(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.Gainsboro;
        }
        private void panel_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.WhiteSmoke;
        }
        //
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            Panel p = (Panel)pb.Parent;
            p.BackColor = Color.Gainsboro;
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            Panel p = (Panel)pb.Parent;
            p.BackColor = Color.WhiteSmoke;
        }
        //
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button pb = (Button)sender;

            Panel p = (Panel)pb.Parent;
            p.BackColor = Color.Gainsboro;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button pb = (Button)sender;

            Panel p = (Panel)pb.Parent;
            p.BackColor = Color.WhiteSmoke;
        }
    }
}
