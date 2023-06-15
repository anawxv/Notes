namespace PAM_MAUI_App.Views;

public partial class AllNotesPage : ContentPage
{
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}