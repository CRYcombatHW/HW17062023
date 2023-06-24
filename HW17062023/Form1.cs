using System.Linq;

namespace HW17062023
{
	public partial class Form1 : Form
	{
		private List<int> guesses;
		private Random random;

		public Form1() {
			guesses = new List<int>();
			random = new Random();

			InitializeComponent();
			UplateTrysLabel();
		}

		private void UplateTrysLabel() => tryLabel.Text = guesses.Count.ToString();
		private bool ShowYesNoMessage(string message, string title = "") => 
			MessageBox.Show(
				message,
				title,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			) == DialogResult.Yes;

		private void buttonGuess_Click(object sender, EventArgs e) {
			int newGuess;

			do {
				newGuess = random.Next() % 2000;
			} while (guesses.Contains(newGuess));
			guesses.Add(newGuess);


			if (ShowYesNoMessage($"Is {guesses.Last()} your number", "Guess")) {
				if (ShowYesNoMessage($"Nice! play again?", "Q")) {
					guesses.Clear();
					UplateTrysLabel();
				} else Close();
			}

			UplateTrysLabel();
		}

		private void buttonReset_Click(object sender, EventArgs e) {
			guesses.Clear();
			UplateTrysLabel();
		}
	}
}