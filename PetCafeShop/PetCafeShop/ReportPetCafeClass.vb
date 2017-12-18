Public Class ReportPetCafeClass

    Public Con As New ConnectionDbPetCafe
    Private _ordernumber As String
    Private _description As String
    Private _grandtotaldollar As String
    Private _grandtotalriel As String
    Private _table As String
    Private _seller As String
    Private _discount As String
    Private _day As String

    Public Property OrderNumber As String
        Get
            Return _ordernumber
        End Get
        Set(value As String)
            _ordernumber = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property
    Public Property GrandTotalDollar As String
        Get
            Return _grandtotaldollar
        End Get
        Set(value As String)
            _grandtotaldollar = value
        End Set
    End Property
    Public Property GrandTotalRiel As String
        Get
            Return _grandtotalriel
        End Get
        Set(value As String)
            _grandtotalriel = value
        End Set
    End Property
    Public Property Table As String
        Get
            Return _table
        End Get
        Set(value As String)
            _table = value
        End Set
    End Property
    Public Property Seller As String
        Get
            Return _seller
        End Get
        Set(value As String)
            _seller = value
        End Set
    End Property
    Public Property Discount As String
        Get
            Return _discount
        End Get
        Set(value As String)
            _discount = value
        End Set
    End Property
    Public Property Day As String
        Get
            Return _day
        End Get
        Set(value As String)
            _day = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ordernumber As String, descriptioin As String, grandtotaldollar As String, grandtotalreil As String, table As String, seller As String, discount As String, day As String)
        _ordernumber = ordernumber
        _description = descriptioin
        _grandtotaldollar = grandtotaldollar
        _grandtotalriel = grandtotalreil
        _table = table
        _seller = seller
        _discount = discount
        _day = day
    End Sub

    Public Function ShowReport(startday As Date, endday As Date) As Object
        Dim report As ReportPetCafeClass
        Dim reports As New List(Of ReportPetCafeClass)
        Dim bs As New BindingSource
        Con.SqLs = "Select * from IceDrink Where Date between '" & startday & "' and '" & endday & "' "
        Con.UseDatabasetoread(Con.SqLs)
        While Con.Reader.Read
            report = New ReportPetCafeClass(Con.Reader.Item(1), Con.Reader.Item(2), Con.Reader.Item(3), Con.Reader.Item(4), Con.Reader.Item(5), Con.Reader.Item(6), Con.Reader.Item(7), Con.Reader.Item(8))
            reports.Add(report)
            bs.DataSource = reports
        End While
        Return bs
    End Function




End Class
