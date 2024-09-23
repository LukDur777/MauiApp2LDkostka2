namespace MauiApp2LD
{
    public partial class MainPage : ContentPage
    {
        int score = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MauiApp2LD(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] dice = new int[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1, 7);
            }
            int RollScore = 0;
            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == i)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    RollScore += count * i;
                }

            }

            Dice0.Source = "kostka" + dice[0] + ".png";
            Dice1.Source = "kostka" + dice[1] + ".png";
            Dice2.Source = "kostka" + dice[2] + ".png";
            Dice3.Source = "kostka" + dice[3] + ".png";
            Dice4.Source = "kostka" + dice[4] + ".png";
            RollScorelabel.Text = "Wynik tego losowania :" + RollScore;
            score += RollScore;
            ScoreLabel.Text = "Wynik gry:" + score;

        }
        private void buttonclicked(object sender, EventArgs e)
        {
            score = 0;
            ScoreLabel.Text = "Wynik gry:" + score;
        }

    }

    }
