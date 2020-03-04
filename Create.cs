string connectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
bool novo;
 
public frmCadastroCliente()
{
    InitializeComponent();
}
 
private void tsbNovo_Click(object sender, EventArgs e)
{
    tsbNovo.Enabled = false;
    tsbSalvar.Enabled = true;
    tsbCancelar.Enabled = true;
    tsbExcluir.Enabled = false;
    tstId.Enabled = false;
    tsbBuscar.Enabled = false;
    txtNome.Enabled = true;
    txtEndereco.Enabled = true;
    mskCep.Enabled = true;
    txtBairro.Enabled = true;
    txtCidade.Enabled = true;
    txtUf.Enabled = true;
    mskTelefone.Enabled = true;
    txtNome.Focus();
    novo = true;
 
} 

private void frmCadastroCliente_Load(object sender, EventArgs e)
{
    tsbNovo.Enabled = true;
    tsbSalvar.Enabled = false;
    tsbCancelar.Enabled = false;
    tsbExcluir.Enabled = false;
    tstId.Enabled = true;
    tsbBuscar.Enabled = true;
    txtNome.Enabled = false;
    txtEndereco.Enabled = false;
    mskCep.Enabled = false;
    txtBairro.Enabled = false;
    txtCidade.Enabled = false;
    txtUf.Enabled = false;
    mskTelefone.Enabled = false;
} 
