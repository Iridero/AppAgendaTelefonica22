namespace AppAgendaTelefonica22
{
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
            dtgAgenda.DataSource = agenda.Contactos;
        }
    }
}