using Autofac;
using TournamentMaker.DataAccess;
using TournamentMaker.UI.Admin.Data;
using TournamentMaker.UI.Admin.ViewModels;

namespace TournamentMaker.UI.Admin.Startup {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();

            builder.RegisterType<TournamentDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();

            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<PlayerDataService>().As<IPlayerDataService>();

            return builder.Build();
        }
    }
}
