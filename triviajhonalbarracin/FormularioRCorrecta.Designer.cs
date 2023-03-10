namespace triviajhonalbarracin
{
    partial class FormularioRCorrecta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRCorrecta));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            panel2 = new Panel();
            botonCerrar = new Button();
            textoPrincipal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 380);
            panel2.TabIndex = 1;
            // 
            // botonCerrar
            // 
            botonCerrar.BackColor = Color.Cyan;
            botonCerrar.FlatAppearance.BorderSize = 0;
            botonCerrar.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point);
            botonCerrar.Location = new Point(724, 12);
            botonCerrar.Name = "botonCerrar";
            botonCerrar.Size = new Size(64, 41);
            botonCerrar.TabIndex = 2;
            botonCerrar.Text = "X";
            botonCerrar.UseVisualStyleBackColor = false;
            botonCerrar.Click += botonCerrar_Click;
            // 
            // textoPrincipal
            // 
            textoPrincipal.AutoSize = true;
            textoPrincipal.Font = new Font("SimSun-ExtB", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            textoPrincipal.Location = new Point(282, 52);
            textoPrincipal.Name = "textoPrincipal";
            textoPrincipal.Size = new Size(256, 47);
            textoPrincipal.TabIndex = 3;
            textoPrincipal.Text = "¡CORRECTO!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormularioRCorrecta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textoPrincipal);
            Controls.Add(botonCerrar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRCorrecta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRCorrecta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel2;
        private Panel panel1;
        private Button botonCerrar;
        private Label textoPrincipal;
        private PictureBox pictureBox1;
    }
}