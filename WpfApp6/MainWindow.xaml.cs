﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Phone> ListPhones { get; set; }
        public Phone SelectedPhone { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ListPhones = new ObservableCollection<Phone>();
            DataContext = this;

            for (int i = 0; i < 5; i++)
            {
                Phone phone = new Phone();
                phone.Name = "sdsd";
                phone.Price = 90;
                ListPhones.Add(phone);
            }

        }
         
    }
}
