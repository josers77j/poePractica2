namespace FormsPractica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MontoInicialtextbox.Text) &&
                !string.IsNullOrEmpty(Porcentajetextbox.Text) && 
                float.TryParse(Porcentajetextbox.Text, out float porcentaje) &&
                float.TryParse(MontoInicialtextbox.Text, out float montoinicial)
                )
            {
                var res = montoinicial + (montoinicial * (porcentaje /100));
                Resultadolbl.Text = $"{res}";
            }
            else
            {
                MessageBox.Show("PRO PRO PRO");
            }
        }
    }
}