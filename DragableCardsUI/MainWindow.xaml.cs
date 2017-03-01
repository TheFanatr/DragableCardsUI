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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragableCardsUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Storyboard cardDragStart = Resources["CardDragStartAnimation"] as Storyboard;
            Storyboard cardDragStop = Resources["CardDragStopAnimation"] as Storyboard;
            DragablzItem.IsDraggingChanged += (s, e) =>
            {
                if (DragablzItem.IsDragging) cardDragStart.Begin();
                else cardDragStop.Begin();
            };
            DragHandle.MouseEnter += (s, e) => Cursor = Cursors.SizeAll;
            DragHandle.MouseLeave += (s, e) => Cursor = Cursors.Arrow;
        }
    }
}
