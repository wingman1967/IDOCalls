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
        }

        private void btnConnectToSyteline_Click(object sender, EventArgs e)
        {
            btnConnectToSyteline.Text = "Please Wait...";
            btnConnectToSyteline.Enabled = false;
            btnConnectToSyteline.Refresh();
            
            txtSessionToken.Text = idoConnect.sessionToken;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
