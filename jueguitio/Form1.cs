using jueguitio.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jueguitio
{
    public partial class Form1 : Form
    {
        int abc1=0;
        int credi =0;
        int prem =0;
        int a;
        int b;
        int c;
        Thread hilo1 = null;
        Thread hilo2 = null;
        Thread hilo3 = null;
        Thread hilo4 = null;
        public Form1()
        {
            InitializeComponent();
     
            int cre = 0;
            credito.Text = cre.ToString();
            //dos.Image = Resources.banana; 
            ThreadStart delegado1 = new ThreadStart(trotar1);
            ThreadStart delegado2 = new ThreadStart(trotar2);
            ThreadStart delegado3 = new ThreadStart(trotar3);
            ThreadStart delegado4 = new ThreadStart(trotar4);
            hilo1 = new Thread(delegado1);
            hilo2 = new Thread(delegado2);
            hilo3 = new Thread(delegado3);
            hilo4 = new Thread(delegado4);
           
        }

        
        private void trotar1()
        {
            Random rnd = new Random();
          
            int jax = rnd.Next(1,4);

            switch (jax)
            {
                case 1:
                    if (this.uno.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.uno.Image = Resources.manzana; });
                    }
                    else
                    {
                        this.uno.Image = Resources.manzana;
                    }
                    a = 0;
                    break;
                case 2:
                    if (this.uno.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.uno.Image = Resources.banana; });
                    }
                    else
                    {
                        this.uno.Image = Resources.banana;
                    }
                    a = 3;
                    break;
                case 3:
                    if (this.uno.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.uno.Image = Resources.sandia; });
                    }
                    else
                    {
                        this.uno.Image = Resources.sandia;
                    }
                    a = 5;
                    break;
                    
                    
                    
            }

            

    
            
        }
        private void trotar2()
        {
            Random rnd = new Random();
         
            int jax = rnd.Next(1, 4);

            switch (jax)
            {
                case 1:
                    if (this.dos.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.dos.Image = Resources.manzana; });
                    }
                    else
                    {
                        this.dos.Image = Resources.manzana;
                    }
                    b = 0;
                    break;
                case 2:
                    if (this.dos.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.dos.Image = Resources.banana; });
                    }
                    else
                    {
                        this.dos.Image = Resources.banana;
                    }
                    b = 3;
                   
                    break;

                case 3:
                    if (this.uno.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.dos.Image = Resources.sandia; });
                    }
                    else
                    {
                        this.dos.Image = Resources.sandia;
                    }
                    b = 5;
                    break;

            }

        }
        private void trotar3()
        {
            Random rnd = new Random();

            int jax = rnd.Next(1, 4);

            switch (jax)
            {
                case 1:
                    if (this.tres.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.tres.Image = Resources.manzana; });
                    }
                    else
                    {
                        this.tres.Image = Resources.manzana;
                    }
                    c = 0;
                    break;
                case 2:
                    if (this.tres.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.tres.Image = Resources.banana; });
                    }
                    else
                    {
                        this.tres.Image = Resources.banana;
                    }
                    c = 3;

                    break;

                case 3:
                    if (this.tres.InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate { this.tres.Image = Resources.sandia; });
                    }
                    else
                    {
                        this.tres.Image = Resources.sandia;
                    }
                   c = 5;
                    break;
                 
            }
            }
        private void trotar4()
        {

            int dedo = 0;
            while (dedo <= 1) {



                abc1 = calculo();
                prem = abc1;
                if (dedo != 0)
                {
                    credi = credi + abc1;
                }
                elpremio(prem);
                loscreditos();
                dedo++;
                
            }
             
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jugar_Click(object sender, EventArgs e)
        {

        
           

            if (credi >0)
            {
                if (credi <99) {

                    credi--;

                    milagro();
                }





            }

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (credi <99)
            {


                credi++;
                credito.Text = credi.ToString();
            }
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            credi = 0;

            credito.Text = credi.ToString() ;
        }

        private int calculo()
        {

            int d = a + b + c;
            if (d == 9)
            {
                
            }
            else if (d == 15)
            {

            }
            else {
                d = 0;
            }
          

            return d;
        }
        private void elpremio(int prem)
        {
            if (this.credito.InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.premio.Text = prem.ToString(); });
            }
            else
            {
                this.premio.Text = prem.ToString();
            }
        }
        private void loscreditos()
        {
       
            if (this.credito.InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { this.credito.Text = credi.ToString(); });
            }
            else
            {
                this.credito.Text = credi.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hilo4.Abort();
        }
        private void milagro()
        {
            if (!hilo1.IsAlive)

            {
                ThreadStart delegado1 = new ThreadStart(trotar1);
                hilo1 = new Thread(delegado1);
                hilo1.Start();
            }
            if (!hilo2.IsAlive)

            {
                ThreadStart delegado2 = new ThreadStart(trotar2);
                hilo2 = new Thread(delegado2);
                hilo2.Start();
            }
            if (!hilo3.IsAlive)

            {
                ThreadStart delegado3 = new ThreadStart(trotar3);
                hilo3 = new Thread(delegado3);
                hilo3.Start();
            }
            if (!hilo4.IsAlive)

            {
                ThreadStart delegado4 = new ThreadStart(trotar4);
                hilo4 = new Thread(delegado4);
                hilo4.Start();
            }
        }
    }
}
