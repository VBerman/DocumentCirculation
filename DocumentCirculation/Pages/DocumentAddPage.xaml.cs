using DocumentCirculation.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для DocumentAddPage.xaml
    /// </summary>
    public partial class DocumentAddPage : Page
    {
        public DocumentAddPage()
        {
            InitializeComponent();
            
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var selectedItem = ((sender as TreeView).SelectedItem as FileStorage);
            if (!selectedItem.IsFolder)
            {
                
                dv.Document = Helpers.Converter.ConvertWordDocToXPSDoc(selectedItem.Path, selectedItem.CountOpen += 1);
                selectedItem.CountOpen += 1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
