﻿using System.Windows;
using VectorGraphicViewer.ViewModels;

namespace VectorGraphicViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainVM mainVM)
        {
            InitializeComponent();
            this.DataContext = mainVM;
        }
    }
}
