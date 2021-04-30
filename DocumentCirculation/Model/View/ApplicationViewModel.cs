using DocumentCirculation.Helpers;
using DocumentCirculation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DocumentCirculation.Model.View
{
    public class ApplicationViewModel : ObservableObject
    {
        public ApplicationViewModel()
        {
            DocumentAddViewModel = new DocumentAddViewModel();
            DocumentListViewModel = new DocumentListViewModel();
            SettingsViewModel = new SettingsViewModel();
            MainMenuViewModel = new MainMenuViewModel();
            AuthorizationViewModel = new AuthorizationViewModel();
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
        //todo: отслеживать закрытие процесса
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


        private MainMenuViewModel mainMenuViewModel;

        public MainMenuViewModel MainMenuViewModel
        {
            get { return mainMenuViewModel; }
            set { mainMenuViewModel = value; }
        }

        private AuthorizationViewModel authorizationViewModel;

        public AuthorizationViewModel AuthorizationViewModel
        {
            get { return authorizationViewModel; }
            set { authorizationViewModel = value; }
        }



        private MainWindow mainWindow;

        public MainWindow MainWindow
        {
            get
            {
                mainWindow = mainWindow ?? new MainWindow();
                mainWindow.Show();
                return mainWindow;
            }
            set
            {
                mainWindow = value;
            }
            
        }

        private Command back;

        public Command Back
        {
            get
            {
                return back ?? (
                    back = new Command(obj =>
                    {


                        if (MainWindow.MainFrame.CanGoBack);
                        {
                        MainWindow.MainFrame.GoBack();
                        }

                    }));



            }
        }


        public DocumentDetailsPage DocumentDetails { get; set; }

        public DocumentsListPage DocumentList { get; set; }

        public SettingsPage SettingsPage { get; set; }

    }
}
