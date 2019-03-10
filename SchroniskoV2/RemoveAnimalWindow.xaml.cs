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
    /// Interaction logic for RemoveAnimalWindow.xaml
    /// </summary>
    public partial class RemoveAnimalWindow : Window
    {
        public RemoveAnimalWindow()
        {
            InitializeComponent();

            List<Animal> animalClasses = ShelterManager.ListAnimals();
            AnimalsList.ItemsSource = animalClasses;
        }


        
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var content = AnimalsList.SelectedItem as Animal;
            
            ShelterManager.RemoveAnimal(content);

            var animalClasses = ShelterManager.ListAnimals();
            AnimalsList.ItemsSource = animalClasses;
        }
    }
}
