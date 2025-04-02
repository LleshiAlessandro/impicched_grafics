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
            tentativi = 15;
            string[] lines = File.ReadAllLines(filePath); // Legge tutte le righe e le mette in un vettore
            int f = rdn.Next(lines.Length);
            string parolaScelta = lines[f];
            string trattino = new string('_', parolaScelta.Length);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
