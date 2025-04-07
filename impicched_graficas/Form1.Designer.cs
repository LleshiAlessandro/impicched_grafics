namespace impicched_graficas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            parola = new TextBox();
            lettera = new TextBox();
            parola_label = new Label();
            lettera_label = new Label();
            argomento_label = new Label();
            punteggio_label = new Label();
            punteggio = new TextBox();
            animali = new Button();
            cibi = new Button();
            lavori = new Button();
            facile = new Button();
            medio = new Button();
            difficile = new Button();
            difficolta_label = new Label();
            label6 = new Label();
            parola_nascosta = new Label();
            lista = new ListBox();
            vite = new Label();
            invio = new Button();
            SuspendLayout();
            // 
            // parola
            // 
            parola.Location = new Point(346, 199);
            parola.Name = "parola";
            parola.Size = new Size(116, 23);
            parola.TabIndex = 0;
            parola.TextChanged += textBox1_TextChanged;
            // 
            // lettera
            // 
            lettera.Location = new Point(233, 199);
            lettera.Name = "lettera";
            lettera.Size = new Size(33, 23);
            lettera.TabIndex = 1;
            lettera.TextChanged += textBox2_TextChanged;
            // 
            // parola_label
            // 
            parola_label.AutoSize = true;
            parola_label.BackColor = Color.LightSkyBlue;
            parola_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parola_label.Location = new Point(337, 171);
            parola_label.MinimumSize = new Size(60, 10);
            parola_label.Name = "parola_label";
            parola_label.Size = new Size(143, 21);
            parola_label.TabIndex = 2;
            parola_label.Text = "inserisci la parola";
            parola_label.Click += label1_Click;
            // 
            // lettera_label
            // 
            lettera_label.AutoSize = true;
            lettera_label.BackColor = Color.LightSkyBlue;
            lettera_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lettera_label.Location = new Point(173, 171);
            lettera_label.MinimumSize = new Size(45, 10);
            lettera_label.Name = "lettera_label";
            lettera_label.Size = new Size(144, 21);
            lettera_label.TabIndex = 3;
            lettera_label.Text = "inserisci la lettera";
            lettera_label.Click += lettera_label_Click;
            // 
            // argomento_label
            // 
            argomento_label.AutoSize = true;
            argomento_label.BackColor = Color.LightSkyBlue;
            argomento_label.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            argomento_label.Location = new Point(218, 252);
            argomento_label.Name = "argomento_label";
            argomento_label.Size = new Size(414, 27);
            argomento_label.TabIndex = 4;
            argomento_label.Text = "scegli l'argomentio delle parole";
            // 
            // punteggio_label
            // 
            punteggio_label.AutoSize = true;
            punteggio_label.BackColor = Color.LightSkyBlue;
            punteggio_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            punteggio_label.Location = new Point(515, 171);
            punteggio_label.Name = "punteggio_label";
            punteggio_label.Size = new Size(90, 21);
            punteggio_label.TabIndex = 5;
            punteggio_label.Text = "punteggio";
            // 
            // punteggio
            // 
            punteggio.Location = new Point(544, 199);
            punteggio.Name = "punteggio";
            punteggio.Size = new Size(33, 23);
            punteggio.TabIndex = 6;
            // 
            // animali
            // 
            animali.BackColor = Color.LightSkyBlue;
            animali.Location = new Point(291, 282);
            animali.MinimumSize = new Size(60, 60);
            animali.Name = "animali";
            animali.Size = new Size(75, 60);
            animali.TabIndex = 8;
            animali.Text = "animali";
            animali.UseVisualStyleBackColor = false;
            animali.Click += animali_Click;
            // 
            // cibi
            // 
            cibi.BackColor = Color.LightSkyBlue;
            cibi.Location = new Point(387, 282);
            cibi.MinimumSize = new Size(60, 60);
            cibi.Name = "cibi";
            cibi.Size = new Size(75, 60);
            cibi.TabIndex = 9;
            cibi.Text = "cibi";
            cibi.UseVisualStyleBackColor = false;
            cibi.Click += cibi_Click;
            // 
            // lavori
            // 
            lavori.BackColor = Color.LightSkyBlue;
            lavori.Location = new Point(493, 282);
            lavori.MinimumSize = new Size(60, 60);
            lavori.Name = "lavori";
            lavori.Size = new Size(75, 60);
            lavori.TabIndex = 10;
            lavori.Text = "lavori";
            lavori.UseVisualStyleBackColor = false;
            lavori.Click += lavori_Click;
            // 
            // facile
            // 
            facile.BackColor = Color.LightSkyBlue;
            facile.Location = new Point(291, 382);
            facile.MinimumSize = new Size(60, 60);
            facile.Name = "facile";
            facile.Size = new Size(75, 60);
            facile.TabIndex = 11;
            facile.Text = "facile";
            facile.UseVisualStyleBackColor = false;
            facile.Click += facile_Click_1;
            // 
            // medio
            // 
            medio.BackColor = Color.LightSkyBlue;
            medio.Location = new Point(387, 382);
            medio.MinimumSize = new Size(60, 60);
            medio.Name = "medio";
            medio.Size = new Size(75, 60);
            medio.TabIndex = 12;
            medio.Text = "medio";
            medio.UseVisualStyleBackColor = false;
            medio.Click += medio_Click_1;
            // 
            // difficile
            // 
            difficile.BackColor = Color.LightSkyBlue;
            difficile.Location = new Point(493, 382);
            difficile.MinimumSize = new Size(60, 60);
            difficile.Name = "difficile";
            difficile.Size = new Size(75, 60);
            difficile.TabIndex = 13;
            difficile.Text = "difficile";
            difficile.UseVisualStyleBackColor = false;
            difficile.Click += difficile_Click_1;
            // 
            // difficolta_label
            // 
            difficolta_label.AutoSize = true;
            difficolta_label.BackColor = Color.LightSkyBlue;
            difficolta_label.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            difficolta_label.Location = new Point(145, 359);
            difficolta_label.Name = "difficolta_label";
            difficolta_label.Size = new Size(595, 20);
            difficolta_label.TabIndex = 14;
            difficolta_label.Text = "scegli la difficoltà per la miodalità con parole randomiche";
            difficolta_label.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSkyBlue;
            label6.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 9);
            label6.Name = "label6";
            label6.Size = new Size(653, 60);
            label6.TabIndex = 15;
            label6.Text = "IL GIOCO DELL' IMPICCATO";
            // 
            // parola_nascosta
            // 
            parola_nascosta.AutoSize = true;
            parola_nascosta.BackColor = Color.LightSkyBlue;
            parola_nascosta.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            parola_nascosta.Location = new Point(231, 100);
            parola_nascosta.MinimumSize = new Size(104, 0);
            parola_nascosta.Name = "parola_nascosta";
            parola_nascosta.Size = new Size(346, 33);
            parola_nascosta.TabIndex = 16;
            parola_nascosta.Text = "la parola nascosta è :";
            parola_nascosta.TextAlign = ContentAlignment.MiddleCenter;
            parola_nascosta.Click += label7_Click;
            // 
            // lista
            // 
            lista.BackColor = Color.LightSkyBlue;
            lista.ForeColor = SystemColors.WindowText;
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 100);
            lista.Name = "lista";
            lista.Size = new Size(120, 94);
            lista.TabIndex = 17;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // vite
            // 
            vite.AutoSize = true;
            vite.BackColor = Color.LightSkyBlue;
            vite.Location = new Point(654, 100);
            vite.MinimumSize = new Size(50, 60);
            vite.Name = "vite";
            vite.Size = new Size(86, 60);
            vite.TabIndex = 18;
            vite.Text = "essenza di defe";
            vite.Click += vite_Click;
            // 
            // invio
            // 
            invio.BackColor = Color.LightSkyBlue;
            invio.Location = new Point(218, 226);
            invio.Name = "invio";
            invio.Size = new Size(79, 23);
            invio.TabIndex = 19;
            invio.Text = "invio";
            invio.UseVisualStyleBackColor = false;
            invio.Click += invio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(invio);
            Controls.Add(vite);
            Controls.Add(lista);
            Controls.Add(parola_nascosta);
            Controls.Add(label6);
            Controls.Add(difficolta_label);
            Controls.Add(difficile);
            Controls.Add(medio);
            Controls.Add(facile);
            Controls.Add(lavori);
            Controls.Add(cibi);
            Controls.Add(animali);
            Controls.Add(punteggio);
            Controls.Add(punteggio_label);
            Controls.Add(argomento_label);
            Controls.Add(lettera_label);
            Controls.Add(parola_label);
            Controls.Add(lettera);
            Controls.Add(parola);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox parola;
        private TextBox lettera;
        private Label parola_label;
        private Label lettera_label;
        private Label argomento_label;
        private Label punteggio_label;
        private TextBox punteggio;
        private Button animali;
        private Button cibi;
        private Button lavori;
        private Button facile;
        private Button medio;
        private Button difficile;
        private Label difficolta_label;
        private Label label6;
        private Label parola_nascosta;
        private ListBox lista;
        private Label vite;
        private Button invio;
    }
}
