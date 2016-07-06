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
            
        }
    }
}
