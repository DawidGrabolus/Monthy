using Monthy.Models;

namespace Monthy.Views;

public partial class LessonPage : ContentPage
{
    private readonly List<Month> months = new List<Month>
        {
            new Month(1, "stycze�"),
            new Month(2, "luty"),
            new Month(3, "marzec"),
            new Month(4, "kwiecie�"),
            new Month(5, "maj"),
            new Month(6, "czerwiec"),
            new Month(7, "lipiec"),
            new Month(8, "sierpie�"),
            new Month(9, "wrzesie�"),
            new Month(10, "pa�dziernik"),
            new Month(11, "listopad"),
            new Month(12, "grudzie�")
        };
    private Random random = new Random();
    private int currentMonthNumber; 

    public LessonPage()
    {
        InitializeComponent();

        currentMonthNumber = random.Next(1, 12);
        monthLabel.Text = Convert.ToString(months[currentMonthNumber].Number);

        Button send = this.FindByName<Button>("send");
        send.Clicked += OnSendButtonClicked;
    }

    private void OnSendButtonClicked(object sender, EventArgs e)
    {
        string userAnswer = entry.Text?.Trim().ToLower();
        Month currentMonth = months.Find(m => m.Number == currentMonthNumber+1);

        if (currentMonth != null)
        {
            if (userAnswer == currentMonth.Name.ToLower())
            {
                DisplayAlert("Result", "Correct!", "OK");
            }
            else
            {
                DisplayAlert("Result", "Incorrect! Try again.", "OK");
            }
        }
    }
}