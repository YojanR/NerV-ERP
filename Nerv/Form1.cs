using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nerv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin")
            {
                if(textBox2.Text == "1234")
                {
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.Show();
                    this.Hide();
                }
            }
        }
        

        //agregarUsuario()
        //{
        //    int agregar objNegocio.AgregarEmpleado(objEntidad);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}