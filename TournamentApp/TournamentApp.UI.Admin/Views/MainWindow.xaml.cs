using System;
using System.Windows;
using Tournament.UI.Admin.ViewModels;

namespace TournamentApp.UI.Admin.Views {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel) {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainViewModel_Loaded;
        }

        private void MainViewModel_Loaded(object sender, RoutedEventArgs e) {
            //throw new NotImplementedException();
        }
    }
}