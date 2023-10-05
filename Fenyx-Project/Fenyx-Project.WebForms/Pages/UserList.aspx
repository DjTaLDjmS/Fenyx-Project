<%@ Page Title="Gestion des utilisateurs" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UserList.aspx.cs"
    Inherits="Fenyx_Project.WebForms.Pages.UserList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <hr />
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <table>
                    <tr>
                        <th>Prénom</th>
                        <td>
                            <asp:TextBox ID="txtFirstName" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server"
                                ControlToValidate="txtFirstName" Text="* Requis" />
                        </td>
                    </tr>
                    <tr>
                        <th>Nom</th>
                        <td>
                            <asp:TextBox ID="txtLastName" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server"
                                ControlToValidate="txtLastName" Text="* Requis" />
                        </td>
                    </tr>
                    <tr>
                        <th>Date de naissance</th>
                        <td>
                            <asp:TextBox ID="txtBirthdate" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorBirthdate" runat="server"
                                ControlToValidate="txtBirthdate" Text="* Requis" />
                        </td>
                        <td>
                            <asp:CompareValidator runat="server" ID="cvDate"
                                ErrorMessage="Date requise" Operator="DataTypeCheck"
                                ControlToValidate="txtBirthdate" Type="Date" />
                        </td>
                    </tr>
                    <tr>
                        <th>Url Photo</th>
                        <td>
                            <asp:TextBox ID="txtPhoto" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhoto" runat="server"
                                ControlToValidate="txtPhoto" Text="* Requis" />
                        </td>
                    </tr>
                    <tr>
                        <th>Adresse</th>
                        <td>
                            <asp:TextBox ID="txtStreet" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorStreet" runat="server"
                                ControlToValidate="txtStreet" Text="* Requis" />
                        </td>
                    </tr>
                    <tr>
                        <th>Code postal</th>
                        <td>
                            <asp:TextBox ID="txtZipcode" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorZipcode" runat="server"
                                ControlToValidate="txtZipcode" Text="* Requis" />
                        </td>
                        <td>
                            <asp:CompareValidator ID="cvInt" runat="server" ControlToValidate="txtZipcode"
                                Type="Integer" Operator="DataTypeCheck" ErrorMessage="Nombre  requis" />
                        </td>
                    </tr>
                    <tr>
                        <th>Ville</th>
                        <td>
                            <asp:TextBox ID="txtCity" runat="server" />
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server"
                                ControlToValidate="txtCity" Text="* Requis" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="BtnReset" Text="Effacer"
                                OnClick="BtnReset_Click" runat="server" CausesValidation="False" />

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="BtnAddUser" Text="Ajouter"
                                OnClick="BtnAddUser_Click" runat="server" />

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="BtnUpdateUser" Text="Modifier"
                                OnClick="BtnUpdateUser_Click" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="BtnDeleteUser" Text="Supprimer"
                                OnClick="BtnDeleteUser_Click" runat="server" CausesValidation="False" />

                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-md-6">
                <asp:GridView ID="GridViewUsers" runat="server" CellSpacing="3"
                    AutoGenerateColumns="false" DataKeyNames="Id"
                    OnSelectedIndexChanged="GridViewUsers_SelectedIndexChanged"
                    AutoGenerateSelectButton="true">
                    <Columns>
                        <asp:BoundField DataField="FirstName"
                            HeaderText="Prénom" SortExpression="FirstName" />
                        <asp:BoundField DataField="LastName"
                            HeaderText="Nom" SortExpression="LastName" />
                        <asp:BoundField DataField="Birthdate"
                            HeaderText="Date de naissance" SortExpression="Birthdate" />
                        <asp:BoundField DataField="PhotoUrl"
                            HeaderText="Photo" SortExpression="PhotoUrl" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
