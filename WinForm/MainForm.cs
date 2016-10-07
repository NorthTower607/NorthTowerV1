using Domain;
using IBApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            //IB's main object
            //var ibClient = new EWrapperExt();

            ////Connect
            //ibClient.ClientSocket.eConnect("127.0.0.1", 7496, 0);

            ////Create and define a contract to fetch data for
            //var contract = new Contract();
            //contract.Symbol = "EUR";
            //contract.SecType = "CASH";
            //contract.Currency = "GBP";
            //contract.Exchange = "IDEALPRO";

            ////Invoke IB's ClientSocket's data request
            //ibClient.ClientSocket.reqMktData(1, contract, "", false, null);







        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainTextBox.Clear();
        }
    }
}
