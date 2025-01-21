Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail

Imports System.IO

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports System
Imports System.Web.Security
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls



Public Class NewVoucher
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection
    Dim objConn As SqlConnection
    Dim ADA As SqlDataAdapter
    Dim CMD As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS As DataSet
    Dim DV As DataView
    Dim sinvno As String
    Dim LOD, body As String
    Dim dt1 As Date
    Dim drt2, drt3, Dtr1 As DataRow
    Dim CHKDUP As Boolean
    Dim CMD1 As SqlCommand
    Dim SS, SS1 As String
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim q, r, s As String
    Dim p, t As Double
    Dim InvFlag2 As String
    Dim count1, count As Integer
    Dim depno As String
    Dim depname As String
    Dim S1(10) As String
    Dim epfno As String
    Dim oStream As New MemoryStream
    Dim T1, T2, T3, Tot1, Tot2 As Integer
    Dim Vou1 As String
    Dim TT1 As String
    Protected WithEvents BtnSubmit As System.Web.UI.WebControls.Button
    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String


    Protected WithEvents LstCode As System.Web.UI.WebControls.DropDownList
    Protected WithEvents LstVat As System.Web.UI.WebControls.DropDownList




    Protected WithEvents TxtLInvNo As System.Web.UI.WebControls.TextBox

    Protected WithEvents LstTT As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Lstvat1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents BtnSave As System.Web.UI.WebControls.Button

    Protected WithEvents txtEmpNo As System.Web.UI.WebControls.TextBox
    Protected WithEvents BttEmpNo As System.Web.UI.WebControls.Button

    Protected WithEvents TxtDepNo As System.Web.UI.WebControls.TextBox


    Protected WithEvents Button1 As System.Web.UI.WebControls.Button



    Protected WithEvents C As System.Web.UI.WebControls.CheckBox


    Protected WithEvents Label27 As System.Web.UI.WebControls.Label

    Protected WithEvents Label28 As System.Web.UI.WebControls.Label

    Protected WithEvents Label30 As System.Web.UI.WebControls.Label

    Protected WithEvents Label33 As System.Web.UI.WebControls.Label
    Protected WithEvents Label34 As System.Web.UI.WebControls.Label
    Protected WithEvents Label35 As System.Web.UI.WebControls.Label


    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label36 As System.Web.UI.WebControls.Label

    Protected WithEvents Label37 As System.Web.UI.WebControls.Label

    Protected WithEvents Label39 As System.Web.UI.WebControls.Label

    Protected WithEvents Label40 As System.Web.UI.WebControls.Label

    Protected WithEvents Panel3 As System.Web.UI.WebControls.Panel

    Protected WithEvents Label31 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel


    Protected WithEvents Label26 As System.Web.UI.WebControls.Label

    Protected WithEvents Label41 As System.Web.UI.WebControls.Label

    Protected WithEvents Label42 As System.Web.UI.WebControls.Label

    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents LstInvNo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Invoice As System.Web.UI.WebControls.Label


    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Put user code to initialize the page here

        '        YY = Right(Trim(Year(Format(Date.Today))), 2)
        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()



        If Not IsPostBack Then





            CMD = New SqlCommand("SELECT Com_No,Com_Nam From Supplier order by Com_No", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                TT = Trim(DR.GetValue(0)) + "-" + Trim(DR.GetValue(1))
                ' LstCom.SelectedValue = TT
                LstCom.Items.Add(TT)
            End While
            TxtCom.Text = Mid(Trim(LstCom.SelectedValue), 1, 4)
            DR.Close()

            CMD = New SqlCommand("SELECT Com_No,Com_Nam From Company order by Com_No", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                TT = Trim(DR.GetValue(0)) + "-" + Trim(DR.GetValue(1))
                ' LstCom.SelectedValue = TT
                LstCompany.Items.Add(TT)
            End While
            TxtCompany.Text = Mid(Trim(LstCompany.SelectedValue), 1, 3)
            DR.Close()


            CMD = New SqlCommand("SELECT Inv_No From CheVoucher where Inv_Company='" & Trim(TxtCompany.Text) & "' order by Inv_No", CON)

            DR = CMD.ExecuteReader
            LstInvoice.Items.Clear()
            While DR.Read
                TT = Trim(DR.GetValue(0))
                LstInvoice.Items.Add(TT)
            End While
            'TxtCom.Text = Mid(Trim(LstCom.SelectedValue), 1, 4)
            DR.Close()




        End If





        If Not IsPostBack Then
            Calendar1.Visible = False
            LstFlag2.SelectedValue = "No"
            'Label11.Visible = False
            LstFlag2.Visible = False
            TxtPer.Visible = False
            TxtPer.Text = 0

            ' End If
            TxtChqNo.Visible = True
            TxtChqNo.Enabled = True
            TxtChqNo.Text = ""
            '-----
            ImageButton1.Visible = True
            ImageButton1.Enabled = True
            'ImageButton6.Visible = True
            ImageButton1.ImageUrl = "~/Menu/save11.png"
            ' TxtInvDt.Text = " "


            'ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)

            TxtRefno.ReadOnly = False

            TxtPer.Text = "N"

            ADA = New SqlDataAdapter("SELECT * FROM FreInvNo where Inv_Com='" & Trim(TxtCompany.Text) & "'", CON)

            DS = New DataSet
            ADA.Fill(DS, "FreInvNo")

            count1 = DS.Tables("FreInvNo").Rows.Count


            If count1 <> 0 Then

                For Each Me.drt2 In DS.Tables("FreInvNo").Rows
                    '
                    Dim q, s As String
                    Dim p As Double
                    s = drt2("Inv_no")
                    p = drt2("Inv_no")
                    q = Format(p, "000000")

                    TxtRefno.Text = p
                    'TxtChqNo.Text = Trim(drt2("Inv_Ref")) + Mid(Trim(Year(Today())), 3, 2) + "/" + q
                    'TxtBillNo.Text = "SLPLI" + Mid(Trim(Year(Today())), 3, 2) + q
                    'TxtBillNo.Text = "2023/" + q
                    TxtBillNo.Text = q
                    Try
                        TxtChqNo.Text = Format(drt2("Chq_No"), "000000")
                    Catch ex As Exception
                    End Try

                Next
            Else
                ' Response.Redirect("InsuDept.aspx")
                TxtBillNo.Text = "000001"
                TxtChqNo.Text = ""

                CON = New SqlConnection
                CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
                'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
                CON.Open()
                CMD = New SqlCommand("SELECT * From Supplier ", CON)

                DR = CMD.ExecuteReader
                'If BtnEdit.Enabled = True Then
                'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
                'Else
                DR.Close()

                'If BtnEdit.Enabled = True Then
                'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
                'Else
                

                CMD.CommandText = ("INSERT INTO FreInvNo (Inv_No,Chq_No,Inv_Com) VALUES (1,1,'" & Trim(TxtCompany.Text) & "')")


                ' End If
                ' End If

                CMD.ExecuteNonQuery()
            End If

        'TxtBillNo.Text = ""
        TxtDes.Text = ""
        TxtInvNo.Text = ""
        TxtBillDt.Text = ""
        'TxtChqNo.Text = ""
        TxtInvAmt.Text = "0"
        TxtInvDes.Text = ""
        TxtInvDt.Text = ""
        ''sinvno = Mid(Trim(TxtRefno.Text), 8, 5)

        '' Dim Cmd11 As New SqlCommand("UPDATE RefNo SET refno=" & sinvno, CON)
        ''Cmd11.ExecuteNonQuery()

        '-----
        BindTheGrid1()
        End If





    End Sub


    Public Sub BindTheGrid1()

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()


        ADA = New SqlDataAdapter("Select id,InvDt ,InvNo , InvDes ,CONVERT(DECIMAL(10,2),InvAmt,2) as InvAmt from InlInv where Company='" & Trim(TxtCompany.Text) & "' and VouNo='" & Trim(TxtBillNo.Text) & "' order by Id", CON)

        DS = New DataSet
        '' SS = "SELECT * FROM HltMaster1 WHERE Emp_Com='" & Mid(Lstcom.SelectedValue, 1, 3) & "' and Emp_No=" & Val(TempEmpno) & " and Emp_Accyr='" & Trim(TxtYr.Text) & "'"
        ADA.Fill(DS, "InlInv")

        count1 = DS.Tables("InlInv").Rows.Count


        Dim TotAmt1 As Double = 0



        If count1 <> 0 Then

            LstCom.Enabled = True


            For Each Me.drt2 In DS.Tables("InlInv").Rows


                TotAmt1 = TotAmt1 + drt2("InvAmt")


            Next
        Else
            'TxtEmpNam.Enabled = True
            'LstCom1.Enabled = True
            'TxtIdNo.Enabled = True


            'TxtEmpNam.Text = " "
            'TxtIdNo.Text = " "
        End If

        TxtInTotA.Text = "*****" + Format(TotAmt1, "###,###,###,###,###.00")
        TxtInTotA1.Text = Format(TotAmt1, "###########.00")
        Dim SS3 As String = "        " + Format(TotAmt1, "       ###,###,###,###,###.00")

        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,convert(varchar(10),InvDt,103) as InvDt ,InvNo , InvDes ,CONVERT(DECIMAL(10,2),InvAmt,2) as InvAmt from InlInv where VouNo='" & Trim(TxtBillNo.Text) & "' and company='" & Trim(TxtCompany.Text) & "' order by Id", CON)

        cmdCustomers.CommandType = CommandType.Text
        'objConn.Open()
        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()
        CON.Close()
    End Sub
    Protected Sub MyDataGrid_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs) Handles MyDataGrid.RowCommand



        If e.CommandName = "Delete" Then
            Dim id As Integer = Convert.ToInt32(e.CommandArgument)
            ' Code to delete the data item with the specified ID '
            Dim DeleteCmd As String = "DELETE from InlInv Where id =" & id

            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            ' Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))

            Cmd.ExecuteNonQuery()

            'BindTheGrid()
        End If

        'BindTheGrid()
    End Sub

    Protected Sub MyDataGrid_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs) Handles MyDataGrid.RowDeleting

        BindTheGrid1()

        ' Code to delete the row from the GridView control '
    End Sub
    Public Sub BindData()
        ADA = New SqlDataAdapter("SELECT * FROM CheVoucher WHERE Inv_No = '" & Trim(LstInvoice.SelectedValue) & "'", CON)
        DS = New DataSet
        ADA.Fill(DS, "CheVoucher")
        count = DS.Tables("CheVoucher").Rows.Count
        For Each Me.Dtr1 In DS.Tables("CheVoucher").Rows

            'CMD.CommandText = ("INSERT INTO WFMasAA (Mas_Refno,Mas_CusCode,Mas_InvNo,Mas_InvDt,Mas_Term,Mas_JobNo,Mas_Ves,Mas_Vog,Mas_Pol,Mas_Etd,Mas_Eta,Mas_Shipper,Mas_Cdty,Mas_Rem,Mas_Bilno,Mas_MbNo,Mas_NoPkg,Mas_Gw,Mas_Vol,Mas_NoCntr,Mas_Cncy,Mas_CnDtl) VALUES ('" & Refno.Text & "','" & Mid(Trim(Lstcom.SelectedValue), 1, 3) & "','" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtTerm.Text) & "','" & Trim(TxtJobNo.Text) & "','" & Trim(TxtVes.Text) & "','" & Trim(TxtVog.Text) & "','" & Trim(TxtPol.Text) & "','" & Mid(Trim(TxtEdt.Text), 4, 2) + "/" + Mid(Trim(TxtEdt.Text), 1, 2) + "/" + Mid(Trim(TxtEdt.Text), 7, 4) & "','" & Mid(Trim(TxtEta.Text), 4, 2) + "/" + Mid(Trim(TxtEta.Text), 1, 2) + "/" + Mid(Trim(TxtEta.Text), 7, 4) & "','" & Trim(LstShipper.SelectedValue) & "','" & Trim(TxtCdty.Text) & "','" & Trim(TxtRem.Text) & "','" & Trim(TxtBlno.Text) & "','" & Trim(TxtMbno.Text) & "','" & Trim(TxtNoPkg.Text) & "'," & Trim(txtGw.Text) & "," & Trim(TxtVol.Text) & ",'" & Trim(txtNoCntr.Text) & "','" & Trim(txtFcncy.Text) & "','" & Trim(TxtCon.Text) & "')")
            'CMD.ExecuteNonQuery()



            SS = Trim(Dtr1("Inv_Com"))

            CMD = New SqlCommand("SELECT Com_No,Com_Nam From Supplier where Com_No='" & SS & "' order by Com_Nam", CON)

            DR = CMD.ExecuteReader
            While DR.Read
                TT = Trim(DR.GetValue(0)) + "-" + Trim(DR.GetValue(1))
                LstCom.SelectedValue = TT
            End While

            TxtCom.Text = Mid(Trim(LstCom.SelectedValue), 1, 4)
            DR.Close()




            Try
                TxtBillNo.Text = Dtr1("Inv_No")
            Catch ex As Exception
                TxtBillNo.Text = ""
            End Try



            Try

                TxtBillDt.Text = Format(DateValue(Dtr1("Inv_Dt")), "dd/MM/yyyy")

            Catch ex As Exception

            End Try


            Try
                TxtDes.Text = Dtr1("Inv_Des1")
            Catch ex As Exception

            End Try
            Try
                TxtChqNo.Text = Dtr1("Inv_ChqNo")
            Catch ex As Exception
            End Try
            Try
                TxtChqDt.Text = Format(DateValue(Dtr1("Inv_Chqdt")), "dd/MM/yyyy")
            Catch ex As Exception
            End Try

        Next
    End Sub



    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        'Dim strConn As String = "Provider=Microsoft.Jet.Sql.4.0;Data Source=" & server.mappath("\pathAndNameToYourDB.mdb") & ";"
        Dim DeleteCmd As String = "DELETE from WFMasA Where id = @Id"
        'Dim MyConn As New SqlConnection(CON)
        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))
        'CON.Open()
        Cmd.ExecuteNonQuery()
        'CON.Close()
        BindTheGrid1()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LstInvNo.Visible = True
        LstInvNo.Enabled = True
        'TxtInvNo.Visible = False
        'TxtInvNo.Enabled = False
        ' BtnAdd.Enabled = False
        BtnSave.Enabled = False
        ' BtnEdit.Enabled = False

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        CMD.Connection = CON
        'SS = "UPDATE ShipDocs SET Mas_flag7='Y',CL_BlDt='" & Format(DateValue(TxtBillDt.Text), "MM/dd/yyyy") & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "'    where Mas_Refno='" & Trim(TxtRefno.Text) & "'"
        '' CMD.CommandText = ("UPDATE ShipDocs SET Mas_flag7='Y',CL_BlDt='" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "',CL_Ctns='" & Trim(TxtCtns.Text) & "' where Mas_Refno='" & Trim(TxtRefno.Text) & "'")
        CMD.ExecuteNonQuery()

        BtnSave.Enabled = False

    End Sub





    Private Overloads Sub ImgBt_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBt.Click

        ' TxtRem.Visible = False
        'TxtCon.Visible = False
        ' Panel2.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "1"
    End Sub

    Private Overloads Sub ImgBt1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBt1.Click

        ' TxtRem.Visible = False
        'TxtCon.Visible = False
        ' Panel2.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "3"
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        If TxtEpfNo.Text = "1" Then
            TxtBillDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
            TxtChqDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
            TxtInvDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        If TxtEpfNo.Text = "2" Then
            TxtInvDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        If TxtEpfNo.Text = "3" Then
            TxtChqDt.Text = Format((Calendar1.SelectedDate).ToString("dd/MM/yyyy"))
        End If
        Calendar1.Visible = False


        'TxtRem.Visible = True'
        ' TxtCon.Visible = True
        'Panel2.Visible = True
        'BindTheGrid()
    End Sub




    Private Sub Reflist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not IsPostBack Then
        ''TxtRefno.Text = Trim(Reflist.SelectedValue)
        TxtBillNo.Text = Right(Trim(TxtRefno.Text), 4)
        ImageButton1.Enabled = True
        BindTheGrid1()
        BindData()

        'End If
    End Sub


    Private Sub ImageButton2_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click


        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()
        CMD = New SqlCommand("SELECT * From Supplier ", CON)

        DR = CMD.ExecuteReader
        'If BtnEdit.Enabled = True Then
        'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        'Else
        DR.Close()

        'If BtnEdit.Enabled = True Then
        'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        'Else
        If Trim(TxtInvDt.Text) = "" Or Trim(TxtInvDt.Text) = "-" Then
            CMD.CommandText = ("INSERT INTO InlInv (InvNo,InvDes,InvAmt,VouNo,Company) VALUES ('" & Trim(TxtInvNo.Text) & "','" & Trim(TxtInvDes.Text) & "','" & Trim(TxtInvAmt.Text) & "','" & Trim(TxtBillNo.Text) & "','" & Trim(TxtCompany.Text) & "')")

        Else

            CMD.CommandText = ("INSERT INTO InlInv (InvDt,InvNo,InvDes,InvAmt,VouNo,Company) VALUES ('" & Mid(Trim(TxtInvDt.Text), 4, 2) + "/" + Mid(Trim(TxtInvDt.Text), 1, 2) + "/" + Mid(Trim(TxtInvDt.Text), 7, 4) & "','" & Trim(TxtInvNo.Text) & "','" & Trim(TxtInvDes.Text) & "','" & Trim(TxtInvAmt.Text) & "','" & Trim(TxtBillNo.Text) & "','" & Trim(TxtCompany.Text) & "')")

        End If
        ' End If
        ' End If

        CMD.ExecuteNonQuery()
        BindTheGrid1()

        TxtInvDt.Text = ""
        TxtInvDes.Text = ""
        TxtInvAmt.Text = "0"

    End Sub

    Private Sub Imagebutton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()
        CMD = New SqlCommand("SELECT * From Supplier ", CON)

        DR = CMD.ExecuteReader
        'If BtnEdit.Enabled = True Then
        'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
        'Else
        DR.Close()
        'SS = "UPDATE ShipDocs SET Mas_flag7='Y',CL_BlDt='" & Format(DateValue(TxtBillDt.Text), "MM/dd/yyyy") & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "'    where Mas_Refno='" & Trim(TxtRefno.Text) & "'"
        'CMD.CommandText = ("UPDATE WfMasAA SET Mas_flag7='Y',CL_BlDt='" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "',CL_WName='" & Trim(TxtWName.Text) & "',CL_EntryNo='" & Trim(TxtEntry.Text) & "',CL_Ves='" & Trim(TxtVName.Text) & "',CL_LName='" & Trim(TxtLName.Text) & "',CL_Ctns='" & Trim(TxtCtns.Text) & "' where Mas_Refno='" & Trim(TxtRefno.Text) & "'")


        If TxtPer.Text = "N" Then

            CMD.CommandText = ("INSERT INTO CheVoucher (Inv_No,Inv_Com,Inv_Des1,Inv_Dt,Inv_ChqNo,Inv_TotVal,Inv_ChqDt,Inv_Company) VALUES ('" & Trim(TxtBillNo.Text) & "','" & Mid(Trim(LstCom.SelectedValue), 1, 4) & "','" & Trim(TxtDes.Text) & "','" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "','" & Trim(TxtChqNo.Text) & "','" & Trim(TxtInTotA1.Text) & "','" & Mid(Trim(TxtChqDt.Text), 4, 2) + "/" + Mid(Trim(TxtChqDt.Text), 1, 2) + "/" + Mid(Trim(TxtChqDt.Text), 7, 4) & "','" & Trim(TxtCompany.Text) & "')")
            CMD.ExecuteNonQuery()

            ImageButton1.Enabled = False


            CMD.CommandText = ("UPDATE FreInvNo SET Inv_No=" & (Val(Trim(TxtBillNo.Text)) + 1) & ",Chq_No=" & (Val(Trim(TxtChqNo.Text)) + 1) & " where Inv_Com='" & Trim(TxtCompany.Text) & "'")
            CMD.ExecuteNonQuery()

            ImageButton1.Visible = True
            ImageButton1.Enabled = False
            'ImageButton6.Visible = True
            ImageButton1.ImageUrl = "~/Menu/save1.png"

            ImageButton7.Visible = True



        Else


            CMD.CommandText = ("UPDATE CheVoucher SET Inv_No='" & Trim(TxtBillNo.Text) & "',Inv_Com='" & Mid(Trim(LstCom.SelectedValue), 1, 4) & "',Inv_Dt='" & Mid(Trim(TxtBillDt.Text), 4, 2) + "/" + Mid(Trim(TxtBillDt.Text), 1, 2) + "/" + Mid(Trim(TxtBillDt.Text), 7, 4) & "',Inv_ChqNo='" & Trim(TxtChqNo.Text) & "',Inv_Company='" & Trim(TxtCompany.Text) & "',Inv_TotVal=" & Trim(TxtInTotA1.Text) & ",Inv_ChqDt='" & Mid(Trim(TxtChqDt.Text), 4, 2) + "/" + Mid(Trim(TxtChqDt.Text), 1, 2) + "/" + Mid(Trim(TxtChqDt.Text), 7, 4) & "' where Inv_No='" & Trim(TxtBillNo.Text) & "' and Inv_Company='" & Trim(TxtCompany.Text) & "'")
            CMD.ExecuteNonQuery()

            ImageButton1.Visible = True
            ImageButton1.Enabled = False
            'ImageButton6.Visible = True
            ImageButton1.ImageUrl = "~/Menu/save1.png"

            ImageButton7.Visible = True




        End If




    End Sub

    Private Sub Imagebutton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        Dim DSS As ChqCommercialdfo = New ChqCommercialdfo
        CrystalReportViewer1.Visible = True
        ' Try
        DSS.SetDatabaseLogon("sa", "tstc@123")
        ' Catch ex As Exception
        ' DSS.SetDatabaseLogon("user1", "1234")
        'End Try
        'DSS.SetDatabaseLogon("user1", "1234")


        'DSS.SetDatabaseLogon("sa", "tstc@123", "SGCSIT\SQLEXPRESS", "DFO")
        DSS.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperEnvelope10
        DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        DSS.SetParameterValue("refno", "" & Trim(TxtBillNo.Text) & "")
        'DSS.SetParameterValue("ComCode", "" & Trim(TxtBillNo.Text) & "")
        DSS.SetParameterValue("ComCode", "" & Trim(TxtCompany.Text) & "")
        ' DSS.SetParameterValue("Amt", "" & Trim(TxtInTot.Text) & "")
        DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
        DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

        ' TxtRefno.Text = ""

        CrystalReportViewer1.SeparatePages = True

        CrystalReportViewer1.ReportSource = DSS

        CrystalReportViewer1.HasRefreshButton = True
        CrystalReportViewer1.HasZoomFactorList = True
        CrystalReportViewer1.HasPageNavigationButtons = True
        CrystalReportViewer1.HasDrillUpButton = True
        'CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.DataBind()


        '--------------
        Try


            SS1 = "Che" & Trim(TxtBillNo.Text) & ".pdf"
            SS = Server.MapPath(".") + "\Data\" & SS1

            oStream = DSS.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
            Response.AddHeader("content-disposition", "attachment;filename=Che" & Trim(TxtChqNo.Text) & ".pdf")
            'Response.AddHeader("content-disposition", "attachment;filename='" & SS & "'")
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"

            Response.BinaryWrite(oStream.ToArray())
            Response.End()


        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub Imagebutton5_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        'TxtRem.Visible = False
        'TxtCon.Visible = False
        Calendar1.Visible = True
        TxtEpfNo.Text = "2"
    End Sub



    Private Sub Imagebutton7_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton7.Click
        ImageButton1.Visible = True
        ImageButton1.Enabled = True
        'ImageButton6.Visible = True
        ImageButton1.ImageUrl = "~/Menu/save11.png"

        TxtPer.Text = "N"

        TxtPer.Text = "N"

        ADA = New SqlDataAdapter("SELECT * FROM FreInvNo where Inv_Com='" & Trim(TxtCompany.Text) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "FreInvNo")

        count1 = DS.Tables("FreInvNo").Rows.Count


        If count1 <> 0 Then

            For Each Me.drt2 In DS.Tables("FreInvNo").Rows
                '
                Dim q, s As String
                Dim p As Double
                s = drt2("Inv_no")
                p = drt2("Inv_no")
                q = Format(p, "000000")

                TxtRefno.Text = p
                'TxtChqNo.Text = Trim(drt2("Inv_Ref")) + Mid(Trim(Year(Today())), 3, 2) + "/" + q
                'TxtBillNo.Text = "SLPLI" + Mid(Trim(Year(Today())), 3, 2) + q
                'TxtBillNo.Text = "2023/" + q
                TxtBillNo.Text = q
                Try
                    TxtChqNo.Text = Format(drt2("Chq_No"), "000000")
                Catch ex As Exception
                End Try

            Next
        Else
            ' Response.Redirect("InsuDept.aspx")
            TxtBillNo.Text = "000001"
            TxtChqNo.Text = ""

            CON = New SqlConnection
            CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
            'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
            CON.Open()
            CMD = New SqlCommand("SELECT * From Supplier ", CON)

            DR = CMD.ExecuteReader
            'If BtnEdit.Enabled = True Then
            'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
            'Else
            DR.Close()

            'If BtnEdit.Enabled = True Then
            'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
            'Else


            CMD.CommandText = ("INSERT INTO FreInvNo (Inv_No,Chq_No,Inv_Com) VALUES (1,1,'" & Trim(TxtCompany.Text) & "')")


            ' End If
            ' End If

            CMD.ExecuteNonQuery()
        End If

        'TxtBillNo.Text = ""
        TxtDes.Text = ""
        TxtInvNo.Text = ""
        TxtBillDt.Text = ""
        'TxtChqNo.Text = ""
        TxtInvAmt.Text = "0"
        TxtInvDes.Text = ""
        TxtInvDt.Text = ""
        ''sinvno = Mid(Trim(TxtRefno.Text), 8, 5)

        '' Dim Cmd11 As New SqlCommand("UPDATE RefNo SET refno=" & sinvno, CON)
        ''Cmd11.ExecuteNonQuery()

        '-----
        BindTheGrid1()

    End Sub



    Private Sub LstInvoice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstInvoice.SelectedIndexChanged
        ImageButton1.Visible = True
        ImageButton1.Enabled = True
        'ImageButton6.Visible = True
        ImageButton1.ImageUrl = "~/Menu/save11.png"
        BindData()
        BindTheGrid1()
        TxtPer.Text = "Y"

    End Sub



    Protected Sub ImageButton8_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton8.Click

        Dim DSS1 As VouCus = New VouCus
        Vou1 = "DSS1"
        If Trim(TxtCompany.Text) = "SLP" Then
            Dim DSS2 As VouCusSLP = New VouCusSLP

            CrystalReportViewer1.Visible = True



            DSS2.SetDatabaseLogon("sa", "tstc@123")
            'DSS1.SetDatabaseLogon("user1", "1234")

            DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
            DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



            DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

            DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
            'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
            'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

            ' TxtRefno.Text = ""

            CrystalReportViewer1.SeparatePages = True

            CrystalReportViewer1.ReportSource = DSS2

            CrystalReportViewer1.HasRefreshButton = True
            CrystalReportViewer1.HasZoomFactorList = True
            CrystalReportViewer1.HasPageNavigationButtons = True
            CrystalReportViewer1.HasDrillUpButton = True
            'CrystalReportViewer1.RefreshReport()
            CrystalReportViewer1.DataBind()


            '--------------
            Try
                oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                Response.Clear()
                Response.Buffer = True
                Response.ContentType = "application/pdf"

                Response.BinaryWrite(oStream.ToArray())
                Response.End()
            Catch ex As Exception
                ' MsgBox(ex.ToString)
            End Try

        Else
            If Trim(TxtCompany.Text) = "HTL" Then
                Dim DSS2 As VouCusHTL = New VouCusHTL

                CrystalReportViewer1.Visible = True



                DSS2.SetDatabaseLogon("sa", "tstc@123")
                'DSS1.SetDatabaseLogon("user1", "1234")
                DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                ' TxtRefno.Text = ""

                CrystalReportViewer1.SeparatePages = True

                CrystalReportViewer1.ReportSource = DSS2

                CrystalReportViewer1.HasRefreshButton = True
                CrystalReportViewer1.HasZoomFactorList = True
                CrystalReportViewer1.HasPageNavigationButtons = True
                CrystalReportViewer1.HasDrillUpButton = True
                'CrystalReportViewer1.RefreshReport()
                CrystalReportViewer1.DataBind()


                '--------------
                Try
                    oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                    Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                    Response.Clear()
                    Response.Buffer = True
                    Response.ContentType = "application/pdf"

                    Response.BinaryWrite(oStream.ToArray())
                    Response.End()
                Catch ex As Exception
                    ' MsgBox(ex.ToString)
                End Try




                DSS1 = New VouCus
                Vou1 = "DSS3"



            Else
                If Trim(TxtCompany.Text) = "SGC" Then
                    Dim DSS2 As VouCusSGC = New VouCusSGC

                    CrystalReportViewer1.Visible = True



                    DSS2.SetDatabaseLogon("sa", "tstc@123")
                    'DSS1.SetDatabaseLogon("user1", "1234")
                    DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                    DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                    'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                    DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                    DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                    'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                    'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                    ' TxtRefno.Text = ""

                    CrystalReportViewer1.SeparatePages = True

                    CrystalReportViewer1.ReportSource = DSS2

                    CrystalReportViewer1.HasRefreshButton = True
                    CrystalReportViewer1.HasZoomFactorList = True
                    CrystalReportViewer1.HasPageNavigationButtons = True
                    CrystalReportViewer1.HasDrillUpButton = True
                    'CrystalReportViewer1.RefreshReport()
                    CrystalReportViewer1.DataBind()


                    '--------------
                    Try
                        oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                        Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                        Response.Clear()
                        Response.Buffer = True
                        Response.ContentType = "application/pdf"

                        Response.BinaryWrite(oStream.ToArray())
                        Response.End()
                    Catch ex As Exception
                        ' MsgBox(ex.ToString)
                    End Try


                Else
                    If Trim(TxtCompany.Text) = "LOG" Then
                        Dim DSS2 As VouCusLHP = New VouCusLHP

                        CrystalReportViewer1.Visible = True



                        DSS2.SetDatabaseLogon("sa", "tstc@123")
                        'DSS1.SetDatabaseLogon("user1", "1234")
                        DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                        DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                        'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                        DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                        DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                        'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                        'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                        ' TxtRefno.Text = ""

                        CrystalReportViewer1.SeparatePages = True

                        CrystalReportViewer1.ReportSource = DSS2

                        CrystalReportViewer1.HasRefreshButton = True
                        CrystalReportViewer1.HasZoomFactorList = True
                        CrystalReportViewer1.HasPageNavigationButtons = True
                        CrystalReportViewer1.HasDrillUpButton = True
                        'CrystalReportViewer1.RefreshReport()
                        CrystalReportViewer1.DataBind()


                        '--------------
                        Try
                            oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                            Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                            Response.Clear()
                            Response.Buffer = True
                            Response.ContentType = "application/pdf"

                            Response.BinaryWrite(oStream.ToArray())
                            Response.End()
                        Catch ex As Exception
                            ' MsgBox(ex.ToString)
                        End Try

                    Else
                        If Trim(TxtCompany.Text) = "SIB" Then
                            Dim DSS2 As VouCusSIB = New VouCusSIB

                            CrystalReportViewer1.Visible = True



                            DSS2.SetDatabaseLogon("sa", "tstc@123")
                            'DSS1.SetDatabaseLogon("user1", "1234")
                            DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                            DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                            'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                            DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                            DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                            'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                            'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                            ' TxtRefno.Text = ""

                            CrystalReportViewer1.SeparatePages = True

                            CrystalReportViewer1.ReportSource = DSS2

                            CrystalReportViewer1.HasRefreshButton = True
                            CrystalReportViewer1.HasZoomFactorList = True
                            CrystalReportViewer1.HasPageNavigationButtons = True
                            CrystalReportViewer1.HasDrillUpButton = True
                            'CrystalReportViewer1.RefreshReport()
                            CrystalReportViewer1.DataBind()


                            '--------------
                            Try
                                oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                                Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                                Response.Clear()
                                Response.Buffer = True
                                Response.ContentType = "application/pdf"

                                Response.BinaryWrite(oStream.ToArray())
                                Response.End()
                            Catch ex As Exception
                                ' MsgBox(ex.ToString)
                            End Try

                        Else
                            If Trim(TxtCompany.Text) = "WHP" Then
                                Dim DSS2 As VouCusWHP = New VouCusWHP

                                CrystalReportViewer1.Visible = True



                                DSS2.SetDatabaseLogon("sa", "tstc@123")
                                'DSS1.SetDatabaseLogon("user1", "1234")
                                DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                                DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                                'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                                DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                                DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                                'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                                'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                                ' TxtRefno.Text = ""

                                CrystalReportViewer1.SeparatePages = True

                                CrystalReportViewer1.ReportSource = DSS2

                                CrystalReportViewer1.HasRefreshButton = True
                                CrystalReportViewer1.HasZoomFactorList = True
                                CrystalReportViewer1.HasPageNavigationButtons = True
                                CrystalReportViewer1.HasDrillUpButton = True
                                'CrystalReportViewer1.RefreshReport()
                                CrystalReportViewer1.DataBind()


                                '--------------
                                Try
                                    oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                                    Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                                    Response.Clear()
                                    Response.Buffer = True
                                    Response.ContentType = "application/pdf"

                                    Response.BinaryWrite(oStream.ToArray())
                                    Response.End()
                                Catch ex As Exception
                                    ' MsgBox(ex.ToString)
                                End Try

                            Else
                                If Trim(TxtCompany.Text) = "SPL" Then
                                    Dim DSS2 As VouCusSPL = New VouCusSPL

                                    CrystalReportViewer1.Visible = True



                                    DSS2.SetDatabaseLogon("sa", "tstc@123")
                                    'DSS1.SetDatabaseLogon("user1", "1234")
                                    DSS2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                                    DSS2.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                                    'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                                    DSS2.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                                    DSS2.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                                    'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                                    'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                                    ' TxtRefno.Text = ""

                                    CrystalReportViewer1.SeparatePages = True

                                    CrystalReportViewer1.ReportSource = DSS2

                                    CrystalReportViewer1.HasRefreshButton = True
                                    CrystalReportViewer1.HasZoomFactorList = True
                                    CrystalReportViewer1.HasPageNavigationButtons = True
                                    CrystalReportViewer1.HasDrillUpButton = True
                                    'CrystalReportViewer1.RefreshReport()
                                    CrystalReportViewer1.DataBind()


                                    '--------------
                                    Try
                                        oStream = DSS2.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                                        Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtCompany.Text) & Trim(TxtBillNo.Text) & ".pdf")
                                        Response.Clear()
                                        Response.Buffer = True
                                        Response.ContentType = "application/pdf"

                                        Response.BinaryWrite(oStream.ToArray())
                                        Response.End()
                                    Catch ex As Exception
                                        ' MsgBox(ex.ToString)
                                    End Try

                                    DSS1 = New VouCus
                                    Vou1 = "DSS3"

                                Else
                                    CrystalReportViewer1.Visible = True



                                    DSS1.SetDatabaseLogon("sa", "tstc@123")
                                    'DSS1.SetDatabaseLogon("user1", "1234")
                                    DSS1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperB5
                                    DSS1.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
                                    'DSS.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape



                                    DSS1.SetParameterValue("InvNo", "" & Trim(TxtBillNo.Text) & "")

                                    DSS1.SetParameterValue("Com", "" & Trim(TxtCompany.Text) & "")
                                    'DSS.SetParameterValue("AmtStr", "" & Trim(TxtInTotA.Text) & "")
                                    'DSS.SetParameterValue("Chqdt", "" & TxtChqDt.Text & "")

                                    ' TxtRefno.Text = ""

                                    CrystalReportViewer1.SeparatePages = True

                                    CrystalReportViewer1.ReportSource = DSS1

                                    CrystalReportViewer1.HasRefreshButton = True
                                    CrystalReportViewer1.HasZoomFactorList = True
                                    CrystalReportViewer1.HasPageNavigationButtons = True
                                    CrystalReportViewer1.HasDrillUpButton = True
                                    'CrystalReportViewer1.RefreshReport()
                                    CrystalReportViewer1.DataBind()


                                    '--------------
                                    Try
                                        oStream = DSS1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat)
                                        Response.AddHeader("content-disposition", "attachment;filename=Vou" & Trim(TxtBillNo.Text) & ".pdf")
                                        Response.Clear()
                                        Response.Buffer = True
                                        Response.ContentType = "application/pdf"

                                        Response.BinaryWrite(oStream.ToArray())
                                        Response.End()
                                    Catch ex As Exception
                                        ' MsgBox(ex.ToString)
                                    End Try



                                End If
                    End If
                End If
            End If
                End If
            End If
        End If

       


    End Sub


    Protected Sub LstCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstCompany.SelectedIndexChanged
        TxtCompany.Text = Mid(Trim(LstCompany.SelectedValue), 1, 3)

        CMD = New SqlCommand("SELECT Inv_No From CheVoucher where Inv_Company='" & Trim(TxtCompany.Text) & "' order by Inv_No", CON)

        DR = CMD.ExecuteReader
        LstInvoice.Items.Clear()
        While DR.Read
            TT = Trim(DR.GetValue(0))
            LstInvoice.Items.Add(TT)
        End While
        'TxtCom.Text = Mid(Trim(LstCom.SelectedValue), 1, 4)
        DR.Close()

        Calendar1.Visible = False
        LstFlag2.SelectedValue = "No"
        'Label11.Visible = False
        LstFlag2.Visible = False
        TxtPer.Visible = False
        TxtPer.Text = 0

        ' End If
        TxtChqNo.Visible = True
        TxtChqNo.Enabled = True
        TxtChqNo.Text = ""
        '-----
        ImageButton1.Visible = True
        ImageButton1.Enabled = True
        'ImageButton6.Visible = True
        ImageButton1.ImageUrl = "~/Menu/save11.png"
        ' TxtInvDt.Text = " "


        'ADA = New SqlDataAdapter("SELECT * FROM InvoiceNo", CON)

        TxtRefno.ReadOnly = False

        TxtPer.Text = "N"

        ADA = New SqlDataAdapter("SELECT * FROM FreInvNo where Inv_Com='" & Trim(TxtCompany.Text) & "'", CON)

        DS = New DataSet
        ADA.Fill(DS, "FreInvNo")

        count1 = DS.Tables("FreInvNo").Rows.Count


        If count1 <> 0 Then

            For Each Me.drt2 In DS.Tables("FreInvNo").Rows
                '
                Dim q, s As String
                Dim p As Double
                s = drt2("Inv_no")
                p = drt2("Inv_no")
                q = Format(p, "000000")

                TxtRefno.Text = p
                'TxtChqNo.Text = Trim(drt2("Inv_Ref")) + Mid(Trim(Year(Today())), 3, 2) + "/" + q
                'TxtBillNo.Text = "SLPLI" + Mid(Trim(Year(Today())), 3, 2) + q
                'TxtBillNo.Text = "2023/" + q
                TxtBillNo.Text = q
                Try
                    TxtChqNo.Text = Format(drt2("Chq_No"), "000000")
                Catch ex As Exception
                End Try

            Next
        Else
            ' Response.Redirect("InsuDept.aspx")
            TxtBillNo.Text = "000001"
            TxtChqNo.Text = ""
            CON = New SqlConnection
            CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
            'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
            CON.Open()
            CMD = New SqlCommand("SELECT * From Supplier ", CON)

            DR = CMD.ExecuteReader
            'If BtnEdit.Enabled = True Then
            'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
            'Else
            DR.Close()

            'If BtnEdit.Enabled = True Then
            'CMD.CommandText = ("INSERT INTO InlTemp (Inv_No,Inv_ItmNo,Inv_des,Inv_pr,Inv_val,Inv_qty) VALUES ('" & LstInvNo.SelectedValue & "','" & Sitmno & "','" & Sdes & "'," & Spri & "," & SVal & "," & SQty & ")")
            'Else


            CMD.CommandText = ("INSERT INTO FreInvNo (Inv_No,Chq_No,Inv_Com) VALUES (1,1,'" & Trim(TxtCompany.Text) & "')")


            ' End If
            ' End If

            CMD.ExecuteNonQuery()

        End If

        'TxtBillNo.Text = ""
        TxtDes.Text = ""
        TxtInvNo.Text = ""
        TxtBillDt.Text = ""
        'TxtChqNo.Text = ""
        TxtInvAmt.Text = "0"
        TxtInvDes.Text = ""
        TxtInvDt.Text = ""
        ''sinvno = Mid(Trim(TxtRefno.Text), 8, 5)

        '' Dim Cmd11 As New SqlCommand("UPDATE RefNo SET refno=" & sinvno, CON)
        ''Cmd11.ExecuteNonQuery()

        '-----
        BindTheGrid1()



    End Sub
End Class
