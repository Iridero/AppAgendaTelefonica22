using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAgendaTelefonica22
{

    public partial class FrmAltaContacto : Form
    {
        public event AlModificarAgenda ContactoAgregado;

        public FrmAltaContacto()
        {
            InitializeComponent();
        }
        public Contacto Nuevo { get; set; }

        private void FrmAltaContacto_Load(object sender, EventArgs e)
        {
            cmbTipoTeléfono.DataSource =
                Enum.GetNames(typeof(TiposDeTeléfono));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nuevo = new Contacto()
            {
                Nombre =txtNombre.Text,
                Dirección=txtDirección.Text,
                Teléfono=txtTeléfono.Text,
                TipoDeTeléfono= 
                (TiposDeTeléfono) cmbTipoTeléfono.SelectedIndex
            };
            ContactoAgregado?.Invoke(Nuevo);
            txtDirección.Clear();
            txtNombre.Clear();
            txtTeléfono.Clear();
            cmbTipoTeléfono.SelectedIndex = 0;
            txtNombre.Focus();
        }
    }
}
