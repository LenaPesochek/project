using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTest {
    public partial class Form1 : Form {
        Testing TestingInstance { get; set;}
        public Form1() {
            InitializeComponent();
        }
        private void MinuteDecreasingButton_Click(object sender, EventArgs e) {
            var minuteCount = int.Parse(MinuteLabel.Text);
            if(minuteCount > 0) {
                minuteCount--;
                MinuteLabel.Text = minuteCount.ToString();
            }
        }
        private void MinuteIncreasingButton_Click(object sender, EventArgs e) {
            var minuteCount = int.Parse(MinuteLabel.Text);
            minuteCount++;
            MinuteLabel.Text = minuteCount.ToString();
        }
        private void SecondDecreasingButton_Click(object sender, EventArgs e) {
            var secondCount = int.Parse(SecondLabel.Text);
            if(secondCount > 0)
                secondCount--;
            else 
                secondCount = 59;
            SecondLabel.Text = secondCount.ToString();
        }
        private void SecondIncreasingButton_Click(object sender, EventArgs e) {
            var secondCount = int.Parse(SecondLabel.Text);
            if(secondCount == 59)
                secondCount = 0;
            else
                secondCount++;
            SecondLabel.Text = secondCount.ToString();

        }
        private void StartTestingButton_Click(object sender, EventArgs e) {
            SelectTabByName("TestTab");
            TestingInstance = new Testing(this);
            CurrentDifficulty currentDifficulty;
            if (EasyLevelRadio.Checked)
                currentDifficulty = CurrentDifficulty.Easy;
            else if(MediumLevelRadio.Checked)
                currentDifficulty = CurrentDifficulty.Medium;
            else
                currentDifficulty = CurrentDifficulty.Hard;
            TestingInstance.Start(GetStartTimerValue(), currentDifficulty);
        }
        private void StopTestingButton_Click(object sender, EventArgs e) {
            TestingInstance.Stop(true);

        }
        private void TestingAgainButton_Click(object sender, EventArgs e) {
            SelectTabByName("InitialTab");
            ClearTestingForm();
        }
        int GetStartTimerValue() {
            return 60 * int.Parse(MinuteLabel.Text) + int.Parse(SecondLabel.Text);
        }
        public void SelectTabByName(string name) {
            TabControl.SelectTab(name);
        }
        public void FillResultTab(string testStatus, string testTime, int mistakes, int mistakesPercent) {
            TestResultLabel.Text = testStatus;
            TestTimeLabel.Text = testTime;
            MistakesCountLabel.Text = string.Format("{0} ({1}%)", mistakes, mistakesPercent);

        }
        public void SetTestingPhraseLabelText(string text) {
            TestingPhraseLabel.Text= text;
        }
        public void SetRemainTimeLabelText( string text) {
            RemainTimeLabel.Text = text;
        }
        private void TestingPhraseTextBox_TextChanged(object sender, EventArgs e) {
            var textBox = (TextBox)sender;
            if(textBox.Text == " ") { 
                textBox.Text = "";
                return;
            }
            var newText = "";
            for(var i = 0; i<textBox.Text.Length; i++) {
                if(!(i != 0 && newText[newText.Length-1] == ' ' && textBox.Text[i] == ' '))
                    newText += textBox.Text[i];
            }
            if(newText != textBox.Text) { 
                textBox.Text = newText;
                return;
            }
            TestingInstance.CompareTestPhrase(textBox.Text);
        }
        public void ClearTestingForm() {
            MinuteLabel.Text = "0";
            SecondLabel.Text = "0";
            EasyLevelRadio.Checked = true;
            RemainTimeLabel.Text = "00:00";
            TestingPhraseLabel.Text = "";
            TestingPhraseTextBox.Text = "";
            TestResultLabel.Text = "";
            TestTimeLabel.Text = "00:00";
            MistakesCountLabel.Text = "0";
        }
    }
}
