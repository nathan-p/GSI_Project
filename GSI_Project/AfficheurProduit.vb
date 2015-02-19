Public Class UserControl1

    Dim home As Home
    Dim article As Article

    Public Sub New(ByVal art As Article, ByVal hom As Home)
        InitializeComponent()
        Me.home = hom
        Me.article = art

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
End Class
