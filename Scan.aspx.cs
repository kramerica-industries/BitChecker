using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;

namespace Bitchecker
{
    public partial class Scan : System.Web.UI.Page
    {
        public Scan() { }

        protected void btnScan_Click(object sender, EventArgs e)
        {
            frmMain.Visible = false;

            bool rogue = false;
            var bits = new BitArray(ctlFile.FileBytes);
            foreach (bool bit in bits)
                if (bit != true && bit != false) rogue = true;

            litScanResults.Text += "<p>Your file has been successfully scanned.</p>";
            litScanResults.Text += "<p><b>Content Type: " + ctlFile.PostedFile.ContentType + "</b></p>";
            litScanResults.Text += "<p><b>File Size: " + ctlFile.PostedFile.ContentLength.ToString() + "</b></p>";
            if (bool.Parse(ConfigurationManager.AppSettings["ShowExperimentalFeatures"]))
                litScanResults.Text += "<p><b>Bits in File: " + bits.Count + "</b></p>";

            litScanResults.Text += "<p>&nbsp;</p>";
            if (rogue)
                litScanResults.Text += "<p>At least one rogue bit was detected! Use the Professional Edition (coming soon) to detect and correct this error.</p>";
            else
                litScanResults.Text += "<p>Congratulations! No rogue bits were found.";
        }
    }
}