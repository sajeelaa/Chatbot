namespace Chatbot1
{
    public class Message
    {
        /// <summary>
        /// propfull Keyword
        /// </summary>   
        private string _keyword;
        public string Keyword
        {
            get { return _keyword; }
        }

        /// <summary>
        /// propfull Antwort
        /// </summary>
        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        /// <summary>
        /// Message CTOR
        /// </summary>
        /// <param name="k"></param>
        /// <param name="a"></param>
        public Message(string k, string a)
        {
            _keyword = k;
            _answer = a;
        }
    }
}
