namespace CalculadoraDeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string mensagemResultado = "";
            double resultado = 0;
            
            try
            {
                double peso = double.Parse(textBoxPeso.Text);
                double altura = double.Parse(textBoxAltura.Text);
                resultado = peso / (altura * altura);
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
            labelResultado.Visible = true;
            labelMensagem.Visible = true;
            labelResultado.Text = "IMC: " + resultado.ToString("N1") + " Kg/m².";
            if(resultado < 18.5)
            {
                mensagemResultado = "Você está magro !";
            }
            else if(resultado >= 18.5 && resultado < 24.9)
            {
                mensagemResultado = "Você está com peso normal !";
            }
            else if(resultado > 24.9 && resultado <= 29.9)
            {
                mensagemResultado = "Você esta com sobre peso !";
            }
            else if (resultado > 29.9 && resultado <= 34.9)
            {
                mensagemResultado = "Você esta com obesidade grau 1 !";
            }
            else if (resultado > 34.9 && resultado <= 39.9)
            {
                mensagemResultado = "Você esta com obesidade grau 2 !";
            }
            else if (resultado > 39.9)
            {
                mensagemResultado = "Você esta com obesidade grau 3 !";
            }
           
            labelMensagem.Text = mensagemResultado;
            
            
        }

        
    }
}
