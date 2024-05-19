using System;
using System.Drawing;
using System.Windows.Forms;

namespace Traffic_racer
{
    public partial class carselection : Form
    {
        public carselection()
        {
            InitializeComponent();
        }
        public static byte car = 1;
        public static double Money = 5000;
        private int cost = 0;
        static bool[] CarBuy = new bool[7];

        private void pbplay_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Hide();
            frm.Show();
        }

        private void carselection_Load(object sender, EventArgs e)
        {
            lblmoney.Text = Money.ToString();
            switch (car)
            {
                case 1:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 1 + ".png");
                    break;
                case 2:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 2 + ".png");
                    break;
                case 3:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 3 + ".png");
                    break;
                case 4:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 4 + ".png");
                    break;
                case 5:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 5 + ".png");
                    break;
                case 6:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 6 + ".png");
                    break;
                case 7:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 7 + ".png");
                    break;
                case 8:
                    pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + 8 + ".png");
                    break;
            }
            car1();
        }

        private void pbright_Click(object sender, EventArgs e)
        {
            car += 1;
            if (car >= 9)
                car = 1;
            pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + car + ".png");
            car1();
        }

        private void pbleft_Click(object sender, EventArgs e)
        {
            car -= 1;
            if (car <= 0)
                car = 8;
            pcar.BackgroundImage = Image.FromFile(@"..\..\carsright\Car" + car + ".png");
            car1();
        }

        private void buy()
        {
            switch (car)
            {
                case 2:
                    if (CarBuy[0] == false)
                    {
                        if (Money >= 2000)
                        {
                            Money -= 2000;
                            CarBuy[0] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
                case 3:
                    if (CarBuy[1] == false)
                    {
                        if (Money >= 3500)
                        {
                            Money -= 3500;
                            CarBuy[1] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
                case 4:
                    if (CarBuy[2] == false)
                    {
                        if (Money >= 5000)
                        {
                            Money -= 5000;
                            CarBuy[2] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
                case 5:
                    if (CarBuy[3] == false)
                    {
                        if (Money >= 7500)
                        {
                            Money -= 7500;
                            CarBuy[3] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
                case 6:
                    if ((CarBuy[4] == false))
                    {
                        if (Money >= 10000)
                        {
                            Money -= 10000;
                            CarBuy[4] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
                case 7:
                    if (CarBuy[5] == false)
                    {
                        if (Money >= 15000)
                        {
                            Money -= 15000;
                            CarBuy[5] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
                case 8:
                    if (CarBuy[6] == false)
                    {
                        if (Money >= 30000)
                        {
                            Money -= 30000;
                            CarBuy[6] = true;
                            pbuy.Visible = false;
                            pblock.Visible = false;
                            pbplay.Enabled = true;
                        }
                        else
                        {
                            pnomoney.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu arabayı zaten satın almışsınız!");
                    }
                    break;
            }
            lblmoney.Text = Money.ToString();
        }

        private void car1()
        {
            switch (car)
            {
                case 1:
                    pbplay.Enabled = true;
                    pblock.Visible = false;
                    pbuy.Visible = false;
                    break;
                case 2:
                    if (CarBuy[0] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 2000;
                        lblcost.Text = cost.ToString();
                    }
                    break;
                case 3:
                    if (CarBuy[1] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 3500;
                        lblcost.Text = cost.ToString();
                    }
                    break;
                case 4:
                    if (CarBuy[2] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 5000;
                        lblcost.Text = cost.ToString();
                    }
                    break;
                case 5:
                    if (CarBuy[3] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 7500;
                        lblcost.Text = cost.ToString();
                    }
                    break;
                case 6:
                    if (CarBuy[4] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 10000;
                        lblcost.Text = cost.ToString();
                    }
                    break;
                case 7:
                    if (CarBuy[5] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 15000;
                        lblcost.Text = cost.ToString();
                    }
                    break;
                case 8:
                    if (CarBuy[6] == true)
                    {
                        pbplay.Enabled = true;
                        pblock.Visible = false;
                        pbuy.Visible = false;
                    }
                    else
                    {
                        pbplay.Enabled = false;
                        pblock.Visible = true;
                        pbuy.Visible = true;
                        cost = 30000;
                        lblcost.Text = cost.ToString();
                    }
                    break;
            }
        }

        private void pbbuy_Click(object sender, EventArgs e)
        {
            buy();
        }

        private void pbnomoneyok_Click(object sender, EventArgs e)
        {
            pnomoney.Visible = false;
        }

        private void lblnomoneyclose_Click(object sender, EventArgs e)
        {
            pnomoney.Visible = false;
        }

        private void lblnomoneyclose_MouseEnter(object sender, EventArgs e)
        {
            lblnomoneyclose.ForeColor = Color.Gray;
        }

        private void lblnomoneyclose_MouseLeave(object sender, EventArgs e)
        {
            lblnomoneyclose.ForeColor = Color.Black;
        }

        public Point MouseLocation;
        private void pfrmmove_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void pfrmmove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void lbl_minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_exitapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_exitapp_MouseEnter(object sender, EventArgs e)
        {
            lbl_exitapp.ForeColor = Color.Gray;
        }

        private void lbl_exitapp_MouseLeave(object sender, EventArgs e)
        {
            lbl_exitapp.ForeColor = Color.White;
        }

        private void lbl_minimized_MouseEnter(object sender, EventArgs e)
        {
            lbl_minimized.ForeColor = Color.Gray;
        }

        private void lbl_minimized_MouseLeave(object sender, EventArgs e)
        {
            lbl_minimized.ForeColor = Color.White;
        }
    }
}
