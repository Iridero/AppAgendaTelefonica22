namespace AppAgendaTelefonica22
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }
        AgendaTelefónica agenda;
        private void Form1_Load(object sender, EventArgs e)
        {
            agenda=new AgendaTelefónica();

            // Prueba
            agenda.Agregar("CArlos", "Alla", "12345", TiposDeTeléfono.Celular);
            LlenarDataGridView();
        }
        private void LlenarDataGridView()
        {
            dtgAgenda.DataSource = agenda.Contactos;
        }
    }
}