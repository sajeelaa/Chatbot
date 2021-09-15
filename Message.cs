using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot1
{
    public class Message
    {
        private string _keyword;

        public string Keyword
        {
            get { return _keyword; }
        }

        private string _answer;

        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        public Message(string k, string a)
        {
            _keyword = k;
            _answer = a;
        }
    }
}
