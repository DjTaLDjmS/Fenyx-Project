<%@ Page Title="Gestion des utilisateurs" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UserList.aspx.cs"
    Inherits="Fenyx_Project.WebForms.Pages.UserList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
    <script src="https://code.jquery.com/ui/1.13.2/jquery-ui.js"></script>
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.13.2/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/1.13.6/css/jquery.dataTables.min.css" />
    <script src="https://cdn.datatables.net/1.13.6/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/plug-ins/1.13.6/sorting/date-eu.js"></script>
    <br />
    <h2><%: Title %></h2>
    <hr />
    <div class="container">
        <div class="row g-3">
            <div class="col-md-6">
                <asp:UpdatePanel ID="UpdatePanelForm" runat="server" UpdateMode="Conditional">
                    <Triggers>
                        <asp:PostBackTrigger ControlID="BtnAddUser" />
                        <asp:PostBackTrigger ControlID="BtnUpdateUser" />
                        <asp:PostBackTrigger ControlID="BtnDeleteUser" />
                        <asp:PostBackTrigger ControlID="BtnReset" />
                    </Triggers>
                    <ContentTemplate>
                        <asp:Label ID="lblMessage" runat="server" EnableViewState="false" ForeColor="blue"></asp:Label>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="txtFirstName">Prénom</label>
                                <asp:TextBox ID="txtFirstName" class="form-control" runat="server" />
                            </div>
                            <div class="col-md-6">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server"
                                    ControlToValidate="txtFirstName" Text="* Requis" />
                            </div>
                        </div>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="txtLastName">Nom</label>
                                <asp:TextBox ID="txtLastName" class="form-control" runat="server" />
                            </div>
                            <div class="col-md-6">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server"
                                    ControlToValidate="txtLastName" Text="* Requis" />
                            </div>
                        </div>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="txtBirthdate">Date de naissance</label>
                                <asp:TextBox ID="txtBirthdate" class="form-control datepicker" runat="server" />
                            </div>
                        </div>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="txtStreet">Adresse</label>
                                <asp:TextBox ID="txtStreet" class="form-control" runat="server" />
                            </div>
                            <div class="col-md-6">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorStreet" runat="server"
                                    ControlToValidate="txtStreet" Text="* Requis" />
                            </div>
                        </div>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="txtZipcode">Code postal</label>
                                <asp:TextBox ID="txtZipcode" class="form-control" runat="server" />
                            </div>
                            <div class="col-md-6">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorZipcode" runat="server"
                                    ControlToValidate="txtZipcode" Text="* Requis" />
                                <asp:CompareValidator ID="cvInt" runat="server" ControlToValidate="txtZipcode"
                                    Type="Integer" Operator="DataTypeCheck" ErrorMessage="Nombre  requis" />
                            </div>
                        </div>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="txtCity">Ville</label>
                                <asp:TextBox ID="txtCity" class="form-control" runat="server" />
                            </div>
                            <div class="col-md-6">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server"
                                    ControlToValidate="txtCity" Text="* Requis" />
                            </div>
                        </div>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <label class="form-label" for="fuPhoto">Photo</label>
                                <asp:FileUpload ID="fuPhoto" class="form-control" runat="server" />
                                <br />
                                <asp:Image ID="imPhoto" class="form-control" runat="server" Height="100" Width="100" />
                                <asp:HiddenField ID="hfPhoto" runat="server" />
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="row g-6">
                                <div class="col-md-3">
                                    <asp:Button ID="BtnAddUser" Text="Ajouter" CssClass="w-100 btn btn-primary btn-lg" Style="margin: 10px"
                                        OnClick="BtnAddUser_Click" runat="server" />
                                </div>
                                <div class="col-md-3">
                                    <asp:Button ID="BtnUpdateUser" Text="Modifier" CssClass="w-100 btn btn-primary btn-lg" Style="margin: 10px"
                                        OnClick="BtnUpdateUser_Click" runat="server" />
                                </div>
                            </div>
                            <div class="row g-6">
                                <div class="col-md-3">
                                    <asp:Button ID="BtnDeleteUser" Text="Supprimer" CssClass="w-100 btn btn-primary btn-lg" Style="margin: 10px"
                                        OnClick="BtnDeleteUser_Click" runat="server" CausesValidation="False" />
                                </div>
                                <div class="col-md-3">
                                    <asp:Button ID="BtnReset" Text="Effacer" CssClass="w-100 btn btn-primary btn-lg" Style="margin: 10px"
                                        OnClick="BtnReset_Click" runat="server" CausesValidation="False" />
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdateProgress ID="Up1" runat="Server" AssociatedUpdatePanelID="UpdatePanelForm">
                    <ProgressTemplate>
                        <span style="background-color: #66997A;">Veuillez patienter ...</span>
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </div>
            <div class="col-md-6">
                <asp:GridView ID="GridViewUsers" runat="server" CellSpacing="3"
                    AutoGenerateColumns="false" DataKeyNames="Id"
                    OnSelectedIndexChanged="GridViewUsers_SelectedIndexChanged"
                    AutoGenerateSelectButton="true" UseAccessibleHeader="true"
                    CssClass="datatables table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:BoundField DataField="FirstName"
                            HeaderText="Prénom" SortExpression="FirstName" />
                        <asp:BoundField DataField="LastName"
                            HeaderText="Nom" SortExpression="LastName" />
                        <asp:BoundField DataField="Birthdate" DataFormatString="{0:dd/MM/yyyy}"
                            HeaderText="Date de naissance" SortExpression="Birthdate" />
                        <asp:ImageField DataImageUrlField="PhotoUrl" DataImageUrlFormatString="../images/{0}"
                            HeaderText="Photo" ControlStyle-Height="50" ControlStyle-Width="50" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <script>
        $(function () {
            $('.datatables').dataTable({
                columnDefs: [
                    { type: 'date-eu', targets: 3 }
                ]
            });
            $(".datepicker").datepicker();
        });
    </script>
</asp:Content>
