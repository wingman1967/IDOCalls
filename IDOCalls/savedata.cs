using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mongoose;
using Mongoose.IDO;
using Mongoose.Core.Configuration;
using Mongoose.Core.Common;
using Mongoose.IDO.Protocol;
using Mongoose.Core.DataAccess;
using Mongoose.Core.Extensions;
using System.Data.SqlClient;

namespace IDOCalls
{
    public partial class savedata : Form
    {
        public savedata(string SessionToken)
        {
            InitializeComponent();
            txtSessionToken.Text = SessionToken;
        }
               

        private void btnSavePatent_Click(object sender, EventArgs e)
        {
            IDOWebServiceReference.DOWebServiceSoapClient webService = new IDOWebServiceReference.DOWebServiceSoapClient("IDOWebServiceSoap");
            string SessionToken = webService.CreateSessionToken("sa", "mongoose", "01 DEV GR Mansfield");

            DataSet PatentDataset;
            DataTable idoTable;
            DataRow newPatent;
            PatentDataset = new DataSet("GR_Patents");
            idoTable = PatentDataset.Tables.Add("IDO");
            idoTable.Columns.Add("Comments", typeof(string));
            idoTable.Columns.Add("Country", typeof(string));
            idoTable.Columns.Add("Expiration", typeof(string));
            idoTable.Columns.Add("Patent", typeof(string));
            idoTable.Columns.Add("Print_on_nameplate", typeof(string));
            newPatent = idoTable.Rows.Add(new object[] { txtComments.Text, txtCountry.Text, txtExpiration.Text, txtPatent.Text, txtPrintOnNamePlate.Text });
            webService.SaveDataSet(SessionToken, PatentDataset, true, "", "", "");
        }
    }
}
