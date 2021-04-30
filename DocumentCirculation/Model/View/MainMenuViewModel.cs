using DocumentCirculation.Helpers;
using DocumentCirculation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DocumentCirculation.Model.View
{
    public class MainMenuViewModel : ObservableObject
    {
        private MainMenu mainMenu { get; set; }
        public MainMenu MainMenu
        {
            get
            {
                mainMenu = mainMenu ?? new MainMenu();
                return mainMenu;
            }
            set => mainMenu = value;
        }

        private Command navigateDocumentAddPage;

        public Command NavigateDocumentAddPage
        {
            get
            {
                return navigateDocumentAddPage ?? (
                    navigateDocumentAddPage = new Command(obj =>
                    {

                        ViewModel.Instanse.MainWindow.MainFrame.Navigate(ViewModel.Instanse.DocumentAddViewModel.DocumentAddPage);

                    }));



            }
        }
    }
}
