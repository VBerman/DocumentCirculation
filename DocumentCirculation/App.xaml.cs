using DocumentCirculation.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DocumentCirculation
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Directory.Delete(PathCreator.GetXPSRepositoryPath(), true);

            Directory.CreateDirectory(PathCreator.GetXPSRepositoryPath());
        }
    }
}
