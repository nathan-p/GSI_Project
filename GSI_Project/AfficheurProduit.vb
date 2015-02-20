Public Class AfficheurProduit

    Dim home As Home
    Dim article As Article
    Dim qte As Integer 'Quantité à récupérer du panier de Home
    Dim ListViewItem2 As System.Windows.Forms.ListViewItem

    Public Sub New(ByRef art As Article, ByVal hom As Home)
        InitializeComponent()
        Me.home = hom
        Me.article = art
        If (Not home.getPanier().ContainsKey(article)) Then
            home.getPanier.Add(article, 0)
        End If
        Me.qte = home.getPanier().Item(article)
        updateStock()
        initLabels()
    End Sub

    Private Sub initLabels()
        Me.labelNomArticle.Text = article.name
        Me.labelDescription.Text = article.desc
        Me.labelMarque.Text = article.brand
        Me.labelPoids.Text = String.Concat(article.weight, " kg")
        Me.labelPrix.Text = String.Concat(article.price, " €")
        Me.LabelStock.Text = String.Concat("En stock : ", article.stock)
    End Sub

    '********************************************************************************
    '*************************** Gestion bouton +/-**********************************
    '********************************************************************************

    Private Sub updateStock()
        'Modifications des labels
        Me.LabelStock.Text = String.Concat("En stock : ", Me.article.stock)
        TextBoxQuantite.Text = CStr(qte)
        home.getPanier.Remove(article)
        If (qte > 0) Then
            home.getPanier.Add(article, qte)
        End If
        'Enable des boutons
        If (Me.article.stock = 0) Then
            Me.boutonAjouter.Enabled = False
            Me.boutonAjouter.FillColor = Color.LightGray
            Me.labelAjouter.BackColor = Color.LightGray
        Else
            Me.boutonAjouter.Enabled = True
            Me.boutonAjouter.FillColor = Color.LightGreen
            Me.labelAjouter.BackColor = Color.LightGreen
        End If
        If (Me.TextBoxQuantite.Text = "0") Then
            Me.boutonRetirer.Enabled = False
            Me.boutonRetirer.FillColor = Color.LightGray
            Me.labelRetirer.BackColor = Color.LightGray
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


    Private Sub boutonAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonAjouter.Click
        Me.article.stock -= 1
        Me.qte += 1
        Me.updateStock()
        Me.home.addToCart(article, qte)
    End Sub

    Private Sub boutonAjouter_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonAjouter.DoubleClick
        Me.article.stock -= 1
        Me.qte += 1
        Me.updateStock()
        Me.home.addToCart(article, qte)
    End Sub

    Private Sub boutonRetirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonRetirer.Click
        Me.article.stock += 1
        Me.qte -= 1
        Me.updateStock()
        Me.home.removeToCart(article, qte)
    End Sub

    Private Sub boutonRetirer_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonRetirer.DoubleClick
        Me.article.stock += 1
        Me.qte -= 1
        Me.updateStock()
        Me.home.removeToCart(article, qte)
    End Sub


    


    Private Sub TextBoxQuantite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxQuantite.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        'Appuie sur la touche entrée
        If Asc(e.KeyChar) = 10 Or Asc(e.KeyChar) = 13 Then
            Dim textval As String
            Dim difference As Integer
            textval = TextBoxQuantite.Text
            If IsNumeric(textval) Then
                If (textval <= (Me.article.stock + qte)) Then
                    difference = (Me.article.stock + qte) - textval
                    qte = textval
                    article.stock = difference
                Else
                    'Chiffre entrée plus grand que le stock donc on prends tout
                    qte = Me.article.stock + qte
                    article.stock = 0
                End If
            Else
                'Si c'est pas un numéric, on remet l'ancienne valeur
                TextBoxQuantite.Text = CStr(qte)
            End If
            Me.updateStock()
        End If

    End Sub


End Class
