namespace jCastrotallerS2A.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}


    private void btnSelect_Clicked_1(object sender, EventArgs e)
    {
        string selectedCountry = pkPaises.SelectedItem as string;

        if (!string.IsNullOrEmpty(selectedCountry))
        {
            DisplayAlert("Selección", $"País seleccionado: {selectedCountry}", "OK");
        }
        else
        {
            DisplayAlert("Selección", "No has seleccionado un país.", "OK");
        }
    }
}