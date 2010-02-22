﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
Public Partial Class LineItem 
    Inherits BusinessBase(Of LineItem)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method 
    End Sub

    Private Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
        Using(BypassPropertyChecks)
            _orderId = orderId
            _lineNum = lineNum
        End Using
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _itemIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10))
    End Sub

    #End Region

    #Region "Properties"

    ''' <summary>
    ''' Used for optimistic concurrency.
    ''' </summary>
    <NotUndoable()> _
    Friend Timestamp As System.Byte() = New System.Byte(8) {}
    

    Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OrderId)
    Private _orderId As System.Int32 = _orderIdProperty.DefaultValue
    
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property OrderId() As System.Int32
        Get 
            Return GetProperty(_orderIdProperty, _orderId) 
        End Get
        Set (value As System.Int32)
            SetProperty(_orderIdProperty, _orderId, value)
        End Set
    End Property

    Private Shared ReadOnly _originalOrderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OriginalOrderId)
    Private _originalOrderId As System.Int32 = _originalOrderIdProperty.DefaultValue
    ''' <summary>
    ''' Holds the original value for OrderId. This is used for non identity primary keys.
    ''' </summary>
    Friend Property OriginalOrderId() As System.Int32
        Get 
            Return GetProperty(_originalOrderIdProperty, _originalOrderId) 
        End Get
        Set (value As System.Int32)
            SetProperty(_originalOrderIdProperty, _originalOrderId, value)
        End Set
    End Property
    

    Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.LineNum)
    Private _lineNum As System.Int32 = _lineNumProperty.DefaultValue
    
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property LineNum() As System.Int32
        Get 
            Return GetProperty(_lineNumProperty, _lineNum) 
        End Get
        Set (value As System.Int32)
            SetProperty(_lineNumProperty, _lineNum, value)
        End Set
    End Property

    Private Shared ReadOnly _originalLineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.OriginalLineNum)
    Private _originalLineNum As System.Int32 = _originalLineNumProperty.DefaultValue
    ''' <summary>
    ''' Holds the original value for LineNum. This is used for non identity primary keys.
    ''' </summary>
    Friend Property OriginalLineNum() As System.Int32
        Get 
            Return GetProperty(_originalLineNumProperty, _originalLineNum) 
        End Get
        Set (value As System.Int32)
            SetProperty(_originalLineNumProperty, _originalLineNum, value)
        End Set
    End Property
    

    Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As LineItem) p.ItemId)
    Private _itemId As System.String = _itemIdProperty.DefaultValue
    
    Public Property ItemId() As System.String
        Get 
            Return GetProperty(_itemIdProperty, _itemId) 
        End Get
        Set (value As System.String)
            SetProperty(_itemIdProperty, _itemId, value)
        End Set
    End Property
    

    Private Shared ReadOnly _quantityProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As LineItem) p.Quantity)
    Private _quantity As System.Int32 = _quantityProperty.DefaultValue
    
    Public Property Quantity() As System.Int32
        Get 
            Return GetProperty(_quantityProperty, _quantity) 
        End Get
        Set (value As System.Int32)
            SetProperty(_quantityProperty, _quantity, value)
        End Set
    End Property
    

    Private Shared ReadOnly _unitPriceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As LineItem) p.UnitPrice)
    Private _unitPrice As System.Decimal = _unitPriceProperty.DefaultValue
    
    Public Property UnitPrice() As System.Decimal
        Get 
            Return GetProperty(_unitPriceProperty, _unitPrice) 
        End Get
        Set (value As System.Decimal)
            SetProperty(_unitPriceProperty, _unitPrice, value)
        End Set
    End Property
    
    'ManyToOne
    Private Shared ReadOnly _orderMemberProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As LineItem) p.OrderMember, Csla.RelationshipTypes.Child)
    Private _orderMember As Order = _orderMemberProperty.DefaultValue
    Public ReadOnly Property OrderMember() As Order
        Get
            If Not(FieldManager.FieldExists(_orderMemberProperty))
                Dim criteria As New PetShop.Tests.StoredProcedures.OrderCriteria()
                criteria.OrderId = OrderId

                If (Me.IsNew Or Not PetShop.Tests.StoredProcedures.Order.Exists(criteria)) Then
                    LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.NewOrder())
                Else
                    LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.GetByOrderId(OrderId))
                End If
            End If
            
            Return GetProperty(_orderMemberProperty, _orderMember) 
        End Get
    End Property
    
    #End Region

    #Region "Root Factory Methods"

    Public Shared Function NewLineItem() As LineItem 
        Return DataPortal.Create(Of LineItem)()
    End Function

    Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId
			criteria.LineNum = lineNum

        Return DataPortal.Fetch(Of LineItem)(criteria)
    End Function

    Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId

        Return DataPortal.Fetch(Of LineItem)(criteria)
    End Function

    Public Shared Sub DeleteLineItem(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
        DataPortal.Delete(New LineItemCriteria (orderId, lineNum))
    End Sub

    #End Region

    #Region "Child Factory Methods"

    Friend Shared Function NewLineItemChild() As LineItem
        Return DataPortal.CreateChild(Of LineItem)()
    End Function

    Friend Shared Function GetByOrderIdLineNumChild(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId
        criteria.LineNum = lineNum

        Return DataPortal.FetchChild(Of LineItem)(criteria)
    End Function

    Friend Shared Function GetByOrderIdChild(ByVal orderId As System.Int32) As LineItem 
        Dim criteria As New LineItemCriteria ()
        criteria.OrderId = orderId

        Return DataPortal.FetchChild(Of LineItem)(criteria)
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As LineItemCriteria ) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region


    #Region "Protected Overriden Method(s)"
    
    ' NOTE: This is needed for Composite Keys. 
    Private ReadOnly _guidID As Guid = Guid.NewGuid()
    Protected Overrides Function GetIdValue() As Object
        Return _guidID
    End Function
    
    #End Region
End Class