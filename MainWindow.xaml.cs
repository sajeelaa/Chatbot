using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chatbot1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BotEngine bot = new BotEngine();
        Storage speicher = new Storage();
        Message test = new Message("ka", "iergendwas");
        public MainWindow()
        {
            InitializeComponent();
         
            // Load muss ausgeführt werden
            BotEngine bot = new BotEngine();
            Storage speicher = new Storage();
            speicher.Load();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            Chat.Text += $"Du: {Schreibbox.Text}\n";
            // Die Methode getAntwort ausführen von Botengine
            if (bot.GetAnswer(Schreibbox.Text) != "@#-%&")

            {
                Chat.Text += $"Bot: {bot.GetAnswer(Schreibbox.Text)}\n";
            }
            else
            {
                Chat.Text += $"Bot: Antwort konnte nicht gefunden werden :( \n";
            }
           
            Schreibbox.Clear();
           
        }

        private void Chat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
