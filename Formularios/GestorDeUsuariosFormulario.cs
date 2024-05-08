using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaRegistradora.Formularios
{
    public partial class GestorDeUsuariosFormulario : Form
    {
        public GestorDeUsuariosFormulario()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdminFormulario menuAdminFormulario = new MenuAdminFormulario();
            menuAdminFormulario.Show();
            this.Hide();
        }
    }
}
