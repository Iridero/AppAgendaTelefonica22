namespace AppAgendaTelefonica22
{
    public delegate void AlModificarAgenda(Contacto contacto);
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }
        AgendaTelef�nica agenda;
        private void Form1_Load(object sender, EventArgs e)
        {
            agenda=new AgendaTelef�nica();

            // Prueba
            agenda.Agregar("CArlos", "Alla", "12345", TiposDeTel�fono.Celular);
            LlenarDataGridView();
        }
        private void LlenarDataGridView()
        {
            dtgAgenda.AutoGenerateColumns = false;
            dtgAgenda.DataSource = null;
            dtgAgenda.DataSource = agenda.Contactos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaContacto f = new FrmAltaContacto();
            f.ContactoAgregado += F_ContactoAgregado;
            f.Show();
        }

        private void F_ContactoAgregado(Contacto nuevo)
        {
            agenda.Agregar(nuevo.Nombre, nuevo.Direcci�n,nuevo.Tel�fono
                ,nuevo.TipoDeTel�fono);
            LlenarDataGridView();
        }
    }
}