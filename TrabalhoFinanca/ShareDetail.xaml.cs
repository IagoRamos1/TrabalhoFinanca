using Dominio.Entidades;
using Integracao;
using Newtonsoft.Json;

namespace TrabalhoFinanca;

public partial class ShareDetail : ContentPage
{

    private readonly BaseClient _client = new BaseClient();
    private string _simboloAcao;

    public ShareDetail(string simboloAcao)
    {
        InitializeComponent();
        _simboloAcao = simboloAcao;
        ShareDetails(_simboloAcao);
    }
    private async Task ShareDetails(String simboloAcao)
    {
        HttpResponseMessage respostaAPI = await _client.GetShare(simboloAcao);
        string conteudo = await respostaAPI.Content.ReadAsStringAsync();
        Entidades entidade = JsonConvert.DeserializeObject<Entidades>(conteudo);


        shortName.Text = $"{entidade.ShortName}";
        longName.Text = $"{entidade.LongName}";
        regularMarketChange.Text = $"{entidade.RegularMarketChange}";
        regularMarketChangePercent.Text = $"{entidade.RegularMarketChangePercent}";
    }
}