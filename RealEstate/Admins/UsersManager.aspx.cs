﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealEstate.BusinessLogic;
using RealEstate.BusinessObjects;
using RealEstate.Common;

namespace RealEstate.Admins
{
    public partial class UsersManager : System.Web.UI.Page
    {
        static string Id = "";
        static bool Insert = false;
        static string Password = "";
        static string Level = "";
        private string Lang = "";
        UsersBL usersBl = new UsersBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbtDeleteT.Attributes.Add("onClick", "javascript:return confirm('Bạn có muốn xóa?');");
                lbtDeleteB.Attributes.Add("onClick", "javascript:return confirm('Bạn có muốn xóa?');");
                NumberClass.OnlyInputNumber(txtOrd);
                //BindGrid();
            }
        }
        private void BindGrid()
        {
            grdUser.DataSource = usersBl.GetList();
            grdUser.DataBind();
            if (grdUser.PageCount <= 1)
            {
                grdUser.PagerStyle.Visible = false;
            }
        }

        protected void grdUser_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            ListItemType itemType = e.Item.ItemType;
            if ((itemType != ListItemType.Footer) && (itemType != ListItemType.Separator))
            {
                if (itemType == ListItemType.Header)
                {
                    object checkBox = e.Item.FindControl("chkSelectAll");
                    if ((checkBox != null))
                    {
                        ((CheckBox)checkBox).Attributes.Add("onClick", "Javascript:chkSelectAll_OnClick(this)");
                    }
                }
                else
                {
                    string tableRowId = grdUser.ClientID + "_row" + e.Item.ItemIndex.ToString();
                    e.Item.Attributes.Add("id", tableRowId);
                    object checkBox = e.Item.FindControl("chkSelect");
                    if ((checkBox != null))
                    {
                        e.Item.Attributes.Add("onMouseMove", "Javascript:chkSelect_OnMouseMove(this)");
                        e.Item.Attributes.Add("onMouseOut", "Javascript:chkSelect_OnMouseOut(this," + e.Item.ItemIndex.ToString() + ")");
                        ((CheckBox)checkBox).Attributes.Add("onClick", "Javascript:chkSelect_OnClick(this," + e.Item.ItemIndex.ToString() + ")");
                    }
                }
            }
        }

        protected void grdUser_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grdUser.CurrentPageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void grdUser_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            string strCA = e.CommandArgument.ToString();
            switch (e.CommandName)
            {
                case "AddSub":
                    Level = strCA;
                    AddButton_Click(source, e);
                    break;
                case "Edit":
                    Insert = false;
                    Id = strCA;
                    List<Users> listE = usersBl.GetByListId(strCA);
                    Level = listE[0].Admin.Substring(0, listE[0].Admin.Length - 5);
                    txtName.Text = listE[0].FullName;
                    txtUsername.Text = listE[0].UserName;
                    txtPassword.Text = "";
                    Password = listE[0].Password;
                    txtAdmin.Text = listE[0].Admin;
                    txtOrd.Text = listE[0].Ord;
                    chkActive.Checked = listE[0].Active == "1" || listE[0].Active == "True";
                    pnView.Visible = false;
                    pnUpdate.Visible = true;
                    break;
                case "Active":
                    string strA = "";
                    string str = e.Item.Cells[2].Text;
                    strA = str == "1" ? "0" : "1";
                    //SqlDataProvider sql = new SqlDataProvider();
                    //sql.ExecuteNonQuery("Update [User] set Active=" + strA + "  Where Id='" + strCA + "'");
                    BindGrid();
                    break;
                case "Delete":
                    usersBl.Delete(strCA);
                    BindGrid();
                    break;
            }
        }
        protected void AddButton_Click(object sender, EventArgs e)
        {
            pnUpdate.Visible = true;
            ControlClass.ResetControlValues(pnUpdate);
            pnView.Visible = false;
            Insert = true;
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridItem item = default(DataGridItem);
            for (int i = 0; i < grdUser.Items.Count; i++)
            {
                item = grdUser.Items[i];
                if (item.ItemType == ListItemType.AlternatingItem | item.ItemType == ListItemType.Item)
                {
                    if (((CheckBox)item.FindControl("ChkSelect")).Checked)
                    {
                        string strId = item.Cells[1].Text;
                        usersBl.Delete(strId);
                    }
                }
            }
            grdUser.CurrentPageIndex = 0;
            BindGrid();
        }

        protected void RefreshButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Users obj = new Users();
                obj.UserID = Id;
                obj.FullName = txtName.Text;
                obj.UserName = txtUsername.Text;
                obj.Level = Level + "00000";
                obj.Admin = txtAdmin.Text != "" ? txtAdmin.Text : "1";
                obj.Ord = txtOrd.Text != "" ? txtOrd.Text : "1";
                obj.Active = chkActive.Checked ? "1" : "0";
                if (Insert == true)
                {
                    obj.Password = txtPassword.Text;
                    usersBl.Add(obj);
                }
                else
                {
                    obj.Password = txtPassword.Text != "" ? StringClass.Encrypt(txtPassword.Text) : Password;
                    usersBl.Add(obj);
                }
                BindGrid();
                pnView.Visible = true;
                pnUpdate.Visible = false;
                Level = "";
                Insert = false;
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            pnView.Visible = true;
            pnUpdate.Visible = false;
            Level = "";
            Insert = false;
        }
    }
}