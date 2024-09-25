using Monthy.Models;

namespace Monthy.Views;

public partial class LessonPage : ContentPage
{
    private readonly List<Month> months = new List<Month>
        {
            new Month(1, "styczeñ"),
            new Month(2, "luty"),
            new Month(3, "marzec"),
            new Month(4, "kwiecieñ"),
            new Month(5, "maj"),
            new Month(6, "czerwiec"),
            new Month(7, "lipiec"),
            new Month(8, "sierpieñ"),
            new Month(9, "wrzesieñ"),
            new Month(10, "paŸdziernik"),
            new Month(11, "listopad"),
            new Month(12, "grudzieñ")
        };
    private Random random = new Random();
    private int currentMonthNumber;
    private int points = 0;

    public LessonPage()
    {
        InitializeComponent();

        pointsLabel.Text = "Points: 0";

        DrawMonth();

        Button send = this.FindByName<Button>("send");
        send.Clicked += OnSendButtonClicked;
    }

    private void DrawMonth()
    {
        entry.Text = "";
        currentMonthNumber = random.Next(1, 12);
        monthLabel.Text = Convert.ToString(months[currentMonthNumber].Number);
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
                DrawMonth();
                points ++;
                pointsLabel.Text = "Points: " + points;
            }
            else
            {
                DisplayAlert("Result", "Incorrect! Try again.\n Right answer: " + currentMonth.Name, "OK");
                DrawMonth();
            }
        }
    }
}