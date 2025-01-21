<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewShare.aspx.vb" Inherits="SgcsVoucher.NewShare" %>


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
            .style83
            {
                height: 33px;
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
            }
            .style98
            {
                height: 20px;
                width: 17px;
            }
            .style99
            {
                height: 18px;
                font-weight: 700;
                width: 112px;
            }
            .style100
            {
                height: 18px;
                font-weight: 700;
            }
            .style101
            {
                height: 18px;
            }
            .style102
            {
                width: 146px;
                height: 33px;
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
							<td class="style92" colspan="8">
                                <asp:DropDownList ID="LstCompany" runat="server" Height="30px" Width="437px" 
                                    Font-Names="Calibri" Font-Size="Small" 
                                    BackColor="#DEDFDE" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
							
						<td class="style93">
                                <asp:label id="Label22" runat="server" Height="25px" Width="124px" 
                                    Font-Size="Small" Font-Names="Calibri">Search Certificate No</asp:label>
                                </td>
						<td class="style92" colspan="6">
                                <asp:DropDownList ID="LstInvoice" runat="server" Font-Names="Calibri" 
                                    Height="30px" Width="170px" BackColor="#FFCCCC" AutoPostBack="True">
                                </asp:DropDownList>
                                </td>
						</tr>				
							<tr class="style41">
							<td class="style95" colspan="2">
                                <asp:label id="Label4" runat="server" Height="25px" 
                                    Width="90px" Font-Size="Small" Font-Names="Calibri">Share Holder</asp:label></td>
							<td class="style96" colspan="8">
                                <asp:DropDownList ID="LstCom" runat="server" Height="30px" Width="437px" 
                                    Font-Names="Calibri" Font-Size="Small" 
                                    BackColor="#DEDFDE" AutoPostBack="True" EnableTheming="True">
                                </asp:DropDownList>
                                </td>
							
						<td class="style97" colspan="7" rowspan="4">
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
							<td class="style83" colspan="2">
                                <asp:label id="Label23" runat="server" Height="25px" Width="86px" 
                                    Font-Size="Small" Font-Names="Calibri">Certificate No</asp:label>
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
                                    Font-Size="Small" Font-Names="Calibri">Certificate Date</asp:label>
                                </td>
							
							<td class="style102" colspan="3">
                                <asp:TextBox ID="TxtBillDt" runat="server" Width="103px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                                </td>
						<td class="style75" colspan="2">
                                <asp:ImageButton ID="ImgBt" runat="server" ImageUrl="~/Menu/Cal3.jpg" 
                                    Width="33px" Height="24px" ImageAlign="Top" CausesValidation="False" />
                            </td>
						</tr>
						<tr>
							<td class="style99" colspan="2">
                                </td>
							<td class="style100" colspan="6">
                                </td>
						<td class="style101" colspan="2">
                            </td>
						</tr>
						
					    <tr>
							<td class="style85" colspan="2">
                                <asp:label id="Label78" runat="server" Height="25px" Width="103px" 
                                    Font-Size="Small" Font-Names="Calibri">No Of Shares</asp:label>
                            </td>
							<td class="style71" colspan="2">
                                <asp:label id="Label114" runat="server" Height="25px" Width="153px" 
                                    Font-Size="Small" Font-Names="Calibri">Distinctive Numbers From</asp:label>
                            </td>
							<td class="style71" colspan="6">
                                <asp:label id="Label117" runat="server" Height="25px" Width="124px" 
                                    Font-Size="Small" Font-Names="Calibri">To</asp:label>
                            </td>
						</tr>
					      <tr>
							<td class="style86">
                                <asp:TextBox ID="TxtSno" runat="server" Width="136px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td class="style86">
                                &nbsp;</td>
							<td colspan="2" class="style78">
                                    <asp:TextBox ID="TxtFno" runat="server" Width="155px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td colspan="2" class="style78">
                                    <asp:TextBox ID="TxtTno" runat="server"  Width="159px" Height="25px" 
                                    Font-Size="Small" Font-Names="Calibri" BorderColor="#0033CC" 
                                    BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox>
                              </td>
							<td class="style98">
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="36px" 
                                    ImageUrl="~/Menu/save11.png" Width="40px" />
                              </td>
							<td colspan="2" class="style78">
                                <asp:ImageButton ID="ImageButton3" runat="server" Height="39px" 
                                    ImageUrl="~/Menu/cheque.jpg" Width="40px" />
                              </td>
							<td class="style78">
                                <asp:ImageButton ID="ImageButton8" runat="server" Height="39px" 
                                    ImageUrl="~/Menu/Voucher.png" Width="52px" />
                              </td>
						    <td class="style79">
                                <asp:ImageButton ID="ImageButton7" runat="server" Height="33px" 
                                    ImageUrl="~/Menu/next-button.png" Width="36px" />
                              </td>
						    <td class="style79">
                                    &nbsp;</td>
						    <td class="style79" colspan="3">
                                    &nbsp;</td>
						    <td class="style79" colspan="2">
                                    &nbsp;</td>
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
							<td class="style32" colspan="11" rowspan="4">
                                						
								<div>
								</div>
                            </td>
						    <td class="style32" colspan="2">
                                &nbsp;</td>
						    <td class="style32">
                                &nbsp;</td>
						    <td class="style32" colspan="2">
                                &nbsp;</td>
						    <td class="style32">
                                &nbsp;</td>
						</tr>
					    <tr>
						    <td class="style32" colspan="6">
                                    &nbsp;</td>
						</tr>
					    <tr>
						    <td class="style32" colspan="5">
                                <asp:TextBox ID="TxtInTotA" runat="server" Height="30px" Width="136px" 
                                    Visible="False"></asp:TextBox>
                                </td>
						    <td class="style32">
                                &nbsp;</td>
						</tr>
					<tr>
						    <td class="style32" colspan="6">
                                <asp:TextBox ID="TxtInTotA1" runat="server" Height="30px" Width="136px" 
                                    Visible="False"></asp:TextBox>
                                </td>
						</tr>
						
						
						
					
						<tr>
							<td class="style47" colspan="8">
                                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                                    AutoDataBind="true" Visible="False" />
                            </td>
						    <td class="style32" colspan="2">
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
							<td class="style47" colspan="8">
                                <asp:TextBox ID="TxtRefno" runat="server" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtRef" runat="server" Visible="False"></asp:TextBox>
                                <asp:TextBox ID="TxtCompany" runat="server" Visible="False"></asp:TextBox>
                            </td>
						    <td class="style32" colspan="2">
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