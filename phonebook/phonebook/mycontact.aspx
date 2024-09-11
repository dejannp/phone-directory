<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="mycontact.aspx.cs" Inherits="mycontact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

     <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">My contacts</h4>

                    
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

