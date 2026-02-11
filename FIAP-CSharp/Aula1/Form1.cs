namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Fiap")
            {
                Menu menu = new();
                this.Hide();
                menu.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
