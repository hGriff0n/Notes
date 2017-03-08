
using System.Windows.Input;

namespace Notes
{
    public static class Commands
    {
        private static readonly RoutedUICommand gotoCmd = new RoutedUICommand("description", "Goto", typeof(Commands));
        public static RoutedUICommand Goto
        {
            get {
                return gotoCmd;
            }
        }

        private static readonly RoutedUICommand tdCmd = new RoutedUICommand("description", "TimeDate", typeof(Commands));
        public static RoutedUICommand TimeDate
        {
            get {
                return tdCmd;
            }
        }

        private static readonly RoutedUICommand wwCmd = new RoutedUICommand("description", "WordWrap", typeof(Commands));
        public static RoutedUICommand WordWrap
        {
            get {
                return wwCmd;
            }
        }

        private static readonly RoutedUICommand fsCmd = new RoutedUICommand("description", "Font", typeof(Commands));
        public static RoutedUICommand Font
        {
            get {
                return fsCmd;
            }
        }

        private static readonly RoutedUICommand statusCmd = new RoutedUICommand("description", "Status", typeof(Commands));
        public static RoutedUICommand Status
        {
            get {
                return statusCmd;
            }
        }

        private static readonly RoutedUICommand aboutCmd = new RoutedUICommand("description", "About", typeof(Commands));
        public static RoutedUICommand About
        {
            get {
                return aboutCmd;
            }
        }

        private static readonly RoutedUICommand tabCmd = new RoutedUICommand("description", "Tab", typeof(Commands));
        public static RoutedUICommand Tab
        {
            get {
                return tabCmd;
            }
        }
    }
}
