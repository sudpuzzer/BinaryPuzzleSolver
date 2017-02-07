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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int puzzleSize;

        public MainWindow()
        {
            InitializeComponent();
            puzzleSizeSelector.Text = "Select Size";
        }

        private void puzzleSizeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (puzzleSizeSelector.SelectedIndex)
            {
                case 0:
                    puzzleSize = 2;
                        break;
                case 1:
                    puzzleSize = 3;
                    break;
                case 2:
                    puzzleSize = 4;
                    break;
            }
            puzzleSizeText.Text = puzzleSize.ToString();
        }
    }
    
}
