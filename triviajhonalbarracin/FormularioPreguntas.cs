using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triviajhonalbarracin
{
    public partial class FormularioPreguntas : Form
    {
        public FormularioPreguntas()
        {
            InitializeComponent();
            panelPregunta2.Hide();
            panelResultados.Hide();
        }

        int puntos = 0;

        #region Manejo Cantidad de Puntos 
        void respuestaIncorrecta()
        {
            FormularioRIncorrecta formularioIncorrecto = new FormularioRIncorrecta();
            formularioIncorrecto.ShowDialog();
            restarPuntos();
        }

        void respuestaCorrecta()
        {
            FormularioRCorrecta correcta = new FormularioRCorrecta();
            correcta.ShowDialog();
            sumarPuntos();
        }

        void sumarPuntos()
        {
            puntos = puntos + 500;
            labelCantidadPuntos.Text = puntos.ToString();
        }

        void restarPuntos()
        {
            if (puntos >=200) 
            {
                puntos = puntos - 100;  
            } 
        }

        #endregion 

        private void botonCerrarPreguntas_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region Panel de la pregunta 2
        private void btnJirafa_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnBallena_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelResultados.Show();

            labelCantidadPuntos.Hide();
            labelParaPuntaje.Hide();
            labelPuntosFinales.Text = puntos.ToString();
        }

        private void btnElefante_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        #endregion

        #region Panel de la pregunta 1 
        private void btn6estaciones_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btn4estaciones_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelPregunta2.Show();
        }

        private void btn5estaciones_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }
    }
}
