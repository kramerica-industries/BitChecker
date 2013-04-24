using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;

namespace Bitchecker
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void btnSend_Click(object sender, EventArgs e)
        {
            (new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"])).Send(
                "contact-form@bitchecker.com",
                ConfigurationManager.AppSettings["ContactFormRecipient"],
                "BitChecker Contact Form",
                txtMessage.Text);
            Response.Redirect("Sent.aspx");
        }
    }
}