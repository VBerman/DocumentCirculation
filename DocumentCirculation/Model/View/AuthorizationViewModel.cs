using DocumentCirculation.Helpers;
using DocumentCirculation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Model.View
{
    public class AuthorizationViewModel : ObservableObject
    {

        private AuthorizationPage authorizationPage;

        public AuthorizationPage AuthorizationPage
        {
            get
            {
                authorizationPage = authorizationPage ?? new AuthorizationPage();
                return authorizationPage;
            }
            set { authorizationPage = value; }
        }

        private Command login;

        public Command Login
        {
            get
            {
                return login ?? (
                    login = new Command(obj =>
                    {

                        ViewModel.Instanse.MainWindow.MainFrame.Navigate(ViewModel.Instanse.MainMenuViewModel.MainMenu);

                    }));



            }
        }
    }
}
