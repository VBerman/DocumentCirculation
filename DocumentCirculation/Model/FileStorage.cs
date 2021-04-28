using DocumentCirculation.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Model
{
    public class FileStorage : ObservableObject
    {

        public FileStorage()
        {

            Files = new ObservableCollection<FileStorage>();


        }
        private ObservableCollection<FileStorage> files;

        public ObservableCollection<FileStorage> Files
        {
            get { return files; }
            set
            {
                files = value;
                OnPropertyChanged();
            }
        }


        public string ShortPath
        {
            get
            {
                
                return System.IO.Path.GetFileName(Path);
            }
        }


        public void ReadAllFiles()
        {
            Files.Clear();

            foreach (var fileName in Directory.GetFiles(Path, "*.docx"))
            {
                Files.Add(new FileStorage() { Path = fileName, IsCurrent = true });
            }
            foreach (var directoryName in Directory.GetDirectories(Path))
            {
                var folder = new FileStorage() { Path = directoryName, IsCurrent = true, IsFolder = true };

                
                folder.ReadAllFiles();
                Files.Add(folder);
            }
        }

        private string path;

        public string Path
        {
            get { return path; }
            set
            {
                path = value;

                OnPropertyChanged();
            }
        }

        private bool isCurrent;

        public bool IsCurrent
        {
            get { return isCurrent; }
            set
            {
                isCurrent = value;
                
                foreach (var item in Files)
                {
                    item.IsCurrent = value;
                }
                OnPropertyChanged();

            }

        }


        private bool isFolder;

        public bool IsFolder
        {
            get { return isFolder; }
            set { isFolder = value;}
        }

        private void LoadFiles()
        {
            
        }
    }
}
