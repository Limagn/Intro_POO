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
            LimparCaixas();
        }

        private void LimparCaixas()
        {
            txtNome.Clear();
            txtCpf.Clear();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex >= 0)
            {
                string[] itens = lstClientes.GetItemText(lstClientes.SelectedItem).Split(" - ");
                txtNome.Text = itens[0];
                txtCpf.Text = itens[1];
                btnExcluir.Enabled = true;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {

                lstClientes.Items.Remove(lstClientes.SelectedItem);

                txtCpf.Clear();
                txtNome.Clear();

                MessageBox.Show("Item Excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExcluir.Enabled = false;

            }
        }
    }
}
