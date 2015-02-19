<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.cartLabel = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.separateurShapeContainer = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.detailPopUpPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.detailPriceLabel = New System.Windows.Forms.Label()
        Me.detailImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.detailSpecLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.detailNameLabel = New System.Windows.Forms.Label()
        Me.detailCategoryLabel = New System.Windows.Forms.Label()
        Me.detailBrandLabel = New System.Windows.Forms.Label()
        Me.detailWeightLabel = New System.Windows.Forms.Label()
        Me.detailPriceKgLabel = New System.Windows.Forms.Label()
        Me.detailOriginLabel = New System.Windows.Forms.Label()
        Me.detailCloseButton = New System.Windows.Forms.Button()
        Me.validationPaymentPanel = New System.Windows.Forms.Panel()
        Me.paymentTotalLabel = New System.Windows.Forms.Label()
        Me.paymentNbProdLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentTitleLabel = New System.Windows.Forms.Label()
        Me.paidButton = New System.Windows.Forms.Button()
        Me.cancelPaidButton = New System.Windows.Forms.Button()
        Me.popUpPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.contentPopUpLabel = New System.Windows.Forms.Label()
        Me.titlePopUpLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cancelPopUpButton = New System.Windows.Forms.Button()
        Me.validPopUpButton = New System.Windows.Forms.Button()
        Me.articlePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.menuBoissonsButton = New System.Windows.Forms.Button()
        Me.menuMarcheButton = New System.Windows.Forms.Button()
        Me.menuSurgelesButton = New System.Windows.Forms.Button()
        Me.menuFraisButton = New System.Windows.Forms.Button()
        Me.menuEpicerieSaleeButton = New System.Windows.Forms.Button()
        Me.menuEpicerieSucreeButton = New System.Windows.Forms.Button()
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
        Me.cartPanel = New System.Windows.Forms.Panel()
        Me.cartSaveButton = New System.Windows.Forms.Button()
        Me.cartTotalPriceLabel = New System.Windows.Forms.Label()
        Me.cartSuppressionButton = New System.Windows.Forms.Button()
        Me.cartDetailButton = New System.Windows.Forms.Button()
        Me.cartListButton = New System.Windows.Forms.Button()
        Me.cartValidationButton = New System.Windows.Forms.Button()
        Me.cartListView = New System.Windows.Forms.ListView()
        Me.headerPanel.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.centerPanel.SuspendLayout()
        Me.detailPopUpPanel.SuspendLayout()
        CType(Me.detailImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.validationPaymentPanel.SuspendLayout()
        Me.popUpPanel.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.menuPanel.SuspendLayout()
        Me.affGridPanel.SuspendLayout()
        Me.affListPanel.SuspendLayout()
        Me.cartPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.headerPanel.Controls.Add(Me.cartLabel)
        Me.headerPanel.Controls.Add(Me.logoPictureBox)
        Me.headerPanel.Controls.Add(Me.searchButton)
        Me.headerPanel.Controls.Add(Me.searchTextBox)
        Me.headerPanel.Controls.Add(Me.separateurShapeContainer)
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1348, 86)
        Me.headerPanel.TabIndex = 2
        '
        'cartLabel
        '
        Me.cartLabel.AutoSize = True
        Me.cartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartLabel.ForeColor = System.Drawing.Color.White
        Me.cartLabel.Location = New System.Drawing.Point(1117, 20)
        Me.cartLabel.Name = "cartLabel"
        Me.cartLabel.Size = New System.Drawing.Size(219, 46)
        Me.cartLabel.TabIndex = 6
        Me.cartLabel.Text = "Mon panier"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.Location = New System.Drawing.Point(12, 6)
        Me.logoPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(221, 90)
        Me.logoPictureBox.TabIndex = 4
        Me.logoPictureBox.TabStop = False
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(860, 23)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(96, 39)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Rechercher"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.searchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.Location = New System.Drawing.Point(271, 23)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(593, 38)
        Me.searchTextBox.TabIndex = 0
        Me.searchTextBox.Text = "Rechercher un produit"
        '
        'separateurShapeContainer
        '
        Me.separateurShapeContainer.Location = New System.Drawing.Point(0, 0)
        Me.separateurShapeContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.separateurShapeContainer.Name = "separateurShapeContainer"
        Me.separateurShapeContainer.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.separateurShapeContainer.Size = New System.Drawing.Size(1348, 86)
        Me.separateurShapeContainer.TabIndex = 5
        Me.separateurShapeContainer.TabStop = False
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
        Me.centerPanel.Controls.Add(Me.detailPopUpPanel)
        Me.centerPanel.Controls.Add(Me.validationPaymentPanel)
        Me.centerPanel.Controls.Add(Me.popUpPanel)
        Me.centerPanel.Controls.Add(Me.articlePanel)
        Me.centerPanel.Controls.Add(Me.menuPanel)
        Me.centerPanel.Controls.Add(Me.affGridPanel)
        Me.centerPanel.Controls.Add(Me.affListPanel)
        Me.centerPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.centerPanel.Location = New System.Drawing.Point(0, 85)
        Me.centerPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(1103, 642)
        Me.centerPanel.TabIndex = 3
        '
        'detailPopUpPanel
        '
        Me.detailPopUpPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.detailPopUpPanel.ColumnCount = 3
        Me.detailPopUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.detailPopUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283.0!))
        Me.detailPopUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.detailPopUpPanel.Controls.Add(Me.detailPriceLabel, 0, 1)
        Me.detailPopUpPanel.Controls.Add(Me.detailImgPictureBox, 0, 0)
        Me.detailPopUpPanel.Controls.Add(Me.detailSpecLabel, 1, 1)
        Me.detailPopUpPanel.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.detailPopUpPanel.Controls.Add(Me.detailCloseButton, 2, 0)
        Me.detailPopUpPanel.Location = New System.Drawing.Point(229, 150)
        Me.detailPopUpPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.detailPopUpPanel.Name = "detailPopUpPanel"
        Me.detailPopUpPanel.RowCount = 2
        Me.detailPopUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.detailPopUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.0!))
        Me.detailPopUpPanel.Size = New System.Drawing.Size(600, 350)
        Me.detailPopUpPanel.TabIndex = 14
        Me.detailPopUpPanel.Visible = False
        '
        'detailPriceLabel
        '
        Me.detailPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.detailPriceLabel.AutoSize = True
        Me.detailPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailPriceLabel.ForeColor = System.Drawing.Color.White
        Me.detailPriceLabel.Location = New System.Drawing.Point(68, 231)
        Me.detailPriceLabel.Name = "detailPriceLabel"
        Me.detailPriceLabel.Size = New System.Drawing.Size(148, 91)
        Me.detailPriceLabel.TabIndex = 0
        Me.detailPriceLabel.Text = "5 €"
        '
        'detailImgPictureBox
        '
        Me.detailImgPictureBox.Location = New System.Drawing.Point(3, 2)
        Me.detailImgPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.detailImgPictureBox.Name = "detailImgPictureBox"
        Me.detailImgPictureBox.Size = New System.Drawing.Size(277, 193)
        Me.detailImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.detailImgPictureBox.TabIndex = 1
        Me.detailImgPictureBox.TabStop = False
        '
        'detailSpecLabel
        '
        Me.detailSpecLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.detailSpecLabel.AutoSize = True
        Me.detailSpecLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailSpecLabel.ForeColor = System.Drawing.Color.White
        Me.detailSpecLabel.Location = New System.Drawing.Point(288, 203)
        Me.detailSpecLabel.Name = "detailSpecLabel"
        Me.detailSpecLabel.Size = New System.Drawing.Size(275, 147)
        Me.detailSpecLabel.TabIndex = 2
        Me.detailSpecLabel.Text = resources.GetString("detailSpecLabel.Text")
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.detailNameLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.detailCategoryLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.detailBrandLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.detailWeightLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.detailPriceKgLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.detailOriginLabel)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(287, 2)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(277, 190)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'detailNameLabel
        '
        Me.detailNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.detailNameLabel.AutoSize = True
        Me.detailNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailNameLabel.ForeColor = System.Drawing.Color.White
        Me.detailNameLabel.Location = New System.Drawing.Point(24, 20)
        Me.detailNameLabel.Name = "detailNameLabel"
        Me.detailNameLabel.Size = New System.Drawing.Size(94, 38)
        Me.detailNameLabel.TabIndex = 0
        Me.detailNameLabel.Text = "NOM"
        '
        'detailCategoryLabel
        '
        Me.detailCategoryLabel.AutoSize = True
        Me.detailCategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailCategoryLabel.ForeColor = System.Drawing.Color.White
        Me.detailCategoryLabel.Location = New System.Drawing.Point(3, 58)
        Me.detailCategoryLabel.Name = "detailCategoryLabel"
        Me.detailCategoryLabel.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.detailCategoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailCategoryLabel.Size = New System.Drawing.Size(137, 25)
        Me.detailCategoryLabel.TabIndex = 1
        Me.detailCategoryLabel.Text = "Catégorie"
        Me.detailCategoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailBrandLabel
        '
        Me.detailBrandLabel.AutoSize = True
        Me.detailBrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailBrandLabel.ForeColor = System.Drawing.Color.White
        Me.detailBrandLabel.Location = New System.Drawing.Point(3, 83)
        Me.detailBrandLabel.Name = "detailBrandLabel"
        Me.detailBrandLabel.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.detailBrandLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailBrandLabel.Size = New System.Drawing.Size(119, 25)
        Me.detailBrandLabel.TabIndex = 2
        Me.detailBrandLabel.Text = "Marque"
        Me.detailBrandLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailWeightLabel
        '
        Me.detailWeightLabel.AutoSize = True
        Me.detailWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailWeightLabel.ForeColor = System.Drawing.Color.White
        Me.detailWeightLabel.Location = New System.Drawing.Point(3, 108)
        Me.detailWeightLabel.Name = "detailWeightLabel"
        Me.detailWeightLabel.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.detailWeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailWeightLabel.Size = New System.Drawing.Size(101, 25)
        Me.detailWeightLabel.TabIndex = 3
        Me.detailWeightLabel.Text = "Poids"
        Me.detailWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailPriceKgLabel
        '
        Me.detailPriceKgLabel.AutoSize = True
        Me.detailPriceKgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailPriceKgLabel.ForeColor = System.Drawing.Color.White
        Me.detailPriceKgLabel.Location = New System.Drawing.Point(3, 133)
        Me.detailPriceKgLabel.Name = "detailPriceKgLabel"
        Me.detailPriceKgLabel.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.detailPriceKgLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailPriceKgLabel.Size = New System.Drawing.Size(122, 25)
        Me.detailPriceKgLabel.TabIndex = 4
        Me.detailPriceKgLabel.Text = "Prix / kg"
        Me.detailPriceKgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailOriginLabel
        '
        Me.detailOriginLabel.AutoSize = True
        Me.detailOriginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailOriginLabel.ForeColor = System.Drawing.Color.White
        Me.detailOriginLabel.Location = New System.Drawing.Point(3, 158)
        Me.detailOriginLabel.Name = "detailOriginLabel"
        Me.detailOriginLabel.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.detailOriginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailOriginLabel.Size = New System.Drawing.Size(115, 25)
        Me.detailOriginLabel.TabIndex = 5
        Me.detailOriginLabel.Text = "Origine"
        Me.detailOriginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailCloseButton
        '
        Me.detailCloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.detailCloseButton.FlatAppearance.BorderSize = 0
        Me.detailCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.detailCloseButton.ForeColor = System.Drawing.Color.White
        Me.detailCloseButton.Location = New System.Drawing.Point(570, 2)
        Me.detailCloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.detailCloseButton.Name = "detailCloseButton"
        Me.detailCloseButton.Size = New System.Drawing.Size(27, 26)
        Me.detailCloseButton.TabIndex = 4
        Me.detailCloseButton.Text = "X"
        Me.detailCloseButton.UseVisualStyleBackColor = True
        '
        'validationPaymentPanel
        '
        Me.validationPaymentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.validationPaymentPanel.Controls.Add(Me.paymentTotalLabel)
        Me.validationPaymentPanel.Controls.Add(Me.paymentNbProdLabel)
        Me.validationPaymentPanel.Controls.Add(Me.Label2)
        Me.validationPaymentPanel.Controls.Add(Me.paymentTitleLabel)
        Me.validationPaymentPanel.Controls.Add(Me.paidButton)
        Me.validationPaymentPanel.Controls.Add(Me.cancelPaidButton)
        Me.validationPaymentPanel.Location = New System.Drawing.Point(271, 178)
        Me.validationPaymentPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.validationPaymentPanel.Name = "validationPaymentPanel"
        Me.validationPaymentPanel.Size = New System.Drawing.Size(535, 0)
        Me.validationPaymentPanel.TabIndex = 9
        Me.validationPaymentPanel.Visible = False
        '
        'paymentTotalLabel
        '
        Me.paymentTotalLabel.AutoSize = True
        Me.paymentTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTotalLabel.ForeColor = System.Drawing.Color.White
        Me.paymentTotalLabel.Location = New System.Drawing.Point(197, 140)
        Me.paymentTotalLabel.Name = "paymentTotalLabel"
        Me.paymentTotalLabel.Size = New System.Drawing.Size(72, 25)
        Me.paymentTotalLabel.TabIndex = 10
        Me.paymentTotalLabel.Text = "Total : "
        '
        'paymentNbProdLabel
        '
        Me.paymentNbProdLabel.AutoSize = True
        Me.paymentNbProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentNbProdLabel.ForeColor = System.Drawing.Color.White
        Me.paymentNbProdLabel.Location = New System.Drawing.Point(83, 78)
        Me.paymentNbProdLabel.Name = "paymentNbProdLabel"
        Me.paymentNbProdLabel.Size = New System.Drawing.Size(361, 25)
        Me.paymentNbProdLabel.TabIndex = 9
        Me.paymentNbProdLabel.Text = "Vous avez 11 produits dans votre panier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(275, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 38)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "56 €"
        '
        'paymentTitleLabel
        '
        Me.paymentTitleLabel.AutoSize = True
        Me.paymentTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTitleLabel.ForeColor = System.Drawing.Color.White
        Me.paymentTitleLabel.Location = New System.Drawing.Point(80, 16)
        Me.paymentTitleLabel.Name = "paymentTitleLabel"
        Me.paymentTitleLabel.Size = New System.Drawing.Size(385, 36)
        Me.paymentTitleLabel.TabIndex = 2
        Me.paymentTitleLabel.Text = "Récapitulatif de votre panier"
        '
        'paidButton
        '
        Me.paidButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.paidButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paidButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.paidButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.paidButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.paidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paidButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paidButton.Location = New System.Drawing.Point(281, 194)
        Me.paidButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.paidButton.Name = "paidButton"
        Me.paidButton.Size = New System.Drawing.Size(217, 36)
        Me.paidButton.TabIndex = 1
        Me.paidButton.Text = "Payer"
        Me.paidButton.UseVisualStyleBackColor = False
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
        Me.cancelPaidButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelPaidButton.Location = New System.Drawing.Point(31, 194)
        Me.cancelPaidButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancelPaidButton.Name = "cancelPaidButton"
        Me.cancelPaidButton.Size = New System.Drawing.Size(217, 36)
        Me.cancelPaidButton.TabIndex = 0
        Me.cancelPaidButton.Text = "Continuer mes achats"
        Me.cancelPaidButton.UseVisualStyleBackColor = False
        '
        'popUpPanel
        '
        Me.popUpPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.popUpPanel.ColumnCount = 1
        Me.popUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.Controls.Add(Me.contentPopUpLabel, 0, 1)
        Me.popUpPanel.Controls.Add(Me.titlePopUpLabel, 0, 0)
        Me.popUpPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.popUpPanel.Location = New System.Drawing.Point(301, 210)
        Me.popUpPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.popUpPanel.Name = "popUpPanel"
        Me.popUpPanel.RowCount = 3
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.popUpPanel.Size = New System.Drawing.Size(532, 0)
        Me.popUpPanel.TabIndex = 12
        '
        'contentPopUpLabel
        '
        Me.contentPopUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contentPopUpLabel.AutoSize = True
        Me.contentPopUpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contentPopUpLabel.ForeColor = System.Drawing.Color.White
        Me.contentPopUpLabel.Location = New System.Drawing.Point(83, -26)
        Me.contentPopUpLabel.Name = "contentPopUpLabel"
        Me.contentPopUpLabel.Size = New System.Drawing.Size(365, 1)
        Me.contentPopUpLabel.TabIndex = 10
        Me.contentPopUpLabel.Text = "Voulez-vous supprimer tous les produit ?"
        '
        'titlePopUpLabel
        '
        Me.titlePopUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.titlePopUpLabel.AutoSize = True
        Me.titlePopUpLabel.BackColor = System.Drawing.Color.Transparent
        Me.titlePopUpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlePopUpLabel.ForeColor = System.Drawing.Color.White
        Me.titlePopUpLabel.Location = New System.Drawing.Point(40, 0)
        Me.titlePopUpLabel.Name = "titlePopUpLabel"
        Me.titlePopUpLabel.Size = New System.Drawing.Size(451, 1)
        Me.titlePopUpLabel.TabIndex = 3
        Me.titlePopUpLabel.Text = "Suppression de tous les produits"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.cancelPopUpButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.validPopUpButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, -50)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(525, 47)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'cancelPopUpButton
        '
        Me.cancelPopUpButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cancelPopUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelPopUpButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancelPopUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelPopUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelPopUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelPopUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelPopUpButton.Location = New System.Drawing.Point(29, 2)
        Me.cancelPopUpButton.Margin = New System.Windows.Forms.Padding(29, 2, 3, 2)
        Me.cancelPopUpButton.Name = "cancelPopUpButton"
        Me.cancelPopUpButton.Size = New System.Drawing.Size(217, 36)
        Me.cancelPopUpButton.TabIndex = 10
        Me.cancelPopUpButton.Text = "Annuler"
        Me.cancelPopUpButton.UseVisualStyleBackColor = False
        '
        'validPopUpButton
        '
        Me.validPopUpButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.validPopUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.validPopUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.validPopUpButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.validPopUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.validPopUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.validPopUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.validPopUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validPopUpButton.Location = New System.Drawing.Point(300, 2)
        Me.validPopUpButton.Margin = New System.Windows.Forms.Padding(51, 2, 3, 2)
        Me.validPopUpButton.Name = "validPopUpButton"
        Me.validPopUpButton.Size = New System.Drawing.Size(217, 36)
        Me.validPopUpButton.TabIndex = 10
        Me.validPopUpButton.Text = "Oui"
        Me.validPopUpButton.UseVisualStyleBackColor = False
        '
        'articlePanel
        '
        Me.articlePanel.Location = New System.Drawing.Point(55, 101)
        Me.articlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.articlePanel.Name = "articlePanel"
        Me.articlePanel.Size = New System.Drawing.Size(997, 531)
        Me.articlePanel.TabIndex = 13
        '
        'menuPanel
        '
        Me.menuPanel.Controls.Add(Me.menuBoissonsButton)
        Me.menuPanel.Controls.Add(Me.menuMarcheButton)
        Me.menuPanel.Controls.Add(Me.menuSurgelesButton)
        Me.menuPanel.Controls.Add(Me.menuFraisButton)
        Me.menuPanel.Controls.Add(Me.menuEpicerieSaleeButton)
        Me.menuPanel.Controls.Add(Me.menuEpicerieSucreeButton)
        Me.menuPanel.Location = New System.Drawing.Point(145, 34)
        Me.menuPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(731, 43)
        Me.menuPanel.TabIndex = 10
        '
        'menuBoissonsButton
        '
        Me.menuBoissonsButton.BackColor = System.Drawing.Color.LightGray
        Me.menuBoissonsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuBoissonsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuBoissonsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuBoissonsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuBoissonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuBoissonsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBoissonsButton.Location = New System.Drawing.Point(507, 1)
        Me.menuBoissonsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuBoissonsButton.Name = "menuBoissonsButton"
        Me.menuBoissonsButton.Size = New System.Drawing.Size(116, 42)
        Me.menuBoissonsButton.TabIndex = 7
        Me.menuBoissonsButton.Text = "Boissons"
        Me.menuBoissonsButton.UseVisualStyleBackColor = False
        '
        'menuMarcheButton
        '
        Me.menuMarcheButton.BackColor = System.Drawing.Color.LightGray
        Me.menuMarcheButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuMarcheButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuMarcheButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuMarcheButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuMarcheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuMarcheButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMarcheButton.Location = New System.Drawing.Point(1, 1)
        Me.menuMarcheButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuMarcheButton.Name = "menuMarcheButton"
        Me.menuMarcheButton.Size = New System.Drawing.Size(107, 42)
        Me.menuMarcheButton.TabIndex = 3
        Me.menuMarcheButton.Text = "Marché"
        Me.menuMarcheButton.UseVisualStyleBackColor = False
        '
        'menuSurgelesButton
        '
        Me.menuSurgelesButton.BackColor = System.Drawing.Color.LightGray
        Me.menuSurgelesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuSurgelesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuSurgelesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuSurgelesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuSurgelesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuSurgelesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuSurgelesButton.Location = New System.Drawing.Point(622, 1)
        Me.menuSurgelesButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuSurgelesButton.Name = "menuSurgelesButton"
        Me.menuSurgelesButton.Size = New System.Drawing.Size(108, 42)
        Me.menuSurgelesButton.TabIndex = 8
        Me.menuSurgelesButton.Text = "Surgelés"
        Me.menuSurgelesButton.UseVisualStyleBackColor = False
        '
        'menuFraisButton
        '
        Me.menuFraisButton.BackColor = System.Drawing.Color.LightGray
        Me.menuFraisButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuFraisButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuFraisButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuFraisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuFraisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuFraisButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuFraisButton.Location = New System.Drawing.Point(107, 1)
        Me.menuFraisButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuFraisButton.Name = "menuFraisButton"
        Me.menuFraisButton.Size = New System.Drawing.Size(85, 42)
        Me.menuFraisButton.TabIndex = 4
        Me.menuFraisButton.Text = "Frais"
        Me.menuFraisButton.UseVisualStyleBackColor = False
        '
        'menuEpicerieSaleeButton
        '
        Me.menuEpicerieSaleeButton.BackColor = System.Drawing.Color.LightGray
        Me.menuEpicerieSaleeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSaleeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuEpicerieSaleeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSaleeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSaleeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuEpicerieSaleeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEpicerieSaleeButton.Location = New System.Drawing.Point(191, 1)
        Me.menuEpicerieSaleeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuEpicerieSaleeButton.Name = "menuEpicerieSaleeButton"
        Me.menuEpicerieSaleeButton.Size = New System.Drawing.Size(156, 42)
        Me.menuEpicerieSaleeButton.TabIndex = 5
        Me.menuEpicerieSaleeButton.Text = "Epicerie Salée"
        Me.menuEpicerieSaleeButton.UseVisualStyleBackColor = False
        '
        'menuEpicerieSucreeButton
        '
        Me.menuEpicerieSucreeButton.BackColor = System.Drawing.Color.LightGray
        Me.menuEpicerieSucreeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuEpicerieSucreeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuEpicerieSucreeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSucreeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuEpicerieSucreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuEpicerieSucreeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuEpicerieSucreeButton.Location = New System.Drawing.Point(346, 1)
        Me.menuEpicerieSucreeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menuEpicerieSucreeButton.Name = "menuEpicerieSucreeButton"
        Me.menuEpicerieSucreeButton.Size = New System.Drawing.Size(163, 42)
        Me.menuEpicerieSucreeButton.TabIndex = 6
        Me.menuEpicerieSucreeButton.Text = "Epicerie Sucrée"
        Me.menuEpicerieSucreeButton.UseVisualStyleBackColor = False
        '
        'affGridPanel
        '
        Me.affGridPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.affGridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.affGridPanel.Controls.Add(Me.ShapeContainer3)
        Me.affGridPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.affGridPanel.Location = New System.Drawing.Point(1000, 34)
        Me.affGridPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.affListPanel.Location = New System.Drawing.Point(949, 34)
        Me.affListPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        'cartPanel
        '
        Me.cartPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartPanel.Controls.Add(Me.cartSaveButton)
        Me.cartPanel.Controls.Add(Me.cartTotalPriceLabel)
        Me.cartPanel.Controls.Add(Me.cartSuppressionButton)
        Me.cartPanel.Controls.Add(Me.cartDetailButton)
        Me.cartPanel.Controls.Add(Me.cartListButton)
        Me.cartPanel.Controls.Add(Me.cartValidationButton)
        Me.cartPanel.Controls.Add(Me.cartListView)
        Me.cartPanel.Location = New System.Drawing.Point(1101, 86)
        Me.cartPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartPanel.Name = "cartPanel"
        Me.cartPanel.Size = New System.Drawing.Size(245, 638)
        Me.cartPanel.TabIndex = 4
        '
        'cartSaveButton
        '
        Me.cartSaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartSaveButton.Location = New System.Drawing.Point(15, 576)
        Me.cartSaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartSaveButton.Name = "cartSaveButton"
        Me.cartSaveButton.Size = New System.Drawing.Size(221, 28)
        Me.cartSaveButton.TabIndex = 7
        Me.cartSaveButton.Text = "Sauvegarder"
        Me.cartSaveButton.UseVisualStyleBackColor = True
        '
        'cartTotalPriceLabel
        '
        Me.cartTotalPriceLabel.AutoSize = True
        Me.cartTotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartTotalPriceLabel.ForeColor = System.Drawing.Color.DimGray
        Me.cartTotalPriceLabel.Location = New System.Drawing.Point(41, 434)
        Me.cartTotalPriceLabel.Name = "cartTotalPriceLabel"
        Me.cartTotalPriceLabel.Size = New System.Drawing.Size(156, 32)
        Me.cartTotalPriceLabel.TabIndex = 6
        Me.cartTotalPriceLabel.Text = "Total : 56 €"
        '
        'cartSuppressionButton
        '
        Me.cartSuppressionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartSuppressionButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartSuppressionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartSuppressionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartSuppressionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartSuppressionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartSuppressionButton.Location = New System.Drawing.Point(13, 542)
        Me.cartSuppressionButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartSuppressionButton.Name = "cartSuppressionButton"
        Me.cartSuppressionButton.Size = New System.Drawing.Size(221, 32)
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
        Me.cartDetailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartDetailButton.Location = New System.Drawing.Point(13, 503)
        Me.cartDetailButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartDetailButton.Name = "cartDetailButton"
        Me.cartDetailButton.Size = New System.Drawing.Size(221, 34)
        Me.cartDetailButton.TabIndex = 4
        Me.cartDetailButton.Text = "Détails"
        Me.cartDetailButton.UseVisualStyleBackColor = True
        '
        'cartListButton
        '
        Me.cartListButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartListButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartListButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartListButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartListButton.Location = New System.Drawing.Point(13, 608)
        Me.cartListButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartListButton.Name = "cartListButton"
        Me.cartListButton.Size = New System.Drawing.Size(221, 26)
        Me.cartListButton.TabIndex = 3
        Me.cartListButton.Text = "Mes listes"
        Me.cartListButton.UseVisualStyleBackColor = True
        '
        'cartValidationButton
        '
        Me.cartValidationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartValidationButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartValidationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartValidationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartValidationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartValidationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartValidationButton.Location = New System.Drawing.Point(13, 469)
        Me.cartValidationButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartValidationButton.Name = "cartValidationButton"
        Me.cartValidationButton.Size = New System.Drawing.Size(221, 30)
        Me.cartValidationButton.TabIndex = 2
        Me.cartValidationButton.Text = "Valider"
        Me.cartValidationButton.UseVisualStyleBackColor = True
        '
        'cartListView
        '
        Me.cartListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartListView.Location = New System.Drawing.Point(0, -1)
        Me.cartListView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cartListView.Name = "cartListView"
        Me.cartListView.Size = New System.Drawing.Size(247, 434)
        Me.cartListView.TabIndex = 1
        Me.cartListView.UseCompatibleStateImageBehavior = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.headerPanel)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.cartPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home"
        Me.Text = "Form1"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.centerPanel.ResumeLayout(False)
        Me.detailPopUpPanel.ResumeLayout(False)
        Me.detailPopUpPanel.PerformLayout()
        CType(Me.detailImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.validationPaymentPanel.ResumeLayout(False)
        Me.validationPaymentPanel.PerformLayout()
        Me.popUpPanel.ResumeLayout(False)
        Me.popUpPanel.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.menuPanel.ResumeLayout(False)
        Me.affGridPanel.ResumeLayout(False)
        Me.affListPanel.ResumeLayout(False)
        Me.cartPanel.ResumeLayout(False)
        Me.cartPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents headerPanel As System.Windows.Forms.Panel
    Friend WithEvents searchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents centerPanel As System.Windows.Forms.Panel
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents separateurShapeContainer As Microsoft.VisualBasic.PowerPacks.ShapeContainer
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
    Friend WithEvents cartPanel As System.Windows.Forms.Panel
    Friend WithEvents cartListButton As System.Windows.Forms.Button
    Friend WithEvents cartValidationButton As System.Windows.Forms.Button
    Friend WithEvents cartListView As System.Windows.Forms.ListView
    Friend WithEvents cartTotalPriceLabel As System.Windows.Forms.Label
    Friend WithEvents cartSuppressionButton As System.Windows.Forms.Button
    Friend WithEvents cartDetailButton As System.Windows.Forms.Button
    Friend WithEvents cartSaveButton As System.Windows.Forms.Button
    Friend WithEvents menuMarcheButton As System.Windows.Forms.Button
    Friend WithEvents menuFraisButton As System.Windows.Forms.Button
    Friend WithEvents menuEpicerieSaleeButton As System.Windows.Forms.Button
    Friend WithEvents menuSurgelesButton As System.Windows.Forms.Button
    Friend WithEvents menuBoissonsButton As System.Windows.Forms.Button
    Friend WithEvents menuEpicerieSucreeButton As System.Windows.Forms.Button
    Friend WithEvents validationPaymentPanel As System.Windows.Forms.Panel
    Friend WithEvents paidButton As System.Windows.Forms.Button
    Friend WithEvents cancelPaidButton As System.Windows.Forms.Button
    Friend WithEvents paymentTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents paymentNbProdLabel As System.Windows.Forms.Label
    Friend WithEvents paymentTotalLabel As System.Windows.Forms.Label
    Friend WithEvents menuPanel As System.Windows.Forms.Panel
    Friend WithEvents popUpPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents contentPopUpLabel As System.Windows.Forms.Label
    Friend WithEvents titlePopUpLabel As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cancelPopUpButton As System.Windows.Forms.Button
    Friend WithEvents validPopUpButton As System.Windows.Forms.Button
    Friend WithEvents articlePanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents detailPopUpPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents detailPriceLabel As System.Windows.Forms.Label
    Friend WithEvents detailImgPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents detailSpecLabel As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents detailNameLabel As System.Windows.Forms.Label
    Friend WithEvents detailCategoryLabel As System.Windows.Forms.Label
    Friend WithEvents detailBrandLabel As System.Windows.Forms.Label
    Friend WithEvents detailWeightLabel As System.Windows.Forms.Label
    Friend WithEvents detailPriceKgLabel As System.Windows.Forms.Label
    Friend WithEvents detailOriginLabel As System.Windows.Forms.Label
    Friend WithEvents detailCloseButton As System.Windows.Forms.Button

End Class
