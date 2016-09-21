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
    public partial class Form1 : Form
    {
        ListViewItem lv = new ListViewItem();
        ListViewItem.ListViewSubItem lsv = new ListViewItem.ListViewSubItem();
                        
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

            //Initialize lv
            lsvIDO.View = View.Details;
            lsvIDO.Columns.Clear();
            lsvIDO.Columns.Add("Collection Name", 180, HorizontalAlignment.Left);
            lsvIDO.Columns.Add("Property Name", 200, HorizontalAlignment.Left);
            lsvIDO.Columns.Add("Data Type", 180, HorizontalAlignment.Left);
            lsvIDO.Columns.Add("Property Class", 180, HorizontalAlignment.Left);
            lsvIDO.Columns.Add("SQL Data Type", 120, HorizontalAlignment.Left);

            //Initialize IDO combobox
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = "GRCDSLSQL0.dom.grc";
            csb.InitialCatalog = "SL_MAN_App";
            csb.UserID = "sa";
            csb.Password = "Macpac600";
            string connString = csb.ToString();
            cboIDOs.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "select distinct CollectionName from idocollectionsview";
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                       while (reader.Read())
                         {
                            cboIDOs.Items.Add(reader["CollectionName"].ToString());

                         }
                    }
                    reader.Close();
                }
                connection.Close();
            }

            cboIDOs.Items.Add("FULL");
            cboIDOs.Text = "AccessAs";
        }

        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            btnGetRecord.Text = "Please Wait...";
            btnGetRecord.Enabled = false;
            btnGetRecord.Refresh();
            
            IDOWebServiceReference.DOWebServiceSoapClient webService = new IDOWebServiceReference.DOWebServiceSoapClient("IDOWebServiceSoap");
            string SessionToken = webService.CreateSessionToken("sa", "mongoose", "01 DEV GR Mansfield");
            txtSessionToken.Text = SessionToken;

            if (cboIDOs.Text == "FULL")
            {
                System.Data.DataSet IdoDataSet = webService.LoadDataSet(
                    SessionToken,
                    "MGCore.IdoProperties",
                    "CollectionName, PropertyName, DataType , PropertyClass, ColumnDataType",
                    "", "", "", 0
                    );

                lsvIDO.Items.Clear();

                try
                {
                    for (int i = 0; i < IdoDataSet.Tables[0].Rows.Count; i++)
                    {
                        lv = lsvIDO.Items.Add(IdoDataSet.Tables[0].Rows[i]["CollectionName"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["PropertyName"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["DataType"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["ColumnDataType"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["PropertyClass"].ToString());

                    }
                }
                catch (Exception x)
                {
                    lblItem.Text = "NO RECORD";
                    lblDescription.Text = "NO RECORD";
                }
                IdoDataSet.Clear();
            }
            else
            {
                System.Data.DataSet IdoDataSet = webService.LoadDataSet(
                SessionToken,
                "MGCore.IdoProperties",
                "CollectionName, PropertyName, DataType , PropertyClass, ColumnDataType",
                "CollectionName=" + "N" + (char)39 + cboIDOs.Text + (char)39 + "", "", "", 0
                );

                lsvIDO.Items.Clear();

                try
                {
                    for (int i = 0; i < IdoDataSet.Tables[0].Rows.Count; i++)
                    {
                        lv = lsvIDO.Items.Add(IdoDataSet.Tables[0].Rows[i]["CollectionName"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["PropertyName"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["DataType"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["ColumnDataType"].ToString());
                        lv.SubItems.Add(IdoDataSet.Tables[0].Rows[i]["PropertyClass"].ToString());
                    }
                }
                catch (Exception x)
                {
                    lblItem.Text = "NO RECORD";
                    lblDescription.Text = "NO RECORD";
                }
                IdoDataSet.Clear();
            }

            btnGetRecord.Text = "Retrieve";
            btnGetRecord.Enabled = true;
            btnGetRecord.Refresh();
        }
    }
}
