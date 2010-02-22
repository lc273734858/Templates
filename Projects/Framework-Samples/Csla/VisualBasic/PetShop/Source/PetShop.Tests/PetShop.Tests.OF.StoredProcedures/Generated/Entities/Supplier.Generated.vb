﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Supplier.vb.
'
'     Template path: EditableRoot.Generated.cst
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
<Csla.Server.ObjectFactory(FactoryNames.SupplierFactoryName)> _
Public Partial Class Supplier 
    Inherits BusinessBase(Of Supplier)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method 
    End Sub

    Private Sub New(ByVal suppId As System.Int32)
        Using(BypassPropertyChecks)
           LoadProperty(_suppIdProperty, suppId)
        End Using
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_nameProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _statusProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_statusProperty, 2))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_addr1Property, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_addr2Property, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_cityProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_stateProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_zipProperty, 5))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_phoneProperty, 40))
    End Sub

    #End Region

    #Region "Properties"


    Private Shared ReadOnly _suppIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Supplier) p.SuppId)
    
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property SuppId() As System.Int32
        Get 
            Return GetProperty(_suppIdProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_suppIdProperty, value)
        End Set
    End Property

    Private Shared ReadOnly _originalSuppIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Supplier) p.OriginalSuppId)
    ''' <summary>
    ''' Holds the original value for SuppId. This is used for non identity primary keys.
    ''' </summary>
    Friend Property OriginalSuppId() As System.Int32
        Get 
            Return GetProperty(_originalSuppIdProperty) 
        End Get
        Set (value As System.Int32)
            SetProperty(_originalSuppIdProperty, value)
        End Set
    End Property
    

    Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Name)
    
    Public Property Name() As System.String
        Get 
            Return GetProperty(_nameProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_nameProperty, value)
        End Set
    End Property
    

    Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Status)
    
    Public Property Status() As System.String
        Get 
            Return GetProperty(_statusProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_statusProperty, value)
        End Set
    End Property
    

    Private Shared ReadOnly _addr1Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Addr1)
    
    Public Property Addr1() As System.String
        Get 
            Return GetProperty(_addr1Property)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_addr1Property, value)
        End Set
    End Property
    

    Private Shared ReadOnly _addr2Property As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Addr2)
    
    Public Property Addr2() As System.String
        Get 
            Return GetProperty(_addr2Property)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_addr2Property, value)
        End Set
    End Property
    

    Private Shared ReadOnly _cityProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.City)
    
    Public Property City() As System.String
        Get 
            Return GetProperty(_cityProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_cityProperty, value)
        End Set
    End Property
    

    Private Shared ReadOnly _stateProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.State)
    
    Public Property State() As System.String
        Get 
            Return GetProperty(_stateProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_stateProperty, value)
        End Set
    End Property
    

    Private Shared ReadOnly _zipProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Zip)
    
    Public Property Zip() As System.String
        Get 
            Return GetProperty(_zipProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_zipProperty, value)
        End Set
    End Property
    

    Private Shared ReadOnly _phoneProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Supplier) p.Phone)
    
    Public Property Phone() As System.String
        Get 
            Return GetProperty(_phoneProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_phoneProperty, value)
        End Set
    End Property
    
    'OneToMany
    Private Shared ReadOnly _itemsProperty As PropertyInfo(Of ItemList) = RegisterProperty(Of ItemList)(Function(p As Supplier) p.Items, Csla.RelationshipTypes.Child)
Public ReadOnly Property Items() As ItemList 
        Get
            If Not (FieldManager.FieldExists(_itemsProperty)) Then
                Dim criteria As New PetShop.Tests.OF.StoredProcedures.ItemCriteria()
                criteria.Supplier = SuppId

                If (Me.IsNew Or Not PetShop.Tests.OF.StoredProcedures.ItemList.Exists(criteria)) Then
                    LoadProperty(_itemsProperty, PetShop.Tests.OF.StoredProcedures.ItemList.NewList())
                Else
                    LoadProperty(_itemsProperty, PetShop.Tests.OF.StoredProcedures.ItemList.GetBySupplier(SuppId))
                End If
            End If
            
            Return GetProperty(_itemsProperty) 
        End Get
    End Property
    
    #End Region


    #Region "Factory Methods"

    Public Shared Function NewSupplier() As Supplier 
        Return DataPortal.Create(Of Supplier)()
    End Function

    Public Shared Function GetBySuppId(ByVal suppId As System.Int32) As Supplier 
        Dim criteria As New SupplierCriteria ()
        criteria.SuppId = suppId
        
        Return DataPortal.Fetch(Of Supplier)(criteria)
    End Function

    Public Shared Sub DeleteSupplier(ByVal suppId As System.Int32)
        DataPortal.Delete(New SupplierCriteria (suppId))
    End Sub

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As SupplierCriteria ) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region

        #Region "Property overrides"

        ''' <summary>
        ''' Returns true if the business object or any of its children properties are dirty.
        ''' </summary>
        Public Overloads Overrides ReadOnly Property IsDirty() As Boolean
            Get
                If MyBase.IsDirty Then
                    Return True
                End If

                If (FieldManager.FieldExists(_itemsProperty) AndAlso Items.IsDirty) Then
                    Return True
                End If
                Return False
            End Get
        End Property

        #End Region


End Class
