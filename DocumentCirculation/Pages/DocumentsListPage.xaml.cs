using DocumentCirculation.Helpers;
using DocumentCirculation.Model;
using DocumentCirculation.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DocumentCirculation.Pages
{
    /// <summary>
    /// Логика взаимодействия для DocumentsListPage.xaml
    /// </summary>
    public partial class DocumentsListPage : Page
    {
        public DocumentsListPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DocumentDetailsPage());
        }

        private void DataGrid_Selected(object sender, RoutedEventArgs e)
        {
            dv.Document = null;
            var selectedItem = ((sender as DataGrid).SelectedItem as Document);

            (DataContext as ApplicationViewModel).DocumentListViewModel.CurrentDocument = selectedItem;

            dv.Document = Converter.ConvertWordDocToXPSDoc((DataContext as ApplicationViewModel).DocumentListViewModel.CurrentDocument.Path);

        }
    }   
}
