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


namespace IDOCalls
{
    public partial class Form1 : Form
    {

                
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOpenSession_Click(object sender, EventArgs e)
        {
            string requestServiceURL = "http://grcdslutil/IDORequestService/RequestService.aspx";
            Client client = new Client(requestServiceURL, IDOProtocol.Http);
            OpenSessionResponseData response = new OpenSessionResponseData();

            using (client)
            {
                response = client.OpenSession("sldatacollection", "mongoose", "01 DEV GR Mansfield");
                if (response.LogonSucceeded)
                {
                    
                    lblStatus.Text = "Session:  OPEN";
                    lblStatus.Refresh();
                    MessageBox.Show("Logged in");
                }
                else
                {
                    lblStatus.Text = "Session:  CLOSED";
                    lblStatus.Refresh();
                    MessageBox.Show("An Error occurred.  Logged out");
                }

                MessageBox.Show("About To Close Session");
                client.CloseSession();
                lblStatus.Text = "Session:  CLOSED";

            }

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Session:  CLOSED";
            lblItem.Text = "NO RECORD";
            lblDescription.Text = "NO RECORD";
        }

        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            btnGetRecord.Text = "Please Wait...";
            btnGetRecord.Enabled = false;
            btnGetRecord.Refresh();
            
            IDOWebServiceReference.DOWebServiceSoapClient webService = new IDOWebServiceReference.DOWebServiceSoapClient("IDOWebServiceSoap");
            string SessionToken = webService.CreateSessionToken("idotest", "dnetpvcomm", "01 DEV GR Mansfield");
            txtSessionToken.Text = SessionToken;

            System.Data.DataSet IdoDataSet = webService.LoadDataSet(
                SessionToken,
                "SL.SLCoitems",
                "Item, Description",
                "co_num = " + (char)39 + txtOrderNumber.Text + (char)39 + " and co_line = " + (char)39 + txtLineNumber.Text + (char)39,
                "", "", -1
                );

            lblItem.Text = "NO RECORD";
            lblDescription.Text = "NO RECORD";

            try
            {
                for (int i = 0; i < IdoDataSet.Tables[0].Rows.Count; i++)
                {
                    lblItem.Text = IdoDataSet.Tables[0].Rows[i]["Item"].ToString();
                    lblDescription.Text = IdoDataSet.Tables[0].Rows[i]["Description"].ToString();
                }
            }
            catch (Exception x)
            {
                lblItem.Text = "NO RECORD";
                lblDescription.Text = "NO RECORD";
            }

            IdoDataSet.Clear();

            btnGetRecord.Text = "Retrieve Record";
            btnGetRecord.Enabled = true;
            btnGetRecord.Refresh();
        }
    }
}
