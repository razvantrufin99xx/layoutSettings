using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace layoutSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class layoutsettings
        {
            public Form1 f;
            public layoutsettings()
            {

            }
            public layoutsettings(Form f)
            {
                this.f = (Form1)f;
            }

            public int getCountAllControlsOnAForm()
            {
                int n = f.Controls.Count;
                return n;
            }

            public bool addNewButton(string buttonname, string buttontext, int left, int top, int width, int height)
            {
                int n = getCountAllControlsOnAForm();
                f.Controls.Add(new Button());
                f.Controls[n].Name = buttonname;
                f.Controls[n].Text = buttontext;
                f.Controls[n].Left = left;
                f.Controls[n].Top = top;
                f.Controls[n].Width = width;
                f.Controls[n].Height = height;
                f.Controls[n].Visible = true;
                
                return true;
            }
            
        }

        public int getCountAllControlsOnAForm()
        {
            int n = this.Controls.Count;
            return n;
        }


        public void test(object sender, EventArgs e)
        {
                 this.Text = this.Controls[this.getCountAllControlsOnAForm() - 1].ToString();
        }
        public void test2(object sender, EventArgs e)
        {
            this.Text = "Form 1 ";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            layoutsettings ls = new layoutsettings(this);
           
            ls.addNewButton("btn1", "Adauga", 10, 10, 256, 256);
            
            ls.f.Controls[this.getCountAllControlsOnAForm() - 1].Click += new EventHandler(test);


            ls.addNewButton("btn2", "Sterge", 366, 10, 256, 256);

            ls.f.Controls[this.getCountAllControlsOnAForm() - 1].Click += new EventHandler(test2);

        }
    }
}
