Public Class Article
    Private nom As String
    Private categorie As String
    Private urlImage As String
    Private prix As Double
    Private prixAuKilo As Double
    Private marque As String
    Private description As String
    Private origine As String
    Private poid As Double
    Private qteStock As Integer


    '********************************************************************************
    '*************************** Constructeur     ***********************************
    '********************************************************************************
    Public Sub New(ByVal name As String, ByVal cat As String, ByVal brand As String, ByVal price As Double, ByVal weight As Double, Optional ByVal origin As String = "France", Optional ByVal desc As String = "Aucune description.", Optional ByVal img As String = "")
        ' Set the property value.
        Me.nom = name
        Me.categorie = cat
        Me.prix = price
        Me.marque = brand
        Me.poid = weight
        Me.qteStock = 10
        Me.description = desc
        Me.origine = origin
        Me.urlImage = img
        Me.prixAuKilo = price / weight
        Me.Capitalize()
    End Sub

    Public Sub Capitalize()
        ' Capitalize the value of the property.
        nom = UCase(nom)
        marque = UCase(marque)
        description = UCase(description)
        origine = UCase(origine)
    End Sub

    '********************************************************************************
    '*************************** Getter et setter ***********************************
    '********************************************************************************
    Public Property name() As String
        Get
            Return Nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property

    Public Property category() As String
        Get
            Return categorie
        End Get
        Set(ByVal value As String)
            categorie = value
        End Set
    End Property

    Public Property price() As String
        Get
            Return Prix
        End Get
        Set(ByVal value As String)
            prix = value
        End Set
    End Property

    Public Property priceKilo() As String
        Get
            Return PrixAuKilo
        End Get
        Set(ByVal value As String)
            prixAuKilo = value
        End Set
    End Property

    Public Property stock() As Integer
        Get
            Return qteStock
        End Get
        Set(ByVal value As Integer)
            qteStock = value
        End Set
    End Property

    Public Property brand() As String
        Get
            Return marque
        End Get
        Set(ByVal value As String)
            marque = value
        End Set
    End Property

    Public Property desc() As String
        Get
            Return description
        End Get
        Set(ByVal value As String)
            description = value
        End Set
    End Property

    Public Property origin() As String
        Get
            Return origine
        End Get
        Set(ByVal value As String)
            origine = value
        End Set
    End Property

    Public Property weight() As String
        Get
            Return poid
        End Get
        Set(ByVal value As String)
            poid = value
        End Set
    End Property

    Public Property img() As String
        Get
            Return urlImage
        End Get
        Set(ByVal value As String)
            urlImage = value
        End Set
    End Property

End Class

