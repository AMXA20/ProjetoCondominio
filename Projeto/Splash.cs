using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }
        public static void ThreadSplash()
        {
            Application.Run(new Programa());
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            
                
              
            if (progressBar1.Value == 33)
            {
               /* 
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadSplash));
                t.SetApartmentState(ApartmentState.STA);
                t.IsBackground = true;
               
                t.Start();
                */
                timer1.Stop();
                Programa p = new Programa();
                this.Hide();
                p.ShowDialog();
                this.Close();
                
            }
            

        }
        
    }
}
