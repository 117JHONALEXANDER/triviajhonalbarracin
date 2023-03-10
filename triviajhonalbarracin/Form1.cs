namespace triviajhonalbarracin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonbotoniniciar_Click(object sender, EventArgs e)
        {
            FormularioPreguntas fr = new FormularioPreguntas(); 
            fr.Show();  
            this.Hide();  
        }

        private void textoCerrarFormulario_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}