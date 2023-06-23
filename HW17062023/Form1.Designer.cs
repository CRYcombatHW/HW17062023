namespace HW17062023
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			buttonGuess = new Button();
			buttonReset = new Button();
			label1 = new Label();
			tryLabel = new Label();
			SuspendLayout();
			// 
			// buttonGuess
			// 
			buttonGuess.Location = new Point(93, 80);
			buttonGuess.Name = "buttonGuess";
			buttonGuess.Size = new Size(212, 23);
			buttonGuess.TabIndex = 0;
			buttonGuess.Text = "Guess";
			buttonGuess.UseVisualStyleBackColor = true;
			buttonGuess.Click += buttonGuess_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(12, 80);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(75, 23);
			buttonReset.TabIndex = 1;
			buttonReset.Text = "Reset";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += buttonReset_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 2;
			label1.Text = "Atempts: ";
			// 
			// tryLabel
			// 
			tryLabel.AutoSize = true;
			tryLabel.Location = new Point(67, 9);
			tryLabel.Name = "tryLabel";
			tryLabel.Size = new Size(0, 15);
			tryLabel.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(317, 115);
			Controls.Add(tryLabel);
			Controls.Add(label1);
			Controls.Add(buttonReset);
			Controls.Add(buttonGuess);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonGuess;
		private Button buttonReset;
		private Label label1;
		private Label tryLabel;
	}
}