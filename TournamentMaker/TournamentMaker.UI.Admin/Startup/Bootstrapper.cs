using Autofac;
using Prism.Events;
using TournamentMaker.DataAccess;
using TournamentMaker.UI.Admin.Data;
using TournamentMaker.UI.Admin.Interfaces;
using TournamentMaker.UI.Admin.ViewModels;

namespace TournamentMaker.UI.Admin.Startup {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<TournamentDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();

            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<PlayerViewModel>().As<IPlayerViewModel>();
            builder.RegisterType<PlayerNavigationViewModel>().As<IPlayerNavigationViewModel>();
            builder.RegisterType<PlayerDetailViewModel>().As<IPlayerDetailViewModel>();
            builder.RegisterType<PlayerCreationViewModel>().As<IPlayerCreationViewModel>();

            builder.RegisterType<TeamViewModel>().As<ITeamViewModel>();

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<PlayerDataService>().As<IPlayerDataService>();

            return builder.Build();
        }
    }
}
