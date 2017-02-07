using System;
using System.Collections.Generic;
using System.ComponentModel;
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


namespace BinaryPuzzleSolver
{
public class puzzleSize : INotifyPropertyChanged
    {
        private int size;
        public int Size
        {
            get { return this.size; }
            set
            {
                if(this.size != value)
                {
                    this.size = value;
                    this.NotifyPropertyChanged("Size");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private puzzleSize puzzle = new puzzleSize() { Size = 1 };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void puzzleSizeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            puzzle.Size = 2;
        }
    }
    
}
