namespace AppIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double alt, peso, imc;
            alt = (double)numAltura.Value;
            peso = (double)numPeso.Value;
            imc = peso / Math.Pow(alt, 2);

            lblIMC.Text = $"{imc:F2} kg/m²";

            lblClassif.Text = Classificar(imc);
        }

        string Classificar(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do Peso";
            if (imc < 25)
                return "Peso Normal";
            if (imc < 30)
                return "Sobrepeso";
            if (imc < 35)
                return "Obesidade I";
            if (imc < 40)
                return "Obesidade II";
            
            return "Obesidade Mórbida";
        }



        private void lblIMC_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numAltura_ValueChanged_1(object sender, EventArgs e)
        {
            decimal a = numAltura.Value;
            /* if (a != 0)//true
                btCalcular.Enabled = true;
            else //false
                btCalcular.Enabled = false; */
            btCalcular.Enabled = (a != 0);
        }
    }
}
