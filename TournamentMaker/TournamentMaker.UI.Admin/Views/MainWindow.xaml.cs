using System.Windows;
using TournamentMaker.UI.Admin.ViewModels;

namespace TournamentMaker.UI.Admin {
    public partial class MainWindow : Window {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel) {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            Loaded += MainViewModel_Loaded;
        }

        private async void MainViewModel_Loaded(object sender, RoutedEventArgs e) {
            await _viewModel.LoadAsync();
        }
    }
}
