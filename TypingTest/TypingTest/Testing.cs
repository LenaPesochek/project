using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTest {
    class Testing {
        const string phrasesPath = "..\\..\\..\\Content\\phrases.txt";
        int timerCurrentValue;
        int timerStartValue;
        string testPhrase;
        Timer timer = new Timer();
        Form1 TestingForm { get; set;}
        public Testing(Form1 form) {
            TestingForm = form;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
        }
        public string TestPhrase { 
            get{
                if(string.IsNullOrEmpty(testPhrase))
                    testPhrase = GetTestPhrase();
                return testPhrase;
            }
        }
        public string[] GetSplitTestPhrase() {
            return TestPhrase.Split(" ");
        }
        public CurrentTestStatus TestStatus { get; set;}
        CurrentDifficulty Difficulty { get; set;}
        void timer_Tick(object sender, EventArgs e) {
            if (timerCurrentValue != 0) {
                TestingForm.SetRemainTimeLabelText(GetRemainTime(timerCurrentValue));
                timerCurrentValue--;
            } else { 
                TestStatus = CurrentTestStatus.TimeIsOver;
                Stop(false);
            }
        }
        string GetRemainTime(int time) {
            int minutes = (time - time % 60) / 60;
            int seconds = time - minutes * 60;
            return string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));
        }
        string GetTestPhrase() {
            var difficultyInPhrase = "[" + Difficulty.ToString() + "]";
            var currentDifficultyPhrases = File.ReadLines(phrasesPath).Where(x => x.Contains(difficultyInPhrase));
            var phrase = currentDifficultyPhrases.Skip(new Random().Next(0, currentDifficultyPhrases.Count() - 1)).First();
            phrase = phrase.Replace(difficultyInPhrase, "");
            return phrase;
        }
        public void Start(int startValue, CurrentDifficulty difficulty) {
            timerCurrentValue = startValue;
            timerStartValue = startValue;
            Difficulty = difficulty;
            timer.Start();
            TestingForm.SetTestingPhraseLabelText(TestPhrase);
        }
        public void Stop(bool forced) {
            if(forced)
                TestStatus = CurrentTestStatus.TestIsStopped;
            timer.Stop();
            TestingForm.SelectTabByName("ResultTab");
            TestingForm.FillResultTab(GetStringTestStatus(), GetSpentTime(), MistakesCount, MistakesPercent);
            }
        string GetSpentTime() {
            int spentTime = timerStartValue - timerCurrentValue;
            int minutes = (spentTime - spentTime % 60) / 60;
            int seconds = spentTime - minutes * 60;
            return string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));

        }
        public void CompareTestPhrase(string inputPhrase) {
            if(inputPhrase == "") {
                MistakesCount = 0;
                return;
            }
            if(inputPhrase == TestPhrase) { 
                MistakesCount = 0;
                TestStatus = CurrentTestStatus.TestIsFinished;
                Stop(false);
                return;
            }
            var inputPhraseArray = inputPhrase.Split(" ");
            var testPhraseArray = GetSplitTestPhrase();
            var mistakesCount = 0;
            for(var i=0; i<inputPhraseArray.Length; i++) {
                if(inputPhraseArray[i] != testPhraseArray[i])
                    mistakesCount++;
            }
            MistakesCount = mistakesCount;

            MistakesPercent = Convert.ToInt32(((double)MistakesCount/testPhraseArray.Length)*100);
            
        }
        string GetStringTestStatus() {
            switch(TestStatus) {
                case CurrentTestStatus.TestIsFinished:
                    return "Test is finished";
                case CurrentTestStatus.TimeIsOver:
                    return "Time is over";
                default:
                    return "Test is stopped";
            }
        }
        public int MistakesCount { get; set;}
        public int MistakesPercent { get; set;}


    }
    public enum CurrentTestStatus {
        TestIsStopped = 0,
        TestIsFinished = 1,
        TimeIsOver = 2
    }
    public enum CurrentDifficulty {
        Easy = 0,
        Medium = 1,
        Hard = 2
    }
}
