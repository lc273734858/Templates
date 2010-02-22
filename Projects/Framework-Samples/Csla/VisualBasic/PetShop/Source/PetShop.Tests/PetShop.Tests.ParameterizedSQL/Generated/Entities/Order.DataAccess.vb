﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1413, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Order.vb.
'
'     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Public Partial Class Order

    #Region "Root Data Access"

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()
        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return
        End If

        ValidationRules.CheckRules()

        OnCreated()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Private Shadows Sub DataPortal_Fetch(ByVal criteria As OrderCriteria )
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale], [timestamp] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Orders' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        OnFetched()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Insert()
        Dim cancel As Boolean = False
        OnInserting(cancel)
        If (cancel) Then
            Return
        End If

        Const commandText As String = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId], [timestamp] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UserId", Me.UserId)
				command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
				command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
				command.Parameters.AddWithValue("@p_ShipAddr2", Me.ShipAddr2)
				command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
				command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
				command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
				command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
				command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
				command.Parameters.AddWithValue("@p_BillAddr2", Me.BillAddr2)
				command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
				command.Parameters.AddWithValue("@p_BillState", Me.BillState)
				command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
				command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
				command.Parameters.AddWithValue("@p_Courier", Me.Courier)
				command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
				command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
				command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
				command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
				command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
				command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
				command.Parameters.AddWithValue("@p_Locale", Me.Locale)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Timestamp = ADOHelper.GetBytes(reader, "timestamp")
                        _orderId = reader.GetInt32("OrderId")
                    End If
                End Using
            End Using



            FieldManager.UpdateChildren(Me, connection)
        End Using

        OnInserted()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Update()
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If (cancel) Then
            Return
        End If

        Const commandText As String = "UPDATE [dbo].[Orders]  SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId AND [timestamp] = @p_timestamp; SELECT [timestamp] FROM [dbo].[Orders] WHERE OrderId = @p_OrderId"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
				command.Parameters.AddWithValue("@p_UserId", Me.UserId)
				command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
				command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
				command.Parameters.AddWithValue("@p_ShipAddr2", Me.ShipAddr2)
				command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
				command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
				command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
				command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
				command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
				command.Parameters.AddWithValue("@p_BillAddr2", Me.BillAddr2)
				command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
				command.Parameters.AddWithValue("@p_BillState", Me.BillState)
				command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
				command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
				command.Parameters.AddWithValue("@p_Courier", Me.Courier)
				command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
				command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
				command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
				command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
				command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
				command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
				command.Parameters.AddWithValue("@p_Locale", Me.Locale)
                command.Parameters.AddWithValue("@p_timestamp", SqlDbType.Timestamp)
                command.Parameters("@p_timestamp").Value = Me.Timestamp
                command.Parameters("@p_timestamp").Direction = ParameterDirection.InputOutput

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    If reader.RecordsAffected = 0 Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If

                    If reader.Read() Then
                        Using (BypassPropertyChecks)
                            Timestamp = ADOHelper.GetBytes(reader, "timestamp")
                            _orderId = reader.GetInt32("OrderId")
                        End Using
                    End If
                End Using
            End Using


            FieldManager.UpdateChildren(Me, connection)
        End Using

        OnUpdated()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_DeleteSelf()
        Dim cancel As Boolean = False
        OnSelfDeleting(cancel)
        If (cancel) Then
            Return
        End If
    
        DataPortal_Delete(New OrderCriteria (_orderId))
    
        OnSelfDeleted()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Shadows Sub DataPortal_Delete(ByVal criteria As OrderCriteria )
        Dim cancel As Boolean = False
        OnDeleting(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("DELETE FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
        End Using

        OnDeleted()
    End Sub

    #End Region

    #Region "Child Data Access"

    <RunLocal()> _
    Protected Overrides Sub Child_Create()
        Dim cancel As Boolean = False
        OnChildCreating(cancel)
        If (cancel) Then
            Return
        End If

        ValidationRules.CheckRules()

        OnChildCreated()
    End Sub

    Private Sub Child_Fetch(ByVal criteria As OrderCriteria )
        Dim cancel As Boolean = False
        OnChildFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale], [timestamp] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Orders' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        OnChildFetched()

        MarkAsChild()
    End Sub

    Private Sub Child_Insert(ByVal connection As SqlConnection)
        Dim cancel As Boolean = False
        OnChildInserting(cancel)
        If (cancel) Then
            Return
        End If

        If connection.State <> ConnectionState.Open Then connection.Open()
        Const commandText As String = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId], [timestamp] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()"
        Using command As New SqlCommand(commandText, connection)
            command.Parameters.AddWithValue("@p_UserId", Me.UserId)
				command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
				command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
				command.Parameters.AddWithValue("@p_ShipAddr2", Me.ShipAddr2)
				command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
				command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
				command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
				command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
				command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
				command.Parameters.AddWithValue("@p_BillAddr2", Me.BillAddr2)
				command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
				command.Parameters.AddWithValue("@p_BillState", Me.BillState)
				command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
				command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
				command.Parameters.AddWithValue("@p_Courier", Me.Courier)
				command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
				command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
				command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
				command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
				command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
				command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
				command.Parameters.AddWithValue("@p_Locale", Me.Locale)

            Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                If reader.Read() Then
                    Timestamp = ADOHelper.GetBytes(reader, "timestamp")
                    _orderId = reader.GetInt32("OrderId")
                End If
            End Using

        End Using

        OnChildInserted()
    End Sub

    Private Sub Child_Update(ByVal connection As SqlConnection)
        Dim cancel As Boolean = False
        OnChildUpdating(cancel)
        If (cancel) Then
            Return
        End If

        If connection.State <> ConnectionState.Open Then connection.Open()
        Const commandText As String = "UPDATE [dbo].[Orders]  SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId AND [timestamp] = @p_timestamp; SELECT [timestamp] FROM [dbo].[Orders] WHERE OrderId = @p_OrderId"
        Using command As New SqlCommand(commandText, connection)
            command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
				command.Parameters.AddWithValue("@p_UserId", Me.UserId)
				command.Parameters.AddWithValue("@p_OrderDate", Me.OrderDate)
				command.Parameters.AddWithValue("@p_ShipAddr1", Me.ShipAddr1)
				command.Parameters.AddWithValue("@p_ShipAddr2", Me.ShipAddr2)
				command.Parameters.AddWithValue("@p_ShipCity", Me.ShipCity)
				command.Parameters.AddWithValue("@p_ShipState", Me.ShipState)
				command.Parameters.AddWithValue("@p_ShipZip", Me.ShipZip)
				command.Parameters.AddWithValue("@p_ShipCountry", Me.ShipCountry)
				command.Parameters.AddWithValue("@p_BillAddr1", Me.BillAddr1)
				command.Parameters.AddWithValue("@p_BillAddr2", Me.BillAddr2)
				command.Parameters.AddWithValue("@p_BillCity", Me.BillCity)
				command.Parameters.AddWithValue("@p_BillState", Me.BillState)
				command.Parameters.AddWithValue("@p_BillZip", Me.BillZip)
				command.Parameters.AddWithValue("@p_BillCountry", Me.BillCountry)
				command.Parameters.AddWithValue("@p_Courier", Me.Courier)
				command.Parameters.AddWithValue("@p_TotalPrice", Me.TotalPrice)
				command.Parameters.AddWithValue("@p_BillToFirstName", Me.BillToFirstName)
				command.Parameters.AddWithValue("@p_BillToLastName", Me.BillToLastName)
				command.Parameters.AddWithValue("@p_ShipToFirstName", Me.ShipToFirstName)
				command.Parameters.AddWithValue("@p_ShipToLastName", Me.ShipToLastName)
				command.Parameters.AddWithValue("@p_AuthorizationNumber", Me.AuthorizationNumber)
				command.Parameters.AddWithValue("@p_Locale", Me.Locale)
            command.Parameters.AddWithValue("@p_timestamp", SqlDbType.Timestamp)
            command.Parameters("@p_timestamp").Value = Me.Timestamp
            command.Parameters("@p_timestamp").Direction = ParameterDirection.InputOutput

            Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                If reader.RecordsAffected = 0 Then
                    Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If

                If reader.Read() Then
                    Timestamp = ADOHelper.GetBytes(reader, "timestamp")
                    _orderId = reader.GetInt32("OrderId")
                End If
            End Using

        End Using

        OnChildUpdated()
    End Sub

    Private Sub Child_DeleteSelf()
        Dim cancel As Boolean = False
        OnChildSelfDeleting(cancel)
        If (cancel) Then
            Return
        End If
    
        DataPortal_Delete(New OrderCriteria (_orderId))
    
        OnChildSelfDeleted()
    End Sub

    #End Region

    Private Sub Map(ByVal reader As SafeDataReader)
        Dim cancel As Boolean = False
        OnMapping(cancel)
        If (cancel) Then
            Return
        End If

        Using(BypassPropertyChecks)
            Timestamp = ADOHelper.GetBytes(reader, "timestamp")
            _orderId = reader.GetInt32("OrderId")
            _userId = reader.GetString("UserId")
            _orderDate = reader.GetDateTime("OrderDate")
            _shipAddr1 = reader.GetString("ShipAddr1")
            _shipAddr2 = reader.GetString("ShipAddr2")
            _shipCity = reader.GetString("ShipCity")
            _shipState = reader.GetString("ShipState")
            _shipZip = reader.GetString("ShipZip")
            _shipCountry = reader.GetString("ShipCountry")
            _billAddr1 = reader.GetString("BillAddr1")
            _billAddr2 = reader.GetString("BillAddr2")
            _billCity = reader.GetString("BillCity")
            _billState = reader.GetString("BillState")
            _billZip = reader.GetString("BillZip")
            _billCountry = reader.GetString("BillCountry")
            _courier = reader.GetString("Courier")
            _totalPrice = reader.GetDecimal("TotalPrice")
            _billToFirstName = reader.GetString("BillToFirstName")
            _billToLastName = reader.GetString("BillToLastName")
            _shipToFirstName = reader.GetString("ShipToFirstName")
            _shipToLastName = reader.GetString("ShipToLastName")
            _authorizationNumber = reader.GetInt32("AuthorizationNumber")
            _locale = reader.GetString("Locale")
        End Using

        OnMapped()

        MarkOld()
    End Sub
    
    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnFetched()
    End Sub
    Partial Private Sub OnMapping(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnMapped()
    End Sub
    Partial Private Sub OnInserting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnInserted()
    End Sub
    Partial Private Sub OnUpdating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnUpdated()
    End Sub
    Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnSelfDeleted()
    End Sub
    Partial Private Sub OnDeleting(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnDeleted()
    End Sub

    #End Region

    #Region "Child data access partial methods"

    Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildCreated()
    End Sub
    Partial Private Sub OnChildFetching(ByVal criteria As OrderCriteria , ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildFetched()
    End Sub
    Partial Private Sub OnChildInserting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildInserted()
    End Sub
    Partial Private Sub OnChildUpdating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildUpdated()
    End Sub
    Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildSelfDeleted()
    End Sub

    #End Region
End Class