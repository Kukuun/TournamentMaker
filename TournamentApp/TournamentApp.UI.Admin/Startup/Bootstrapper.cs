using Autofac;
using Tournament.UI.Admin.Data;
using Tournament.UI.Admin.Interfaces;
using Tournament.UI.Admin.ViewModels;
using TournamentApp.DataAccess;
using TournamentApp.UI.Admin.Views;

namespace TournamentApp.UI.Admin.Startup {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();

            //builder.RegisterType<TournamentDbContext>().AsSelf().SingleInstance();
            builder.RegisterType<TournamentDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<PlayerDataService>().As<IPlayerDataService>();

            return builder.Build();
        }
    }
}