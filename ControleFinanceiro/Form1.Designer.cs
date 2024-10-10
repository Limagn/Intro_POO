namespace ControleFinanceiro
{
    partial class frmCliente
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblCpf = new Label();
            btnInserir = new Button();
            btnExcluir = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(79, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(159, 76);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(159, 136);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(114, 27);
            txtCpf.TabIndex = 3;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(79, 140);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // btnInserir
            // 
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(79, 203);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(86, 31);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(187, 203);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(79, 268);
            lstClientes.Margin = new Padding(3, 4, 3, 4);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(194, 124);
            lstClientes.TabIndex = 6;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 443);
            Controls.Add(lstClientes);
            Controls.Add(btnExcluir);
            Controls.Add(btnInserir);
            Controls.Add(txtCpf);
            Controls.Add(lblCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCliente";
            Text = "Controle de Clientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblCpf;
        private Button btnInserir;
        private Button btnExcluir;
        private ListBox lstClientes;
    }
}
