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
    }
}
