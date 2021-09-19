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

        /// <summary>
        /// Text Datei einlesen
        /// </summary
        //Bitte korrigieren Sie den Pfad bevor sie den Programm ausführen
        StreamReader nachricht = new StreamReader(@"C:\Users\sajeela\OneDrive - ipso Bildung AG\ICT Modul\Modul 226b\Chatbot\Text.txt");

        /// <summary>
        /// Load Methode
        /// </summary>
        public void Load()
        {
            //nachricht(Inhalt von Text.txt) wird mit StreamReader gelesen danach mit Close wieder geschlossen 
            string textdatei = nachricht.ReadToEnd();
            nachricht.Close();
            //Abgetrennt mit dem Ausrufezeichen
            Messages = textdatei.Split('!');

            for (int i = 0; i < Messages.Length; i += 2)
            {
                try
                {
                    Message mg = new Message(Messages[i], Messages[i + 1]);
                    BotEngine.MessagesList.Add(mg);
                }
                catch
                {
                    if (textdatei == "")
                    {
                        throw new Exception("Der Textfile ist leer.");
                    }
                }
            }
        }
    }
}
