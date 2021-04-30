using DocumentCirculation.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Model.View
{
    public class DocumentListViewModel : ObservableObject
    {
        public DocumentListViewModel()
        {
            DocumentsList = new ObservableCollection<Document>(DBController.Context.Document.ToList());
        }

        private ObservableCollection<Document> documentsList;

        public ObservableCollection<Document> DocumentsList
        {
            get { return documentsList; }
            set { documentsList = value; }
        }

        private Document currentDocument;

        public Document CurrentDocument
        {
            get { return currentDocument; }
            set
            {
                currentDocument = value;
                
    
            }
        }

        private Command saveChangesDocument;

        public Command SaveChangesDocument
        {
            get
            {
                return saveChangesDocument ?? (
                    saveChangesDocument = new Command(obj =>
                    {

                        DBController.Context.SaveChanges();

                    }));



            }
        }
      
       


    }
}
