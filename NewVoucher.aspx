<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewVoucher.aspx.vb" Inherits="SgcsVoucher.NewVoucher" %>


<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

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
            padding: 0px;
                margin-left: 0px;
                margin-right: 0px;
                margin-bottom: 0px;
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
       
       .style32
            {
                height: 48px;
                font-weight: 700;
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
                .style41
            {
                height: 48px;
            } 
                                       
             .style47
            {
                width: 578px;
                height: 48px;
            }
             .style47
            {
                width: 1304px;
                height: 48px;
            }
              .style47
            {
                width: 1304px;
                height: 48px;
            }
              .style71
            {
                height: 29px;
                font-weight: 700;
            }
            .style72
            {
                height: 29px;
            }
            .style74
            {
                width: 1304px;
                height: 33px;
            }
            .style75
            {
                height: 33px;
                font-weight: 700;
            }
            .style76
            {
                height: 33px;
            }
            .style78
            {
                height: 20px;
            }
            .style79
            {
                height: 20px;
                font-weight: 700;
            }
            .style80
            {
                height: 3px;
                font-weight: 700;
            }
            .style81
            {
                width: 1304px;
                height: 3px;
            }
            .style83
            {
                height: 33px;
                width: 112px;
            }
            .style84
            {
                height: 3px;
                font-weight: 700;
                width: 112px;
            }
            .style85
            {
                height: 29px;
                font-weight: 700;
                width: 112px;
            }
            .style86
            {
                height: 20px;
                width: 112px;
            }
            .style88
            {
                height: 33px;
                font-weight: 700;
                width: 414px;
            }
            .style89
            {
                width: 414px;
                height: 3px;
            }
            .style90
            {
                height: 48px;
                font-weight: 700;
                width: 414px;
            }
            .style91
            {
                height: 22px;
                width: 112px;
            }
            .style92
            {
                height: 22px;
            }
            .style93
            {
                height: 22px;
                width: 414px;
            }
            .style94
            {
                height: 3px;
            }
            .style95
            {
                height: 12px;
                width: 112px;
            }
            .style96
            {
                height: 12px;
            }
            .style97
            {
                height: 12px;
                width: 414px;
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
			
					<table class="style7" id="table1" style="MARGIN-LEFT: 50px; height: 587px;">
					<tr class="style41">
							<td class="style91" colspan="2">
                                <asp:label id="Label1" runat="server" Height="25px" 
                                    Width="90px" Font-Size="Small" Font-Names="Calibri">Company</asp:label></td>
							<td class="style92" colspan="5">
                                <asp:DropDownList ID="LstCompany" runat="server" Height="30px" Width="437px" 
                                    Font-Names="Calibri" Font-Size="Small" 
                                    BackColor="#DEDFDE" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
							
						<td class="style93">
                                <asp:label id="Label22" runat="server" Height="25px" Width="85px" 
                                    Font-Size="Small" Font-Names="Calibri">Search Voucher</asp:label>
                                </td>
						<td class="style92" colspan="4">
                                <asp:DropDownList ID="LstInvoice" runat="server" Font-Names="Calibri" 
                                    Height="30px" Width="170px" BackColor="#FFCCCC" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
						</tr>				
							<tr class="style41">
							<td class="style95" colspan="2">
                                <asp:label id="Label4" runat="server" Height="25px" 
                                    Width="90px" Font-Size="Small" Font-Names="Calibri">Customer</asp:label></td>
							<td class="style96" colspan="5">
                                <asp:DropDownList ID="LstCom" runat="server" Height="30px" Width="437px" 
                                    Font-Names="Calibri" Font-Size="Small" 
                                    BackColor="#DEDFDE">
                                </asp:DropDownList>
                                </td>
							
						<td class="style97">
                                </td>
						<td class="style96" colspan="4">
                                </td>
						</tr>				
						<tr>
							<td class="style83" colspan="2">
                                <asp:label id="Label23" runat="server" Height="25px" Width="86px" 
                                    Font-Size="Small" Font-Names="Calibri">Voucher No</asp:label>
                                </td>
							<td class="style76">
                                <asp:TextBox ID="TxtBillNo" runat="server" Width="161px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                </td>
							
							<td class="style74">
                                </td>
							
							<td class="style74">
                                <asp:label id="Label17" runat="server" Height="25px" Width="113px" 
                                    Font-Size="Small" Font-Names="Calibri">Voucher Date</asp:label>
                                </td>
							
							<td class="style74">
                                <asp:TextBox ID="TxtBillDt" runat="server" Width="92px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                <asp:ImageButton ID="ImgBt" runat="server" ImageUrl="~/Menu/Cal3.jpg" 
                                    Width="33px" Height="24px" ImageAlign="Top" CausesValidation="False" />
                                </td>
						<td class="style75">
                            </td>
						<td class="style88">
                                <asp:label id="Label111" runat="server" 
                                    Height="25px" Width="97px" Font-Size="Small" Font-Names="Calibri"> 
                                Cheque No </asp:label>
                                </td>
						<td class="style75" colspan="4">
                            <asp:TextBox ID="TxtChqNo" runat="server" Width="162px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                            </td>
						</tr>
						<tr>
							<td class="style84" colspan="2">
                                <asp:label id="Label115" runat="server" Height="25px" Width="114px" 
                                    Font-Size="Small" Font-Names="Calibri">Voucher Description</asp:label>
                                </td>
							<td class="style80" colspan="4">
                                    <asp:TextBox ID="TxtDes" runat="server"  Width="438px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                </td>
						<td class="style94">
                            </td>
						<td class="style89">
                                <asp:label id="Label116" runat="server" Height="25px" Width="113px" 
                                    Font-Size="Small" Font-Names="Calibri">Cheque Date</asp:label>
                                </td>
						<td class="style81" colspan="4">
                                <asp:TextBox ID="TxtChqDt" runat="server" Width="92px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                <asp:ImageButton ID="ImgBt1" runat="server" ImageUrl="~/Menu/Cal3.jpg" 
                                    Width="33px" Height="24px" ImageAlign="Top" CausesValidation="False" />
                            </td>
						</tr>
						
					    <tr>
							<td class="style85" colspan="2">
                                <asp:label id="Label78" runat="server" Height="25px" Width="103px" 
                                    Font-Size="Small" Font-Names="Calibri">Invoice Date</asp:label>
                            </td>
							<td class="style71" colspan="2">
                                <asp:label id="Label114" runat="server" Height="25px" Width="124px" 
                                    Font-Size="Small" Font-Names="Calibri">Invoice No</asp:label>
                            </td>
							<td class="style71" colspan="3">
                                <asp:label id="Label117" runat="server" Height="25px" Width="124px" 
                                    Font-Size="Small" Font-Names="Calibri">Description</asp:label>
                            </td>
						    <td class="style72" colspan="2">
                                <asp:label id="Label77" runat="server" Height="25px" Width="84px" 
                                    Font-Size="Small" Font-Names="Calibri">Value(LKR)</asp:label>
                            </td>
						    <td class="style72" colspan="2">
                                &nbsp;</td>
						    <td class="style72">
                                    </td>
						</tr>
					      <tr>
							<td class="style86">
                                <asp:TextBox ID="TxtInvDt" runat="server" Width="93px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td class="style86">
                                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Menu/Cal3.jpg" 
                                    Width="33px" Height="24px" ImageAlign="Top" CausesValidation="False" />
                              </td>
							<td colspan="2" class="style78">
                                    <asp:TextBox ID="TxtInvNo" runat="server" Width="155px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine" BackColor="#FFCC99"></asp:TextBox>
                              </td>
							<td colspan="3" class="style78">
                                    <asp:TextBox ID="TxtInvDes" runat="server"  Width="393px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
						    <td class="style79" colspan="2">
                                    <asp:TextBox ID="TxtInvAmt" runat="server"  Width="126px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
						    <td class="style79" colspan="2">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="32px" 
                                    ImageUrl="~/Menu/Insert-Button.png" Width="35px" />
                              </td>
						    <td class="style79">
                                </td>
                             <td class="style78">
                                 </td>
                             <td class="style78">
                                 </td>
                             <td class="style78">
                                 </td>
                              <td class="style78">
                                  </td>
                              <td class="style78">
                                  </td>
                               <td class="style78">
                                   </td>
                                
						</tr>
					    <tr>
							<td class="style32" colspan="8" rowspan="4">
                                						
								<div>
									<div id="Layer1" style="OVERFLOW: scroll; WIDTH: 738px; HEIGHT: 268px">
    <asp:GridView ID="MyDataGrid" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
                                            BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" 
                                            Font-Names="Calibri" Font-Size="Small" Width="603px" 
                                            AutoGenerateColumns="False" AutoGenerateDeleteButton="false" 
                                            AutoGenerateEditButton="false" Height="16px" >
        <RowStyle BackColor="#F7F7DE" />
        
        
        
        
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" visible="false"/>
                 
                  <asp:TemplateField HeaderText="Delete">
                  <ItemTemplate>
                  <asp:ImageButton ID="btnDelete" runat="server" ImageUrl="menu\delete.jpg" CommandName="Delete" CommandArgument='<%# Eval("id") %>' />
                  </ItemTemplate>
            </asp:TemplateField>
             
            
            
       <asp:BoundField DataField="InvDt" ReadOnly="True" HeaderText="Invoice Date">
							<HeaderStyle Width="1in"></HeaderStyle>
						</asp:BoundField>
						<asp:BoundField DataField="InvNo" ReadOnly="True" HeaderText="Invoice No">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						<asp:BoundField DataField="InvDes" ReadOnly="True" HeaderText="Description">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundField>
						
						<asp:BoundField DataField="InvAmt" ReadOnly="True" HeaderText="Amount(Rs.)">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
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
						    <td class="style32">
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="36px" 
                                    ImageUrl="~/Menu/save11.png" Width="40px" />
                            </td>
						    <td class="style32">
                                <asp:ImageButton ID="ImageButton3" runat="server" Height="39px" 
                                    ImageUrl="~/Menu/cheque.jpg" Width="40px" />
                            </td>
						    <td class="style32">
                                <asp:ImageButton ID="ImageButton8" runat="server" Height="39px" 
                                    ImageUrl="~/Menu/Voucher.png" Width="39px" />
                            </td>
						    <td class="style32">
                                <asp:ImageButton ID="ImageButton7" runat="server" Height="33px" 
                                    ImageUrl="~/Menu/next-button.png" Width="36px" />
                            </td>
						</tr>
					    <tr>
						    <td class="style32" colspan="4">
                                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                                        BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" 
                                        Font-Size="9pt" ForeColor="Black" Height="165px" NextPrevFormat="ShortMonth" 
                                        Width="249px">
                                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                                        <OtherMonthDayStyle ForeColor="#999999" />
                                        <DayStyle BackColor="#CCCCCC" />
                                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                                            Height="8pt" />
                                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" 
                                            Font-Size="12pt" ForeColor="White" Height="12pt" />
                                    </asp:Calendar>
                            </td>
						</tr>
					    <tr>
						    <td class="style32" colspan="3">
                                <asp:TextBox ID="TxtInTotA" runat="server" Height="30px" Width="136px"></asp:TextBox>
                                </td>
						    <td class="style32">
                                &nbsp;</td>
						</tr>
					<tr>
						    <td class="style32" colspan="4">
                                <asp:TextBox ID="TxtInTotA1" runat="server" Height="30px" Width="136px" 
                                    Visible="False"></asp:TextBox>
                                </td>
						</tr>
						
						
						
					
						<tr>
							<td class="style47" colspan="6">
                                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                                    AutoDataBind="true" Visible="False" />
                            </td>
						    <td class="style32">
                                <asp:TextBox ID="TxtCom" runat="server" Visible="False" Width="35px"></asp:TextBox>
                                <asp:ImageButton ID="ImageButton6" runat="server" Height="27px" 
                                    ImageUrl="~/Menu/save1.png" Width="32px" />
                            </td>
						    <td class="style90">
                                <asp:TextBox ID="TxtEpfNo" runat="server" Height="25px" Width="22px" 
                                    Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtPer" runat="server" Visible="False" Height="25px" 
                                    Width="42px"></asp:TextBox>
                            </td>
						</tr>						
					
					
					
						<tr>
							<td class="style47" colspan="6">
                                <asp:TextBox ID="TxtRefno" runat="server" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtRef" runat="server" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtCompany" runat="server" Visible="False"></asp:TextBox>
                            </td>
						    <td class="style32">
                                <asp:Label ID="TxtInTot" runat="server" Text="Label" Visible="False"></asp:Label>
                            </td>
						    <td class="style90">
                                <asp:DropDownList ID="LstFlag2" runat="server" Visible="False" Height="25px" 
                                    Width="36px">
                                </asp:DropDownList>
                            </td>
						</tr>			
					
					</table>
					
				</div>
      <div>


  </div>
    
    
    </form>
</body>
</html>