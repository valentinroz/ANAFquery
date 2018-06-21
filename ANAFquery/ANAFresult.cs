using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANAFquery
{
    public class ANAFresult
    {
        public string cui { get; set; }
        public string data { get; set; }
        public string denumire { get; set; }
        public string adresa { get; set; }
        public string scpTVA { get; set; }
        public string data_sfarsit_ScpTVA { get; set; }
        public string data_anul_imp_ScpTVA { get; set; }
        public string mesaj_ScpTVA { get; set; }
        public string dataInceputTvaInc { get; set; }
        public string dataSfarsitTvaInc { get; set; }
        public string dataActualizareTvaInc { get; set; }
        public string dataPublicareTvaInc { get; set; }
        public string tipActTvaInc { get; set; }
        public string statusTvaIncasare { get; set; }
        public string dataInactivare { get; set; }
        public string dataReactivare { get; set; }
        public string dataPublicare { get; set; }
        public string dataRadiere { get; set; }
        public string statusInactivi { get; set; }
        public string dataInceputSplitTVA { get; set; }
        public string dataAnulareSplitTVA { get; set; }
        public string statusSplitTVA { get; set; }

    }
}
