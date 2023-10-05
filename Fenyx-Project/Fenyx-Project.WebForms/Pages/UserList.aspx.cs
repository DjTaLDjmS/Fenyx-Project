using Fenyx_Project.WebForms.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenyx_Project.WebForms.Pages
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateList();
            }
        }

        private void PopulateList()
        {
            var client = new UserServiceReference.UserServiceClient();
            var users = client.FindAllUsers();
            GridViewUsers.DataSource = users;
            GridViewUsers.DataBind();
        }

        protected void GridViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid idUser = new Guid();
            if (Guid.TryParse(GridViewUsers.SelectedDataKey.Value.ToString(), out idUser))
            {
                var client = new UserServiceReference.UserServiceClient();
                var user = client.FindUser(idUser);

                if (user != null)
                {
                    ViewState["IdUser"] = idUser;
                    txtFirstName.Text = user.FirstName;
                    txtLastName.Text = user.LastName;
                    txtBirthdate.Text = user.Birthdate.ToString("dd/MM/yyyy");
                    txtPhoto.Text = user.PhotoUrl;
                    txtStreet.Text = user.AddressStreet;
                    txtZipcode.Text = user.AddressZipcode.ToString();
                    txtCity.Text = user.AddressCity;
                }
            }
        }

        protected void BtnAddUser_Click(object sender, EventArgs e)
        {
            UserContract user = new UserContract();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Birthdate = DateTime.Parse(txtBirthdate.Text);
            user.PhotoUrl = txtPhoto.Text;
            user.AddressStreet = txtStreet.Text;
            user.AddressZipcode = int.Parse(txtZipcode.Text);
            user.AddressCity = txtCity.Text;

            var client = new UserServiceReference.UserServiceClient();
            var userReturn = client.AddUser(user);

            PopulateList();

            ResetTextBoxes();
        }

        protected void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (ViewState["IdUser"] != null)
            {
                UserContract user = new UserContract();
                user.Id = Guid.Parse(ViewState["IdUser"].ToString());
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Birthdate = DateTime.Parse(txtBirthdate.Text);
                user.PhotoUrl = txtPhoto.Text;
                user.AddressStreet = txtStreet.Text;
                user.AddressZipcode = int.Parse(txtZipcode.Text);
                user.AddressCity = txtCity.Text;

                var client = new UserServiceReference.UserServiceClient();
                var userReturn = client.UpdateUser(user);

                PopulateList();

                ResetTextBoxes();
            }
        }

        protected void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (ViewState["IdUser"] != null)
            {
                Guid id = Guid.Parse(ViewState["IdUser"].ToString());
                var client = new UserServiceReference.UserServiceClient();
                client.DeleteUser(id);

                PopulateList();

                ResetTextBoxes();
            }
        }

        private void ResetTextBoxes()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtBirthdate.Text = String.Empty;
            txtPhoto.Text = String.Empty;
            txtStreet.Text = String.Empty;
            txtZipcode.Text = String.Empty;
            txtCity.Text = String.Empty;
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }
    }
}