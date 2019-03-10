﻿using SchroniskoV2.Business_Logic;
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

namespace SchroniskoV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// todo:
    /// zapisywanie i wczytywanie stanu, przycisk 'Wyjscie'
    /// wyświetlanie obecnego stanu schroniska na górze, bez klikania w "Status"
    /// eleganckie usuwanie zwierzaków - używając ObservableCollection i INotifyCollectionChanged. Do tego usuwanie wielu na raz.
    /// regex na wbijanie zwierzakóws
    /// baza
    /// elegancki zapis i odczyt, niehardkodowany jak jest teraz
    /// wyświetlanie daty i godziny
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            var addAnimal = new AddAnimal();
            addAnimal.Show();
        }
        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            var removeAnimalWindow = new RemoveAnimalWindow();
            removeAnimalWindow.Show();
        }
        private void Status_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Zarejestrowano obecnie {ShelterManager.Count()} zwierząt. Maksymalna liczba zwierząt " +
                $"w schronisku to {ShelterManager.LimitZwierzat} zwierząt.");
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ShelterManager.ListAnimalsString(), "Lista zwierząt");
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            ShelterManager.SaveAllAnimals(false);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ShelterManager.SaveAllAnimals(true);

            System.Windows.Application.Current.Shutdown();
        }
    }
}
