namespace triviajhonalbarracin
{
    partial class FormularioRIncorrecta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRIncorrecta));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            panel2 = new Panel();
            botonCerrarIncorrecto = new Button();
            label1 = new Label();
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
            panel1.Location = new Point(0, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(85, 364);
            panel2.TabIndex = 1;
            // 
            // botonCerrarIncorrecto
            // 
            botonCerrarIncorrecto.BackColor = Color.Cyan;
            botonCerrarIncorrecto.FlatAppearance.BorderSize = 0;
            botonCerrarIncorrecto.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point);
            botonCerrarIncorrecto.Location = new Point(694, 12);
            botonCerrarIncorrecto.Name = "botonCerrarIncorrecto";
            botonCerrarIncorrecto.Size = new Size(94, 44);
            botonCerrarIncorrecto.TabIndex = 2;
            botonCerrarIncorrecto.Text = "X";
            botonCerrarIncorrecto.UseVisualStyleBackColor = false;
            botonCerrarIncorrecto.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(265, 49);
            label1.Name = "label1";
            label1.Size = new Size(282, 44);
            label1.TabIndex = 3;
            label1.Text = "¡INCORRECTO!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormularioRIncorrecta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(botonCerrarIncorrecto);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioRIncorrecta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRIncorrecta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel2;
        private Panel panel1;
        private Button botonCerrarIncorrecto;
        private Label label1;
        private PictureBox pictureBox1;
    }
}