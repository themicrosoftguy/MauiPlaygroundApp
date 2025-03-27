using MauiPlaygroundApp.ViewModels;

namespace MauiPlaygroundApp.Views;

public partial class PinPage : ContentPage
{
	public PinPage()
	{
        BindingContext = new PinPageViewModel();
        InitializeComponent();

        // When First PIN box series entry completed, move focus to the next set of PIN entry boxes, so, user can
        // continue entring PIN.
        newPINView.PINEntryCompleted += delegate { confirmPINView.FocusBox(); };
    }
}