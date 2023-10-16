using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenyx_Project.WebForms.Pages
{
    public partial class UserControl : System.Web.UI.UserControl
    {
        private string pageTitle;
        public event EventHandler PageTitleUpdated;

        protected void BtnUpdatePageTitle_Click(object sender, EventArgs e)
        {
            this.pageTitle = txtPageTitle.Text;
            PageTitleUpdated?.Invoke(this, EventArgs.Empty);
        }

        public string PageTitle
        {
            get { return pageTitle; }
        }
    }
}