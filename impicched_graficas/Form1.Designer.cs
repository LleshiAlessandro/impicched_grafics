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
            button1 = new Button();
            invio = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // parola
            // 
            parola.Location = new Point(346, 216);
            parola.Name = "parola";
            parola.Size = new Size(116, 23);
            parola.TabIndex = 0;
            parola.TextChanged += textBox1_TextChanged;
            // 
            // lettera
            // 
            lettera.Location = new Point(233, 216);
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
            parola_label.Location = new Point(346, 188);
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
            lettera_label.Location = new Point(173, 188);
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
            argomento_label.Location = new Point(218, 271);
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
            punteggio_label.Location = new Point(515, 188);
            punteggio_label.Name = "punteggio_label";
            punteggio_label.Size = new Size(90, 21);
            punteggio_label.TabIndex = 5;
            punteggio_label.Text = "punteggio";
            punteggio_label.Click += punteggio_label_Click;
            // 
            // animali
            // 
            animali.BackColor = Color.LightSkyBlue;
            animali.Location = new Point(291, 301);
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
            cibi.Location = new Point(387, 301);
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
            lavori.Location = new Point(493, 301);
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
            facile.Location = new Point(291, 421);
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
            medio.Location = new Point(387, 421);
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
            difficile.Location = new Point(493, 421);
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
            difficolta_label.Location = new Point(145, 378);
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
            label6.Location = new Point(87, -1);
            label6.Name = "label6";
            label6.Size = new Size(653, 60);
            label6.TabIndex = 15;
            label6.Text = "IL GIOCO DELL' IMPICCATO";
            label6.Click += label6_Click;
            // 
            // parola_nascosta
            // 
            parola_nascosta.AutoSize = true;
            parola_nascosta.BackColor = Color.LightSkyBlue;
            parola_nascosta.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            parola_nascosta.Location = new Point(233, 115);
            parola_nascosta.MinimumSize = new Size(350, 35);
            parola_nascosta.Name = "parola_nascosta";
            parola_nascosta.Size = new Size(350, 35);
            parola_nascosta.TabIndex = 16;
            parola_nascosta.Text = " ";
            parola_nascosta.TextAlign = ContentAlignment.MiddleCenter;
            parola_nascosta.Click += label7_Click;
            // 
            // lista
            // 
            lista.BackColor = Color.LightSkyBlue;
            lista.ForeColor = SystemColors.WindowText;
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 68);
            lista.Name = "lista";
            lista.Size = new Size(120, 94);
            lista.TabIndex = 17;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // vite
            // 
            vite.AutoSize = true;
            vite.BackColor = Color.LightSkyBlue;
            vite.Location = new Point(661, 68);
            vite.MinimumSize = new Size(50, 20);
            vite.Name = "vite";
            vite.Size = new Size(86, 20);
            vite.TabIndex = 18;
            vite.Text = "essenza di defe";
            vite.Click += vite_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(362, 245);
            button1.Name = "button1";
            button1.Size = new Size(79, 23);
            button1.TabIndex = 20;
            button1.Text = "invio parola";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // invio
            // 
            invio.BackColor = Color.LightSkyBlue;
            invio.Location = new Point(218, 245);
            invio.Name = "invio";
            invio.Size = new Size(79, 23);
            invio.TabIndex = 19;
            invio.Text = "invio lettera";
            invio.UseVisualStyleBackColor = false;
            invio.Click += invio_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(53, 294);
            button3.Name = "button3";
            button3.Size = new Size(79, 23);
            button3.TabIndex = 22;
            button3.Text = "jolly";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(661, 294);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 23;
            button4.Text = "nuova P";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.Location = new Point(661, 338);
            button5.Name = "button5";
            button5.Size = new Size(79, 23);
            button5.TabIndex = 24;
            button5.Text = "chiudi";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 68);
            label1.MinimumSize = new Size(350, 35);
            label1.Name = "label1";
            label1.Size = new Size(350, 35);
            label1.TabIndex = 25;
            label1.Text = "la parola nascosta è :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 323);
            label2.MinimumSize = new Size(90, 50);
            label2.Name = "label2";
            label2.Size = new Size(136, 50);
            label2.TabIndex = 26;
            label2.Text = "lettera jolly:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(515, 214);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 27;
            label3.Text = "che ca**o di selvaggio";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSkyBlue;
            label4.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(611, 115);
            label4.MinimumSize = new Size(35, 35);
            label4.Name = "label4";
            label4.Size = new Size(35, 35);
            label4.TabIndex = 28;
            label4.Text = " ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1024, 617);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
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
            Controls.Add(punteggio_label);
            Controls.Add(argomento_label);
            Controls.Add(lettera_label);
            Controls.Add(parola_label);
            Controls.Add(lettera);
            Controls.Add(parola);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(40, 30);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button button1;
        private Button invio;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
