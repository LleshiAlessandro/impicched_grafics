namespace impicched_graficas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rdn = new Random();
        string parolaScelta = "";
        string trattino = "";
        int tentativi = 0, jolly2 = 0;
        string filePath = "";
        char f = ' ';
        string jolly = " ";
        int jollyUsato = 1;
        void lettura(string filePath, int tentativi)
        {
            string[] lines = File.ReadAllLines(filePath); // Legge tutte le righe e le mette in un vettore
            int f = rdn.Next(lines.Length);
            parolaScelta = lines[f];
            trattino = new string('_', parolaScelta.Length);
            parola_nascosta.Text = " ";
            for (int i = 0; i < parolaScelta.Length; i++)
            {
                parola_nascosta.Text += trattino[i];
            }
        }
        void parola_ind()//controlla se la parola che ho inserito nella text box è uguale alla parola nascosta
        {
            if (parola.Text == parolaScelta)
            {
                trattino = parola.Text;
            }
            else
            {
                tentativi--;
                if (tentativi <= 0)
                {
                    MessageBox.Show("hai esaurito le vite hai perso");
                }
            }
            vite.Text = tentativi.ToString();
            parola_nascosta.Text = trattino;
        }
        void lettera_ind()//controlla se la lettera che ho inserito nella text box è contenuta nella parola nascosta
        {
            char[] a = trattino.ToCharArray();
            if (parolaScelta.Contains(f))
            {
                for (int i = 0; i < trattino.Length; i++)
                {

                    if (f == parolaScelta[i])
                    {
                        a[i] = parolaScelta[i];
                    }

                }
            }
            else
            {
                tentativi--;
                if (tentativi <= 0)
                {
                    MessageBox.Show("hai esaurito le vite hai perso");
                }
            }
            vite.Text = tentativi.ToString();
            trattino = new string(a);
            parola_nascosta.Text = trattino;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //
        }

        private void lettera_label_Click(object sender, EventArgs e)
        {

        }

        private void cibi_Click(object sender, EventArgs e)
        {
            tentativi = 8;
            lettura("cibi.txt", 8);
            vite.Text = "i tentativi sono :" + tentativi.ToString();
        }

        private void animali_Click(object sender, EventArgs e)
        {
            tentativi = 8;
            lettura("animali.txt", 8);
            vite.Text = "i tentativi sono :" + tentativi.ToString();
        }

        private void lavori_Click(object sender, EventArgs e)
        {
            tentativi = 8;
            lettura("lavori.txt", 8);
            vite.Text = "i tentativi sono :" + tentativi.ToString();
        }

        private void facile_Click_1(object sender, EventArgs e)
        {
            tentativi = 15;
            lettura("parole_semplici.txt", 15);
            vite.Text = "i tentativi sono :" + tentativi.ToString();
        }

        private void medio_Click_1(object sender, EventArgs e)
        {
            tentativi = 10;
            lettura("parole_medie.txt", 10);
            vite.Text = "i tentativi sono :" + tentativi.ToString();
        }

        private void difficile_Click_1(object sender, EventArgs e)
        {
            tentativi = 5;
            lettura("parole_difficili.txt", 5);
            vite.Text = "i tentativi sono :" + tentativi.ToString();

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void vite_Click(object sender, EventArgs e)
        {

        }
        private void invio_Click(object sender, EventArgs e)
        {
            f = lettera.Text[0];
            lettera_ind();
            lista.Items.Add(lettera.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = parola.Text[0];
            parola_ind();
            lista.Items.Add(parola.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jollyUsato == 1)
            {
                jollyUsato--;
                Random rnd = new Random();
                jolly2 = rnd.Next(0, parolaScelta.Length);
                jolly += parolaScelta[jolly2];
                label2.Text = jolly;
            }
            else if (jollyUsato == 0)
            {
                label2.Text = "Hai già usato il jolly";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}