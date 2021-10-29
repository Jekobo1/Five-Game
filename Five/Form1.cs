using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Five
{
    public partial class Five : Form
    {
        public int count = 0;
        public int n = 0;
        public int tick;

        public Five()
        {
            InitializeComponent();
            
        }
        
        public int Num()
        {
            Random rnd = new Random();
            int num;
            do
            {
                num = rnd.Next(1, 10);
                
            } while (num == 5);
            
            return num;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            
            n = Num();
            this.Number.Text = n.ToString();
            ScoreP();
            Greater.Checked = false;
            Smaller.Checked = false;



        }
        private void ScoreP()
        {
            

            if (this.Greater.Checked && n > 5)
            {
                count++;
                this.scoretext.Text = count.ToString();

            }
            
            else if (this.Smaller.Checked && n < 5)
            {
                count++;
                this.scoretext.Text = count.ToString();
            }
            else if(this.Greater.Checked && this.Smaller.Checked)
            {
                this.scoretext.Text = count.ToString();
            }
            
            else
                this.scoretext.Text = count.ToString();


        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tick++;
            if (tick == 25)
            {
                if (count < 15)
                {
                    this.Text = "Loser!";
                    MessageBox.Show("You loose!");
                    timer1.Stop();
                    Application.Exit();
                }
                else
                    timer1.Stop();

            }
            else if (count == 15)
            {
                this.Text = "Winner!";
                MessageBox.Show("You won!");
                Application.Exit();
                timer1.Stop();
            }
            this.Text = tick.ToString();
        }

        private void Greater_CheckedChanged(object sender, EventArgs e)
        {
            if (Greater.Checked == true)
                Smaller.Checked = false;
        }

        private void Smaller_CheckedChanged(object sender, EventArgs e)
        {
            if (Smaller.Checked == true)
                Greater.Checked = false;
        }
    }
}
