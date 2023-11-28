﻿using System;
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

namespace Student_management_system.UserInterfaces
{
    /// <summary>
    /// Interaction logic for AddLecturerWindow.xaml
    /// </summary>
    public partial class AddLecturerWindow : Window
    {
        public AddLecturerWindow(AddLecturerWindowVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }
    }
}