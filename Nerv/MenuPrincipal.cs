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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            OcultarSubmenus();
            PosicionarInterfaz();
            PosicionarMenus();
            PosicionarSMCats();
            PosicionarSMOp();
            PosicionarSMReps();
            PosicionarSMSegs();
            PosicionarSMs();
        }
        public void OcultarSubmenus()
        {
            panelCatalogos.Visible = false;
            panelReportes.Visible = false;
            panelOperaciones.Visible = false;
            panelSeguridad.Visible = false;
        }
        public void PosicionarInterfaz()
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Width = this.Width;
            panel1.Height = 125;
            panel2.Left = 0;
            panel2.Top = 0;
            panel2.Width = 150;
            panel2.Height = this.Height;
            panel3.Left = 0;
            panel3.Top = 0;
            panel3.Width = 150;
            panel3.Height = 125;
            panel4.Left = 0;
            panel4.Top = 0;
            panel4.Width = this.Width;
            panel4.Height = this.Height;
        }
        public void PosicionarMenus()
        {
            MenuCatalogos.Top = panel3.Bottom + 50;
            MenuOperaciones.Top = MenuCatalogos.Bottom + 50;
            MenuReportes.Top = MenuOperaciones.Bottom + 50;
            MenuSeguridad.Top = MenuReportes.Bottom + 50;


            MenuCatalogos.Left = 30;
            MenuOperaciones.Left = 30;
            MenuReportes.Left = 30;
            MenuSeguridad.Left = 30;

        }
        public void PosicionarSMs()
        {
            panelCatalogos.Top = MenuCatalogos.Top;
            panelOperaciones.Top = MenuOperaciones.Top;
            panelReportes.Top = MenuReportes.Top;
            panelSeguridad.Top = MenuSeguridad.Top;

            panelCatalogos.Left = panel2.Right;
            panelOperaciones.Left = panel2.Right;
            panelReportes.Left = panel2.Right;
            panelSeguridad.Left = panel2.Right;

            panelCatalogos.Height = (SMCat3.Bottom + 20);
            panelOperaciones.Height = (SMOp2.Bottom + 20);
            panelReportes.Height = (SMRep4.Bottom + 20);
            panelSeguridad.Height = (SMSeg1.Bottom + 20);

            panelCatalogos.Width = 200;
            panelOperaciones.Width = 200;
            panelReportes.Width = 200;
            panelSeguridad.Width = 200;
        }
        public void PosicionarSMCats()
        {
            SMCat1.Top = 20;
            SMCat2.Top = SMCat1.Bottom + 50;
            SMCat3.Top = SMCat2.Bottom + 50;

            SMCat1.Left = 40;
            SMCat2.Left = 40;
            SMCat3.Left = 40;
        }
        public void PosicionarSMReps()
        {
            SMRep1.Top = 20;
            SMRep2.Top = SMRep1.Bottom + 50;
            SMRep3.Top = SMRep2.Bottom + 50;
            SMRep4.Top = SMRep3.Bottom + 50;

            SMRep1.Left = 40;
            SMRep2.Left = 40;
            SMRep3.Left = 40;
            SMRep4.Left = 40;
        }
        public void PosicionarSMOp()
        {
            SMOp1.Top = 20;
            SMOp2.Top = SMOp1.Bottom + 50;

            SMOp1.Left = 40;
            SMOp2.Left = 40;

        }
        public void PosicionarSMSegs()
        {
            SMSeg1.Top = 20;

            SMSeg1.Left = 40;
        }
        private void MenuCatalogos_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            panelCatalogos.Visible = true;
        }
        private void MenuOperaciones_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            panelOperaciones.Visible = true;
        }
        private void MenuReportes_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            panelReportes.Visible = true;
        }
        private void MenuSeguridad_Click(object sender, EventArgs e)
        {
            OcultarSubmenus();
            panelSeguridad.Visible = true;
        }

        private void SMRep1_Click(object sender, EventArgs e)
        {
            ReporteInventarios RI = new ReporteInventarios();
            RI.Show();
            this.Close();
        }
        private void SMRep2_Click(object sender, EventArgs e)
        {
            ReporteCompras RC = new ReporteCompras();
            RC.Show();
            this.Close();
        }
        private void SMRep3_Click(object sender, EventArgs e)
        {
            ReporteVentas RV = new ReporteVentas();
            RV.Show();
            this.Close();
        }
        private void SMRep4_Click(object sender, EventArgs e)
        {
            ReporteRezago RR = new ReporteRezago();
            RR.Show();
            this.Close();
        }
        private void SMCat1_Click(object sender, EventArgs e)
        {
            CatalogoProductos CP = new CatalogoProductos();
            CP.Show();
            this.Close();
        }
        private void SMOp1_Click(object sender, EventArgs e)
        {
            RegistroCompras OP1 = new RegistroCompras();
            OP1.Show();
            this.Close();
        }
        private void SMOp2_Click(object sender, EventArgs e)
        {
            RegistroVentas OP2 = new RegistroVentas();
            OP2.Show();
            this.Close();
        }
        private void SMSeg1_Click(object sender, EventArgs e)
        {
            GestionUsuarios GU = new GestionUsuarios();
            GU.Show();
            this.Close();
        }
        private void SMCat2_Click(object sender, EventArgs e)
        {
            CatalogoClientes CC = new CatalogoClientes();
            CC.Show();
            this.Close();
        }
        private void SMCat3_Click(object sender, EventArgs e)
        {
            CatalogoProveedores Cprov = new CatalogoProveedores();
            Cprov.Show();
            this.Close();
        }
    }
}
