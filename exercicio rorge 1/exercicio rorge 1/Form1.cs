namespace exercicio_rorge_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.idade = Convert.ToInt32(textBox1.Text);
            p.nome = textBox2.Text;

            MessageBox.Show("oi " + p.nome + "sua idade é " + p.idade);
        }
    }
}
