namespace DBAutonomus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            bool r;
            Datos obj= new Datos();
            if (obj.abrirConexion() == true)
            {
                MessageBox.Show("Exito");
            }
            else
                MessageBox.Show("Error");
        }
    }
}
