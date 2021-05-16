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

namespace DiceRoller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollD20(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 21);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
            
        }

        private void RollD4(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 5);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
        }

        private void RollD6(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 7);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
        }

        private void RollD8(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 9);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
        }

        private void RollD10(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 11);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
        }

        private void RollD12(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 13);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
        }

        private void RollD100(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string modifierText = Modifier.Text;
            int modifier;
            int.TryParse(modifierText, out modifier);

            int dieRoll = random.Next(1, 101);
            int result = dieRoll + modifier;
            ResultText.Text = result.ToString();
        }
    }
}
