namespace PAM_MAUI_App;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        string novaFrase = ObterNovaFrase();

        fraseLabel.Text = novaFrase;
    }

    private List<string> frases = new List<string>
	{
    "Hello, Rafael!",
    "Hello, Ana!",
	};

    private string ObterNovaFrase()
    {
        Random random = new Random();
        int index = random.Next(frases.Count);
        return frases[index];
    }
}

