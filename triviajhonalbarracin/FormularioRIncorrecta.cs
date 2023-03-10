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
    public partial class FormularioRIncorrecta : Form
    {
        public FormularioRIncorrecta()
        {
            InitializeComponent();
            reproducirSonido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string rutaAudio = "D:/sonidos/incorrecta.wav";
        private void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();
        }
    }
}
