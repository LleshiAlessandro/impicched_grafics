namespace impicched_graficas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rdn = new Random();
        void lettura(string filePath, int tentativi)
        {
            string[] lines = File.ReadAllLines(filePath); // Legge tutte le righe e le mette in un vettore
            int f = rdn.Next(lines.Length);
            string parolaScelta = lines[f];
            string trattino = new string('_', parolaScelta.Length);
            parola_nascosta.Text = " ";
            for (int i = 0; i < parolaScelta.Length; i++)
            {
                parola_nascosta.Text += trattino[i];
            }
        }
        int tentativi = 0;
        string filePath = "";
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
            lettura("cibi.txt", 8);
        }

        private void animali_Click(object sender, EventArgs e)
        {
            lettura("animali.txt", 8);
        }

        private void lavori_Click(object sender, EventArgs e)
        {
            lettura("lavori.txt", 8);
        }

        private void facile_Click_1(object sender, EventArgs e)
        {
            lettura("parole_semplici.txt", 15);
        }

        private void medio_Click_1(object sender, EventArgs e)
        {
            lettura("parole_medie.txt", 10);
        }

        private void difficile_Click_1(object sender, EventArgs e)
        {
            lettura("parole_difficili.txt", 5);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.Text = parola.Text;
        }
    }
}
