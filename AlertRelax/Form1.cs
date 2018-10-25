using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace AlertRelax
{
    public partial class Form1 : Form
    {
        private Int16 h = 0, m = 0, m45 = 0, s = 0;
        private Int16 mr = 0, sr = 0;

        SoundPlayer reng = new SoundPlayer(@"sound\reng.wav");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void sysTray_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            sysTray.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                sysTray.Visible = true;
                sysTray.ShowBalloonTip(500);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                sysTray.Visible = false;
            }
        }

        private void hideToNotify()
        {
            if(FormWindowState.Normal == this.WindowState)
            {
                sysTray.Visible = true;
                this.Hide();
            }
        }
        private void time_Tick(object sender, EventArgs e)
        {
            if (s <= 60)
            {
                s++;
                
            }
            if(s == 60)
            {
                s = 0;
                m++;
                m45++;
            }
            if(m45 == 45)
            {
                hideToNotify();
                m45 = 0;
                timeRelax.Start();
                //Alert Sound
                sysTray.BalloonTipText = "Đại ca ơi nghỉ xíu đi !!!";
                sysTray.ShowBalloonTip(500); 
                if(8<= DateTime.Now.Hour && DateTime.Now.Hour <= 22)
                    reng.Play();
            }
            if(m == 60)
            {
                m = 0;
                h++;
            }
            timeDisp.Text = h + ":" + m + ":" + s;
        }


        private void timeRelax_Tick(object sender, EventArgs e)
        {
            if (sr <= 60)
            {
                sr++;

            }
            if (sr == 60)
            {
                sr = 0;
                mr++;
            }
            if(mr == 5)
            {
                //Alert Sound
                hideToNotify();
                mr = 0;
                sr = 0;
                m45 = 0;
                timeRelax.Stop();
                sysTray.BalloonTipText = "Đại ca ơi vào học tiếp đi. Đại ca học vui vẻ xíu hết giờ em báo cho <3";
                sysTray.ShowBalloonTip(1000);
                if (8 <= DateTime.Now.Hour && DateTime.Now.Hour <= 22)
                    reng.Play();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            time.Start();
            if (8 < DateTime.Now.Hour && DateTime.Now.Hour < 22)
                reng.Play();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            reng.Stop();
            time.Stop();
            timeRelax.Stop();
        }
    }
}
