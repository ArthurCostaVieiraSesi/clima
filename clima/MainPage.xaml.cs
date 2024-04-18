namespace clima;

public partial class MainPage : ContentPage
{
    Results resultado;
	public MainPage()
	{
		InitializeComponent();
		TestaLayout();
		PreencherTela();
	}

		void TestaLayout()
		{
			resultado = new Results();
			resultado.temp = 24;
			resultado.description = "Tempo Nublado";
			resultado.rain = 88;
			resultado.city = "Apucarana";
			resultado.humidity = 88;
			resultado.wind_speed = 3;
			resultado.wind_direction = 397;
			resultado.wind_cardinal = "N";
			resultado.sunrise = "06:13";
			resultado.sunset = "18:27";
			resultado.moon_phase = "Cheia";

		}

		void PreencherTela()
		{
			LabelChuva.Text = resultado.rain.ToString();
			LabelHumidade.Text = resultado.humidity.ToString();
			LabelGraus.Text = resultado.temp.ToString();
			LabelClima.Text = resultado.description;
			LabelCidade.Text = resultado.city;
			LabelForça.Text = resultado. wind_speed.ToString();
			LabelDireção.Text = resultado.wind_direction.ToString();
			LabelAmanhecer.Text = resultado.sunrise;
			LabelAnoitecer.Text = resultado.sunset;
			LabelLua.Text = resultado.moon_phase;
			LabelCardinal.Text = resultado.wind_cardinal;

		}

}

