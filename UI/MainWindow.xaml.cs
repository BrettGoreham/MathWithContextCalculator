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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MathViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.viewModel = new MathViewModel();
            this.DataContext = viewModel;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            String text = EquationBox.Text;
            EquationBox.Text = "";
            viewModel.handleEquationSubmit(text);
        }
    }
}
