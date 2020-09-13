<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Ticket-En.aspx.cs" Inherits="NTourism.View.En.Ticket.Ticket_En" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Script/Ticket.js"></script>
    <link href="Style/Ticketcss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-7 col-md-12 col-sm-12 col-xs-12">
                <img src="/Resources/En/Ticket/Ticket.png" class="ImgTicketStyle" alt="Ticket-OurServices" title="Ticket-OurServices" />
            </div>
            <div class="col-lg-5 col-md-12 col-sm-12 col-xs-12">
                <div id="form_container">
                    <form id="Ticket" method="post">
                        <label>Ticket</label>
                        <div class="group">
                            <input id="Name" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Name">Name</label>
                        </div>
                        <div class="group">
                            <input id="Email" type="email"  maxlength="50" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Email">Email</label>
                        </div>
                        <div class="group">
                            <input id="Title" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Title">Title</label>
                        </div>
                        <div class="group">
                            <input id="Writeyourmessage" type="text" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Writeyourmessage">Writeyourmessage</label>
                        </div>
                        <ul class="errorMessages"></ul>
                        <input id="btnsubmit" type="submit" value="CONTINUE" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
