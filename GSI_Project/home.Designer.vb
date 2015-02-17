<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.header = New System.Windows.Forms.Panel()
        Me.cartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.affGridPanel = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.affListPanel = New System.Windows.Forms.Panel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.menuSurgeles = New System.Windows.Forms.Panel()
        Me.menuSurgelesLabel = New System.Windows.Forms.Label()
        Me.menuEpicerieSucree = New System.Windows.Forms.Panel()
        Me.menuEpicerieSucreeLabel = New System.Windows.Forms.Label()
        Me.menuBoissons = New System.Windows.Forms.Panel()
        Me.menuBoissonsLabel = New System.Windows.Forms.Label()
        Me.menuMarche = New System.Windows.Forms.Panel()
        Me.menuMarcheLabel = New System.Windows.Forms.Label()
        Me.menuFrais = New System.Windows.Forms.Panel()
        Me.menuFraisLabel = New System.Windows.Forms.Label()
        Me.menuEpicerieSalee = New System.Windows.Forms.Panel()
        Me.menuEpicerieSaleeLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cartDetailButton = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.cartDetaillButton2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.centerPanel.SuspendLayout()
        Me.affGridPanel.SuspendLayout()
        Me.affListPanel.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.menuSurgeles.SuspendLayout()
        Me.menuEpicerieSucree.SuspendLayout()
        Me.menuBoissons.SuspendLayout()
        Me.menuMarche.SuspendLayout()
        Me.menuFrais.SuspendLayout()
        Me.menuEpicerieSalee.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.header.Controls.Add(Me.cartLabel)
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Controls.Add(Me.searchButton)
        Me.header.Controls.Add(Me.TextBox1)
        Me.header.Controls.Add(Me.ShapeContainer1)
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1348, 86)
        Me.header.TabIndex = 2
        '
        'cartLabel
        '
        Me.cartLabel.AutoSize = True
        Me.cartLabel.Font = New System.Drawing.Font("Roboto Lt", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartLabel.ForeColor = System.Drawing.Color.White
        Me.cartLabel.Location = New System.Drawing.Point(1118, 20)
        Me.cartLabel.Name = "cartLabel"
        Me.cartLabel.Size = New System.Drawing.Size(218, 48)
        Me.cartLabel.TabIndex = 6
        Me.cartLabel.Text = "Mon panier"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 97)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(860, 23)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(96, 40)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Rechercher"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Roboto Lt", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(271, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(594, 40)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Rechercher un produit"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1348, 86)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1101
        Me.LineShape1.X2 = 1101
        Me.LineShape1.Y1 = 6
        Me.LineShape1.Y2 = 76
        '
        'centerPanel
        '
        Me.centerPanel.BackColor = System.Drawing.Color.White
        Me.centerPanel.Controls.Add(Me.affGridPanel)
        Me.centerPanel.Controls.Add(Me.affListPanel)
        Me.centerPanel.Controls.Add(Me.Menu)
        Me.centerPanel.Controls.Add(Me.ShapeContainer4)
        Me.centerPanel.Location = New System.Drawing.Point(0, 85)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(1103, 642)
        Me.centerPanel.TabIndex = 3
        '
        'affGridPanel
        '
        Me.affGridPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.affGridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.affGridPanel.Controls.Add(Me.ShapeContainer3)
        Me.affGridPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.affGridPanel.Location = New System.Drawing.Point(1000, 34)
        Me.affGridPanel.Name = "affGridPanel"
        Me.affGridPanel.Size = New System.Drawing.Size(53, 44)
        Me.affGridPanel.TabIndex = 2
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(51, 42)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Enabled = False
        Me.RectangleShape4.Location = New System.Drawing.Point(30, 24)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(15, 15)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Enabled = False
        Me.RectangleShape3.Location = New System.Drawing.Point(7, 24)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(15, 15)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Enabled = False
        Me.RectangleShape2.Location = New System.Drawing.Point(30, 4)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(15, 15)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape1.Enabled = False
        Me.RectangleShape1.Location = New System.Drawing.Point(7, 4)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(15, 15)
        '
        'affListPanel
        '
        Me.affListPanel.BackColor = System.Drawing.Color.DarkGray
        Me.affListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.affListPanel.Controls.Add(Me.ShapeContainer2)
        Me.affListPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.affListPanel.Location = New System.Drawing.Point(950, 34)
        Me.affListPanel.Name = "affListPanel"
        Me.affListPanel.Size = New System.Drawing.Size(53, 44)
        Me.affListPanel.TabIndex = 1
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(51, 42)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 6
        Me.LineShape5.X2 = 43
        Me.LineShape5.Y1 = 35
        Me.LineShape5.Y2 = 35
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 6
        Me.LineShape4.X2 = 43
        Me.LineShape4.Y1 = 26
        Me.LineShape4.Y2 = 26
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 6
        Me.LineShape3.X2 = 43
        Me.LineShape3.Y1 = 17
        Me.LineShape3.Y2 = 17
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 6
        Me.LineShape2.X2 = 43
        Me.LineShape2.Y1 = 8
        Me.LineShape2.Y2 = 8
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Menu.Controls.Add(Me.menuSurgeles)
        Me.Menu.Controls.Add(Me.menuEpicerieSucree)
        Me.Menu.Controls.Add(Me.menuBoissons)
        Me.Menu.Controls.Add(Me.menuMarche)
        Me.Menu.Controls.Add(Me.menuFrais)
        Me.Menu.Controls.Add(Me.menuEpicerieSalee)
        Me.Menu.Location = New System.Drawing.Point(135, 34)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(730, 44)
        Me.Menu.TabIndex = 0
        '
        'menuSurgeles
        '
        Me.menuSurgeles.BackColor = System.Drawing.Color.Gainsboro
        Me.menuSurgeles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuSurgeles.Controls.Add(Me.menuSurgelesLabel)
        Me.menuSurgeles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuSurgeles.Location = New System.Drawing.Point(621, -1)
        Me.menuSurgeles.Name = "menuSurgeles"
        Me.menuSurgeles.Size = New System.Drawing.Size(108, 44)
        Me.menuSurgeles.TabIndex = 7
        '
        'menuSurgelesLabel
        '
        Me.menuSurgelesLabel.AutoSize = True
        Me.menuSurgelesLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuSurgelesLabel.Enabled = False
        Me.menuSurgelesLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuSurgelesLabel.Location = New System.Drawing.Point(10, 9)
        Me.menuSurgelesLabel.Name = "menuSurgelesLabel"
        Me.menuSurgelesLabel.Size = New System.Drawing.Size(86, 24)
        Me.menuSurgelesLabel.TabIndex = 5
        Me.menuSurgelesLabel.Text = "Surgelés"
        '
        'menuEpicerieSucree
        '
        Me.menuEpicerieSucree.BackColor = System.Drawing.Color.Gainsboro
        Me.menuEpicerieSucree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuEpicerieSucree.Controls.Add(Me.menuEpicerieSucreeLabel)
        Me.menuEpicerieSucree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSucree.Location = New System.Drawing.Point(345, -1)
        Me.menuEpicerieSucree.Name = "menuEpicerieSucree"
        Me.menuEpicerieSucree.Size = New System.Drawing.Size(162, 44)
        Me.menuEpicerieSucree.TabIndex = 5
        '
        'menuEpicerieSucreeLabel
        '
        Me.menuEpicerieSucreeLabel.AutoSize = True
        Me.menuEpicerieSucreeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSucreeLabel.Enabled = False
        Me.menuEpicerieSucreeLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEpicerieSucreeLabel.Location = New System.Drawing.Point(7, 9)
        Me.menuEpicerieSucreeLabel.Name = "menuEpicerieSucreeLabel"
        Me.menuEpicerieSucreeLabel.Size = New System.Drawing.Size(144, 24)
        Me.menuEpicerieSucreeLabel.TabIndex = 3
        Me.menuEpicerieSucreeLabel.Text = "Epicerie Sucrée"
        '
        'menuBoissons
        '
        Me.menuBoissons.BackColor = System.Drawing.Color.Gainsboro
        Me.menuBoissons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuBoissons.Controls.Add(Me.menuBoissonsLabel)
        Me.menuBoissons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuBoissons.Location = New System.Drawing.Point(506, -1)
        Me.menuBoissons.Name = "menuBoissons"
        Me.menuBoissons.Size = New System.Drawing.Size(116, 44)
        Me.menuBoissons.TabIndex = 6
        '
        'menuBoissonsLabel
        '
        Me.menuBoissonsLabel.AutoSize = True
        Me.menuBoissonsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuBoissonsLabel.Enabled = False
        Me.menuBoissonsLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBoissonsLabel.Location = New System.Drawing.Point(11, 9)
        Me.menuBoissonsLabel.Name = "menuBoissonsLabel"
        Me.menuBoissonsLabel.Size = New System.Drawing.Size(91, 24)
        Me.menuBoissonsLabel.TabIndex = 4
        Me.menuBoissonsLabel.Text = "Boissons"
        '
        'menuMarche
        '
        Me.menuMarche.BackColor = System.Drawing.Color.Gainsboro
        Me.menuMarche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuMarche.Controls.Add(Me.menuMarcheLabel)
        Me.menuMarche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuMarche.Location = New System.Drawing.Point(-1, -1)
        Me.menuMarche.Name = "menuMarche"
        Me.menuMarche.Size = New System.Drawing.Size(107, 44)
        Me.menuMarche.TabIndex = 2
        '
        'menuMarcheLabel
        '
        Me.menuMarcheLabel.AutoSize = True
        Me.menuMarcheLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuMarcheLabel.Enabled = False
        Me.menuMarcheLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMarcheLabel.Location = New System.Drawing.Point(14, 9)
        Me.menuMarcheLabel.Name = "menuMarcheLabel"
        Me.menuMarcheLabel.Size = New System.Drawing.Size(76, 24)
        Me.menuMarcheLabel.TabIndex = 0
        Me.menuMarcheLabel.Text = "Marché"
        '
        'menuFrais
        '
        Me.menuFrais.BackColor = System.Drawing.Color.Gainsboro
        Me.menuFrais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuFrais.Controls.Add(Me.menuFraisLabel)
        Me.menuFrais.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuFrais.Location = New System.Drawing.Point(105, -1)
        Me.menuFrais.Name = "menuFrais"
        Me.menuFrais.Size = New System.Drawing.Size(86, 44)
        Me.menuFrais.TabIndex = 3
        '
        'menuFraisLabel
        '
        Me.menuFraisLabel.AutoSize = True
        Me.menuFraisLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuFraisLabel.Enabled = False
        Me.menuFraisLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuFraisLabel.Location = New System.Drawing.Point(15, 9)
        Me.menuFraisLabel.Name = "menuFraisLabel"
        Me.menuFraisLabel.Size = New System.Drawing.Size(54, 24)
        Me.menuFraisLabel.TabIndex = 1
        Me.menuFraisLabel.Text = "Frais"
        '
        'menuEpicerieSalee
        '
        Me.menuEpicerieSalee.BackColor = System.Drawing.Color.Gainsboro
        Me.menuEpicerieSalee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menuEpicerieSalee.Controls.Add(Me.menuEpicerieSaleeLabel)
        Me.menuEpicerieSalee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSalee.Location = New System.Drawing.Point(190, -1)
        Me.menuEpicerieSalee.Name = "menuEpicerieSalee"
        Me.menuEpicerieSalee.Size = New System.Drawing.Size(156, 44)
        Me.menuEpicerieSalee.TabIndex = 4
        '
        'menuEpicerieSaleeLabel
        '
        Me.menuEpicerieSaleeLabel.AutoSize = True
        Me.menuEpicerieSaleeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSaleeLabel.Enabled = False
        Me.menuEpicerieSaleeLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEpicerieSaleeLabel.Location = New System.Drawing.Point(14, 9)
        Me.menuEpicerieSaleeLabel.Name = "menuEpicerieSaleeLabel"
        Me.menuEpicerieSaleeLabel.Size = New System.Drawing.Size(132, 24)
        Me.menuEpicerieSaleeLabel.TabIndex = 2
        Me.menuEpicerieSaleeLabel.Text = "Epicerie Salée"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.ShapeContainer5)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Location = New System.Drawing.Point(1102, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 638)
        Me.Panel2.TabIndex = 4
        '
        'cartDetailButton
        '
        Me.cartDetailButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartDetailButton.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.cartDetailButton.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartDetailButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartDetailButton.Location = New System.Drawing.Point(-37, 102)
        Me.cartDetailButton.Name = "cartDetailButton"
        Me.cartDetailButton.Size = New System.Drawing.Size(80, 80)
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape4, Me.OvalShape3, Me.cartDetailButton})
        Me.ShapeContainer5.Size = New System.Drawing.Size(246, 638)
        Me.ShapeContainer5.TabIndex = 0
        Me.ShapeContainer5.TabStop = False
        '
        'cartDetaillButton2
        '
        Me.cartDetaillButton2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartDetaillButton2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.cartDetaillButton2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartDetaillButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartDetaillButton2.Location = New System.Drawing.Point(1065, 103)
        Me.cartDetaillButton2.Name = "cartDetaillButton2"
        Me.cartDetaillButton2.Size = New System.Drawing.Size(80, 80)
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape2, Me.OvalShape1, Me.cartDetaillButton2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(1103, 642)
        Me.ShapeContainer4.TabIndex = 3
        Me.ShapeContainer4.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape1.Location = New System.Drawing.Point(1061, 224)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(80, 80)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape2.Location = New System.Drawing.Point(1062, 354)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(80, 80)
        '
        'OvalShape3
        '
        Me.OvalShape3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape3.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape3.Location = New System.Drawing.Point(-38, 223)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(80, 80)
        '
        'OvalShape4
        '
        Me.OvalShape4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape4.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.OvalShape4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape4.Location = New System.Drawing.Point(-39, 353)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(80, 80)
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListView1.Location = New System.Drawing.Point(0, 20)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(246, 562)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 612)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Mes listes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "home"
        Me.Text = "Form1"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.centerPanel.ResumeLayout(False)
        Me.affGridPanel.ResumeLayout(False)
        Me.affListPanel.ResumeLayout(False)
        Me.Menu.ResumeLayout(False)
        Me.menuSurgeles.ResumeLayout(False)
        Me.menuSurgeles.PerformLayout()
        Me.menuEpicerieSucree.ResumeLayout(False)
        Me.menuEpicerieSucree.PerformLayout()
        Me.menuBoissons.ResumeLayout(False)
        Me.menuBoissons.PerformLayout()
        Me.menuMarche.ResumeLayout(False)
        Me.menuMarche.PerformLayout()
        Me.menuFrais.ResumeLayout(False)
        Me.menuFrais.PerformLayout()
        Me.menuEpicerieSalee.ResumeLayout(False)
        Me.menuEpicerieSalee.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents centerPanel As System.Windows.Forms.Panel
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cartLabel As System.Windows.Forms.Label
    Friend WithEvents Menu As System.Windows.Forms.Panel
    Friend WithEvents menuMarcheLabel As System.Windows.Forms.Label
    Friend WithEvents menuEpicerieSucreeLabel As System.Windows.Forms.Label
    Friend WithEvents menuEpicerieSaleeLabel As System.Windows.Forms.Label
    Friend WithEvents menuFraisLabel As System.Windows.Forms.Label
    Friend WithEvents menuBoissonsLabel As System.Windows.Forms.Label
    Friend WithEvents affListPanel As System.Windows.Forms.Panel
    Friend WithEvents affGridPanel As System.Windows.Forms.Panel
    Friend WithEvents menuEpicerieSucree As System.Windows.Forms.Panel
    Friend WithEvents menuBoissons As System.Windows.Forms.Panel
    Friend WithEvents menuMarche As System.Windows.Forms.Panel
    Friend WithEvents menuFrais As System.Windows.Forms.Panel
    Friend WithEvents menuEpicerieSalee As System.Windows.Forms.Panel
    Friend WithEvents menuSurgeles As System.Windows.Forms.Panel
    Friend WithEvents menuSurgelesLabel As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cartDetailButton As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents cartDetaillButton2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape4 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
