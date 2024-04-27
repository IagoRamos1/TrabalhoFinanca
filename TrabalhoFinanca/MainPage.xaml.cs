
namespace TrabalhoFinanca
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CliqueBuscarInformacoes(object sender, EventArgs e)
        {
            string simboloAcao = campoSimbolo.Text;

            ShareDetail share = new ShareDetail(simboloAcao);
            await Navigation.PushAsync(share);
        }
    }

}
