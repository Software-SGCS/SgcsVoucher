<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="SgcsVoucher._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Samson Group Corporate Services (Pvt) Ltd.</title>
				
	    <style type="text/css">
            .style1
        {
            width: 122%;
        }
        *
        {
            margin: 0px;
                padding: 0px;
            }
            .style7
            {
                height: 30px;
                width: 828px;
            }
            .style10
            {
                width: 308px;
                height: 48px;
            }
                #Menu ul
        {
        	list-style:none;
        }
            #Menu ul li
            {
            	background-color:Green;
            	border:1px solid white;
            	width:190px;
            	height:35px;
            	line-height:35px;
            	text-align:center;
            	float:left;
            	position:relative;
            }
              #Menu ul li a
              {
              	text-decoration:none;
              	color:White;
              	display:block;
	            width: 191px;
              }
              #Menu ul li a:hover
              {
                 background-color:Maroon;
			           
              }
              /*Second UL */
              #Menu ul ul
              {
              position:absolute;
             display:none;       
              }
              #Menu ul li:hover >ul
              {
              display:block;
              }
             #Menu ul ul ul
             {
              margin-left:190px;
              top:0px;
             }
       
            .style33
            {
                width: 326px;
                height: 48px;
            }
            .style34
            {
                width: 1304px;
                height: 48px;
            }
                                     
             .style70
            {
                width: 578px;
            }
		             
           </style>
		
	    
	</head>
	<body>
    <form id="form1" runat="server">
  <div>
				<table class="style1" style="MARGIN-LEFT: 50px">
					<tr>
						<td class="style33">
                            <asp:image id="Image1" runat="server" Height="43px" 
                                Width="756px" ImageUrl="~/Menu/SgcsHead.png" ImageAlign="TextTop"></asp:image></td>
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
							</td>
						
						
						<td class="style34">
                                &nbsp;</td>
						
						
						<td class="style34">
                                <asp:ImageButton ID="ImgBt0" runat="server" ImageUrl="~/Menu/SgcsLogo.png" 
                                    Width="60px" Height="68px" ImageAlign="Top" 
                                CausesValidation="False" />
						</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
							&nbsp;</td>
						
						
						<td class="style34">
                                    &nbsp;</td>
						
						
                                <td class="style10" rowspan="2">
                                    &nbsp;</td>
					</tr>
					
					
					
				</table>
			</div>
			<div id="Menu" class="style1" style="MARGIN-LEFT: 50px">
				<ul>
					<li>
						<a href="Home.aspx">Home</a>
					</li>
					<li>
						<a href="#">Services</a>
						  <ul>
						<li>
								<a href="NewVoucher.aspx">Voucher</a>
							</li>
							<li>  
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							        <ul>
					                     <li>
					                     	<a href="#">-------------</a>
					                     </li>
							             <li>
					                     	<a href="#">-------------</a>
					                     </li>
							        </ul>
							
							</li>
							
							<li>
								<a href="#">-------------</a>
							</li>
						</ul>
					</li>
					<li>
						<a href="#">Information</a>
						<ul>
						<li>
								<a href="EntryCustomer.aspx">Customer</a>
							</li>
							<li>
								<a href="EntryCompany.aspx">Company</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
							<li>
								<a href="#">-------------</a>
							</li>
						</ul>
					   </li>
						<li>
						<a href="#">Reports</a>
					</li>
					<li>
						<a href="#">Contacts</a>
					</li>
					<li>
						<a href="#"></a>
					</li>
				</ul>
			</div>		
				
				<div>
					<table class="style1" id="table1" style="MARGIN-LEFT: 50px">
						<tr>
							<td class="style70">
                                <asp:Image ID="Image5" runat="server" Height="580px" ImageUrl="~/Menu/sgcs.gif" 
                                    Width="1148px" />
                            </td>
							<td class="style70">
								</td>
							<td class="style70"></td>
							
						</tr>
						
											
						<tr>
							<td class="style70">&nbsp;</td>
							<td class="style70">&nbsp;</td>
						<td class="style7">&nbsp;</td>
						</tr>
						<tr>
							<td class="style70">&nbsp;</td>
							<td class="style70">&nbsp;</td>
						<td class="style7">&nbsp;</td>
						
						</tr>
						<tr>
							<td class="style70">
                                &nbsp;</td>
							<td class="style70">&nbsp;</td>
							<td class="style7">&nbsp;</td>
						</tr>
						<tr>
							<td class="style70">&nbsp;</td>
							<td class="style70">
								&nbsp;</td>
							<td class="style70" style="WIDTH: 199px">&nbsp;</td>
								
						</tr>
						<tr>
							<td class="style70">
                                &nbsp;</td>
							<td class="style70">&nbsp;
								<div>
									<div id="Layer1" style="OVERFLOW: scroll; WIDTH: 754px; HEIGHT: 270px">
                                    </div>
								</div>
							</td>
						</tr>
					</table>
					<table class="style1" style="WIDTH: 100%; HEIGHT: 12px">
						<tr>
							<td class="style70" style="WIDTH: 199px"><asp:imagebutton id="Save1" runat="server" Height="39px" Width="48px" ImageUrl="Menu\save1.png"></asp:imagebutton></td>
							<td class="style70" style="WIDTH: 199px">&nbsp;</td>
							<td class="style70" style="WIDTH: 199px">&nbsp;
								<asp:button id="BtnAdd" tabIndex="7" runat="server" Font-Bold="True" Width="64px" Text="Add"
									Visible="False" Enabled="False"></asp:button></td>
							<td class="style70" style="WIDTH: 199px">&nbsp;
								<asp:button id="BtnEdit" tabIndex="8" runat="server" Font-Bold="True" Width="64px" Text="Edit"
									Visible="False" Enabled="False"></asp:button></td>
							<td>&nbsp;<asp:button id="BtnCle" tabIndex="9" runat="server" Font-Bold="True" Height="24px" Width="64px"
									Text="Clear" Visible="False" Enabled="False"></asp:button></td>
							<td class="style70" style="WIDTH: 199px"><asp:button id="BtnDel" tabIndex="11" runat="server" Font-Bold="True" Width="64px" Text="Delete"
									Visible="False" Enabled="False"></asp:button></td>
							<td>
								<h1>&nbsp;</h1>
							</td>
							<td class="style70" style="WIDTH: 199px">&nbsp;<asp:button id="BtnSave" tabIndex="11" runat="server" Font-Bold="True" Width="64px" Text="Save"
									Visible="False" Enabled="False"></asp:button></td>
							<td>&nbsp;</td>
						</tr>
					</table>
				</div>
      <div>


  </div>
    
    
    </form>
</body>
</html>