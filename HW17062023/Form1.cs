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
		}

		private void UplateTrysLabel() => tryLabel.Text = guesses.Count.ToString();

		private void buttonGuess_Click(object sender, EventArgs e) {
			int newGuess;

			do {
				newGuess = random.Next() % 2000;
			} while (guesses.Contains(newGuess));
			guesses.Add(newGuess);


			if (
				MessageBox.Show(
					 $"Is {guesses.Last()} your number",
					 "Guess",
					 MessageBoxButtons.YesNo,
					 MessageBoxIcon.Question
				) == DialogResult.Yes
			) {
				if (
					MessageBox.Show(
						 $"Nice! play again?",
						 "Guess",
						 MessageBoxButtons.YesNo,
						 MessageBoxIcon.Question
					) == DialogResult.Yes
				) {
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