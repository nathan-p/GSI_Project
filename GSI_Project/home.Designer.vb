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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.header = New System.Windows.Forms.Panel()
        Me.cartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.validationPanel = New System.Windows.Forms.Panel()
        Me.menuSurgelesButton = New System.Windows.Forms.Button()
        Me.menuBoissonsButton = New System.Windows.Forms.Button()
        Me.menuEpicerieSucreeButton = New System.Windows.Forms.Button()
        Me.menuEpicerieSaleeButton = New System.Windows.Forms.Button()
        Me.menuFraisButton = New System.Windows.Forms.Button()
        Me.menuMarcheButton = New System.Windows.Forms.Button()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cartSaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cartSuppressionButton = New System.Windows.Forms.Button()
        Me.cartDetailButton = New System.Windows.Forms.Button()
        Me.myListButton = New System.Windows.Forms.Button()
        Me.cartValidationButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cancelPaidButton = New System.Windows.Forms.Button()
        Me.paidButton = New System.Windows.Forms.Button()
        Me.paymentTitleLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentNbProdLabel = New System.Windows.Forms.Label()
        Me.paymentTotalLabel = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.centerPanel.SuspendLayout()
        Me.validationPanel.SuspendLayout()
        Me.affGridPanel.SuspendLayout()
        Me.affListPanel.SuspendLayout()
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
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 90)
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
        Me.centerPanel.Controls.Add(Me.validationPanel)
        Me.centerPanel.Controls.Add(Me.menuSurgelesButton)
        Me.centerPanel.Controls.Add(Me.menuBoissonsButton)
        Me.centerPanel.Controls.Add(Me.menuEpicerieSucreeButton)
        Me.centerPanel.Controls.Add(Me.menuEpicerieSaleeButton)
        Me.centerPanel.Controls.Add(Me.menuFraisButton)
        Me.centerPanel.Controls.Add(Me.menuMarcheButton)
        Me.centerPanel.Controls.Add(Me.affGridPanel)
        Me.centerPanel.Controls.Add(Me.affListPanel)
        Me.centerPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.centerPanel.Location = New System.Drawing.Point(0, 85)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(1103, 642)
        Me.centerPanel.TabIndex = 3
        '
        'validationPanel
        '
        Me.validationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.validationPanel.Controls.Add(Me.paymentTotalLabel)
        Me.validationPanel.Controls.Add(Me.paymentNbProdLabel)
        Me.validationPanel.Controls.Add(Me.Label2)
        Me.validationPanel.Controls.Add(Me.paymentTitleLabel)
        Me.validationPanel.Controls.Add(Me.paidButton)
        Me.validationPanel.Controls.Add(Me.cancelPaidButton)
        Me.validationPanel.Location = New System.Drawing.Point(271, 179)
        Me.validationPanel.Name = "validationPanel"
        Me.validationPanel.Size = New System.Drawing.Size(537, 255)
        Me.validationPanel.TabIndex = 9
        Me.validationPanel.Visible = False
        '
        'menuSurgelesButton
        '
        Me.menuSurgelesButton.BackColor = System.Drawing.Color.LightGray
        Me.menuSurgelesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuSurgelesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuSurgelesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuSurgelesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuSurgelesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuSurgelesButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuSurgelesButton.Location = New System.Drawing.Point(761, 36)
        Me.menuSurgelesButton.Name = "menuSurgelesButton"
        Me.menuSurgelesButton.Size = New System.Drawing.Size(108, 42)
        Me.menuSurgelesButton.TabIndex = 8
        Me.menuSurgelesButton.Text = "Surgelés"
        Me.menuSurgelesButton.UseVisualStyleBackColor = False
        '
        'menuBoissonsButton
        '
        Me.menuBoissonsButton.BackColor = System.Drawing.Color.LightGray
        Me.menuBoissonsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuBoissonsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuBoissonsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuBoissonsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuBoissonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuBoissonsButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBoissonsButton.Location = New System.Drawing.Point(646, 36)
        Me.menuBoissonsButton.Name = "menuBoissonsButton"
        Me.menuBoissonsButton.Size = New System.Drawing.Size(116, 42)
        Me.menuBoissonsButton.TabIndex = 7
        Me.menuBoissonsButton.Text = "Boissons"
        Me.menuBoissonsButton.UseVisualStyleBackColor = False
        '
        'menuEpicerieSucreeButton
        '
        Me.menuEpicerieSucreeButton.BackColor = System.Drawing.Color.LightGray
        Me.menuEpicerieSucreeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSucreeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuEpicerieSucreeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSucreeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSucreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuEpicerieSucreeButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEpicerieSucreeButton.Location = New System.Drawing.Point(485, 36)
        Me.menuEpicerieSucreeButton.Name = "menuEpicerieSucreeButton"
        Me.menuEpicerieSucreeButton.Size = New System.Drawing.Size(162, 42)
        Me.menuEpicerieSucreeButton.TabIndex = 6
        Me.menuEpicerieSucreeButton.Text = "Epicerie Sucrée"
        Me.menuEpicerieSucreeButton.UseVisualStyleBackColor = False
        '
        'menuEpicerieSaleeButton
        '
        Me.menuEpicerieSaleeButton.BackColor = System.Drawing.Color.LightGray
        Me.menuEpicerieSaleeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSaleeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuEpicerieSaleeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSaleeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSaleeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuEpicerieSaleeButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEpicerieSaleeButton.Location = New System.Drawing.Point(330, 36)
        Me.menuEpicerieSaleeButton.Name = "menuEpicerieSaleeButton"
        Me.menuEpicerieSaleeButton.Size = New System.Drawing.Size(156, 42)
        Me.menuEpicerieSaleeButton.TabIndex = 5
        Me.menuEpicerieSaleeButton.Text = "Epicerie Salée"
        Me.menuEpicerieSaleeButton.UseVisualStyleBackColor = False
        '
        'menuFraisButton
        '
        Me.menuFraisButton.BackColor = System.Drawing.Color.LightGray
        Me.menuFraisButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuFraisButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuFraisButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuFraisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuFraisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuFraisButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuFraisButton.Location = New System.Drawing.Point(245, 36)
        Me.menuFraisButton.Name = "menuFraisButton"
        Me.menuFraisButton.Size = New System.Drawing.Size(86, 42)
        Me.menuFraisButton.TabIndex = 4
        Me.menuFraisButton.Text = "Frais"
        Me.menuFraisButton.UseVisualStyleBackColor = False
        '
        'menuMarcheButton
        '
        Me.menuMarcheButton.BackColor = System.Drawing.Color.LightGray
        Me.menuMarcheButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuMarcheButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuMarcheButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuMarcheButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuMarcheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuMarcheButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMarcheButton.Location = New System.Drawing.Point(139, 36)
        Me.menuMarcheButton.Name = "menuMarcheButton"
        Me.menuMarcheButton.Size = New System.Drawing.Size(107, 42)
        Me.menuMarcheButton.TabIndex = 3
        Me.menuMarcheButton.Text = "Marché"
        Me.menuMarcheButton.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.cartSaveButton)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cartSuppressionButton)
        Me.Panel2.Controls.Add(Me.cartDetailButton)
        Me.Panel2.Controls.Add(Me.myListButton)
        Me.Panel2.Controls.Add(Me.cartValidationButton)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Location = New System.Drawing.Point(1102, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 638)
        Me.Panel2.TabIndex = 4
        '
        'cartSaveButton
        '
        Me.cartSaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartSaveButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartSaveButton.Location = New System.Drawing.Point(15, 576)
        Me.cartSaveButton.Name = "cartSaveButton"
        Me.cartSaveButton.Size = New System.Drawing.Size(222, 28)
        Me.cartSaveButton.TabIndex = 7
        Me.cartSaveButton.Text = "Sauvegarder"
        Me.cartSaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(41, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 34)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total : 56 €"
        '
        'cartSuppressionButton
        '
        Me.cartSuppressionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartSuppressionButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartSuppressionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartSuppressionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartSuppressionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartSuppressionButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartSuppressionButton.Location = New System.Drawing.Point(14, 541)
        Me.cartSuppressionButton.Name = "cartSuppressionButton"
        Me.cartSuppressionButton.Size = New System.Drawing.Size(222, 32)
        Me.cartSuppressionButton.TabIndex = 5
        Me.cartSuppressionButton.Text = "Supprimer"
        Me.cartSuppressionButton.UseVisualStyleBackColor = True
        '
        'cartDetailButton
        '
        Me.cartDetailButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartDetailButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartDetailButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartDetailButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartDetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartDetailButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartDetailButton.Location = New System.Drawing.Point(14, 503)
        Me.cartDetailButton.Name = "cartDetailButton"
        Me.cartDetailButton.Size = New System.Drawing.Size(222, 34)
        Me.cartDetailButton.TabIndex = 4
        Me.cartDetailButton.Text = "Détails"
        Me.cartDetailButton.UseVisualStyleBackColor = True
        '
        'myListButton
        '
        Me.myListButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.myListButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.myListButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.myListButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.myListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.myListButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myListButton.Location = New System.Drawing.Point(14, 608)
        Me.myListButton.Name = "myListButton"
        Me.myListButton.Size = New System.Drawing.Size(222, 26)
        Me.myListButton.TabIndex = 3
        Me.myListButton.Text = "Mes listes"
        Me.myListButton.UseVisualStyleBackColor = True
        '
        'cartValidationButton
        '
        Me.cartValidationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartValidationButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartValidationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartValidationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartValidationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartValidationButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartValidationButton.Location = New System.Drawing.Point(14, 469)
        Me.cartValidationButton.Name = "cartValidationButton"
        Me.cartValidationButton.Size = New System.Drawing.Size(222, 30)
        Me.cartValidationButton.TabIndex = 2
        Me.cartValidationButton.Text = "Valider"
        Me.cartValidationButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListView1.Location = New System.Drawing.Point(0, -1)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(246, 434)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'cancelPaidButton
        '
        Me.cancelPaidButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cancelPaidButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelPaidButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelPaidButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancelPaidButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelPaidButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelPaidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelPaidButton.Font = New System.Drawing.Font("Roboto Lt", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelPaidButton.Location = New System.Drawing.Point(31, 195)
        Me.cancelPaidButton.Name = "cancelPaidButton"
        Me.cancelPaidButton.Size = New System.Drawing.Size(217, 36)
        Me.cancelPaidButton.TabIndex = 0
        Me.cancelPaidButton.Text = "Continuer mes achats"
        Me.cancelPaidButton.UseVisualStyleBackColor = False
        '
        'paidButton
        '
        Me.paidButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.paidButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paidButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.paidButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.paidButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.paidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paidButton.Font = New System.Drawing.Font("Roboto Lt", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paidButton.Location = New System.Drawing.Point(281, 195)
        Me.paidButton.Name = "paidButton"
        Me.paidButton.Size = New System.Drawing.Size(217, 36)
        Me.paidButton.TabIndex = 1
        Me.paidButton.Text = "Payer"
        Me.paidButton.UseVisualStyleBackColor = False
        '
        'paymentTitleLabel
        '
        Me.paymentTitleLabel.AutoSize = True
        Me.paymentTitleLabel.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTitleLabel.ForeColor = System.Drawing.Color.White
        Me.paymentTitleLabel.Location = New System.Drawing.Point(80, 16)
        Me.paymentTitleLabel.Name = "paymentTitleLabel"
        Me.paymentTitleLabel.Size = New System.Drawing.Size(396, 37)
        Me.paymentTitleLabel.TabIndex = 2
        Me.paymentTitleLabel.Text = "Récapitulatif de votre panier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(274, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 41)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "56 €"
        '
        'paymentNbProdLabel
        '
        Me.paymentNbProdLabel.AutoSize = True
        Me.paymentNbProdLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentNbProdLabel.ForeColor = System.Drawing.Color.White
        Me.paymentNbProdLabel.Location = New System.Drawing.Point(83, 78)
        Me.paymentNbProdLabel.Name = "paymentNbProdLabel"
        Me.paymentNbProdLabel.Size = New System.Drawing.Size(364, 24)
        Me.paymentNbProdLabel.TabIndex = 9
        Me.paymentNbProdLabel.Text = "Vous avez 11 produits dans votre panier"
        '
        'paymentTotalLabel
        '
        Me.paymentTotalLabel.AutoSize = True
        Me.paymentTotalLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTotalLabel.ForeColor = System.Drawing.Color.White
        Me.paymentTotalLabel.Location = New System.Drawing.Point(197, 140)
        Me.paymentTotalLabel.Name = "paymentTotalLabel"
        Me.paymentTotalLabel.Size = New System.Drawing.Size(71, 24)
        Me.paymentTotalLabel.TabIndex = 10
        Me.paymentTotalLabel.Text = "Total : "
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
        Me.validationPanel.ResumeLayout(False)
        Me.validationPanel.PerformLayout()
        Me.affGridPanel.ResumeLayout(False)
        Me.affListPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents affListPanel As System.Windows.Forms.Panel
    Friend WithEvents affGridPanel As System.Windows.Forms.Panel
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
    Friend WithEvents myListButton As System.Windows.Forms.Button
    Friend WithEvents cartValidationButton As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cartSuppressionButton As System.Windows.Forms.Button
    Friend WithEvents cartDetailButton As System.Windows.Forms.Button
    Friend WithEvents cartSaveButton As System.Windows.Forms.Button
    Friend WithEvents menuMarcheButton As System.Windows.Forms.Button
    Friend WithEvents menuFraisButton As System.Windows.Forms.Button
    Friend WithEvents menuEpicerieSaleeButton As System.Windows.Forms.Button
    Friend WithEvents menuSurgelesButton As System.Windows.Forms.Button
    Friend WithEvents menuBoissonsButton As System.Windows.Forms.Button
    Friend WithEvents menuEpicerieSucreeButton As System.Windows.Forms.Button
    Friend WithEvents validationPanel As System.Windows.Forms.Panel
    Friend WithEvents paidButton As System.Windows.Forms.Button
    Friend WithEvents cancelPaidButton As System.Windows.Forms.Button
    Friend WithEvents paymentTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents paymentNbProdLabel As System.Windows.Forms.Label
    Friend WithEvents paymentTotalLabel As System.Windows.Forms.Label

End Class
