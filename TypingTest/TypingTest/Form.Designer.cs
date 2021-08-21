
using System.Windows.Forms;

namespace TypingTest {
    partial class Form {
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.InitialTab = new System.Windows.Forms.TabPage();
            this.SecondCaptionLabel = new System.Windows.Forms.Label();
            this.MinuteCaptionLabel = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.HardLevelRadio = new System.Windows.Forms.RadioButton();
            this.MediumLevelRadio = new System.Windows.Forms.RadioButton();
            this.EasyLevelRadio = new System.Windows.Forms.RadioButton();
            this.StartTestingButton = new System.Windows.Forms.Button();
            this.SecondIncreasingButton = new System.Windows.Forms.Button();
            this.SecondDecreasingButton = new System.Windows.Forms.Button();
            this.MinuteIncreasingButton = new System.Windows.Forms.Button();
            this.MinuteDecreasingButton = new System.Windows.Forms.Button();
            this.TestTab = new System.Windows.Forms.TabPage();
            this.TestingPhraseTextBox = new System.Windows.Forms.TextBox();
            this.TestingPhraseLabel = new System.Windows.Forms.Label();
            this.StopTestingButton = new System.Windows.Forms.Button();
            this.RemainTimeLabel = new System.Windows.Forms.Label();
            this.ResultTab = new System.Windows.Forms.TabPage();
            this.FinishedTestLabel = new System.Windows.Forms.Label();
            this.MistakesCountLabel = new System.Windows.Forms.Label();
            this.MistakesCountCaptionLabel = new System.Windows.Forms.Label();
            this.TestTimeLabel = new System.Windows.Forms.Label();
            this.SpentTimeCaptionLabel = new System.Windows.Forms.Label();
            this.TestResultLabel = new System.Windows.Forms.Label();
            this.TestResultCaptionLabel = new System.Windows.Forms.Label();
            this.TestingAgainButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.InitialTab.SuspendLayout();
            this.TestTab.SuspendLayout();
            this.ResultTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.InitialTab);
            this.TabControl.Controls.Add(this.TestTab);
            this.TabControl.Controls.Add(this.ResultTab);
            this.TabControl.Location = new System.Drawing.Point(2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(399, 273);
            this.TabControl.TabIndex = 0;
            // 
            // InitialTab
            // 
            this.InitialTab.Controls.Add(this.SecondCaptionLabel);
            this.InitialTab.Controls.Add(this.MinuteCaptionLabel);
            this.InitialTab.Controls.Add(this.DifficultyLabel);
            this.InitialTab.Controls.Add(this.SecondLabel);
            this.InitialTab.Controls.Add(this.MinuteLabel);
            this.InitialTab.Controls.Add(this.HardLevelRadio);
            this.InitialTab.Controls.Add(this.MediumLevelRadio);
            this.InitialTab.Controls.Add(this.EasyLevelRadio);
            this.InitialTab.Controls.Add(this.StartTestingButton);
            this.InitialTab.Controls.Add(this.SecondIncreasingButton);
            this.InitialTab.Controls.Add(this.SecondDecreasingButton);
            this.InitialTab.Controls.Add(this.MinuteIncreasingButton);
            this.InitialTab.Controls.Add(this.MinuteDecreasingButton);
            this.InitialTab.Location = new System.Drawing.Point(4, 24);
            this.InitialTab.Name = "InitialTab";
            this.InitialTab.Padding = new System.Windows.Forms.Padding(3);
            this.InitialTab.Size = new System.Drawing.Size(391, 245);
            this.InitialTab.TabIndex = 0;
            this.InitialTab.Text = "Initial";
            this.InitialTab.UseVisualStyleBackColor = true;
            // 
            // SecondCaptionLabel
            // 
            this.SecondCaptionLabel.AutoSize = true;
            this.SecondCaptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondCaptionLabel.Location = new System.Drawing.Point(6, 64);
            this.SecondCaptionLabel.Name = "SecondCaptionLabel";
            this.SecondCaptionLabel.Size = new System.Drawing.Size(67, 20);
            this.SecondCaptionLabel.TabIndex = 12;
            this.SecondCaptionLabel.Text = "Seconds";
            // 
            // MinuteCaptionLabel
            // 
            this.MinuteCaptionLabel.AutoSize = true;
            this.MinuteCaptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuteCaptionLabel.Location = new System.Drawing.Point(6, 33);
            this.MinuteCaptionLabel.Name = "MinuteCaptionLabel";
            this.MinuteCaptionLabel.Size = new System.Drawing.Size(64, 20);
            this.MinuteCaptionLabel.TabIndex = 11;
            this.MinuteCaptionLabel.Text = "Minutes";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifficultyLabel.Location = new System.Drawing.Point(6, 102);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(119, 20);
            this.DifficultyLabel.TabIndex = 10;
            this.DifficultyLabel.Text = "Choose the level";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondLabel.Location = new System.Drawing.Point(149, 67);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(18, 20);
            this.SecondLabel.TabIndex = 9;
            this.SecondLabel.Text = "0";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuteLabel.Location = new System.Drawing.Point(149, 36);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(18, 20);
            this.MinuteLabel.TabIndex = 8;
            this.MinuteLabel.Text = "0";
            // 
            // HardLevelRadio
            // 
            this.HardLevelRadio.AutoSize = true;
            this.HardLevelRadio.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HardLevelRadio.Location = new System.Drawing.Point(32, 185);
            this.HardLevelRadio.Name = "HardLevelRadio";
            this.HardLevelRadio.Size = new System.Drawing.Size(63, 24);
            this.HardLevelRadio.TabIndex = 7;
            this.HardLevelRadio.Text = "Hard";
            this.HardLevelRadio.UseVisualStyleBackColor = true;
            // 
            // MediumLevelRadio
            // 
            this.MediumLevelRadio.AutoSize = true;
            this.MediumLevelRadio.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MediumLevelRadio.Location = new System.Drawing.Point(32, 155);
            this.MediumLevelRadio.Name = "MediumLevelRadio";
            this.MediumLevelRadio.Size = new System.Drawing.Size(80, 24);
            this.MediumLevelRadio.TabIndex = 6;
            this.MediumLevelRadio.Text = "Medium";
            this.MediumLevelRadio.UseVisualStyleBackColor = true;
            // 
            // EasyLevelRadio
            // 
            this.EasyLevelRadio.AutoSize = true;
            this.EasyLevelRadio.Checked = true;
            this.EasyLevelRadio.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EasyLevelRadio.Location = new System.Drawing.Point(32, 125);
            this.EasyLevelRadio.Name = "EasyLevelRadio";
            this.EasyLevelRadio.Size = new System.Drawing.Size(59, 24);
            this.EasyLevelRadio.TabIndex = 5;
            this.EasyLevelRadio.TabStop = true;
            this.EasyLevelRadio.Text = "Easy";
            this.EasyLevelRadio.UseVisualStyleBackColor = true;
            // 
            // StartTestingButton
            // 
            this.StartTestingButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartTestingButton.Location = new System.Drawing.Point(306, 207);
            this.StartTestingButton.Name = "StartTestingButton";
            this.StartTestingButton.Size = new System.Drawing.Size(75, 30);
            this.StartTestingButton.TabIndex = 4;
            this.StartTestingButton.Text = "Start";
            this.StartTestingButton.UseVisualStyleBackColor = true;
            this.StartTestingButton.Click += new System.EventHandler(this.StartTestingButton_Click);
            // 
            // SecondIncreasingButton
            // 
            this.SecondIncreasingButton.Location = new System.Drawing.Point(184, 64);
            this.SecondIncreasingButton.Name = "SecondIncreasingButton";
            this.SecondIncreasingButton.Size = new System.Drawing.Size(37, 23);
            this.SecondIncreasingButton.TabIndex = 3;
            this.SecondIncreasingButton.Text = ">";
            this.SecondIncreasingButton.UseVisualStyleBackColor = true;
            this.SecondIncreasingButton.Click += new System.EventHandler(this.SecondIncreasingButton_Click);
            // 
            // SecondDecreasingButton
            // 
            this.SecondDecreasingButton.Location = new System.Drawing.Point(93, 64);
            this.SecondDecreasingButton.Name = "SecondDecreasingButton";
            this.SecondDecreasingButton.Size = new System.Drawing.Size(39, 23);
            this.SecondDecreasingButton.TabIndex = 2;
            this.SecondDecreasingButton.Text = "<";
            this.SecondDecreasingButton.UseVisualStyleBackColor = true;
            this.SecondDecreasingButton.Click += new System.EventHandler(this.SecondDecreasingButton_Click);
            // 
            // MinuteIncreasingButton
            // 
            this.MinuteIncreasingButton.Location = new System.Drawing.Point(184, 33);
            this.MinuteIncreasingButton.Name = "MinuteIncreasingButton";
            this.MinuteIncreasingButton.Size = new System.Drawing.Size(37, 23);
            this.MinuteIncreasingButton.TabIndex = 1;
            this.MinuteIncreasingButton.Text = ">";
            this.MinuteIncreasingButton.UseVisualStyleBackColor = true;
            this.MinuteIncreasingButton.Click += new System.EventHandler(this.MinuteIncreasingButton_Click);
            // 
            // MinuteDecreasingButton
            // 
            this.MinuteDecreasingButton.Location = new System.Drawing.Point(92, 33);
            this.MinuteDecreasingButton.Name = "MinuteDecreasingButton";
            this.MinuteDecreasingButton.Size = new System.Drawing.Size(39, 23);
            this.MinuteDecreasingButton.TabIndex = 0;
            this.MinuteDecreasingButton.Text = "<";
            this.MinuteDecreasingButton.UseVisualStyleBackColor = true;
            this.MinuteDecreasingButton.Click += new System.EventHandler(this.MinuteDecreasingButton_Click);
            // 
            // TestTab
            // 
            this.TestTab.Controls.Add(this.TestingPhraseTextBox);
            this.TestTab.Controls.Add(this.TestingPhraseLabel);
            this.TestTab.Controls.Add(this.StopTestingButton);
            this.TestTab.Controls.Add(this.RemainTimeLabel);
            this.TestTab.Location = new System.Drawing.Point(4, 24);
            this.TestTab.Name = "TestTab";
            this.TestTab.Padding = new System.Windows.Forms.Padding(3);
            this.TestTab.Size = new System.Drawing.Size(391, 245);
            this.TestTab.TabIndex = 1;
            this.TestTab.Text = "Testing";
            this.TestTab.UseVisualStyleBackColor = true;
            // 
            // TestingPhraseTextBox
            // 
            this.TestingPhraseTextBox.Location = new System.Drawing.Point(6, 108);
            this.TestingPhraseTextBox.Multiline = true;
            this.TestingPhraseTextBox.Name = "TestingPhraseTextBox";
            this.TestingPhraseTextBox.Size = new System.Drawing.Size(384, 67);
            this.TestingPhraseTextBox.TabIndex = 3;
            this.TestingPhraseTextBox.TextChanged += new System.EventHandler(this.TestingPhraseTextBox_TextChanged);
            // 
            // TestingPhraseLabel
            // 
            this.TestingPhraseLabel.AutoSize = true;
            this.TestingPhraseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestingPhraseLabel.Location = new System.Drawing.Point(3, 49);
            this.TestingPhraseLabel.MaximumSize = new System.Drawing.Size(386, 50);
            this.TestingPhraseLabel.Name = "TestingPhraseLabel";
            this.TestingPhraseLabel.Size = new System.Drawing.Size(97, 19);
            this.TestingPhraseLabel.TabIndex = 2;
            this.TestingPhraseLabel.Text = "Testing phrase";
            // 
            // StopTestingButton
            // 
            this.StopTestingButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopTestingButton.Location = new System.Drawing.Point(275, 194);
            this.StopTestingButton.Name = "StopTestingButton";
            this.StopTestingButton.Size = new System.Drawing.Size(116, 37);
            this.StopTestingButton.TabIndex = 1;
            this.StopTestingButton.Text = "Stop Testing";
            this.StopTestingButton.UseVisualStyleBackColor = true;
            this.StopTestingButton.Click += new System.EventHandler(this.StopTestingButton_Click);
            // 
            // RemainTimeLabel
            // 
            this.RemainTimeLabel.AutoSize = true;
            this.RemainTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemainTimeLabel.Location = new System.Drawing.Point(7, 7);
            this.RemainTimeLabel.Name = "RemainTimeLabel";
            this.RemainTimeLabel.Size = new System.Drawing.Size(59, 24);
            this.RemainTimeLabel.TabIndex = 0;
            this.RemainTimeLabel.Text = "00:00";
            // 
            // ResultTab
            // 
            this.ResultTab.Controls.Add(this.FinishedTestLabel);
            this.ResultTab.Controls.Add(this.MistakesCountLabel);
            this.ResultTab.Controls.Add(this.MistakesCountCaptionLabel);
            this.ResultTab.Controls.Add(this.TestTimeLabel);
            this.ResultTab.Controls.Add(this.SpentTimeCaptionLabel);
            this.ResultTab.Controls.Add(this.TestResultLabel);
            this.ResultTab.Controls.Add(this.TestResultCaptionLabel);
            this.ResultTab.Controls.Add(this.TestingAgainButton);
            this.ResultTab.Location = new System.Drawing.Point(4, 24);
            this.ResultTab.Name = "ResultTab";
            this.ResultTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResultTab.Size = new System.Drawing.Size(391, 245);
            this.ResultTab.TabIndex = 2;
            this.ResultTab.Text = "Result";
            this.ResultTab.UseVisualStyleBackColor = true;
            // 
            // FinishedTestLabel
            // 
            this.FinishedTestLabel.AutoSize = true;
            this.FinishedTestLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishedTestLabel.Location = new System.Drawing.Point(81, 14);
            this.FinishedTestLabel.Name = "FinishedTestLabel";
            this.FinishedTestLabel.Size = new System.Drawing.Size(223, 23);
            this.FinishedTestLabel.TabIndex = 7;
            this.FinishedTestLabel.Text = "You finished your typing test";
            // 
            // MistakesCountLabel
            // 
            this.MistakesCountLabel.AutoSize = true;
            this.MistakesCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MistakesCountLabel.Location = new System.Drawing.Point(194, 119);
            this.MistakesCountLabel.Name = "MistakesCountLabel";
            this.MistakesCountLabel.Size = new System.Drawing.Size(18, 20);
            this.MistakesCountLabel.TabIndex = 6;
            this.MistakesCountLabel.Text = "0";
            // 
            // MistakesCountCaptionLabel
            // 
            this.MistakesCountCaptionLabel.AutoSize = true;
            this.MistakesCountCaptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.MistakesCountCaptionLabel.Location = new System.Drawing.Point(106, 119);
            this.MistakesCountCaptionLabel.Name = "MistakesCountCaptionLabel";
            this.MistakesCountCaptionLabel.Size = new System.Drawing.Size(72, 20);
            this.MistakesCountCaptionLabel.TabIndex = 5;
            this.MistakesCountCaptionLabel.Text = "Mistakes";
            // 
            // TestTimeLabel
            // 
            this.TestTimeLabel.AutoSize = true;
            this.TestTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestTimeLabel.Location = new System.Drawing.Point(194, 88);
            this.TestTimeLabel.Name = "TestTimeLabel";
            this.TestTimeLabel.Size = new System.Drawing.Size(49, 20);
            this.TestTimeLabel.TabIndex = 4;
            this.TestTimeLabel.Text = "00:00";
            // 
            // SpentTimeCaptionLabel
            // 
            this.SpentTimeCaptionLabel.AutoSize = true;
            this.SpentTimeCaptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.SpentTimeCaptionLabel.Location = new System.Drawing.Point(94, 88);
            this.SpentTimeCaptionLabel.Name = "SpentTimeCaptionLabel";
            this.SpentTimeCaptionLabel.Size = new System.Drawing.Size(84, 20);
            this.SpentTimeCaptionLabel.TabIndex = 3;
            this.SpentTimeCaptionLabel.Text = "Time spent";
            // 
            // TestResultLabel
            // 
            this.TestResultLabel.AutoSize = true;
            this.TestResultLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestResultLabel.Location = new System.Drawing.Point(194, 57);
            this.TestResultLabel.Name = "TestResultLabel";
            this.TestResultLabel.Size = new System.Drawing.Size(101, 20);
            this.TestResultLabel.TabIndex = 2;
            this.TestResultLabel.Text = "Test finished";
            // 
            // TestResultCaptionLabel
            // 
            this.TestResultCaptionLabel.AutoSize = true;
            this.TestResultCaptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.TestResultCaptionLabel.Location = new System.Drawing.Point(69, 57);
            this.TestResultCaptionLabel.Name = "TestResultCaptionLabel";
            this.TestResultCaptionLabel.Size = new System.Drawing.Size(109, 20);
            this.TestResultCaptionLabel.TabIndex = 1;
            this.TestResultCaptionLabel.Text = "Testing status";
            // 
            // TestingAgainButton
            // 
            this.TestingAgainButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestingAgainButton.Location = new System.Drawing.Point(263, 197);
            this.TestingAgainButton.Name = "TestingAgainButton";
            this.TestingAgainButton.Size = new System.Drawing.Size(123, 34);
            this.TestingAgainButton.TabIndex = 0;
            this.TestingAgainButton.Text = "Test again";
            this.TestingAgainButton.UseVisualStyleBackColor = true;
            this.TestingAgainButton.Click += new System.EventHandler(this.TestingAgainButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 275);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.InitialTab.ResumeLayout(false);
            this.InitialTab.PerformLayout();
            this.TestTab.ResumeLayout(false);
            this.TestTab.PerformLayout();
            this.ResultTab.ResumeLayout(false);
            this.ResultTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage InitialTab;
        private System.Windows.Forms.TabPage TestTab;
        private System.Windows.Forms.TabPage ResultTab;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.RadioButton HardLevelRadio;
        private System.Windows.Forms.RadioButton MediumLevelRadio;
        private System.Windows.Forms.RadioButton EasyLevelRadio;
        private System.Windows.Forms.Button StartTestingButton;
        private System.Windows.Forms.Button SecondIncreasingButton;
        private System.Windows.Forms.Button SecondDecreasingButton;
        private System.Windows.Forms.Button MinuteIncreasingButton;
        private System.Windows.Forms.Button MinuteDecreasingButton;
        private System.Windows.Forms.TextBox TestingPhraseTextBox;
        private System.Windows.Forms.Label TestingPhraseLabel;
        private System.Windows.Forms.Button StopTestingButton;
        private System.Windows.Forms.Label RemainTimeLabel;
        private System.Windows.Forms.Label FinishedTestLabel;
        private System.Windows.Forms.Label MistakesCountLabel;
        private System.Windows.Forms.Label MistakesCountCaptionLabel;
        private System.Windows.Forms.Label TestTimeLabel;
        private System.Windows.Forms.Label SpentTimeCaptionLabel;
        private System.Windows.Forms.Label TestResultLabel;
        private System.Windows.Forms.Label TestResultCaptionLabel;
        private System.Windows.Forms.Button TestingAgainButton;
        private Label SecondCaptionLabel;
        private Label MinuteCaptionLabel;
    }
}

