using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Helpers
{
    public static class PathCreator
    {
        public static string GetXPSRepositoryPath()
        {
            return Directory.GetCurrentDirectory() + "\\XPSDocuments\\";
        }

        public static string GetWordRepositoryPath()
        {
            return Directory.GetCurrentDirectory() + "\\WordDocuments\\";
        }

        public static string GetFileWordPathFromName(string name)
        {
            return GetWordRepositoryPath() + name + ".docx";
        }


        public static void CreateRepositoryPaths()
        {
            CreateRepositoryPath(GetXPSRepositoryPath());

            CreateRepositoryPath(GetWordRepositoryPath());

        }
        public static void CreateRepositoryPath(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);

            }


            Directory.CreateDirectory(path);


        }



    }
}
