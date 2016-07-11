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
        public IDOConnection idoConnect;

        public Form1()
        {
            InitializeComponent();
            idoConnect = new IDOConnection();
            txtSessionToken.Text = idoConnect.sessionToken;
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            string customerList = "";
            this.callResults.Text = "";
           System.Data.DataSet results = idoConnect.getCustomers();
            for(int i = 0; i < results.Tables[0].Rows.Count; i++ )
            {
                customerList += results.Tables[0].Rows[i]["Name"].ToString() + "\r\n";
            }
            this.callResults.Text = customerList;
        }
    }

}
