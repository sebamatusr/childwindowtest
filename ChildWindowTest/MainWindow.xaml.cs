using MahApps.Metro.Controls;
using MahApps.Metro.SimpleChildWindow;

namespace ChildWindowTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            // note: ShowChildWindowAsync shows the chidl window in a modal way

            // show the first child window
            this.Loaded += async (o, args) => await this.ShowChildWindowAsync(new UserControl1());

            // show also the other child window, now above the first one
            this.Loaded += async (o, args) => await this.ShowChildWindowAsync(new Window2());
        }
    }
}