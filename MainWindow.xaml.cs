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
     * Get the scroll bar working properly
     * Also need to find a way to move the sub-menus into the app window
     * Move Command logic into a separate class (once I've figured out how to add all commands)
     * Implement all of the commands in the menu bar
     * Improve the appearance of the drop-down menus
     * Add in ability to have multiple notes open at once (needs gui)
     */

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int tabSize = 4;
        private String currentFile = "";

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
            // But Ctrl-Z pretty much already does this

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

        private void PageStylingCommand(Object sender, ExecutedRoutedEventArgs e)
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

        private void TabCommand(Object sender, ExecutedRoutedEventArgs e)
        {
            var pos = textBox.CaretIndex;

            // Insert spaces instead of tabs
            textBox.Text = textBox.Text.Insert(pos, new string(' ', tabSize));
            textBox.CaretIndex = pos + tabSize;

            // Insert spaces to alignment
            //var lineStart = textBox.GetCharacterIndexFromLineIndex(textBox.GetLineIndexFromCharacterIndex(pos));
            //var indent = tabSize * ((pos - lineStart + tabSize) / tabSize);
            //textBox.Text = textBox.Text.Insert(pos, new string(' ', indent - (pos - lineStart)));
            //textBox.CaretIndex = lineStart + indent;

            // Tab insertion (oddly equal to 5 spaces)
            //textBox.Text = textBox.Text.Insert(pos, "\t");
            //textBox.CaretIndex = pos + 1;

            // Unfortunately, I don't think I can have tabbing to alignment

            e.Handled = true;
        }

        private void DoNothingDefault(Object sender, ExecutedRoutedEventArgs e) {}
    }
}
