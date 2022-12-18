namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
            label3.Visible = true;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }
        int collectedcoins = 0;
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 492)
            { x = r.Next(0,115);
              enemy1.Location = new Point(x, 0);
            }  else { enemy1.Top += speed; }

            if (enemy2.Top >= 492)
            {x = r.Next(240, 300);
                enemy2.Location = new Point(x, 0);
            }else { enemy2.Top += speed; }

            if (enemy3.Top >= 492)
            { x = r.Next(240, 300);
              enemy3.Location = new Point(x, 0);
            }else { enemy3.Top += speed; }

            if (enemy4.Top >= 492)
            { x = r.Next(120, 235);
               enemy4.Location = new Point(x, 0);
            } else { enemy4.Top += speed; }

        }
        void coins(int speed)
        {if(coin1.Top >= 492) { x = r.Next(120, 230);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }
            if (coin2.Top >= 492)
            {
                x = r.Next(240, 300);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }
            if (coin3.Top >= 492)
            {
                x = r.Next(0, 230);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }
            if (coin4.Top >= 492)
            {
                x = r.Next(0, 115);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }
        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
                
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
                
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
                
            }
            if (car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
                
            }
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 492) { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 492) { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 492) { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 492) { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox7.Top >= 492) { pictureBox7.Top = 0; }
            else { pictureBox7.Top += speed; }

            if (pictureBox8.Top >= 492) { pictureBox8.Top = 0; }
            else { pictureBox8.Top += speed; }

            if (pictureBox9.Top >= 492) { pictureBox9.Top = 0; }
            else { pictureBox9.Top += speed; }

            if (pictureBox10.Top >= 492) { pictureBox10.Top = 0; }
            else { pictureBox10.Top += speed; }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {   collectedcoins++;
                label2.Text = "Score = "+collectedcoins.ToString();
                x = r.Next(0, 230);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label2.Text = "Score = " + collectedcoins.ToString();
                x = r.Next(0, 230);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label2.Text = "Score = " + collectedcoins.ToString();
                x = r.Next(0, 230);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label2.Text = "Score = " + collectedcoins.ToString();
                x = r.Next(0, 230);
                coin4.Location = new Point(x, 0);
            }
        }
        int gamespeed;
        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                {
                    car.Left += -8;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 370)
                {
                    car.Left += 8;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21) { gamespeed++;
                    label3.Visible = false;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
    }