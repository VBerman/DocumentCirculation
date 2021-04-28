﻿using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;

namespace DocumentCirculation.Helpers
{
    class Converter
    {
        public static FixedDocumentSequence ConvertWordDocToXPSDoc(string wordDocName)
        {
            var wordApplication = new Application();
            wordApplication.Documents.Add(wordDocName);

            var doc = wordApplication.ActiveDocument;

            try
            {
               
                var xpsDocName = GetXPSRepositoryPath() + Path.GetFileNameWithoutExtension(wordDocName) + ".xps";

                doc.SaveAs(xpsDocName, WdSaveFormat.wdFormatXPS);

                wordApplication.Quit();



                XpsDocument xpsDoc = new XpsDocument(xpsDocName, System.IO.FileAccess.Read);

                return xpsDoc.GetFixedDocumentSequence();
            }
            catch (Exception)
            {


            }
            return null;
        }


        public static string GetXPSRepositoryPath()
        {
            return Directory.GetCurrentDirectory() + "/XPSDocuments/";
        }
    }
}
