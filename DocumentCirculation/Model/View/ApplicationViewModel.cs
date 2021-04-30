using DocumentCirculation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Model.View
{
    public class ApplicationViewModel : ObservableObject
    {
        public ApplicationViewModel()
        {
            DocumentAddViewModel = new DocumentAddViewModel();
            DocumentListViewModel = new DocumentListViewModel();
            SettingsViewModel = new SettingsViewModel();
        }
        private DocumentAddViewModel documentAddViewModel;

        public DocumentAddViewModel DocumentAddViewModel
        {
            get { return documentAddViewModel; }
            set
            {
                documentAddViewModel = value;
                OnPropertyChanged();
            }
        }

        private DocumentListViewModel documentListViewModel;

        public DocumentListViewModel DocumentListViewModel
        {
            get { return documentListViewModel; }
            set
            {
                documentListViewModel = value;
                OnPropertyChanged();
            }
        }

        private SettingsViewModel settingsViewModel;

        public SettingsViewModel SettingsViewModel
        {
            get { return settingsViewModel; }
            set { settingsViewModel = value; }
        }


    }
}
