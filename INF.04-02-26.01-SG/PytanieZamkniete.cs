using System;
using System.Collections.Generic;
using System.Text;

namespace INF._04_02_26._01_SG
{
    public class PytanieZamkniete : Pytanie
    {
        private string answerA;
        private string answerB;
        private string answerC;
        private char correctAnswer;

        public PytanieZamkniete(string content, string imgFile, string answerA, string answerB,
                                string answerC, char correctAnswer)
            : base(content, imgFile)
        {
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.correctAnswer = correctAnswer;
        }

        public override bool CheckAnswer(char answer)
        {
            isCorrect = answer == correctAnswer;
            return isCorrect;
        }
    }
}