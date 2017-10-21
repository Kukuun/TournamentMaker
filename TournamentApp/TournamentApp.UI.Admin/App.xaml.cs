using Autofac;
using System;
using System.Windows;
using TournamentApp.UI.Admin.Startup;
using TournamentApp.UI.Admin.Views;

namespace TournamentApp.UI {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void Application_Startup(object sender, StartupEventArgs args) {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();
            var mainWindow = container.Resolve<MainWindow>();

            mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
            MessageBox.Show("Unexpected error occured. Please inform the admin." + Environment.NewLine + e.Exception.Message, "Unxpected Error");

            // Means the exception has been handled.
            e.Handled = true;
        }
    }
}