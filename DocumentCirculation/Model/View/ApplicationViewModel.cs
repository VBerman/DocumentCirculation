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
        }
        private DocumentAddViewModel documentAddViewModel;

        public DocumentAddViewModel DocumentAddViewModel
        {
            get { return documentAddViewModel; }
            set { documentAddViewModel = value;
                OnPropertyChanged();
            }
        }
        

    }
}
