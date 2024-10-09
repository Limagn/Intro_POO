using ControleFinanceiro.Model;

namespace ControleFinanceiro
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void VerificarCaixasPreenchidas()
        {
            if (txtNome.Text != "" && txtCpf.Text != "")
                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            lstClientes.Items.Add(cliente.ToString());

            txtNome.Clear();
            txtCpf.Clear();
        }
    }
}
