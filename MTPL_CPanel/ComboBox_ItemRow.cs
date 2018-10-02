using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTPL_CPanel
{
    class ComboBox_ItemRow : object
    {
        private String _BRAND_ID;
        private string _BRAND_NAME;
        public ComboBox_ItemRow(String BRAND_ID, String BRAND_NAME)
        {
            _BRAND_ID = BRAND_ID;
            _BRAND_NAME = BRAND_NAME;
        }
        override
            public string ToString()
        {
            return _BRAND_NAME;
        }
        public string getId()
        {
            return _BRAND_ID;
        }
    }
}
