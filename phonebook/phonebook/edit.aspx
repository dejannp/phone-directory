<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">


    <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">Update contact</h4>

                    <div class="card-content">
                       
                            <div class="form-group">
                                <label for="firstname">First Name</label>

                               
                                
                                <asp:TextBox ID="firstname" runat="server"  class="form-control" placeholder="Enter First Name"></asp:TextBox>
                            
                            
                            </div>
                            
                            <div class="form-group">
                                <label for="lastname">Last Name</label>
                                 <asp:TextBox ID="lastname" runat="server"  class="form-control" placeholder="Enter Last Name"></asp:TextBox>
                            </div>


                             <div class="form-group">
                                <label for="contactno">Contact No</label>
                                 <asp:TextBox ID="TextBox1" runat="server"  class="form-control" placeholder="Enter First Name"></asp:TextBox>
                            </div>

                             <div class="form-group">
                                <label for="email">Email</label>
                                 <asp:TextBox ID="email" runat="server"  class="form-control" placeholder="Enter Email"></asp:TextBox>
                            </div>

                             <div class="form-group">
                                <label for="resident_adress">Resident adress</label>
                                 <asp:TextBox ID="resident" runat="server"  class="form-control" placeholder="Enter Resident adress"></asp:TextBox>
                            </div>

                             <div class="form-group">
                                <label for="city">City</label>
                                 <asp:TextBox ID="city" runat="server"  class="form-control" placeholder="Enter City"></asp:TextBox>
                            </div>

                          










                         
                        <asp:Button Text="Edit contact" ID="button1" runat="server" class="btn btn-primary btn-sm waves-effect waves-light" OnClick="button1_Click"  /></asp:Button >
                   
                    </div>

                </div>

            </div>

        </div>

    





</asp:Content>


