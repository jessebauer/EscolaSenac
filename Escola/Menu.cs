namespace Escola
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            CadFuncionario cadFuncionario = new CadFuncionario();
            this.Hide();
            cadFuncionario.Show();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            CadAluno cadAluno = new CadAluno();
            this.Hide();
            cadAluno.Show();
        }
    }
}