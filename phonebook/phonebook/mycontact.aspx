<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="mycontact.aspx.cs" Inherits="mycontact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

     <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">My contacts</h4>

                    <br />
                

         <table class="table" style="align:right" border="0" >
             <br />
             <tr">
                 <td class="modal-sm" style="width: 301px">  <label for="firstname" style="margin-top:10px">Search for contact</label></td>
              
        
                 <td>  <asp:TextBox ID="search" runat="server"  class="form-control" placeholder="Enter First Name"></asp:TextBox></td>
                 <td> <asp:Button Text="Search" ID="button1" runat="server" class="btn btn-primary btn-sm waves-effect waves-light" style="margin-top:5px" OnClick="button1_Click" /></asp:Button ></td>
            




             </tr>
         </table>









               <asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>

        <table class="table" border="1">

            <tr>
                <th>firstname</th>
                <th>lastname</th>
                <th>contactno</th>
                <th>email</th>
                <th>adress</th>
                <th>city</th>
                <th>Manage contact</th>
            </tr>


        
    </HeaderTemplate>
    <ItemTemplate>
    
        <tr>

            <td><%#Eval("firstname") %></td>
            <td><%#Eval("lastname") %></td>
            <td><%#Eval("contactno") %></td>
            <td><%#Eval("email") %></td>
            <td><%#Eval("resident_adress") %></td>
            <td><%#Eval("city") %></td>
                 <td><a href="edit.aspx?id=<%#Eval("id") %> "><img  src="assets/images/edit.png" height="50" width="50" style="margin-left:10px" /></a><a href="delete.aspx?id=<%#Eval("id") %>"><img  src="assets/images/delete.png"height="50" width="50" style="margin-left:35px" /></a></td>


        </tr>




    </ItemTemplate>


    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
                   





                    





                   
                    </div>
                   
                </div>
                  
         </div>


         







</asp:Content>

