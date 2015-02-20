Imports System.IO

Public Class Home

    Enum State
        INIT
        CART
        VALID_CART
    End Enum

    Enum categorie
        MARCHE
        FRAIS
        SALES
        SUCRES
        BOISSONS
        SURGELES
    End Enum

    '********************************************************************************
    '*************************** ATTRIBUTES *****************************************
    '********************************************************************************
    Dim myState As State
    Dim nbProduct As Integer
    Dim listArticles As ArrayList
    Dim listAfficheurs As ArrayList
    Dim listSavedCart As ArrayList
    Dim categorieActif As categorie
    Dim panier As New Dictionary(Of Article, Integer)
    Dim sommePanier As Double
    Private Const SEUIL As Double = 20

    Private Property CurrentSB As ListViewItem.ListViewSubItem

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'INITIALISATION DES ATTRIBUTS
        myState = State.INIT
        categorieActif = categorie.MARCHE
        listSavedCart = New ArrayList
        updateUI()
        updateMenuButton()
        'INITIALISATION DE LA LISTE
        initArticles()
    End Sub

    Private Sub updateUI()
        updateSommePanier()
        Select Case myState
            Case State.INIT
                nbProduct = 0
                clearCart()
                validationPaymentPanel.Visible = False
                popUpPanel.Visible = False
                buttonEnable()
            Case State.CART
                validationPaymentPanel.Visible = False
                popUpPanel.Visible = False
                buttonEnable()
            Case State.VALID_CART
                validationPaymentPanel.Height = 255
                validationPaymentPanel.Visible = True
                popUpPanel.Visible = False
                buttonEnable()
        End Select
    End Sub

    Private Sub buttonEnable()
        Select Case myState
            Case State.INIT
                cartDetailButton.Enabled = False
                cartListButton.Enabled = True
                cartValidationButton.Enabled = False
                cartSaveButton.Enabled = False
                cartSuppressionButton.Enabled = False
            Case State.CART
                cartDetailButton.Enabled = True
                cartListButton.Enabled = True
                cartSaveButton.Enabled = True
                cartSuppressionButton.Enabled = True
                If (sommePanier >= SEUIL) Then
                    cartValidationButton.Enabled = True
                Else
                    cartValidationButton.Enabled = False
                End If
            Case State.VALID_CART
                cartDetailButton.Enabled = True
                cartListButton.Enabled = True
                cartValidationButton.Enabled = True
                cartSaveButton.Enabled = True
                cartSuppressionButton.Enabled = True
        End Select
    End Sub

    Private Sub clearCart()
        cartListView.Items.Clear()
        panier.Clear()
        updateSommePanier()
    End Sub

    Private Sub showPopUp()
        popUpPanel.Height = 200
        popUpPanel.Visible = True
    End Sub

    Public Sub showDetailPopUp()
        detailPopUpPanel.Height = 350
        detailPopUpPanel.Visible = True

    End Sub

    Private Sub realisePayment()
        Select Case myState
            Case State.INIT

            Case State.CART

            Case State.VALID_CART
                addArticlesInPanel()
                reinitialiserAfficheurArticles(False)
        End Select
    End Sub


    Public Sub addToCart(ByVal art As Article, ByVal qte As Integer)
        myState = State.CART
        'récuperer l'index de l'image du produit
        Dim imageIndex As Integer
        For index As Integer = 0 To (ImageList1.Images.Count - 1)
            If (ImageList1.Images.Keys(index).ToString = art.img) Then
                imageIndex = index
                Exit For
            End If
        Next

        Dim item As ListViewItem
        item = New System.Windows.Forms.ListViewItem(New String() {art.name, art.price, qte}, imageIndex)

        Dim itemFound As ListViewItem = cartListView.FindItemWithText(art.name)

        'si l'article n'est pas dans la panier on l'ajoute sinon on modifie sa quantite
        If (itemFound Is Nothing) Then
            cartListView.Items.Add(item)
        Else
            itemFound.SubItems.Item(2).Text = qte.ToString
        End If

        cartListView.Update()
        updateUI()
    End Sub

    Public Sub removeToCart(ByVal art As Article, ByVal qte As Integer)
        If (cartListView.Items.Count = 0) Then
            myState = State.INIT
        End If

        Dim itemFound As ListViewItem = cartListView.FindItemWithText(art.name)

        'si l'article n'est pas dans la panier y'a un bug sinon on modifie sa quantite
        If (itemFound Is Nothing) Then
            'probleme
        Else
            If qte = 0 Then
                itemFound.Remove()
            Else
                itemFound.SubItems.Item(2).Text = qte.ToString
            End If
            cartListView.Update()
        End If
        updateUI()
    End Sub



    Private Sub setPopUp(ByVal title As String, ByVal content As String, ByVal validButton As String, ByVal cancelButton As String)
        titlePopUpLabel.Text = title
        contentPopUpLabel.Text = content
        cancelPopUpButton.Text = cancelButton
        validPopUpButton.Text = validButton
    End Sub

    Public Sub setDetailPopUp(ByVal name As String, ByVal category As String,
                               ByVal brand As String, ByVal weight As String,
                               ByVal priceKg As String, ByVal origin As String,
                               ByVal description As String, ByVal price As String,
                               ByVal urlImg As String
                               )
        detailNameLabel.Text = name
        detailOriginLabel.Text = "Origine : " + origin
        'detailImgPictureBox.Image = New Bitmap("./Ressources/pomme.jpg")
        Dim path As String = Directory.GetCurrentDirectory()
        detailImgPictureBox.Image = Image.FromFile(path + "\Ressources\" + urlImg)
        detailPriceLabel.Text = price + "€"
        cartListButton.Text = detailPriceLabel.Text

        detailPriceKgLabel.Text = "Prix/kg : " + priceKg + "€ / kg"
        detailWeightLabel.Text = "Poids : " + weight + " kg"
        detailCategoryLabel.Text = "Catégorie : " + category
        detailSpecLabel.Text = description
        detailBrandLabel.Text = "Marque : " + brand
    End Sub

    Private Sub updateMenuButton()
        menuBoissonsButton.BackColor = Color.Gainsboro
        menuBoissonsButton.Cursor = Cursors.Hand
        menuBoissonsButton.Enabled = True

        menuEpicerieSaleeButton.BackColor = Color.Gainsboro
        menuEpicerieSaleeButton.Cursor = Cursors.Hand
        menuEpicerieSaleeButton.Enabled = True

        menuEpicerieSucreeButton.BackColor = Color.Gainsboro
        menuEpicerieSucreeButton.Cursor = Cursors.Hand
        menuEpicerieSucreeButton.Enabled = True

        menuFraisButton.BackColor = Color.Gainsboro
        menuFraisButton.Cursor = Cursors.Hand
        menuFraisButton.Enabled = True

        menuSurgelesButton.BackColor = Color.Gainsboro
        menuSurgelesButton.Cursor = Cursors.Hand
        menuSurgelesButton.Enabled = True

        menuMarcheButton.BackColor = Color.Gainsboro
        menuMarcheButton.Cursor = Cursors.Hand
        menuMarcheButton.Enabled = True

        Select Case categorieActif
            Case categorie.BOISSONS
                menuBoissonsButton.BackColor = Color.LightSlateGray
                menuBoissonsButton.Cursor = Cursors.Default
                menuBoissonsButton.Enabled = False
            Case (categorie.FRAIS)
                menuFraisButton.BackColor = Color.LightSlateGray
                menuFraisButton.Cursor = Cursors.Default
                menuFraisButton.Enabled = False
            Case categorie.MARCHE
                menuMarcheButton.BackColor = Color.LightSlateGray
                menuMarcheButton.Cursor = Cursors.Default
                menuMarcheButton.Enabled = False
            Case categorie.SALES
                menuEpicerieSaleeButton.BackColor = Color.LightSlateGray
                menuEpicerieSaleeButton.Cursor = Cursors.Default
                menuEpicerieSaleeButton.Enabled = False
            Case categorie.SUCRES
                menuEpicerieSucreeButton.BackColor = Color.LightSlateGray
                menuEpicerieSucreeButton.Cursor = Cursors.Default
                menuEpicerieSucreeButton.Enabled = False
            Case categorie.SURGELES
                menuSurgelesButton.BackColor = Color.LightSlateGray
                menuSurgelesButton.Cursor = Cursors.Default
                menuSurgelesButton.Enabled = False
        End Select
    End Sub


    Private Sub updateDetailCart()
        detailCartListView.Items.Clear()

        For Each produit In panier
            Dim item As ListViewItem
            item = New System.Windows.Forms.ListViewItem(New String() {produit.Key.name, produit.Key.price, produit.Value, produit.Key.desc})
            detailCartListView.Items.Add(item)
        Next
        detailCartPanel.Refresh()

    End Sub


    '********************************************************************************
    '*************************** ARTICLES INITIALIZATION ****************************
    '********************************************************************************

    Private Sub initArticles()
        '**********************
        'Création des articles
        '**********************
        'Catégorie Marché
        Dim pomme As WindowsApplication1.Article
        pomme = New Article("Pomme", "Marche", "Traiteur", 0.6, 1, "France", "Pommes granny", "pomme.jpg")
        Dim cerises As WindowsApplication1.Article
        cerises = New Article("Cerise", "Marche", "Traiteur", 1, 1, "France", "Cerises griottes", "cerise.jpg")
        Dim litchi As WindowsApplication1.Article
        litchi = New Article("Litchi", "Marche", "Traiteur", 1.2, 1, "Madagascar", "Des litchi", "litchi.jpg")
        'Catégorie Frais
        Dim poisson As WindowsApplication1.Article
        poisson = New Article("Saumon", "Frais", " ", 5.2, 1.1, "France", "Saumon frais de norvège", "saumon.jpg")
        'Catégorie Epicerie Salee
        Dim saucisson As WindowsApplication1.Article
        saucisson = New Article("Saucisson", "Sales", "Justin bridou", 3.2, 1, "France", "Viande de porc recyclé", "saucisson.jpg")
        'Catégorie Epicerie Sucree
        Dim malabar As WindowsApplication1.Article
        malabar = New Article("Malabars", "Sucres", "Malabar", 1.2, 1, "France", "Chewing gum au goût nature", "malabar.jpg")
        Dim carambar As WindowsApplication1.Article
        carambar = New Article("Carambar", "Sucres", "Carambar", 0.8, 0.8, "France", "Sucreries goût caramel", "carambar.jpg")
        'Catégorie Boissons
        Dim eau As WindowsApplication1.Article
        eau = New Article("Eau Evian", "Boisson", "Evian", 0.5, 1.5, "France", "Eau minérale naturelle Evian", "evian.jpg")
        Dim lait As WindowsApplication1.Article
        lait = New Article("Lait bio", "Boisson", "Lactel", 0.46, 1, "France", "Lait de vache", "lait.jpg")
        Dim coca As WindowsApplication1.Article
        coca = New Article("Coca-cola", "Boisson", "Coca", 1.6, 1, "USA", "Boisson gazeuse", "coca.jpg")
        Dim jusOrange As WindowsApplication1.Article
        jusOrange = New Article("Jus d'orange", "Boisson", "Pulco", 1.2, 1, "Espagne", "Pur jus de fruit sans pulpe", "orange.jpg")
        'Catégorie Surgeles
        Dim poissonPane As WindowsApplication1.Article
        poissonPane = New Article("Poisson Pané", "Surgeles", "Findus", 4.5, 2, "France", "Poisson panés frais pêché la veille", "poisson_pane.jpg")
        Dim steakHache As WindowsApplication1.Article
        steakHache = New Article("Steak haché", "Surgeles", "Charal", 5.3, 2, "France", "Pur boeuf", "steak.JPG")


        listArticles = New ArrayList
        listArticles.Add(pomme)
        listArticles.Add(cerises)
        listArticles.Add(litchi)
        listArticles.Add(poisson)
        listArticles.Add(saucisson)
        listArticles.Add(malabar)
        listArticles.Add(carambar)
        listArticles.Add(eau)
        listArticles.Add(lait)
        listArticles.Add(coca)
        listArticles.Add(jusOrange)
        listArticles.Add(poissonPane)
        listArticles.Add(steakHache)

        'Création des afficheurs et ajout au panel
        Me.listAfficheurs = New ArrayList
        createAfficheurs()
        addArticlesInPanel()
    End Sub

    Sub addArticlesInPanel()
        Me.articlePanel.Controls.Clear()
        Dim cat As String
        cat = New String("")
        Select Case categorieActif
            Case categorie.BOISSONS
                cat = "Boisson"
            Case categorie.FRAIS
                cat = "Frais"
            Case categorie.MARCHE
                cat = "Marche"
            Case categorie.SALES
                cat = "Sales"
            Case categorie.SUCRES
                cat = "Sucres"
            Case categorie.SURGELES
                cat = "Surgeles"
        End Select
        For Each item As AfficheurProduit In listAfficheurs
            If (item.art.category = cat) Then
                Me.articlePanel.Controls.Add(item)
            End If
        Next
    End Sub

    Sub createAfficheurs()
        Me.listAfficheurs.Clear()
        For Each item As Article In listArticles
            Dim afficheur As AfficheurProduit
            afficheur = New AfficheurProduit(item, Me)
            Dim path As String = Directory.GetCurrentDirectory()
            afficheur.imageBox.Image = Image.FromFile(path + "\Ressources\" + item.img)
            Me.listAfficheurs.Add(afficheur)
        Next
    End Sub

    Private Sub reinitialiserAfficheurArticles(ByVal isSuppressionPanier As Boolean)
        For Each afficheur As AfficheurProduit In Me.listAfficheurs
            afficheur.updateTextBox(isSuppressionPanier)
        Next
    End Sub

    Public Property getPanier() As Dictionary(Of Article, Integer)
        Get
            Return panier
        End Get
        Set(ByVal value As Dictionary(Of Article, Integer))
            panier = value
        End Set
    End Property

    '********************************************************************************
    '*************************** GESTION PRIX PANIER ET SEUIL************************
    '********************************************************************************

    Private Function calculSommePanier() As Double
        Dim sommeTotal As Double
        Dim sommeArticle As Double
        sommeTotal = 0
        For Each article As Article In panier.Keys
            sommeArticle = article.price * panier.Item(article)
            sommeTotal += sommeArticle
        Next
        Return sommeTotal
    End Function

    Private Sub updateSommePanier()
        sommePanier = calculSommePanier()
        cartTotalPriceLabel.Text = "Total : " + String.Format(sommePanier) + " €"
        Label2.Text = String.Format(sommePanier) + " €"
    End Sub
    '********************************************************************************
    '*************************** Gestion listes sauvegardés  ************************
    '********************************************************************************
    Private Function buildPanierFromNode(ByRef noeud As TreeNode) As Dictionary(Of Article, Integer)
        Dim newPanier As New Dictionary(Of Article, Integer)

        Return newPanier
    End Function

    '********************************************************************************
    '*************************** MENU SORT DISPLAY HOVER LISTENER *******************
    '********************************************************************************
    Private Sub affListPanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles affListPanel.MouseEnter
        affListPanel.BackColor = Color.Silver
    End Sub

    Private Sub affListPanel_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles affListPanel.MouseLeave
        affListPanel.BackColor = Color.Gainsboro
    End Sub





    '********************************************************************************
    '*************************** LISTENER CART BUTTON *******************************
    '********************************************************************************
    Private Sub cartValidationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartValidationButton.Click
        Select Case myState
            Case State.INIT
                'interdit
            Case State.CART
                myState = State.VALID_CART
                updateUI()
            Case State.VALID_CART
                'interdit
        End Select
    End Sub

    Private Sub cartDetailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartDetailButton.Click
        updateDetailCart()
        detailCartPanel.Visible = True
    End Sub

    Private Sub cartSuppressionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartSuppressionButton.Click
        Select Case myState
            Case State.INIT
                'interdit
            Case State.CART
                setPopUp("Suppression des produits", "Voulez-vous supprimer tous les produits ?", "Supprimer", "Annuler")
                showPopUp()
            Case State.VALID_CART

        End Select

    End Sub

    Private Sub cartSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartSaveButton.Click
        listSavedCart.Add(panier)
        Dim idList As String = String.Format(listSavedCart.Count)
        Dim noeudNouvelleListe As TreeNode
        noeudNouvelleListe = SavedListsTreeView.Nodes.Add(idList, "Liste n°" + idList + " (Total: " + String.Format(sommePanier) + " €)", "", "")
        For Each item As Article In panier.Keys
            noeudNouvelleListe.Nodes.Add(item.name, String.Format(panier.Item(item)) + " x " + item.name, "", "")
        Next
    End Sub

    Private Sub myListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartListButton.Click
        savedListPanel.Visible = True
    End Sub


    '********************************************************************************
    '*************************** LISTENER PAYMENT BUTTON ****************************
    '********************************************************************************

    Private Sub paidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paidButton.Click
        Select Case myState
            Case State.INIT
                'interdit
            Case State.CART
                'interdit
            Case State.VALID_CART
                realisePayment()
                myState = State.INIT
                updateUI()
        End Select
    End Sub

    Private Sub cancelPaidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelPaidButton.Click
        Select Case myState
            Case State.INIT
                'interdit
            Case State.CART
                'interdit
            Case State.VALID_CART
                myState = State.CART
                updateUI()
        End Select
    End Sub



    '********************************************************************************
    '*************************** LISTENER POP UP BUTTON *****************************
    '********************************************************************************

    Private Sub validPopUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles validPopUpButton.Click
        Select Case myState
            Case State.INIT
                'interdit
            Case State.CART
                reinitialiserAfficheurArticles(True)
                myState = State.INIT
                updateUI()
            Case State.VALID_CART
                reinitialiserAfficheurArticles(True)
                myState = State.INIT
                updateUI()
        End Select
    End Sub

    Private Sub cancelPopUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelPopUpButton.Click
        Select Case myState
            Case State.INIT
                'interdit
            Case State.CART
                myState = State.CART
                updateUI()
            Case State.VALID_CART
                myState = State.VALID_CART
                updateUI()
        End Select
    End Sub

    '********************************************************************************
    '*************************** MENU BUTTON CLICK LISTENER *************************
    '********************************************************************************

    Private Sub menuFraisButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFraisButton.Click
        categorieActif = categorie.FRAIS
        addArticlesInPanel()
        updateMenuButton()
    End Sub

    Private Sub menuMarcheButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMarcheButton.Click
        categorieActif = categorie.MARCHE
        addArticlesInPanel()
        updateMenuButton()
    End Sub

    Private Sub menuEpicerieSaleeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSaleeButton.Click
        categorieActif = categorie.SALES
        addArticlesInPanel()
        updateMenuButton()
    End Sub

    Private Sub menuEpicerieSucreeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSucreeButton.Click
        categorieActif = categorie.SUCRES
        addArticlesInPanel()
        updateMenuButton()
    End Sub

    Private Sub menuBoissonsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBoissonsButton.Click
        categorieActif = categorie.BOISSONS
        addArticlesInPanel()
        updateMenuButton()
    End Sub

    Private Sub menuSurgelesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSurgelesButton.Click
        categorieActif = categorie.SURGELES
        addArticlesInPanel()
        updateMenuButton()
    End Sub


    '********************************************************************************
    '********************** DETAIL PRODUTC BUTTON CLICK LISTENER ********************
    '********************************************************************************
    Private Sub detailCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detailCloseButton.Click
        detailPopUpPanel.Visible = False
    End Sub

    Private Sub articlePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles articlePanel.Paint

    End Sub


    Private Sub cartDetailCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartDetailCancelButton.Click
        detailCartPanel.Visible = False
    End Sub

    '********************************************************************************
    '********************** SAVED LIST BUTTON CLICK LISTENER ************************
    '********************************************************************************

    Private Sub loadSavedListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadSavedListButton.Click
        If (Not SavedListsTreeView.SelectedNode Is Nothing) Then
            'Reconstruire le panier depuis le node puis faire un panier = panier reconstruit
            panier = buildPanierFromNode(SavedListsTreeView.SelectedNode)
        End If
    End Sub

    Private Sub deleteSavedListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteSavedListButton.Click
        If (Not SavedListsTreeView.SelectedNode Is Nothing) Then
            'Reconstruire le panier depuis le node puis faire un remove du panier reconstruit
            'listSavedCart.Remove(buildPanierFromNode(SavedListsTreeView.SelectedNode))
            SavedListsTreeView.SelectedNode.Remove()
        End If
        If (SavedListsTreeView.SelectedNode Is Nothing) Then
            deleteSavedListButton.Enabled = False
            loadSavedListButton.Enabled = False
        End If
    End Sub

    Private Sub savedListsCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savedListsCancelButton.Click
        savedListPanel.Visible = False
    End Sub

    Private Sub SavedListsTreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles SavedListsTreeView.AfterSelect
        deleteSavedListButton.Enabled = True
        loadSavedListButton.Enabled = True
    End Sub

End Class
