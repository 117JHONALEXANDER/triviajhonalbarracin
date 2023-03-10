using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triviajhonalbarracin
{
    public partial class FormularioRCorrecta : Form
    {
        public FormularioRCorrecta()
        {
            InitializeComponent();
            reproducirSonido(); 
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string rutaAudio = "D:/sonidos/correcta.wav"; 
        private void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play(); 
        }
    }
}
