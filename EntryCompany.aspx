<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EntryCompany.aspx.vb" Inherits="SgcsVoucher.EntryCompany" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Samson Group Corporate Services (Pvt) Ltd</title>
				
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
							&nbsp;</td>
						
						
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
							<td class="style36"><asp:label id="Label4" runat="server" Height="24px" 
                                    Width="139px" Font-Size="Small" Font-Names="Calibri">Customer Code(3 Digits)</asp:label></td>
							<td class="style37">
								<asp:textbox id="TxtConCode" tabIndex="1" runat="server" Height="20px" 
                                    Width="72px" Font-Size="Small"
									Font-Names="Calibri"></asp:textbox>
								<asp:imagebutton id="Imagebutton3" runat="server" Height="25px" Width="78px" 
                                    ImageUrl="Menu\serch.gif" ImageAlign="AbsBottom"></asp:imagebutton>
							</td>
							<td class="style7">
								&nbsp;</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;</td>
							
						</tr>
						
											
						<tr>
							<td class="style36"><asp:label id="Label8" runat="server" Height="16px" Width="114px" Font-Size="Small" Font-Names="Calibri">Name</asp:label></td>
							<td class="style37"><asp:textbox id="TxtConNam" tabIndex="3" runat="server" Height="20px" Width="432px" Font-Size="Small"
									Font-Names="Calibri"></asp:textbox></td>
						
							<td class="style7">&nbsp;</td>
						
						</tr>
						<tr>
							<td class="style36"><asp:label id="Label10" 
                                    runat="server" Height="24px" Width="136px" Font-Size="Small" 
                                    Font-Names="Calibri"> Address</asp:label></td>
							<td class="style37"><asp:textbox id="TxtConAdd1" runat="server" Height="20px" Width="432px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style7">&nbsp;</td>
						</tr>
						<tr>
							<td class="style36">
                                <asp:label id="Label11" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Contact 
                                Nos</asp:label></td>
							<td class="style37"><asp:textbox id="TxtContact" runat="server" Height="20px" 
                                    Width="432px" Font-Size="Small" Font-Names="Calibri"></asp:textbox></td>
							<td class="style7">&nbsp;</td>
						</tr>
						<tr>
							<td class="style36"><asp:label id="Label5" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Email</asp:label></td>
							<td class="style37">
								<asp:textbox id="TxtCusEmail" runat="server" Height="20px" Width="432px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:textbox>
                                </td>
							<td class="style7">
								&nbsp;</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;</td>
								
						</tr>
						<tr>
							<td class="style36"><asp:label id="Label1" runat="server" Height="24px" Width="129px" Font-Size="Small" Font-Names="Calibri">Registration 
                                No</asp:label></td>
							<td class="style37">
								<asp:textbox id="TxtRegNo" runat="server" Height="20px" Width="432px" 
                                    Font-Names="Calibri" Font-Size="Small"></asp:textbox>
                                <asp:imagebutton id="Save11" runat="server" Height="30px" Width="35px" 
                                    ImageUrl="Menu\save11.png" ImageAlign="AbsBottom"></asp:imagebutton></td>
							<td class="style7">
								&nbsp;</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;</td>
								
						</tr>
						
						<tr>
							<td class="style38">
                                <asp:Image ID="Image2" runat="server" Height="404px" 
                                    ImageUrl="~/Menu/EmpMaster4.jpg" Width="133px" />
                            </td>
							<td class="style39">&nbsp;
								<div>
									<div id="Layer1" style="OVERFLOW: scroll; WIDTH: 862px; HEIGHT: 385px">
    <asp:GridView ID="MyDataGrid" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
                                            BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                                            Font-Names="Calibri" Font-Size="Small" Width="844px" 
                                            AutoGenerateColumns="False"  >
        <RowStyle BackColor="#F7F7DE" />
        
       
        
        
        <Columns>
                  <asp:BoundField DataField="id" HeaderText="id" visible="false"/>
                 
                  <asp:TemplateField HeaderText="Delete">
                  <ItemTemplate>
                  <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="menu\delete.jpg" CommandName="Delete" CommandArgument='<%# Eval("id") %>' />
                  </ItemTemplate>
                  </asp:TemplateField>
                   
         
                
            <asp:Boundfield DataField="Com_No" HeaderText="Customer #">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
			</asp:Boundfield>
						
          
						<asp:BoundField DataField="Com_Nam" HeaderText="Name">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="Com_Add1" HeaderText="Address">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Com_Email" HeaderText="E_Mail">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Com_Per" HeaderText="Contact Nos">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="Com_Pvno" HeaderText="Comany RegNo">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
            
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
                                    </div>
								</div>
							</td>
							<td class="style40">
					<table class="style1" style="WIDTH: 100%; HEIGHT: 12px">
						<tr>
							<td class="style2" style="WIDTH: 199px"><asp:imagebutton id="Save1" runat="server" Height="39px" Width="48px" ImageUrl="Menu\save1.png"></asp:imagebutton></td>
							<td class="style2" style="WIDTH: 199px">&nbsp;</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;
								<asp:button id="BtnAdd" tabIndex="7" runat="server" Font-Bold="True" Width="64px" Text="Add"
									Visible="False" Enabled="False"></asp:button></td>
							<td class="style2" style="WIDTH: 199px">&nbsp;
								<asp:button id="BtnEdit" tabIndex="8" runat="server" Font-Bold="True" Width="64px" Text="Edit"
									Visible="False" Enabled="False"></asp:button></td>
							<td>&nbsp;<asp:button id="BtnCle" tabIndex="9" runat="server" Font-Bold="True" Height="24px" Width="64px"
									Text="Clear" Visible="False" Enabled="False"></asp:button></td>
							<td class="style2" style="WIDTH: 199px"><asp:button id="BtnDel" tabIndex="11" runat="server" Font-Bold="True" Width="64px" Text="Delete"
									Visible="False" Enabled="False"></asp:button></td>
							<td>
								<h1>&nbsp;</h1>
							</td>
							<td class="style2" style="WIDTH: 199px">&nbsp;<asp:button id="BtnSave" tabIndex="11" runat="server" Font-Bold="True" Width="64px" Text="Save"
									Visible="False" Enabled="False"></asp:button></td>
							<td>&nbsp;</td>
						</tr>
					</table>
							</td>
						</tr>
					</table>
				</div>
      <div>


  </div>
    
    
    </form>
</body>
</html>
