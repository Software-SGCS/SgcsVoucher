Imports System.Web.UI.WebControls
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Mail
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System
Imports System.Web.Security
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports CrystalDecisions.CrystalReports.Engine


Public Class EntryCustomer
    Inherits System.Web.UI.Page
    Dim CON As SqlConnection

    Dim ADA, ADA1 As SqlDataAdapter
    Dim CMD, CMD1 As SqlCommand
    Dim DR, DR1, DR2, DR3 As SqlDataReader
    Dim DS, DS1 As DataSet
    Dim DV As DataView
    Dim LOD As String
    Dim drt2, drt3, drt1 As DataRow
    Dim CHKDUP As Boolean
    'Dim CMD1 As SqlCommand
    Dim RE As SqlDataReader
    Dim RE1 As SqlDataReader
    Dim CRI1, CRI2, CRI3 As String
    Dim str1, str2 As String
    Dim Sinvno As String
    Dim TempEmpno, TempCom As String
    Dim ss, Pflag As String
    Dim Tno As String
    Dim Tno1 As String
    Dim Tno2 As String
    Dim count1, Count2 As Integer
    Dim StrConCode, StrConNam, StrConAdd1, StrConAdd2, StrConAdd3, StrBnkNam, StrBnkAdd, StrCod, Strpod, StrExg, StrCncy As String

    Protected WithEvents dtgCustomers As System.Web.UI.WebControls.DataGrid
    Dim TT As String
    Dim TT1 As String
    Protected WithEvents BtnSave11 As System.Web.UI.WebControls.Button


    Protected WithEvents lbtnEdit As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lbtnUpdate As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lbtnCancel As System.Web.UI.WebControls.LinkButton
    Protected WithEvents lblDelete As System.Web.UI.WebControls.LinkButton
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel

    Protected WithEvents Save111 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents L1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    Protected WithEvents Save1111 As System.Web.UI.WebControls.ImageButton


    Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox


    Protected strCountry As String


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Protected WithEvents Panel4 As System.Web.UI.WebControls.Panel

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init

        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load



        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()



        'Global.PwFlag = "N"

        'If Global.PwLevel = "1" Then
        'lobal.PwFlag = "Y"

        'Else
        '    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level='" & Global.PwLevel & "'", CON)

        '   DR = CMD.ExecuteReader
        '   While DR.Read
        '    End While

        '   DR.Close()

        'End If

        '----------------
        Pflag = "N"

        If Count2 = "1" Then
            Pflag = "Y"
        Else

            If Count2 = "2" Then
                CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level2='1'", CON)

            Else
                If Count2 = "3" Then
                    CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level3='1'", CON)

                Else
                    If Count2 = "4" Then
                        CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level4='1'", CON)
                    Else
                        If Count2 = "5" Then

                            CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='ExpNewEntry7.aspx' and Form_level5='1'", CON)

                        Else
                            '   CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PQR.aspx' and Form_level='" & Global.PwLevel & "'", CON)

                        End If

                    End If
                End If

            End If
            'CMD = New SqlCommand("SELECT Form_name,Form_level FROM FormTable where Form_name='PosOpEntry.aspx' and Form_level='" & Global.PwLevel & "'", CON)

            '  DR = CMD.ExecuteReader
            ' While DR.Read
            Pflag = "Y"
            ' End While

            'DR.Close()
        End If

        If Pflag = "Y" Then
            Response.AddHeader("Refresh", 1800)
        Else
            Response.Redirect("POSDispaly11.aspx")
        End If


        '-----------------


        ' BttIns1.Enabled = False
        If Not IsPostBack Then

            ' Panel6.BackImageUrl = "Menu\EmpMaster4.jpg"


            Save11.Visible = True
            Save1.Visible = False
            Save11.Enabled = True
            Save11.ImageUrl = "Menu\save11.png"

            BindTheGrid()
        End If




    End Sub
    Public Sub BindTheGrid()
        'Try
        ' CON.Close()



        ss = "Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster where trim(emp_No)='" & Trim(TempEmpno) & "' and Emp_Com='" & TempCom & "'"


        Dim cmdCustomers As SqlCommand = New SqlCommand("Select id,Com_No,Com_Nam,Com_Add1,Com_Email,Com_Per From Supplier order by Com_No,Com_Nam", CON)

        ''Dim cmdCustomers As SqlCommand = New SqlCommand("Select Id,Emp_Nam,Emp_RelType,Format(Emp_Dod,'dd/MM/yyyy') as EmpDod,format(Emp_DeathAmt,'#,###.00') as EmpDeathamt, Format(Emp_PayDt,'dd/MM/yyyy') as EmpPaydt,Emp_chqno from RelationMaster", CON)

        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType from RelationMaster", CON)
        'Dim cmdCustomers As SqlCommand = New SqlCommand("Select ID,Emp_Nam,Emp_RelType,Emp_Chqno from RelationMaster", CON)
        cmdCustomers.CommandType = CommandType.Text
        MyDataGrid.Enabled = True

        MyDataGrid.DataSource = cmdCustomers.ExecuteReader()
        MyDataGrid.DataBind()

        MyDataGrid.Visible = True
        ' CON.Close()

        'Catch ex As Exception

        'End Try
    End Sub



    Sub MyDataGrid_UpdateCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)

        Dim cmdCustomers As SqlCommand


        Dim stritmNo As String = e.Item.Cells(2).Text
        Dim strdes As String = e.Item.Cells(3).Text
        Dim strpr As String = e.Item.Cells(4).Text
        Dim StrQty As String = e.Item.Cells(5).Text
        Dim strval As String = e.Item.Cells(6).Text


        Dim StrSql As String


        StrSql = "UPDATE InlTemp SET Inv_Qty=" & StrQty & " WHERE Inv_Itmno='" & stritmNo & "'"
        cmdCustomers = New SqlCommand(StrSql, CON)
        ' Con.Open()
        'cmdCustomers.ExecuteReader(CommandBehavior.CloseConnection)
        'MyDataGrid.EditItemIndex = -1
        BindTheGrid()
        MyDataGrid.Visible = True

    End Sub

    Sub MyDataGrid_EditCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)
        ''MyDataGrid.EditItemIndex = e.Item.ItemIndex
        BindTheGrid()
    End Sub
    Sub MyDataGrid_Cancel(ByVal Source As Object, ByVal E As DataGridCommandEventArgs)
        '' MyDataGrid.EditItemIndex = -1
        BindTheGrid()
    End Sub

    Private Sub LstSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindTheGrid()
    End Sub

    Private Sub BttIns1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MyDataGrid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDataGrid.SelectedIndexChanged

    End Sub

    Private Sub TxtConCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' CON.Open()


    End Sub

    Private Sub TxtCncy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Imagebutton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)


        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()

        ss = "SELECT * FROM  Supplier WHERE Com_No = '" & Trim(TxtConCode.Text) & "'"
        ADA = New SqlDataAdapter("SELECT * FROM Supplier WHERE Com_No = '" & Trim(TxtConCode.Text) & "'", CON)
        DS1 = New DataSet

        ADA.Fill(DS1, "Supplier")
        Save11.Visible = True
        Save1.Visible = False
        count1 = DS1.Tables("Supplier").Rows.Count

        If count1 <> 0 Then
            TxtConCode.Enabled = True
            TxtConNam.Enabled = True
            TxtConAdd1.Enabled = True

            TxtCusEmail.Enabled = True

            For Each Me.drt2 In DS1.Tables("Supplier").Rows

                TxtConCode.Text = drt2("Com_No")

                Try
                    TxtConNam.Text = drt2("Com_Nam")
                Catch ex As Exception
                    TxtConNam.Text = ""
                End Try

                Try
                    TxtConAdd1.Text = drt2("Com_Add1")
                Catch ex As Exception
                    TxtConAdd1.Text = ""
                End Try





                Try
                    TxtContact.Text = drt2("Com_Per")
                Catch ex As Exception
                    TxtContact.Text = ""
                End Try


                Try
                    TxtCusEmail.Text = drt2("Com_Email")
                Catch ex As Exception
                    TxtCusEmail.Text = ""
                End Try

            Next

        Else
            TxtConCode.Enabled = True
            TxtConNam.Enabled = True
            TxtConAdd1.Enabled = True
            TxtContact.Enabled = True

            TxtCusEmail.Enabled = True

            ' TxtConCode.Text = " "
            TxtConNam.Text = " "
            TxtConAdd1.Text = " "
            TxtContact.Text = " "

            TxtCusEmail.Text = " "

        End If



        BindTheGrid()
    End Sub





    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

    End Sub

    Private Sub Save11_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Save11.Click

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()


        CMD = New SqlCommand("SELECT * FROM Supplier", CON)
        DR = CMD.ExecuteReader


        DR.Close()


        ADA = New SqlDataAdapter("SELECT * FROM Supplier WHERE Com_No = '" & Trim(TxtConCode.Text) & "'", CON)
        DS = New DataSet

        ADA.Fill(DS, "Supplier")

        count1 = DS.Tables("Supplier").Rows.Count

        If count1 <> 0 Then

            CMD.Connection = CON
            CMD.CommandText = ("UPDATE Supplier SET Com_No='" & Trim(TxtConCode.Text) & "',Com_Nam='" & Trim(TxtConNam.Text) & "',Com_Add1= '" & Trim(TxtConAdd1.Text) & "',Com_Email= '" & Trim(TxtCusEmail.Text) & "',Com_Per= '" & Trim(TxtContact.Text) & "' WHERE Com_No='" & Trim(TxtConCode.Text) & "'")
            CMD.ExecuteNonQuery()

        Else

            CMD.Connection = CON
            CMD.CommandText = ("INSERT INTO Supplier(Com_No,Com_Nam,Com_Add1,Com_Email,Com_Per) VALUES ('" & Trim(TxtConCode.Text) & "','" & Trim(TxtConNam.Text) & "','" & Trim(TxtConAdd1.Text) & "','" & Trim(TxtCusEmail.Text) & "','" & Trim(TxtContact.Text) & "')")
            CMD.ExecuteNonQuery()
        End If

        BindTheGrid()
        Save11.Enabled = False
        Save11.ImageUrl = "Menu\save1.png"


        ' Save1.Visible = True
    End Sub

    Private Sub Imagebutton3_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Imagebutton3.Click

        CON = New SqlConnection
        CON.ConnectionString = ("data source=SgcsIt\SQLEXPRESS;initial catalog=SgcsVoucher; user id=sa;password=tstc@123")
        'CON.ConnectionString = ("data source=(local);initial catalog=SgcsVoucher; user id=sa;password=tstc123")
        CON.Open()



        ss = "SELECT * FROM Supplier WHERE Com_No = '" & Trim(TxtConCode.Text) & "'"
        ADA = New SqlDataAdapter("SELECT * FROM Supplier WHERE Com_No = '" & Trim(TxtConCode.Text) & "'", CON)
        DS1 = New DataSet

        ADA.Fill(DS1, "Supplier")
        Save11.Visible = True
        Save1.Visible = False
        count1 = DS1.Tables("Supplier").Rows.Count

        If count1 <> 0 Then
            TxtConCode.Enabled = True
            TxtConNam.Enabled = True
            TxtConAdd1.Enabled = True

            TxtCusEmail.Enabled = True

            For Each Me.drt2 In DS1.Tables("Supplier").Rows

                TxtConCode.Text = drt2("Com_No")

                Try
                    TxtConNam.Text = drt2("Com_Nam")
                Catch ex As Exception
                    TxtConNam.Text = ""
                End Try

                Try
                    TxtConAdd1.Text = drt2("Com_Add1")
                Catch ex As Exception
                    TxtConAdd1.Text = ""
                End Try





                Try
                    TxtContact.Text = drt2("Com_Per")
                Catch ex As Exception
                    TxtContact.Text = ""
                End Try


                Try
                    TxtCusEmail.Text = drt2("Com_Emails")
                Catch ex As Exception
                    TxtCusEmail.Text = ""
                End Try

            Next

        Else
            TxtConCode.Enabled = True
            TxtConNam.Enabled = True
            TxtConAdd1.Enabled = True
            TxtContact.Enabled = True

            TxtCusEmail.Enabled = True

            ' TxtConCode.Text = " "
            TxtConNam.Text = " "
            TxtConAdd1.Text = " "
            TxtContact.Text = " "

            TxtCusEmail.Text = " "

        End If



        BindTheGrid()
    End Sub
    Protected Sub MyDataGrid_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs) Handles MyDataGrid.RowCommand



        If e.CommandName = "Delete" Then
            Dim id As Integer = Convert.ToInt32(e.CommandArgument)
            ' Code to delete the data item with the specified ID '
            Dim DeleteCmd As String = "DELETE from Supplier Where id =" & id

            Dim Cmd As New SqlCommand(DeleteCmd, CON)
            ' Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))

            Cmd.ExecuteNonQuery()

            'BindTheGrid()
        End If

        'BindTheGrid()
    End Sub

    Protected Sub MyDataGrid_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs) Handles MyDataGrid.RowDeleting

        BindTheGrid()

        ' Code to delete the row from the GridView control '
    End Sub
    Protected Sub TxtConCode_TextChanged1(ByVal sender As Object, ByVal e As EventArgs) Handles TxtConCode.TextChanged
        Save11.Enabled = True
        Save11.ImageUrl = "Menu\save11.png"

    End Sub

    Sub MyDataGrid_DeleteCommand(ByVal s As Object, ByVal e As DataGridCommandEventArgs)

        Dim DeleteCmd As String = "DELETE from Supplier Where id = @Id"

        Dim Cmd As New SqlCommand(DeleteCmd, CON)
        Cmd.Parameters.Add(New SqlParameter("@ID", MyDataGrid.DataKeys(CInt(e.Item.ItemIndex))))

        Cmd.ExecuteNonQuery()

        BindTheGrid()
    End Sub

End Class

