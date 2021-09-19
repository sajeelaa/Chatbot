using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot1
{
    public class BotEngine
    {
        public static List<Message> MessagesList = new List<Message>();

        /// <summary>
        /// CTOR
        /// </summary>
        public BotEngine()
        {

        }

        private string _answer;

        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        /// <summary>
        /// Methode GetAnswer
        /// </summary>
        /// <param name="E"></param>
        /// <returns></returns>
        public string GetAnswer(string E)
        {
            foreach (var A in MessagesList)
            {
                if (E == A.Keyword)
                {
                    return A.Answer;
                }
            }
        
            //@# Heisst Es wurde nicht gefunden
            return "@#-%&";
        }
    }
}
