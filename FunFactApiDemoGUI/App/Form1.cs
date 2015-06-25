using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunFactApiDemoGUI.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTrivia_Click(object sender, EventArgs e)
        {
            GetFunFact("trivia");
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            GetFunFact("math");
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            GetFunFact("date");
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            GetFunFact("year");
        }

        private void GetFunFact(string type)
        {
            /* If something happened or the user wanted to exit, break out of the loop */
            if (type == null)
            {
                Environment.Exit(0);
            }

            /* Get a new ApiCaller */
            ApiCaller apiCaller = new ApiCaller();

            /* Get a new ApiCommand using the type the user wanted */
            ApiCommand apiCommand = new ApiCommand(type);

            /* Download the data from the api */
            ApiResponse apiResponse = apiCaller.ExecutApiCommand(apiCommand);

            /* Show the user the random fact */
            lblOutput.Text = apiResponse.RandomFact;
        }
    }
}
