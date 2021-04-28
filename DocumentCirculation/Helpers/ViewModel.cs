using DocumentCirculation.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Helpers
{
    class ViewModel
    {
        private static ApplicationViewModel instanse { get; set; }

        public ViewModel()
        {

        }
        public static ApplicationViewModel Instanse
        {
            get
            {
                instanse = instanse ?? new ApplicationViewModel();
                return instanse;
            }
        }
    }
}
