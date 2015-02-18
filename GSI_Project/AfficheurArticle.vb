Public Class AfficheurArticle
    Inherits System.Windows.Forms.UserControl
    Friend WithEvents labelPlusInfo As System.Windows.Forms.LinkLabel
    Friend WithEvents labelPrix As System.Windows.Forms.Label
    Friend WithEvents imageBox As System.Windows.Forms.PictureBox
    Friend WithEvents labelDescription As System.Windows.Forms.Label
    Friend WithEvents labelPoids As System.Windows.Forms.Label
    Friend WithEvents labelQuantite As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents boutonAjouter As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents boutonRetirer As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents labelMarque As System.Windows.Forms.Label
    Friend WithEvents labelAjouter As System.Windows.Forms.Label
    Friend WithEvents labelRetirer As System.Windows.Forms.Label
    Friend WithEvents labelNomArticle As System.Windows.Forms.Label

    '********************************************************************************
    '*************************** Init component   ***********************************
    '********************************************************************************
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.labelNomArticle = New System.Windows.Forms.Label()
        Me.labelPlusInfo = New System.Windows.Forms.LinkLabel()
        Me.labelPrix = New System.Windows.Forms.Label()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.labelPoids = New System.Windows.Forms.Label()
        Me.labelQuantite = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.boutonRetirer = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.boutonAjouter = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.labelMarque = New System.Windows.Forms.Label()
        Me.labelAjouter = New System.Windows.Forms.Label()
        Me.labelRetirer = New System.Windows.Forms.Label()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelNomArticle
        '
        Me.labelNomArticle.AutoSize = True
        Me.labelNomArticle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNomArticle.Location = New System.Drawing.Point(11, 24)
        Me.labelNomArticle.Name = "labelNomArticle"
        Me.labelNomArticle.Size = New System.Drawing.Size(45, 21)
        Me.labelNomArticle.TabIndex = 0
        Me.labelNomArticle.Text = "nom"
        '
        'labelPlusInfo
        '
        Me.labelPlusInfo.AutoSize = True
        Me.labelPlusInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlusInfo.Location = New System.Drawing.Point(123, 120)
        Me.labelPlusInfo.Name = "labelPlusInfo"
        Me.labelPlusInfo.Size = New System.Drawing.Size(55, 13)
        Me.labelPlusInfo.TabIndex = 1
        Me.labelPlusInfo.TabStop = True
        Me.labelPlusInfo.Text = "+ D'infos"
        '
        'labelPrix
        '
        Me.labelPrix.AutoSize = True
        Me.labelPrix.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrix.Location = New System.Drawing.Point(11, 165)
        Me.labelPrix.Name = "labelPrix"
        Me.labelPrix.Size = New System.Drawing.Size(50, 21)
        Me.labelPrix.TabIndex = 2
        Me.labelPrix.Text = "2.00 €"
        '
        'imageBox
        '
        Me.imageBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imageBox.ImageLocation = "System.Drawing.Bitmap"
        Me.imageBox.Location = New System.Drawing.Point(15, 48)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(100, 85)
        Me.imageBox.TabIndex = 3
        Me.imageBox.TabStop = False
        '
        'labelDescription
        '
        Me.labelDescription.AutoSize = True
        Me.labelDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescription.Location = New System.Drawing.Point(123, 72)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(30, 13)
        Me.labelDescription.TabIndex = 4
        Me.labelDescription.Text = "desc"
        '
        'labelPoids
        '
        Me.labelPoids.AutoSize = True
        Me.labelPoids.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPoids.Location = New System.Drawing.Point(123, 85)
        Me.labelPoids.Name = "labelPoids"
        Me.labelPoids.Size = New System.Drawing.Size(36, 13)
        Me.labelPoids.TabIndex = 5
        Me.labelPoids.Text = "poids"
        '
        'labelQuantite
        '
        Me.labelQuantite.AutoSize = True
        Me.labelQuantite.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelQuantite.Location = New System.Drawing.Point(154, 162)
        Me.labelQuantite.Name = "labelQuantite"
        Me.labelQuantite.Size = New System.Drawing.Size(19, 21)
        Me.labelQuantite.TabIndex = 8
        Me.labelQuantite.Text = "0"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.boutonRetirer, Me.boutonAjouter})
        Me.ShapeContainer1.Size = New System.Drawing.Size(237, 203)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'boutonRetirer
        '
        Me.boutonRetirer.FillColor = System.Drawing.Color.LightCoral
        Me.boutonRetirer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.boutonRetirer.Location = New System.Drawing.Point(112, 155)
        Me.boutonRetirer.Name = "boutonRetirer"
        Me.boutonRetirer.Size = New System.Drawing.Size(32, 33)
        '
        'boutonAjouter
        '
        Me.boutonAjouter.FillColor = System.Drawing.Color.LightGreen
        Me.boutonAjouter.FillGradientColor = System.Drawing.Color.ForestGreen
        Me.boutonAjouter.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.boutonAjouter.Location = New System.Drawing.Point(180, 140)
        Me.boutonAjouter.Name = "boutonAjouter"
        Me.boutonAjouter.Size = New System.Drawing.Size(53, 51)
        '
        'labelMarque
        '
        Me.labelMarque.AutoSize = True
        Me.labelMarque.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMarque.Location = New System.Drawing.Point(122, 48)
        Me.labelMarque.Name = "labelMarque"
        Me.labelMarque.Size = New System.Drawing.Size(65, 21)
        Me.labelMarque.TabIndex = 10
        Me.labelMarque.Text = "marque"
        '
        'labelAjouter
        '
        Me.labelAjouter.AutoSize = True
        Me.labelAjouter.BackColor = System.Drawing.Color.LightGreen
        Me.labelAjouter.Enabled = False
        Me.labelAjouter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAjouter.Location = New System.Drawing.Point(195, 150)
        Me.labelAjouter.Name = "labelAjouter"
        Me.labelAjouter.Size = New System.Drawing.Size(27, 30)
        Me.labelAjouter.TabIndex = 11
        Me.labelAjouter.Text = "+"
        '
        'labelRetirer
        '
        Me.labelRetirer.AutoSize = True
        Me.labelRetirer.BackColor = System.Drawing.Color.LightCoral
        Me.labelRetirer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.labelRetirer.Location = New System.Drawing.Point(122, 162)
        Me.labelRetirer.Name = "labelRetirer"
        Me.labelRetirer.Size = New System.Drawing.Size(16, 21)
        Me.labelRetirer.TabIndex = 12
        Me.labelRetirer.Text = "-"
        '
        'AfficheurArticle
        '
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.labelRetirer)
        Me.Controls.Add(Me.labelAjouter)
        Me.Controls.Add(Me.labelMarque)
        Me.Controls.Add(Me.labelQuantite)
        Me.Controls.Add(Me.labelPoids)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.labelPrix)
        Me.Controls.Add(Me.labelPlusInfo)
        Me.Controls.Add(Me.labelNomArticle)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "AfficheurArticle"
        Me.Size = New System.Drawing.Size(237, 203)
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    '********************************************************************************
    '*************************** Getter et setter ***********************************
    '********************************************************************************


    Public Property nom() As String
        Get
            Return Me.labelNomArticle.Text
        End Get
        Set(ByVal Value As String)
            Me.labelNomArticle.Text = Value
        End Set
    End Property

    Public Property marque() As String
        Get
            Return Me.labelMarque.Text
        End Get
        Set(ByVal Value As String)
            Me.labelMarque.Text = Value
        End Set
    End Property

    Public Property prix() As String
        Get
            Return Me.labelPrix.Text
        End Get
        Set(ByVal Value As String)
            Me.labelPrix.Text = Value
        End Set
    End Property

    Public Property image() As String
        Get
            Return Me.imageBox.ImageLocation
        End Get
        Set(ByVal Value As String)
            Me.imageBox.ImageLocation = Value
        End Set
    End Property

    Public Property description() As String
        Get
            Return Me.labelDescription.Text
        End Get
        Set(ByVal Value As String)
            If (Me.labelDescription Is Nothing) Then
                Me.labelDescription = New System.Windows.Forms.Label()
            End If
            Me.labelDescription.Text = Value
        End Set
    End Property

    Public Property poid() As String
        Get
            Return Me.labelPoids.Text
        End Get
        Set(ByVal Value As String)
            Me.labelPoids.Text = Value
        End Set
    End Property

    Public Property quantite() As String
        Get
            Return Me.labelQuantite.Text
        End Get
        Set(ByVal Value As String)
            Me.labelQuantite.Text = Value
        End Set
    End Property

    '********************************************************************************
    '*************************** Listener         ***********************************
    '********************************************************************************

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonAjouter.Click

    End Sub

    Private Sub boutonRetirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boutonRetirer.Click

    End Sub

    Private Sub labelAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelAjouter.Click

    End Sub

    Private Sub labelRetirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelRetirer.Click

    End Sub

    Private Sub labelPlusInfo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles labelPlusInfo.LinkClicked

    End Sub


    Private Sub labelMarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelMarque.Click

    End Sub

    Private Sub AfficheurArticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeComponent()
        Me.AutoSize = False
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    End Sub
End Class
