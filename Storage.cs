using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot1
{
    public class Storage : IStorage
    {

        public string[] Messages = new string[1];

        StreamReader nachricht = new StreamReader(@"C:\Temp\Text.txt");

        public void Load()
        {
            string textdatei = nachricht.ReadToEnd();
            nachricht.Close();
            Messages = textdatei.Split('!');

            for (int i = 0; i < Messages.Length; i +=2)
            {
                Message mg = new Message(Messages[i], Messages[i + 1]);
                BotEngine.MessagesList.Add(mg);

            }
        }
    }
}
