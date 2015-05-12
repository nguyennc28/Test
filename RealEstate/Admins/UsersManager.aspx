<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UsersManager.aspx.cs" Inherits="RealEstate.Admins.UsersManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="PageName">Quản lý người dùng</div>
    <asp:Panel ID="pnView" runat="server">
        <div class="Control">
            <ul>
                <li>
                    <asp:LinkButton CssClass="vadd" ID="lbtAddT"
                        runat="server" OnClick="AddButton_Click">Thêm mới</asp:LinkButton></li>
                <li>
                    <asp:LinkButton CssClass="vdelete" ID="lbtDeleteT" runat="server"
                        OnClick="DeleteButton_Click">Xóa</asp:LinkButton></li>
                <li>
                    <asp:LinkButton CssClass="vrefresh" ID="lbtRefreshT" runat="server"
                        OnClick="RefreshButton_Click">Làm mới</asp:LinkButton></li>
                <li><a class="vback" href="javascript:void(0);" onclick="window.history.go(-1);">Trở lại</a> </li>
            </ul>
        </div>
        <asp:DataGrid ID="grdUser" runat="server" Width="100%" CssClass="TableView"
            AutoGenerateColumns="False"
            OnItemCommand="grdUser_ItemCommand" OnItemDataBound="grdUser_ItemDataBound"
            OnPageIndexChanged="grdUser_PageIndexChanged" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowSorting="True">
            <FooterStyle BackColor="Tan" />
            <HeaderStyle CssClass="trHeader" BackColor="Tan" Font-Bold="True"></HeaderStyle>
            <ItemStyle CssClass="trOdd"></ItemStyle>
            <AlternatingItemStyle CssClass="trEven" BackColor="PaleGoldenrod"></AlternatingItemStyle>
            <Columns>
                <%--<asp:BoundColumn DataField="Admin" HeaderText="Quản trị?" ItemStyle-CssClass="CheckBox" Visible="true" />--%>
                <asp:TemplateColumn ItemStyle-CssClass="tdCenter">
                    <HeaderTemplate>
                        <asp:CheckBox ID="chkSelectAll" runat="server" AutoPostBack="False" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                    <ItemStyle CssClass="tdCenter" />
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="Id" HeaderText="Id" Visible="False"></asp:BoundColumn>
                <asp:BoundColumn DataField="Active" HeaderText="Active" Visible="False" />
                <asp:TemplateColumn ItemStyle-CssClass="Text">
                    <HeaderTemplate>
                        Họ tên
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# RealEstate.Common.StringClass.ShowNameLevel(DataBinder.Eval(Container.DataItem, "Name").ToString(), DataBinder.Eval(Container.DataItem, "Level").ToString()) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="Text" />
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="Username" HeaderText="Tên đăng nhập" ItemStyle-CssClass="Text" Visible="true">
                    <ItemStyle CssClass="Text" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Gender" HeaderText="Giới tính"></asp:BoundColumn>
                <asp:BoundColumn DataField="Avatar" HeaderText="Ảnh đại diện"></asp:BoundColumn>
                <asp:BoundColumn DataField="Birthday" HeaderText="Ngày sinh"></asp:BoundColumn>
                <asp:BoundColumn DataField="Ord" HeaderText="Thứ tự" ItemStyle-CssClass="Number" Visible="true" >
                    <ItemStyle CssClass="Number" />
                </asp:BoundColumn>
                <asp:BoundColumn DataField="Email" HeaderText="Email"></asp:BoundColumn>
                <asp:BoundColumn DataField="Address" HeaderText="Địa chỉ"></asp:BoundColumn>
                <asp:BoundColumn DataField="MobilePhone" HeaderText="Điện thoại"></asp:BoundColumn>
                <asp:BoundColumn DataField="IdentityCard" HeaderText="Số CMTND"></asp:BoundColumn>
                <asp:BoundColumn DataField="LastLoggedOn" HeaderText="Lần đăng nhập cuối"></asp:BoundColumn>
                <asp:BoundColumn DataField="CreatedDate" HeaderText="Ngày tạo"></asp:BoundColumn>
                <asp:BoundColumn DataField="GroupID" HeaderText="Nhóm"></asp:BoundColumn>
                <asp:BoundColumn DataField="Level" HeaderText="Cấp"></asp:BoundColumn>
                <asp:BoundColumn DataField="Admin" HeaderText="Quản trị"></asp:BoundColumn>
                <asp:TemplateColumn ItemStyle-CssClass="CheckBox">
                    <HeaderTemplate>
                        Kích hoạt
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server" Text='<%# RealEstate.Common.PageHelper.ShowActiveStatus(DataBinder.Eval(Container.DataItem, "Active").ToString()) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="CheckBox" />
                </asp:TemplateColumn>
                <asp:TemplateColumn ItemStyle-CssClass="Function">
                    <HeaderTemplate>
                        Chức năng
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="cmdAddSub" runat="server" AlternateText="Thêm cấp con" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Level")%>' CommandName="AddSub" CssClass="Add" ImageUrl="/App_Themes/Admin/images/add.png" ToolTip="Thêm cấp con" />
                        <asp:ImageButton ID="cmdEdit" runat="server" AlternateText="Sửa" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id")%>' CommandName="Edit" CssClass="Edit" ImageUrl="/App_Themes/Admin/images/edit.png" ToolTip="Sửa" />
                        <asp:ImageButton ID="cmdDelete" runat="server" AlternateText="Xóa" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id")%>' CommandName="Delete" CssClass="Delete" ImageUrl="/App_Themes/Admin/images/delete.png" OnClientClick="javascript:return confirm('Bạn có muốn xóa?');" ToolTip="Xóa" />
                        <asp:ImageButton ID="cmdActive" runat="server" AlternateText='<%#RealEstate.Common.PageHelper.ShowActiveToolTip(DataBinder.Eval(Container.DataItem, "Active").ToString())%>' CommandArgument='<%#DataBinder.Eval(Container.DataItem,"Id")%>' CommandName="Active" CssClass="Active" ImageUrl='<%#RealEstate.Common.PageHelper.ShowActiveImage(DataBinder.Eval(Container.DataItem, "Active").ToString())%>' ToolTip='<%# RealEstate.Common.PageHelper.ShowActiveToolTip(DataBinder.Eval(Container.DataItem, "Active").ToString())%>' />
                    </ItemTemplate>
                    <ItemStyle CssClass="Function" />
                </asp:TemplateColumn>
            </Columns>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataGrid>
        <div class="Control">
            <ul>
                <li>
                    <asp:LinkButton CssClass="vadd" ID="lbtAddB"
                        runat="server" OnClick="AddButton_Click">Thêm mới</asp:LinkButton></li>
                <li>
                    <asp:LinkButton CssClass="vdelete" ID="lbtDeleteB" runat="server"
                        OnClick="DeleteButton_Click">Xóa</asp:LinkButton></li>
                <li>
                    <asp:LinkButton CssClass="vrefresh" ID="lbtRefreshB" runat="server"
                        OnClick="RefreshButton_Click">Làm mới</asp:LinkButton></li>
                <li><a class="vback" href="javascript:void(0);" onclick="window.history.go(-1);">Trở lại</a> </li>
            </ul>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnUpdate" runat="server" Visible="False">
        <table class="TableUpdate" border="1">
            <tr>
                <td class="Control" colspan="2">
                    <ul>
                        <li>
                            <asp:LinkButton CssClass="uupdate"
                                ID="lbtUpdateT" runat="server" OnClick="Update_Click">Ghi lại</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton CssClass="uback" ID="lbtBackT" runat="server"
                                CausesValidation="False" OnClick="Back_Click">Trở về</asp:LinkButton></li>
                    </ul>
                </td>
            </tr>
            <tr>
                <th>
                    <asp:Label ID="lblName" runat="server" Text="Họ tên:"></asp:Label></th>
                <td>
                    <asp:TextBox ID="txtName" runat="server" CssClass="text"></asp:TextBox><asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="*" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <th>
                    <asp:Label ID="lblUsername" runat="server" Text="Tên đăng nhập:"></asp:Label></th>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="text"></asp:TextBox><asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="*" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <th>
                    <asp:Label ID="lblPassword" runat="server" Text="Mật khẩu:"></asp:Label></th>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="datetime" Height="16px" Width="398px"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Giới tính:</th>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">Nam</asp:ListItem>
                        <asp:ListItem Value="Nu">Nữ</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <th>Ảnh đại diện:</th>
                <td>
                    <asp:TextBox ID="txtAvatar" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Ngày sinh:</th>
                <td>
                    <asp:Calendar ID="cldBirthday" runat="server" Height="16px" Width="162px"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <th>Email:</th>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Địa chỉ:</th>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Di động:</th>
                <td>
                    <asp:TextBox ID="txtMobiphone" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Số CMTND:</th>
                <td>
                    <asp:TextBox ID="txtIdentitycard" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <%--<tr>
                <th>Lần đăng nhập cuối:</th>
                <td>
                    <asp:TextBox ID="txt" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>--%>
            <tr>
                <th>Ngày tạo:</th>
                <td>
                    <asp:Calendar ID="cldCreateDate" runat="server" Height="16px" Width="162px"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <th>Mã nhóm:</th>
                <td>
                    <asp:DropDownList ID="ddlGroup" runat="server" Height="16px" Width="195px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <th>Cấp người dùng:</th>
                <td>
                    <asp:TextBox ID="txtLevel" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <tr style="display: none">
                <th>
                    <asp:Label ID="lblAdmin" runat="server" Text="Quản trị?:"></asp:Label></th>
                <td>
                    <asp:TextBox ID="txtAdmin" runat="server" CssClass="date"></asp:TextBox></td>
            </tr>
            <tr>
                <th>
                    <asp:Label ID="lblOrd" runat="server" Text="Thứ tự:"></asp:Label></th>
                <td>
                    <asp:TextBox ID="txtOrd" runat="server" CssClass="text number" /><asp:RequiredFieldValidator ID="rfvOrd" runat="server" ControlToValidate="txtOrd" Display="Dynamic" ErrorMessage="*" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <th>
                    <asp:Label ID="lblActive" runat="server" Text="Kích hoạt:"></asp:Label></th>
                <td>
                    <asp:CheckBox ID="chkActive" runat="server" /></td>
            </tr>
            <tr>
                <td class="Control" colspan="2">
                    <ul>
                        <li>
                            <asp:LinkButton CssClass="uupdate" ID="lbtUpdateB" runat="server"
                                OnClick="Update_Click">Ghi lại</asp:LinkButton></li>
                        <li>
                            <asp:LinkButton CssClass="uback" ID="lbtBackB" runat="server"
                                CausesValidation="False" OnClick="Back_Click">Trở về</asp:LinkButton></li>
                    </ul>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
