using DocumentCirculation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentCirculation.Helpers
{
    class DBController
    {
        private static DatabaseContext context { get; set; }

        public DBController()
        {

        }
        public static DatabaseContext Context
        {
            get
            {
                context = context ?? new DatabaseContext();
                return context;
            }
        }


    }
}
