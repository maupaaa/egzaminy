using System;
using System.Collections.Generic;
using System.Text;

namespace INF._04_02_26._01_SG
{
    public abstract class Pytanie
    {
        protected string content;
        protected string imgFile;
        protected bool isCorrect;

        protected Pytanie(string content, string imgFile)
        {
            this.content = content;
            this.imgFile = imgFile;
            isCorrect = false;     }

        public abstract bool CheckAnswer(char answer);
    }
}
