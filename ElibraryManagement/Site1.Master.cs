using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible=true; // User login link button
                    LinkButton2.Visible=true; // Sign up link button

                    LinkButton3.Visible = false; // Logout link button
                    LinkButton7.Visible = false; // Hello User link button

                    LinkButton6.Visible = true; // Admin login link button
                    LinkButton11.Visible = false; // Author Management link button
                    LinkButton12.Visible = false; // Publisher Management link button
                    LinkButton8.Visible = false; // Book Inventory link button
                    LinkButton9.Visible = false; // Book issuing link button
                    LinkButton10.Visible = false; // Member Management link button
                }
                else if(Session["role"].Equals("user"))
                {

                    LinkButton1.Visible = false; // User login link button
                    LinkButton2.Visible = false; // Sign up link button

                    LinkButton3.Visible = true; // Logout link button
                    LinkButton7.Visible = true; // Hello User link button
                    LinkButton7.Text = "Hello "+ Session["username"].ToString();

                    LinkButton6.Visible = true; // Admin login link button
                    LinkButton11.Visible = false; // Author Management link button
                    LinkButton12.Visible = false; // Publisher Management link button
                    LinkButton8.Visible = false; // Book Inventory link button
                    LinkButton9.Visible = false; // Book issuing link button
                }
                else if (Session["role"].Equals("admin"))
                {

                    LinkButton1.Visible = false; // User login link button
                    LinkButton2.Visible = false; // Sign up link button

                    LinkButton3.Visible = true; // Logout link button
                    LinkButton7.Visible = true; // Hello User link button
                    LinkButton7.Text = "Hello Admin";

                    LinkButton6.Visible = false; // Admin login link button
                    LinkButton11.Visible = true; // Author Management link button
                    LinkButton12.Visible = true; // Publisher Management link button
                    LinkButton8.Visible = true; // Book Inventory link button
                    LinkButton9.Visible = true; // Book issuing link button
                }
            }
            catch (Exception ex)
                {

                }
            

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

                LinkButton1.Visible = true; // User login link button
                LinkButton2.Visible = true; // Sign up link button

                LinkButton3.Visible = false; // Logout link button
                LinkButton7.Visible = false; // Hello User link button

                LinkButton6.Visible = true; // Admin login link button
                LinkButton11.Visible = false; // Author Management link button
                LinkButton12.Visible = false; // Publisher Management link button
                LinkButton8.Visible = false; // Book Inventory link button
                LinkButton9.Visible = false; // Book issuing link button
                LinkButton10.Visible = false; // Member Management link button

        }
    }
}