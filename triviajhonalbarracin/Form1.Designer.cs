namespace triviajhonalbarracin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textoTituloPrincipal = new Label();
            textoCerrarFormulario = new Label();
            SubtituloBienvenida = new Label();
            pictureBox1 = new PictureBox();
            panelinferiorBienv = new Panel();
            labelautor = new Label();
            panelinferior2Bienv = new Panel();
            buttonbotoniniciar = new Button();
            moverformulario = new Bunifu.Framework.UI.BunifuDragControl(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelinferiorBienv.SuspendLayout();
            SuspendLayout();
            // 
            // textoTituloPrincipal
            // 
            textoTituloPrincipal.AutoSize = true;
            textoTituloPrincipal.Font = new Font("SimSun-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textoTituloPrincipal.ForeColor = Color.LimeGreen;
            textoTituloPrincipal.Location = new Point(124, 36);
            textoTituloPrincipal.Name = "textoTituloPrincipal";
            textoTituloPrincipal.Size = new Size(577, 37);
            textoTituloPrincipal.TabIndex = 0;
            textoTituloPrincipal.Text = "TRIVIA DE CIENCIAS NATURALES";
            // 
            // textoCerrarFormulario
            // 
            textoCerrarFormulario.AutoSize = true;
            textoCerrarFormulario.Font = new Font("Ink Free", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point);
            textoCerrarFormulario.Location = new Point(853, 9);
            textoCerrarFormulario.Name = "textoCerrarFormulario";
            textoCerrarFormulario.Size = new Size(32, 41);
            textoCerrarFormulario.TabIndex = 1;
            textoCerrarFormulario.Text = "X";
            textoCerrarFormulario.Click += textoCerrarFormulario_Click;
            // 
            // SubtituloBienvenida
            // 
            SubtituloBienvenida.AutoSize = true;
            SubtituloBienvenida.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SubtituloBienvenida.Location = new Point(94, 126);
            SubtituloBienvenida.Name = "SubtituloBienvenida";
            SubtituloBienvenida.Size = new Size(669, 30);
            SubtituloBienvenida.TabIndex = 2;
            SubtituloBienvenida.Text = "¿Qué tanto conoces de Ciencias Naturales?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelinferiorBienv
            // 
            panelinferiorBienv.BackColor = Color.FromArgb(128, 255, 128);
            panelinferiorBienv.BorderStyle = BorderStyle.FixedSingle;
            panelinferiorBienv.Controls.Add(labelautor);
            panelinferiorBienv.Dock = DockStyle.Bottom;
            panelinferiorBienv.Location = new Point(0, 458);
            panelinferiorBienv.Name = "panelinferiorBienv";
            panelinferiorBienv.Size = new Size(897, 50);
            panelinferiorBienv.TabIndex = 4;
            // 
            // labelautor
            // 
            labelautor.AutoSize = true;
            labelautor.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            labelautor.Location = new Point(27, 17);
            labelautor.Name = "labelautor";
            labelautor.Size = new Size(268, 20);
            labelautor.TabIndex = 0;
            labelautor.Text = "Powered by Jhon Alexander Albarracín M.";
            // 
            // panelinferior2Bienv
            // 
            panelinferior2Bienv.BackColor = Color.FromArgb(128, 255, 128);
            panelinferior2Bienv.BorderStyle = BorderStyle.FixedSingle;
            panelinferior2Bienv.Location = new Point(0, 12);
            panelinferior2Bienv.Name = "panelinferior2Bienv";
            panelinferior2Bienv.Size = new Size(76, 427);
            panelinferior2Bienv.TabIndex = 5;
            // 
            // buttonbotoniniciar
            // 
            buttonbotoniniciar.BackColor = Color.DarkGray;
            buttonbotoniniciar.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonbotoniniciar.Location = new Point(659, 274);
            buttonbotoniniciar.Name = "buttonbotoniniciar";
            buttonbotoniniciar.Size = new Size(178, 49);
            buttonbotoniniciar.TabIndex = 6;
            buttonbotoniniciar.Text = "INICIAR TRIVIA";
            buttonbotoniniciar.UseVisualStyleBackColor = false;
            buttonbotoniniciar.Click += buttonbotoniniciar_Click;
            // 
            // moverformulario
            // 
            moverformulario.Fixed = true;
            moverformulario.Horizontal = true;
            moverformulario.TargetControl = this;
            moverformulario.Vertical = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(897, 508);
            Controls.Add(buttonbotoniniciar);
            Controls.Add(panelinferior2Bienv);
            Controls.Add(panelinferiorBienv);
            Controls.Add(pictureBox1);
            Controls.Add(SubtituloBienvenida);
            Controls.Add(textoCerrarFormulario);
            Controls.Add(textoTituloPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelinferiorBienv.ResumeLayout(false);
            panelinferiorBienv.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoTituloPrincipal;
        private Label textoCerrarFormulario;
        private Label SubtituloBienvenida;
        private PictureBox pictureBox1;
        private Panel panelinferiorBienv;
        private Label labelautor;
        private Panel panelinferior2Bienv;
        private Button buttonbotoniniciar;
        private Bunifu.Framework.UI.BunifuDragControl moverformulario;
    }
}