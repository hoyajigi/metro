using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.Common
{
    class CommonData
    {
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        
        public string StartStation { get; set; }
        public string EndStation { get; set; }

        public string way1 { get; set; }
        public string way2 { get; set; }
        public string way1time1 { get; set; }
        public string way1time2 { get; set; }
        public string way2time1 { get; set; }
        public string way2time2 { get; set; }

        public int lastupdatetime { get; set; }

        public void CommonData()
        {
        }


    }
}
