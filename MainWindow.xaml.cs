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

namespace Notes
{
    /* TODO:
     * Move Command logic into a separate class (once I've figured out how to add all commands)
     */
     
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();//  DispatcherTimer setup
            var dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            // The idea here is to automatically update the event tracker with recent changes after a short time

            // Updating the Label which displays the current second
            //lblSeconds.Content = DateTime.Now.Second;
            // AcceptTab
            // AllowDrop
            // Clip
            // CanRedo
            // CanUndo
            // Caret..
            //textBox.C

            // Forcing the CommandManager to raise the RequerySuggested event
            //CommandManager.InvalidateRequerySuggested();
        }

        private void NewFileCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void OpenFileCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void SaveFileCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void SaveAsCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void PrintCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void DeleteCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void FindCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ReplaceCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void HelpCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void GotoCommand(Object sender, ExecutedRoutedEventArgs e)
        {
            
        }

        private void TimeDateCommand(Object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void WordWrapCommand(Object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void FontCommand(Object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void StatusCommand(Object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void AboutCommand(Object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
