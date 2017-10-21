using Autofac;
using TournamentApp.UI.Admin.Views;

namespace TournamentApp.UI.Admin.Startup {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();

            return builder.Build();
        }
    }
}