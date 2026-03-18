using System.Text.Json;

namespace CadastroProdutos
{
    public partial class FormPrincipal : Form
    {
        private readonly string caminhoArquivo = "produtos.json";
        private List<Produto> produtos = new List<Produto>();

        public FormPrincipal()
        {
            InitializeComponent();  
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            if (txtNome.Text == string.Empty)
            {
                lblStatus.Text = "O nome não pode ser nulo";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            decimal precoConvertido = decimal.Parse(txtPreco.Text);

            if (precoConvertido < 0)
            {
                lblStatus.Text = "O preço não pode ser negativo";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            List<Produto> produtos = CarregarDados();

            Produto produto = new Produto();

            produto.Nome = txtNome.Text;

            produto.Nome = txtNome.Text;
            produto.Preco = precoConvertido;
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.Nome = txtNome.Text;
            produto.CepFornecedor = txtCep.Text;
            produto.Logradouro = txtLogradouro.Text;
            produto.Bairro = txtBairro.Text;
            produto.Cidade = txtCidade.Text;
            produto.Estado = txtEstado.Text;

            produtos.Add(produto);

            SalvarDados(produtos);

            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty; ;
            txtQuantidade.Text = string.Empty; ;
            txtNome.Text = string.Empty; ;
            txtCep.Text = string.Empty; ;
            txtLogradouro.Text = string.Empty; ;
            txtBairro.Text = string.Empty; ;
            txtCidade.Text = string.Empty; ;
            txtEstado.Text = string.Empty; ;

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = CarregarDados();
        }

        public void SalvarDados(List<Produto> lista)
        {
            string json = JsonSerializer.Serialize(lista);

            File.WriteAllText(caminhoArquivo, json);
        }

        public List<Produto> CarregarDados()
        {
            if (!File.Exists(caminhoArquivo))
            {
                return new List<Produto>();
            }

            string json = File.ReadAllText(caminhoArquivo);

            return JsonSerializer.Deserialize<List<Produto>>(json);
        }

    }
}
