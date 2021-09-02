using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTest {
    class Testing {
        const string phrasesPath = "..\\..\\..\\Content\\phrases.txt";
        int timerCurrentValue;
        int timerStartValue;
        string testPhrase;
        Timer timer = new Timer();
        public Testing(Form form) {
            TestingForm = form;
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = 1000;
        }
        Form TestingForm { get; set; }
        int MistakesCount { get; set; }
        int CorrectWordsCount { get; set;}
        CurrentTestStatus TestStatus { get; set; }
        CurrentDifficulty Difficulty { get; set; }
        int MistakesPercent { get { return Convert.ToInt32((double)MistakesCount / GetSplitInputPhrase().Length * 100); } }
        string TestPhrase { 
            get{
                if(string.IsNullOrEmpty(testPhrase))
                    testPhrase = GetTestPhrase();
                return testPhrase;
            }
        }
        string InputPhrase{ get; set; }
        string[] GetSplitTestPhrase() {
            return TestPhrase.Split(" ");
        }
        string[] GetSplitInputPhrase() {
            return InputPhrase.Split(" ");
        }
        void TimerTick(object sender, EventArgs e) {
            if(timerCurrentValue != 0) {
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
            TestingForm.FillResultTab(GetStringTestStatus(), GetSpentTime(), GetSpeed(), MistakesCount, MistakesPercent);
        }
        string GetSpentTime() {
            int spentTime = timerStartValue - timerCurrentValue;
            int minutes = (spentTime - spentTime % 60) / 60;
            int seconds = spentTime - minutes * 60;
            return string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));
        }

        string GetSpeed() {
            int spentTime = timerStartValue - timerCurrentValue;
            return String.Format("{0:0.0}", ((double)CorrectWordsCount/spentTime*60));
        }
        public void CompareTestPhrase(string inputPhrase) {
            InputPhrase = inputPhrase;
            if(InputPhrase == "") {
                MistakesCount = 0;
                CorrectWordsCount = 0;
                return;
            }
            var inputPhraseArray = GetSplitInputPhrase();
            if(InputPhrase == TestPhrase) { 
                MistakesCount = 0;
                CorrectWordsCount = inputPhraseArray.Length;
                TestStatus = CurrentTestStatus.TestIsFinished;
                Stop(false);
                return;
            }
            var testPhraseArray = GetSplitTestPhrase();
            var mistakesCount = 0;
            for(var i=0; i<inputPhraseArray.Length; i++) {
                if(inputPhraseArray[i] != testPhraseArray[i])
                    mistakesCount++;
            }
            MistakesCount = mistakesCount;
            CorrectWordsCount = inputPhraseArray.Length - MistakesCount;
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
