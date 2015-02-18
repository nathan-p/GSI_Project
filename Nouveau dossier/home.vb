Imports WindowsApplication1.Article
Public Class home

    Dim listArticles As ArrayList
    Enum categorie
        MARCHE
        FRAIS
        SALES
        SUCRES
        BOISSONS
        SURGELES
    End Enum
    Dim categorieActif As categorie

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        categorieActif = categorie.MARCHE
        ListView1.View = View.Details
        ListView1.Columns.Add("Nom")
        ListView1.Columns.Add("Prix")
        ListView1.Items.Add(New ListViewItem("Produit numéro 1"))
        ListView1.Items.Add(New ListViewItem("Produit numéro 2 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 3 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 4 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 5 "))

        initArticles()
    End Sub


    Private Sub initArticles()
        '**********************
        'Création des articles
        '**********************
        'Catégorie Marché
        Dim pomme As WindowsApplication1.Article
        pomme = New Article("Pomme", "Marche", "Traiteur", 0.6, 1, "France", "Pommes granny")
        Dim cerises As WindowsApplication1.Article
        cerises = New Article("Cerise", "Marche", "Traiteur", 1, 1, "France", "Cerises griottes")
        Dim litchi As WindowsApplication1.Article
        litchi = New Article("Litchi", "Marche", "Traiteur", 1.2, 1, "Madagascar", "Des litchi")
        'Catégorie Frais
        Dim poisson As WindowsApplication1.Article
        poisson = New Article("Saumon", "Frais", " ", 5.2, 1.1, "France", "Saumon frais de norvège")
        'Catégorie Epicerie Salee
        Dim saucisson As WindowsApplication1.Article
        saucisson = New Article("Saucisson", "Sales", "Justin bridou", 3.2, 1, "France", "Viande de porc recyclé")
        'Catégorie Epicerie Sucree
        Dim malabar As WindowsApplication1.Article
        malabar = New Article("Malabars", "Sucres", "Malabar", 1.2, 1, "France", "Chewing gum au goût nature")
        Dim carambar As WindowsApplication1.Article
        carambar = New Article("Carambar", "Sucres", "Carambar", 0.8, 0.8, "France", "Sucreries goût caramel")
        'Catégorie Boissons
        Dim eau As WindowsApplication1.Article
        eau = New Article("Eau Evian", "Boisson", "Evian", 0.5, 1.5, "France", "Eau minérale naturelle Evian")
        Dim lait As WindowsApplication1.Article
        lait = New Article("Lait demi écrémé", "Boisson", "Lactel", 0.46, 1, "France", "Lait de vache")
        Dim coca As WindowsApplication1.Article
        coca = New Article("Coca-cola", "Boisson", "Coca", 1.6, 1, "USA", "Boisson gazeuse")
        Dim jusOrange As WindowsApplication1.Article
        jusOrange = New Article("Jus d'orange", "Boisson", "Pulco", 1.2, 1, "Espagne", "Pur jus de fruit sans pulpe")
        'Catégorie Surgeles
        Dim poissonPane As WindowsApplication1.Article
        poissonPane = New Article("Poisson Pané", "Surgeles", "Findus", 4.5, 2, "France", "Poisson panés frais pêché la veille")
        Dim steakHache As WindowsApplication1.Article
        steakHache = New Article("Steak haché", "Surgeles", "Charal", 5.3, 2, "France", "Pur boeuf")


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
        Dim listAfficheur As ArrayList
        listAfficheur = New ArrayList

        addArticlesInPanel()
    End Sub

    Sub addArticlesInPanel()
        Dim afficheur As AfficheurArticle
        Me.panelArticles.Controls.Clear()
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
        Console.WriteLine("Ajouts des articles dans ")
        Console.WriteLine(cat)
        For Each item As Article In listArticles            
            If (item.category = cat) Then
                Console.WriteLine(item.name)
                afficheur = New AfficheurArticle(item)
                Me.panelArticles.Controls.Add(afficheur)
            End If
        Next
    End Sub
    '********************************************************************************
    '*************************** MENU ITEM HOVER LISTENER ***************************
    '********************************************************************************

    Private Sub menuMarche_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMarche.MouseEnter
        menuMarche.BackColor = Color.DarkGray
    End Sub

    Private Sub menuMarche_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMarche.MouseLeave
        menuMarche.BackColor = Color.Gainsboro
    End Sub

    Private Sub menuFrais_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFrais.MouseEnter
        menuFrais.BackColor = Color.DarkGray
    End Sub

    Private Sub menuFrais_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFrais.MouseLeave
        menuFrais.BackColor = Color.Gainsboro
    End Sub


    Private Sub menuBoissons_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBoissons.MouseEnter
        menuBoissons.BackColor = Color.DarkGray
    End Sub

    Private Sub menuBoissons_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBoissons.MouseLeave
        menuBoissons.BackColor = Color.Gainsboro
    End Sub


    Private Sub menuSurgeles_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSurgeles.MouseEnter
        menuSurgeles.BackColor = Color.DarkGray
    End Sub

    Private Sub menuSurgeles_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSurgeles.MouseLeave
        menuSurgeles.BackColor = Color.Gainsboro
    End Sub


    Private Sub menuEpicerieSucree_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSucree.MouseEnter
        menuEpicerieSucree.BackColor = Color.DarkGray
    End Sub

    Private Sub menuEpicerieSucree_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSucree.MouseLeave
        menuEpicerieSucree.BackColor = Color.Gainsboro
    End Sub

    Private Sub menuEpicerieSalee_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSalee.MouseEnter
        menuEpicerieSalee.BackColor = Color.DarkGray
    End Sub

    Private Sub menuEpicerieSalee_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSalee.MouseLeave
        menuEpicerieSalee.BackColor = Color.Gainsboro
    End Sub

    '********************************************************************************
    '*************************** MENU SORT DISPLAY HOVER LISTENER *******************
    '********************************************************************************





    Private Sub affGridPanel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles affGridPanel.MouseEnter
        affGridPanel.BackColor = Color.Silver
    End Sub

    Private Sub affGridPanel_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles affGridPanel.MouseLeave
        affGridPanel.BackColor = Color.Gainsboro
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub menuMarcheLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMarche.Click
        categorieActif = categorie.MARCHE
        addArticlesInPanel()
    End Sub

    Private Sub menuFraisLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFrais.Click
        categorieActif = categorie.FRAIS
        addArticlesInPanel()
    End Sub

    Private Sub menuEpicerieSaleeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSalee.Click
        categorieActif = categorie.SALES
        addArticlesInPanel()
        Console.WriteLine("clic sur salee")

    End Sub

    Private Sub menuEpicerieSucreeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEpicerieSucree.Click
        categorieActif = categorie.SUCRES
        addArticlesInPanel()
    End Sub

    Private Sub menuBoissonsLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBoissons.Click
        categorieActif = categorie.BOISSONS
        addArticlesInPanel()
    End Sub

    Private Sub menuSurgelesLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSurgeles.Click
        categorieActif = categorie.SURGELES
        addArticlesInPanel()
    End Sub

End Class
