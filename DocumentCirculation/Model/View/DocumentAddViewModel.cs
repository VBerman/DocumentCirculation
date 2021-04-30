using DocumentCirculation.Helpers;
using DocumentCirculation.Pages;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentCirculation.Model.View
{
    public class DocumentAddViewModel : ObservableObject
    {
        public DocumentAddViewModel()
        {
            FolderStorage = new FileStorage();

        }
        private bool isOneFile;

        public bool IsOneFile
        {
            get { return isOneFile; }
            set { isOneFile = value; }
        }

        private FileStorage folderStorage;

        public FileStorage FolderStorage
        {
            get { return folderStorage; }
            set
            {
                folderStorage = value;
                OnPropertyChanged();
            }
        }

        private Command chooseFile;

        public Command ChooseFile
        {
            get
            {
                return chooseFile ??
                    (chooseFile = new Command(obj =>
                    {
                        if (IsOneFile)
                        {
                            var dialog = new OpenFileDialog();
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {

                                FolderStorage.Path = dialog.FileName;


                            }
                        }
                        else
                        {
                            var dialog = new CommonOpenFileDialog("Choose base folder");
                            dialog.IsFolderPicker = true;
                            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                            {
                                FolderStorage.Path = dialog.FileName;
                                FolderStorage.ReadAllFiles();
                            }
                        }
                    }));
            }

        }

        private Command loadFiles;

        public Command LoadFiles
        {
            get
            {
                return loadFiles ?? (
                    loadFiles = new Command(obj =>
                    {
                        FolderStorage.LoadFiles();
                        DBController.Context.SaveChanges();

                    }));



            }
        }
        private DocumentAddPage documentAddPage;

        public DocumentAddPage DocumentAddPage
        {
            get
            {
                documentAddPage = documentAddPage ?? new DocumentAddPage();
                return documentAddPage;
            }
            set { documentAddPage = value; }
        }

    }
}
