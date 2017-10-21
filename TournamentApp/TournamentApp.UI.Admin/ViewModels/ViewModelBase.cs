using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tournament.UI.Admin.ViewModels {
    public class ViewModelBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        // The CallerMemberName attribute eliminates the need of hardcoded strings.
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}