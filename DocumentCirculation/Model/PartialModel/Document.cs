using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentCirculation.Helpers;
using DocumentCirculation.Model;
namespace DocumentCirculation.Model
{
    public partial class Document
    {
        public string Path
        {
            get
            {
                var path = PathCreator.GetFileWordPathFromName(Name);

                if (!System.IO.File.Exists(path))
                {
                    System.IO.File.WriteAllBytes(path, FileRepository);
                }
                return path;
            }
        }
    }
}
