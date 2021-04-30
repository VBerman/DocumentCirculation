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
    /// Логика взаимодействия для DocumentDetailsPage.xaml
    /// </summary>
    public partial class DocumentDetailsPage : Page
    {
        public DocumentDetailsPage()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start((DataContext as ApplicationViewModel).DocumentListViewModel.CurrentDocument.Path);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentDocument = (DataContext as ApplicationViewModel).DocumentListViewModel.CurrentDocument;

 
                currentDocument.FileRepository = System.IO.File.ReadAllBytes(currentDocument.Path);
                currentDocument.LastModified = DateTime.Now;
                DBController.Context.SaveChanges();

            }
            catch (Exception) 
            {
            }
        }
    }
}
