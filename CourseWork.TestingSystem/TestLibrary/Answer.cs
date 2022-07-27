using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{

    [Serializable]
    public class Answer
    {

        public string Text { set; get; }

        public bool IsTrue { set; get; }

        public bool IsCheckUser { set; get; }

        public int Id { set; get; }

        public bool IsCorrectAnswer
        {
            get { return String.IsNullOrWhiteSpace(this.Text) ? false : true; }
        }

        public Answer()
        {
            this.Text = String.Empty;
            this.IsTrue = false;
        }

        public Answer(string text, bool isTrue)
        {
            this.Text = text;
            this.IsTrue = isTrue;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Answer answer = (Answer)obj;
            return (answer.Text != this.Text || answer.IsTrue != this.IsTrue) ? false : true ;
        }
    }
}
