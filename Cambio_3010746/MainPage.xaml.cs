namespace Cambio_3010746
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(costoArt.Text);
            double dinero = Convert.ToDouble(dinerocli.Text);

            double cambio = dinero - costo;

            cambioCli.Text = "EL cambio es: $" + cambio;
        }
    }
}