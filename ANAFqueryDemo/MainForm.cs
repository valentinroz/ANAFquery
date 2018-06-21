using ANAFquery;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ANAFqueryDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSimpleQuery_Click(object sender, EventArgs e)
        {
            QueryItem qiQueryItem = new QueryItem(txtSimpleQuery.Text, DateTime.Today);

            ANAFquery.ANAFquery aq = new ANAFquery.ANAFquery();
            aq.SendRequestForOneItem(qiQueryItem, out string FoundItems, out string NonFoundItems);

            ANAFresult ar = JsonConvert.DeserializeObject<ANAFresult>(FoundItems);

            txtOutput.Text = "Found\n" + FoundItems + "\n\n\n\n\nNonFound\n" + NonFoundItems;
        }

        private void btnMultipleQuery_Click(object sender, EventArgs e)
        {
            string strVATnumbers = txtMultipleQuery.Text;
            string[] arrstrVATnumbers = strVATnumbers.Split(',');

            List<QueryItem> listQueryItems = new List<QueryItem>();

            foreach(string strVATnumber in arrstrVATnumbers)
            {
                listQueryItems.Add(new QueryItem(strVATnumber, DateTime.Today));
            }
            ANAFquery.ANAFquery aq = new ANAFquery.ANAFquery();
            aq.SendRequestForListItem(listQueryItems, out string FoundItems, out string NonFoundItems);

            //TODO: deserializare in List<ANAFresult>

            txtOutput.Text = "Gasite\n" + FoundItems + "\n\n\n\n\nNegasite\n" + NonFoundItems;
        }
    }
}
