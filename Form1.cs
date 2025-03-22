namespace CalculadoraComForms
{
    public partial class Form1 : Form
    {
        private bool somar = false;
        private bool dividir = false;
        private bool multiplicar = false;
        private bool subtrair = false;

        public Form1()
        {
            InitializeComponent();
            txtResultado.ReadOnly = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (somar)
            {
                List<string> aSomar = txtResultado.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);

                if (aSomar[1] == "") {
                    if (string.IsNullOrWhiteSpace(txtResultado.Text) || !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("*") && !txtResultado.Text.Contains("/") || txtResultado.Text.EndsWith("+") ||
        txtResultado.Text.EndsWith("-") ||
        txtResultado.Text.EndsWith("*") ||
        txtResultado.Text.EndsWith("/")) ;
                    {
                    }
                    return;
                }
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtResultado.Text = resultado.ToString();

                
            }

            else if (subtrair)
            {
                string expression = txtResultado.Text.Replace(" -(", " +(");  // Altera para a forma "5 -(-3)" para "5 +3"
                List<string> aSubtrair = txtResultado.Text.Split("-").ToList();

                double primeiroNumero = Convert.ToDouble(aSubtrair[0]);
                if (aSubtrair[1] == "")
                {
                    if (string.IsNullOrWhiteSpace(txtResultado.Text) || !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("*") && !txtResultado.Text.Contains("/") || txtResultado.Text.EndsWith("+") ||
        txtResultado.Text.EndsWith("-") ||
        txtResultado.Text.EndsWith("*") ||
        txtResultado.Text.EndsWith("/")) ;
                    {
                    }
                    return;
                }
                double segundoNumero = Convert.ToDouble(aSubtrair[1]);

                double resultado = primeiroNumero - segundoNumero;
                txtResultado.Text = resultado.ToString();

               
            }
            else if (dividir)
            {
                List<string> aDividir = txtResultado.Text.Split("/").ToList();

                double primeiroNumero = Convert.ToDouble(aDividir[0]);
                if (aDividir[1] == "")
                {
                    if (string.IsNullOrWhiteSpace(txtResultado.Text) || !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("*") && !txtResultado.Text.Contains("/") || txtResultado.Text.EndsWith("+") ||
        txtResultado.Text.EndsWith("-") ||
        txtResultado.Text.EndsWith("*") ||
        txtResultado.Text.EndsWith("/")) ;
                    {
                    }
                    return;
                }
                double segundoNumero = Convert.ToDouble(aDividir[1]);

                double resultado = primeiroNumero / segundoNumero;
                txtResultado.Text = resultado.ToString();

                
            }


            else if (multiplicar)
            {
                List<string> aMultiplicar = txtResultado.Text.Split("*").ToList();

                double primeiroNumero = Convert.ToDouble(aMultiplicar[0]);
                if (aMultiplicar[1] == "")
                {
                    if (string.IsNullOrWhiteSpace(txtResultado.Text) || !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("*") && !txtResultado.Text.Contains("/") || txtResultado.Text.EndsWith("+") ||
        txtResultado.Text.EndsWith("-") ||
        txtResultado.Text.EndsWith("*") ||
        txtResultado.Text.EndsWith("/")) ;
                    {
                    }
                    return;
                }
                double segundoNumero = Convert.ToDouble(aMultiplicar[1]);

                double resultado = primeiroNumero * segundoNumero;
                txtResultado.Text = resultado.ToString();

                
            }
            else if (string.IsNullOrWhiteSpace(txtResultado.Text) || !txtResultado.Text.Contains("+") && !txtResultado.Text.Contains("-") && !txtResultado.Text.Contains("*") && !txtResultado.Text.Contains("/"))
            {
            }
            return;

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtResultado.Text[txtResultado.Text.Length - 1] == '-'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '*'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '/')
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
            if (txtResultado.Text[txtResultado.Text.Length - 1] == '+')
                return;
            txtResultado.Text += "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = true;
            multiplicar = false;
            somar = false;

            if (txtResultado.Text[txtResultado.Text.Length - 1] == '+'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '*'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '/')
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
            if (txtResultado.Text[txtResultado.Text.Length - 1] == '-')
                return;
            txtResultado.Text += "-";

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = false;
            multiplicar = true;
            somar = false;

            if (txtResultado.Text[txtResultado.Text.Length - 1] == '-'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '+'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '/')
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
            if (txtResultado.Text[txtResultado.Text.Length - 1] == '*')
                return;
            txtResultado.Text += "*";
            ;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            dividir = true;
            subtrair = false;
            multiplicar = false;
            somar = false;

            if (txtResultado.Text[txtResultado.Text.Length - 1] == '-'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '*'
                || txtResultado.Text[txtResultado.Text.Length - 1] == '+')
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }
            if (txtResultado.Text[txtResultado.Text.Length - 1] == '/')
                return;
            txtResultado.Text += "/";
            ;
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {

            // Se o texto for vazio, não faz nada
            if (string.IsNullOrWhiteSpace(txtResultado.Text))
                return;

            // Se o texto já começa com um sinal negativo, remove ele (tornando o número positivo)
            if (txtResultado.Text[0] == '-')
            {
                txtResultado.Text = txtResultado.Text.Substring(1);
            }
            else
            {
                // Se não começa com um sinal negativo, adiciona o sinal no início do texto
                txtResultado.Text = "-" + txtResultado.Text;
            }

        }
    }
}




