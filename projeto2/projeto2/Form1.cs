using System.Text.Json;
using System.Threading.Tasks;

namespace projeto2
{
    public partial class Form1 : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.id = int.Parse(txtCodigo.Text);
            aluno.nome = txtNome.Text;

            listaAlunos.Add(aluno);

            dgvAluno.DataSource = null;
            dgvAluno.DataSource = listaAlunos;

            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtRM.Text = string.Empty;

            MessageBox.Show("Aluno cadastrado com sucesso", "FIAP");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string url = $"https://viacep.com.br/ws/{txtcep.Text}/json";

            HttpClient cliente = new HttpClient();

            var json = await cliente.GetStringAsync(url);

            AlunoEndereco alunoEnd = new AlunoEndereco();

            alunoEnd = JsonSerializer.Deserialize<AlunoEndereco>(json);

            txtBairro.Text = alunoEnd.BairroAluno;
            txtRua.Text = alunoEnd.RuaAluno;
        
        }
    }
}
