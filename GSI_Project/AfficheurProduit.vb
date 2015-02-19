Public Class AfficheurProduit

    Dim home As Home
    Dim article As Article
    Dim qte As Integer 'Quantité à récupérer du panier de Home

    Public Sub New(ByRef art As Article, ByVal hom As Home)
        InitializeComponent()
        Me.home = hom
        Me.article = art
        qte = 0
        updateStock()
        initLabels()
    End Sub

    Private Sub initLabels()
        Me.labelNomArticle.Text = article.name
        Me.labelDescription.Text = article.desc
        Me.labelMarque.Text = article.brand
        Me.labelPoids.Text = String.Concat(article.weight, " kg")
        Me.labelPrix.Text = String.Concat(article.price, " €")
        Me.LabelStock.Text = String.Concat("Stock : ", article.stock)
    End Sub

    '********************************************************************************
    '*************************** Gestion bouton +/-**********************************
    '********************************************************************************

    Private Sub updateStock()
        'Modifications des labels
        Me.LabelStock.Text = String.Concat("En stock : ", Me.article.stock)
        Me.labelQuantite.Text = Me.qte
        'Enable des boutons
        If (Me.article.stock = 0) Then
            Me.boutonAjouter.Enabled = False
            Me.boutonAjouter.FillColor = Color.DarkGreen
            Me.labelAjouter.BackColor = Color.DarkGreen
        Else
            Me.boutonAjouter.Enabled = True
            Me.boutonAjouter.FillColor = Color.LightGreen
            Me.labelAjouter.BackColor = Color.LightGreen
        End If
        If (Me.labelQuantite.Text = "0") Then
            Me.boutonRetirer.Enabled = False
            Me.boutonRetirer.FillColor = Color.DarkRed
            Me.labelRetirer.BackColor = Color.DarkRed
        Else
            Me.boutonRetirer.Enabled = True
            Me.boutonRetirer.FillColor = Color.LightCoral
            Me.labelRetirer.BackColor = Color.LightCoral
        End If
    End Sub

    '********************************************************************************
    '*************************** Events            **********************************
    '********************************************************************************

    Private Sub labelPlusInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelPlusInfo.MouseClick
        Me.home.setDetailPopUp(
             article.name,
             article.category,
             article.brand,
             article.weight,
             article.priceKilo,
             article.origin,
             article.desc,
             article.price,
             article.img)
        Me.home.showDetailPopUp()
    End Sub

    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub labelPlusInfo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelStock.Click

    End Sub

    Private Sub boutonAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonAjouter.Click
        Me.article.stock -= 1
        Me.qte += 1
        Me.updateStock()
    End Sub

    Private Sub boutonRetirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonRetirer.Click
        Me.article.stock += 1
        Me.qte -= 1
        Me.updateStock()
    End Sub
End Class
