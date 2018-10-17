using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;

                return myCp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
        }
        int n1 = 0;
        public int n;
        private void button1_Click(object sender, EventArgs e)
        {
            //int dis;

            //Display.Rotate(1, Display.Orientations.DEGREES_CW_0);




            MessageBox.Show("Try me bitch");

            while (true)
            {
                
                MessageBox.Show("FUCKED !");
                if (true)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        var myForm = new Form2();
                        myForm.Show();

                        for (int a = 0; a < 10; a++)
                        {
                            while (a < 10)
                            {
                                int mil = 20;
                                Thread.Sleep(mil);
                                Display.Rotate(1, Display.Orientations.DEGREES_CW_0);

                                Thread.Sleep(mil);
                                Display.Rotate(1, Display.Orientations.DEGREES_CW_90);
                                Thread.Sleep(mil);
                                Display.Rotate(1, Display.Orientations.DEGREES_CW_180);
                                Thread.Sleep(mil);
                                Display.Rotate(1, Display.Orientations.DEGREES_CW_270);
                            }
                        }
                    }
               


                        //switch (i)
                        //{
                        //    case 1:

                        //        Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
                        //        break;

                        //    case 2:

                        //        Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
                        //        break;

                        //    case 3:

                        //        Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
                        //        break;

                        //    case 5:

                        //        Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
                        //        break;

                        //}



                    }
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    
    }







