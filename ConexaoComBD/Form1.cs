namespace ConexaoComBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cadastro = new Cadastrar(textNome.Text, textTelefone.Text );
            MessageBox.Show(cadastro.mensagem);
           
            
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}