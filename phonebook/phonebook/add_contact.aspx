<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="add_contact.aspx.cs" Inherits="add_contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">

    
     <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">Create new contact</h4>

                    <div class="card-content">
                        <form>
                            <div class="form-group">
                                <label for="exampleInputEmail1">First Name</label>
                                <input type="email" class="form-control" id="exampleInputEmail1"
                                       placeholder="Enter First Name">
                            </div>
                            <div class="form-group">
                                <label for="exampleInputPassword1">Last Name</label>
                                <input type="password" class="form-control" id="exampleInputPassword1"
                                       placeholder="Enter Last Name">
                            </div>


                             <div class="form-group">
                                <label for="exampleInputPassword1">Contact No</label>
                                <input type="password" class="form-control" id="exampleInputPassword1"
                                       placeholder="Enter Contact No">
                            </div>

                             <div class="form-group">
                                <label for="exampleInputPassword1">Email</label>
                                <input type="password" class="form-control" id="exampleInputPassword1"
                                       placeholder="Enter Email">
                            </div>

                             <div class="form-group">
                                <label for="exampleInputPassword1">Resident adress</label>
                                <input type="password" class="form-control" id="exampleInputPassword1"
                                       placeholder="Enter Resident Adress">
                            </div>

                             <div class="form-group">
                                <label for="exampleInputPassword1">City</label>
                                <input type="password" class="form-control" id="exampleInputPassword1"
                                       placeholder="Enter City">
                            </div>

                          










                            <button type="submit" class="btn btn-primary btn-sm waves-effect waves-light">Add
                            </button>
                        </form>
                    </div>

                </div>

            </div>

        </div>





</asp:Content>

