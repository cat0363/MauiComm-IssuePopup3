using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopup3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnShowPopup_Clicked(object sender, EventArgs e)
    {
        var indicator = new Indicator();
        this.ShowPopup(indicator);
    }
}

