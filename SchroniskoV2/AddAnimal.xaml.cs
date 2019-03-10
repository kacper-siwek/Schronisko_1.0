using SchroniskoV2.Business_Logic;
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
using System.Windows.Shapes;

namespace SchroniskoV2
{
    /// <summary>
    /// Interaction logic for AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Window
    {
        public AddAnimal()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddAnimalButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ShelterManager.Add(AnimalName.Text, AnimalType.Text);
                AnimalName.Clear();
                AnimalType.Clear();
            }
            catch (AnimalsAmountExceededException ex)
            {
                MessageBox.Show("Wykryto błąd: " + ex.Message);
            }
        }
    }
}
