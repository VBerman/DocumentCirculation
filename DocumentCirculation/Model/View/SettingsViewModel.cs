using DocumentCirculation.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Model.View
{
    public class SettingsViewModel : ObservableObject
    {
        public static bool IsShowPreview
        {
            get => Properties.Settings.Default.IsShowPreview;
            set
            {
                Properties.Settings.Default.IsShowPreview = value;
                
                Properties.Settings.Default.Save();

            }
        }

        public static string ConverterShowPreview
        {
            get
            {
                if (IsShowPreview)
                {
                    return "Visible";
                }
                else
                {
                    return "Collapsed";
                }
            }
        }
    }
}
