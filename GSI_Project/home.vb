Public Class home



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Nom")
        ListView1.Columns.Add("Prix")
        ListView1.Items.Add(New ListViewItem("Produit numéro 1"))
        ListView1.Items.Add(New ListViewItem("Produit numéro 2 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 3 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 4 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 5 "))
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
End Class
