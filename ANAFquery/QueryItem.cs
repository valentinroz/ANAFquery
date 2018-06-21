using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANAFquery
{
    public class QueryItem
    {

        public string cui { get; }
        public string data { get; }

        public QueryItem(string VATNumber, DateTime Data)
        {
            this.cui = VATNumber;
            this.data = Data.ToString("yyyy-MM-dd");
        }

    }
}
