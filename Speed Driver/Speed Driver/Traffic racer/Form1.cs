using System;
using System.Drawing;
using System.Windows.Forms;

namespace Traffic_racer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!finished)
            {
                if (pbmaincar.Left >= 90 && pbmaincar.Left <= 1000)
                {
                    if (e.KeyCode == Keys.Left)
                        pbmaincar.Left -= 60;
                        if (pbmaincar.Left <= 99) 
                            finished = true;
                    if (e.KeyCode == Keys.Right)
                        pbmaincar.Left += 60;
                        if (pbmaincar.Left >= 935)
                            finished = true;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                timer2.Stop();
                carselection frm = new carselection();
                frm.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomCar();
            switch (carselection.car)
            {
                case 1:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 1 + ".png");
                    break;
                case 2:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 2 + ".png");
                    break;
                case 3:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 3 + ".png");
                    break;
                case 4:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 4 + ".png");
                    break;
                case 5:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 5 + ".png");
                    break;
                case 6:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 6 + ".png");
                    break;
                case 7:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 7 + ".png");
                    break;
                case 8:
                    pbmaincar.Image = Image.FromFile(@"..\..\cars\Car" + 8 + ".png");
                    break;
            }
            pbmaincar.BackColor = Color.Transparent;
            timer2.Start();
        }
        int animation = 0;
        bool finished;
        int score = 0;
        double money = 0;
        Random rnd = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            pbcar1.Top += rnd.Next(30, 70);
            pbcar2.Top += rnd.Next(30, 70);
            pbcar3.Top += rnd.Next(30, 70);
            pbcar4.Top += rnd.Next(30, 70);
            if (pbcar1.Top > 800)
            {
                pbcar1.Top = rnd.Next(-1200, -500);
                pbcar1.Left = rnd.Next(120, 245);
                pbcar1.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            }
            if (pbcar2.Top > 900)
            {
                pbcar2.Top = rnd.Next(-1200, -500);
                pbcar2.Left = rnd.Next(340, 467);
                pbcar2.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            }
            if (pbcar3.Top > 700)
            {
                pbcar3.Top = rnd.Next(-1200, -500);
                pbcar3.Left = rnd.Next(560, 690);
                pbcar3.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            }
            if (pbcar4.Top > 750)
            {
                pbcar4.Top = rnd.Next(-1200, -500);
                pbcar4.Left = rnd.Next(786, 915);
                pbcar4.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            }
            if (!finished)
            {
                plane1.Top += 30;
                if (plane1.Top > 50)
                {
                    plane1.Top = -230;
                }
                plane2.Top += 30;
                if (plane2.Top > 50)
                {
                    plane2.Top = -230;
                }
                plane3.Top += 30;
                if (plane3.Top > 50)
                {
                    plane3.Top = -230;
                }
                score += 3;
                lblskor.Text = score.ToString();
            }
            if (pbmaincar.Bounds.IntersectsWith(pbcar1.Bounds))
            {
                if (!finished)
                    finished = true;
                if (animation < 100)
                {
                    pbcar1.Top += 35;
                    pbcar2.Top -= 100;
                    pbcar3.Top -= 100;
                    pbcar4.Top -= 100;
                }

            }
            else if (pbmaincar.Bounds.IntersectsWith(pbcar2.Bounds))
            {
                if (!finished)
                    finished = true;
                if (animation < 100)
                {
                    pbcar1.Top -= 100;
                    pbcar2.Top += 35;
                    pbcar3.Top -= 100;
                    pbcar4.Top -= 100;
                }
            }
            else if (pbmaincar.Bounds.IntersectsWith(pbcar3.Bounds))
            {
                if (!finished)
                    finished = true;
                if (animation < 100)
                {
                    pbcar1.Top -= 100;
                    pbcar2.Top -= 100;
                    pbcar3.Top += 35;
                    pbcar4.Top -= 100;
                }
            }
            else if (pbmaincar.Bounds.IntersectsWith(pbcar4.Bounds))
            {
                if (!finished)
                    finished = true;
                if (animation < 100)
                {
                    pbcar1.Top -= 35;
                    pbcar2.Top -= 100;
                    pbcar3.Top -= 100;
                    pbcar4.Top += 35;
                }
            }
            if (finished)
            {
                pbmaincar.Top += 35;
                animation += 20;
                plane1.Top += 10;
                plane2.Top += 10;
                plane3.Top += 10;
                if (animation > 100)
                {
                    timer2.Stop();
                    pfinish.Visible = true;
                    lblfscore.Text = score.ToString();
                    money = score * 1.5;
                    lblearning.Text = money.ToString();
                    carselection.Money += money;
                    lblmoney.Text = carselection.Money.ToString();
                }
            }
        }

        private void pbgarage_Click(object sender, EventArgs e)
        {
            carselection frm = new carselection();
            frm.Show();
            this.Close();
        }

        private void pbplayagain_Click(object sender, EventArgs e)
        {
            animation = 0;
            score = 0;
            pfinish.Visible = false;
            pbmaincar.Location = new Point(515, 512);
            finished = false;
            RandomCar();
            timer2.Start();
        }

        private void RandomCar()
        {
            pbcar1.Top = rnd.Next(-1200, -500);
            pbcar1.Left = rnd.Next(120, 245);
            pbcar1.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            pbcar2.Top = rnd.Next(-1200, -500);
            pbcar2.Left = rnd.Next(340, 467);
            pbcar2.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            pbcar3.Top = rnd.Next(-1200, -500);
            pbcar3.Left = rnd.Next(560, 690);
            pbcar3.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
            pbcar4.Top = rnd.Next(-1200, -500);
            pbcar4.Left = rnd.Next(786, 915);
            pbcar4.Image = Image.FromFile(@"..\..\cars\Car" + rnd.Next(1, 9) + ".png");
        }

        private void lbl_minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_exitapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_minimized_MouseEnter(object sender, EventArgs e)
        {
            lbl_minimized.ForeColor = Color.Gray;
        }

        private void lbl_minimized_MouseLeave(object sender, EventArgs e)
        {
            lbl_minimized.ForeColor = Color.White;
        }

        private void lbl_exitapp_MouseEnter(object sender, EventArgs e)
        {
            lbl_minimized.ForeColor = Color.Gray;
        }

        private void lbl_exitapp_MouseLeave(object sender, EventArgs e)
        {
            lbl_minimized.ForeColor = Color.White;
        }
        private Point MouseLocation;
        private void pfrmmove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void pfrmmove_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }
    }
}
