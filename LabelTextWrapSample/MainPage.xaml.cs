namespace LabelTextWrapSample;

public partial class MainPage : ContentPage
{
    const string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore.";

    int current = 1;

    public MainPage() {
        InitializeComponent();
        SetLorem(current);
    }


    void ToolbarItem_Clicked(object sender, EventArgs e) {
        SetLorem(++current);
        current = current % 3;
    }

    void SetLorem(int count) {
        string text = string.Join(' ', Enumerable.Repeat(lorem, count));
        TextLabelOne.Text = TextLabelTwo.Text = TextLabelThree.Text = TextLabelFour.Text = text;
    }
}
