using Autofac;
using TournamentApp.UI.Views;

namespace TournamentApp.UI.Startup {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();

            return builder.Build();
        }
    }
}