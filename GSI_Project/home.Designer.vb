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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.cartLabel = New System.Windows.Forms.Label()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.separateurShapeContainer = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.labelAccueil = New System.Windows.Forms.Label()
        Me.savedListPanel = New System.Windows.Forms.Panel()
        Me.puPanel = New System.Windows.Forms.Panel()
        Me.puContentLabel = New System.Windows.Forms.Label()
        Me.puCancelButton = New System.Windows.Forms.Button()
        Me.deleteSavedListButton = New System.Windows.Forms.Button()
        Me.loadSavedListButton = New System.Windows.Forms.Button()
        Me.SavedListsTreeView = New System.Windows.Forms.TreeView()
        Me.savedListsCancelButton = New System.Windows.Forms.Button()
        Me.savedListTitleLabel = New System.Windows.Forms.Label()
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
        Me.detailCartPanel = New System.Windows.Forms.Panel()
        Me.cartDetailCancelButton = New System.Windows.Forms.Button()
        Me.detailCartListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cartDetailTitleLabel = New System.Windows.Forms.Label()
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
        Me.cartTotalPriceLabel = New System.Windows.Forms.Label()
        Me.cartMinPriceLabel = New System.Windows.Forms.Label()
        Me.cartValidationButton = New System.Windows.Forms.Button()
        Me.cartListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cartSaveButton = New System.Windows.Forms.Button()
        Me.cartSuppressionButton = New System.Windows.Forms.Button()
        Me.cartDetailButton = New System.Windows.Forms.Button()
        Me.cartListButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.headerPanel.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.centerPanel.SuspendLayout()
        Me.savedListPanel.SuspendLayout()
        Me.puPanel.SuspendLayout()
        Me.validationPaymentPanel.SuspendLayout()
        Me.popUpPanel.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.detailPopUpPanel.SuspendLayout()
        CType(Me.detailImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.detailCartPanel.SuspendLayout()
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
        Me.headerPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1011, 70)
        Me.headerPanel.TabIndex = 2
        '
        'cartLabel
        '
        Me.cartLabel.AutoSize = True
        Me.cartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartLabel.ForeColor = System.Drawing.Color.White
        Me.cartLabel.Location = New System.Drawing.Point(838, 16)
        Me.cartLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cartLabel.Name = "cartLabel"
        Me.cartLabel.Size = New System.Drawing.Size(177, 37)
        Me.cartLabel.TabIndex = 6
        Me.cartLabel.Text = "Mon panier"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.Location = New System.Drawing.Point(9, 5)
        Me.logoPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(166, 73)
        Me.logoPictureBox.TabIndex = 4
        Me.logoPictureBox.TabStop = False
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(645, 19)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(72, 32)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Rechercher"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.searchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.Location = New System.Drawing.Point(203, 19)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(446, 32)
        Me.searchTextBox.TabIndex = 0
        Me.searchTextBox.Text = "Rechercher un produit"
        '
        'separateurShapeContainer
        '
        Me.separateurShapeContainer.Location = New System.Drawing.Point(0, 0)
        Me.separateurShapeContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.separateurShapeContainer.Name = "separateurShapeContainer"
        Me.separateurShapeContainer.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.separateurShapeContainer.Size = New System.Drawing.Size(1011, 70)
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
        Me.centerPanel.Controls.Add(Me.puPanel)
        Me.centerPanel.Controls.Add(Me.labelAccueil)
        Me.centerPanel.Controls.Add(Me.savedListPanel)
        Me.centerPanel.Controls.Add(Me.validationPaymentPanel)
        Me.centerPanel.Controls.Add(Me.popUpPanel)
        Me.centerPanel.Controls.Add(Me.detailPopUpPanel)
        Me.centerPanel.Controls.Add(Me.detailCartPanel)
        Me.centerPanel.Controls.Add(Me.articlePanel)
        Me.centerPanel.Controls.Add(Me.menuPanel)
        Me.centerPanel.Controls.Add(Me.affGridPanel)
        Me.centerPanel.Controls.Add(Me.affListPanel)
        Me.centerPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.centerPanel.Location = New System.Drawing.Point(0, 69)
        Me.centerPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(827, 522)
        Me.centerPanel.TabIndex = 3
        '
        'labelAccueil
        '
        Me.labelAccueil.AutoSize = True
        Me.labelAccueil.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAccueil.Location = New System.Drawing.Point(282, 237)
        Me.labelAccueil.Name = "labelAccueil"
        Me.labelAccueil.Size = New System.Drawing.Size(273, 30)
        Me.labelAccueil.TabIndex = 16
        Me.labelAccueil.Text = "Bienvenue sur GSI Courses"
        '
        'savedListPanel
        '
        Me.savedListPanel.BackColor = System.Drawing.SystemColors.Window
        Me.savedListPanel.Controls.Add(Me.deleteSavedListButton)
        Me.savedListPanel.Controls.Add(Me.loadSavedListButton)
        Me.savedListPanel.Controls.Add(Me.SavedListsTreeView)
        Me.savedListPanel.Controls.Add(Me.savedListsCancelButton)
        Me.savedListPanel.Controls.Add(Me.savedListTitleLabel)
        Me.savedListPanel.Location = New System.Drawing.Point(42, 79)
        Me.savedListPanel.Name = "savedListPanel"
        Me.savedListPanel.Size = New System.Drawing.Size(770, 430)
        Me.savedListPanel.TabIndex = 15
        Me.savedListPanel.Visible = False
        '
        'puPanel
        '
        Me.puPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.puPanel.Controls.Add(Me.puContentLabel)
        Me.puPanel.Controls.Add(Me.puCancelButton)
        Me.puPanel.Location = New System.Drawing.Point(227, 155)
        Me.puPanel.Name = "puPanel"
        Me.puPanel.Size = New System.Drawing.Size(392, 113)
        Me.puPanel.TabIndex = 16
        Me.puPanel.Visible = False
        '
        'puContentLabel
        '
        Me.puContentLabel.AutoSize = True
        Me.puContentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puContentLabel.ForeColor = System.Drawing.Color.White
        Me.puContentLabel.Location = New System.Drawing.Point(5, 53)
        Me.puContentLabel.Name = "puContentLabel"
        Me.puContentLabel.Size = New System.Drawing.Size(300, 20)
        Me.puContentLabel.TabIndex = 1
        Me.puContentLabel.Text = "Votre commande à été prise en compte ! "
        '
        'puCancelButton
        '
        Me.puCancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.puCancelButton.FlatAppearance.BorderSize = 0
        Me.puCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.puCancelButton.Location = New System.Drawing.Point(353, 3)
        Me.puCancelButton.Name = "puCancelButton"
        Me.puCancelButton.Size = New System.Drawing.Size(36, 34)
        Me.puCancelButton.TabIndex = 0
        Me.puCancelButton.Text = "X"
        Me.puCancelButton.UseVisualStyleBackColor = True
        '
        'deleteSavedListButton
        '
        Me.deleteSavedListButton.Enabled = False
        Me.deleteSavedListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteSavedListButton.Location = New System.Drawing.Point(184, 381)
        Me.deleteSavedListButton.Name = "deleteSavedListButton"
        Me.deleteSavedListButton.Size = New System.Drawing.Size(113, 23)
        Me.deleteSavedListButton.TabIndex = 6
        Me.deleteSavedListButton.Text = "Supprimer la liste"
        Me.deleteSavedListButton.UseVisualStyleBackColor = True
        '
        'loadSavedListButton
        '
        Me.loadSavedListButton.Enabled = False
        Me.loadSavedListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadSavedListButton.Location = New System.Drawing.Point(68, 381)
        Me.loadSavedListButton.Name = "loadSavedListButton"
        Me.loadSavedListButton.Size = New System.Drawing.Size(104, 23)
        Me.loadSavedListButton.TabIndex = 5
        Me.loadSavedListButton.Text = "Charger la liste"
        Me.loadSavedListButton.UseVisualStyleBackColor = True
        '
        'SavedListsTreeView
        '
        Me.SavedListsTreeView.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SavedListsTreeView.Location = New System.Drawing.Point(47, 66)
        Me.SavedListsTreeView.Name = "SavedListsTreeView"
        Me.SavedListsTreeView.Size = New System.Drawing.Size(685, 293)
        Me.SavedListsTreeView.TabIndex = 4
        '
        'savedListsCancelButton
        '
        Me.savedListsCancelButton.FlatAppearance.BorderSize = 0
        Me.savedListsCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savedListsCancelButton.Location = New System.Drawing.Point(723, 19)
        Me.savedListsCancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.savedListsCancelButton.Name = "savedListsCancelButton"
        Me.savedListsCancelButton.Size = New System.Drawing.Size(34, 24)
        Me.savedListsCancelButton.TabIndex = 3
        Me.savedListsCancelButton.Text = "X"
        Me.savedListsCancelButton.UseVisualStyleBackColor = True
        '
        'savedListTitleLabel
        '
        Me.savedListTitleLabel.AutoSize = True
        Me.savedListTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!)
        Me.savedListTitleLabel.Location = New System.Drawing.Point(239, 20)
        Me.savedListTitleLabel.Name = "savedListTitleLabel"
        Me.savedListTitleLabel.Size = New System.Drawing.Size(288, 31)
        Me.savedListTitleLabel.TabIndex = 0
        Me.savedListTitleLabel.Text = "Vos listes enregistrées"
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
        Me.validationPaymentPanel.Location = New System.Drawing.Point(203, 145)
        Me.validationPaymentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.validationPaymentPanel.Name = "validationPaymentPanel"
        Me.validationPaymentPanel.Size = New System.Drawing.Size(535, 253)
        Me.validationPaymentPanel.TabIndex = 9
        Me.validationPaymentPanel.Visible = False
        '
        'paymentTotalLabel
        '
        Me.paymentTotalLabel.AutoSize = True
        Me.paymentTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTotalLabel.ForeColor = System.Drawing.Color.White
        Me.paymentTotalLabel.Location = New System.Drawing.Point(148, 114)
        Me.paymentTotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.paymentTotalLabel.Name = "paymentTotalLabel"
        Me.paymentTotalLabel.Size = New System.Drawing.Size(56, 20)
        Me.paymentTotalLabel.TabIndex = 10
        Me.paymentTotalLabel.Text = "Total : "
        '
        'paymentNbProdLabel
        '
        Me.paymentNbProdLabel.AutoSize = True
        Me.paymentNbProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentNbProdLabel.ForeColor = System.Drawing.Color.White
        Me.paymentNbProdLabel.Location = New System.Drawing.Point(62, 63)
        Me.paymentNbProdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.paymentNbProdLabel.Name = "paymentNbProdLabel"
        Me.paymentNbProdLabel.Size = New System.Drawing.Size(292, 20)
        Me.paymentNbProdLabel.TabIndex = 9
        Me.paymentNbProdLabel.Text = "Vous avez 11 produits dans votre panier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(206, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "56 €"
        '
        'paymentTitleLabel
        '
        Me.paymentTitleLabel.AutoSize = True
        Me.paymentTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTitleLabel.ForeColor = System.Drawing.Color.White
        Me.paymentTitleLabel.Location = New System.Drawing.Point(60, 13)
        Me.paymentTitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.paymentTitleLabel.Name = "paymentTitleLabel"
        Me.paymentTitleLabel.Size = New System.Drawing.Size(312, 29)
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
        Me.paidButton.Location = New System.Drawing.Point(211, 158)
        Me.paidButton.Margin = New System.Windows.Forms.Padding(2)
        Me.paidButton.Name = "paidButton"
        Me.paidButton.Size = New System.Drawing.Size(163, 29)
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
        Me.cancelPaidButton.Location = New System.Drawing.Point(23, 158)
        Me.cancelPaidButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cancelPaidButton.Name = "cancelPaidButton"
        Me.cancelPaidButton.Size = New System.Drawing.Size(163, 29)
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
        Me.popUpPanel.Location = New System.Drawing.Point(226, 171)
        Me.popUpPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.popUpPanel.Name = "popUpPanel"
        Me.popUpPanel.RowCount = 3
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.popUpPanel.Size = New System.Drawing.Size(399, 0)
        Me.popUpPanel.TabIndex = 12
        '
        'contentPopUpLabel
        '
        Me.contentPopUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contentPopUpLabel.AutoSize = True
        Me.contentPopUpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contentPopUpLabel.ForeColor = System.Drawing.Color.White
        Me.contentPopUpLabel.Location = New System.Drawing.Point(52, -21)
        Me.contentPopUpLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.contentPopUpLabel.Name = "contentPopUpLabel"
        Me.contentPopUpLabel.Size = New System.Drawing.Size(295, 1)
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
        Me.titlePopUpLabel.Location = New System.Drawing.Point(17, 0)
        Me.titlePopUpLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.titlePopUpLabel.Name = "titlePopUpLabel"
        Me.titlePopUpLabel.Size = New System.Drawing.Size(365, 1)
        Me.titlePopUpLabel.TabIndex = 3
        Me.titlePopUpLabel.Text = "Suppression de tous les produits"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.cancelPopUpButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.validPopUpButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(2, -40)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(394, 38)
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
        Me.cancelPopUpButton.Location = New System.Drawing.Point(22, 2)
        Me.cancelPopUpButton.Margin = New System.Windows.Forms.Padding(22, 2, 2, 2)
        Me.cancelPopUpButton.Name = "cancelPopUpButton"
        Me.cancelPopUpButton.Size = New System.Drawing.Size(163, 29)
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
        Me.validPopUpButton.Location = New System.Drawing.Point(225, 2)
        Me.validPopUpButton.Margin = New System.Windows.Forms.Padding(38, 2, 2, 2)
        Me.validPopUpButton.Name = "validPopUpButton"
        Me.validPopUpButton.Size = New System.Drawing.Size(163, 29)
        Me.validPopUpButton.TabIndex = 10
        Me.validPopUpButton.Text = "Oui"
        Me.validPopUpButton.UseVisualStyleBackColor = False
        '
        'detailPopUpPanel
        '
        Me.detailPopUpPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.detailPopUpPanel.ColumnCount = 3
        Me.detailPopUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.detailPopUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.detailPopUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.detailPopUpPanel.Controls.Add(Me.detailPriceLabel, 0, 1)
        Me.detailPopUpPanel.Controls.Add(Me.detailImgPictureBox, 0, 0)
        Me.detailPopUpPanel.Controls.Add(Me.detailSpecLabel, 1, 1)
        Me.detailPopUpPanel.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.detailPopUpPanel.Controls.Add(Me.detailCloseButton, 2, 0)
        Me.detailPopUpPanel.Location = New System.Drawing.Point(172, 122)
        Me.detailPopUpPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.detailPopUpPanel.Name = "detailPopUpPanel"
        Me.detailPopUpPanel.RowCount = 2
        Me.detailPopUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.0!))
        Me.detailPopUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.detailPopUpPanel.Size = New System.Drawing.Size(450, 284)
        Me.detailPopUpPanel.TabIndex = 14
        Me.detailPopUpPanel.Visible = False
        '
        'detailPriceLabel
        '
        Me.detailPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.detailPriceLabel.AutoSize = True
        Me.detailPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailPriceLabel.ForeColor = System.Drawing.Color.White
        Me.detailPriceLabel.Location = New System.Drawing.Point(46, 199)
        Me.detailPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailPriceLabel.Name = "detailPriceLabel"
        Me.detailPriceLabel.Size = New System.Drawing.Size(121, 73)
        Me.detailPriceLabel.TabIndex = 0
        Me.detailPriceLabel.Text = "5 €"
        '
        'detailImgPictureBox
        '
        Me.detailImgPictureBox.Location = New System.Drawing.Point(2, 2)
        Me.detailImgPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.detailImgPictureBox.Name = "detailImgPictureBox"
        Me.detailImgPictureBox.Size = New System.Drawing.Size(208, 183)
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
        Me.detailSpecLabel.Location = New System.Drawing.Point(215, 187)
        Me.detailSpecLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailSpecLabel.Name = "detailSpecLabel"
        Me.detailSpecLabel.Size = New System.Drawing.Size(208, 97)
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(215, 2)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(208, 183)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'detailNameLabel
        '
        Me.detailNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.detailNameLabel.AutoSize = True
        Me.detailNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailNameLabel.ForeColor = System.Drawing.Color.White
        Me.detailNameLabel.Location = New System.Drawing.Point(17, 16)
        Me.detailNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailNameLabel.Name = "detailNameLabel"
        Me.detailNameLabel.Size = New System.Drawing.Size(77, 31)
        Me.detailNameLabel.TabIndex = 0
        Me.detailNameLabel.Text = "NOM"
        '
        'detailCategoryLabel
        '
        Me.detailCategoryLabel.AutoSize = True
        Me.detailCategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailCategoryLabel.ForeColor = System.Drawing.Color.White
        Me.detailCategoryLabel.Location = New System.Drawing.Point(2, 47)
        Me.detailCategoryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailCategoryLabel.Name = "detailCategoryLabel"
        Me.detailCategoryLabel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.detailCategoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailCategoryLabel.Size = New System.Drawing.Size(108, 20)
        Me.detailCategoryLabel.TabIndex = 1
        Me.detailCategoryLabel.Text = "Catégorie"
        Me.detailCategoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailBrandLabel
        '
        Me.detailBrandLabel.AutoSize = True
        Me.detailBrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailBrandLabel.ForeColor = System.Drawing.Color.White
        Me.detailBrandLabel.Location = New System.Drawing.Point(2, 67)
        Me.detailBrandLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailBrandLabel.Name = "detailBrandLabel"
        Me.detailBrandLabel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.detailBrandLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailBrandLabel.Size = New System.Drawing.Size(93, 20)
        Me.detailBrandLabel.TabIndex = 2
        Me.detailBrandLabel.Text = "Marque"
        Me.detailBrandLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailWeightLabel
        '
        Me.detailWeightLabel.AutoSize = True
        Me.detailWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailWeightLabel.ForeColor = System.Drawing.Color.White
        Me.detailWeightLabel.Location = New System.Drawing.Point(2, 87)
        Me.detailWeightLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailWeightLabel.Name = "detailWeightLabel"
        Me.detailWeightLabel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.detailWeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailWeightLabel.Size = New System.Drawing.Size(78, 20)
        Me.detailWeightLabel.TabIndex = 3
        Me.detailWeightLabel.Text = "Poids"
        Me.detailWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailPriceKgLabel
        '
        Me.detailPriceKgLabel.AutoSize = True
        Me.detailPriceKgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailPriceKgLabel.ForeColor = System.Drawing.Color.White
        Me.detailPriceKgLabel.Location = New System.Drawing.Point(2, 107)
        Me.detailPriceKgLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailPriceKgLabel.Name = "detailPriceKgLabel"
        Me.detailPriceKgLabel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.detailPriceKgLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailPriceKgLabel.Size = New System.Drawing.Size(93, 20)
        Me.detailPriceKgLabel.TabIndex = 4
        Me.detailPriceKgLabel.Text = "Prix / kg"
        Me.detailPriceKgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'detailOriginLabel
        '
        Me.detailOriginLabel.AutoSize = True
        Me.detailOriginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailOriginLabel.ForeColor = System.Drawing.Color.White
        Me.detailOriginLabel.Location = New System.Drawing.Point(2, 127)
        Me.detailOriginLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.detailOriginLabel.Name = "detailOriginLabel"
        Me.detailOriginLabel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.detailOriginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.detailOriginLabel.Size = New System.Drawing.Size(89, 20)
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
        Me.detailCloseButton.Location = New System.Drawing.Point(427, 2)
        Me.detailCloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.detailCloseButton.Name = "detailCloseButton"
        Me.detailCloseButton.Size = New System.Drawing.Size(20, 21)
        Me.detailCloseButton.TabIndex = 4
        Me.detailCloseButton.Text = "X"
        Me.detailCloseButton.UseVisualStyleBackColor = True
        '
        'detailCartPanel
        '
        Me.detailCartPanel.Controls.Add(Me.cartDetailCancelButton)
        Me.detailCartPanel.Controls.Add(Me.detailCartListView)
        Me.detailCartPanel.Controls.Add(Me.cartDetailTitleLabel)
        Me.detailCartPanel.Location = New System.Drawing.Point(41, 82)
        Me.detailCartPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.detailCartPanel.Name = "detailCartPanel"
        Me.detailCartPanel.Size = New System.Drawing.Size(771, 431)
        Me.detailCartPanel.TabIndex = 0
        Me.detailCartPanel.Visible = False
        '
        'cartDetailCancelButton
        '
        Me.cartDetailCancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartDetailCancelButton.FlatAppearance.BorderSize = 0
        Me.cartDetailCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartDetailCancelButton.Location = New System.Drawing.Point(732, 15)
        Me.cartDetailCancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cartDetailCancelButton.Name = "cartDetailCancelButton"
        Me.cartDetailCancelButton.Size = New System.Drawing.Size(34, 24)
        Me.cartDetailCancelButton.TabIndex = 2
        Me.cartDetailCancelButton.Text = "X"
        Me.cartDetailCancelButton.UseVisualStyleBackColor = True
        '
        'detailCartListView
        '
        Me.detailCartListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.detailCartListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.detailCartListView.Location = New System.Drawing.Point(108, 58)
        Me.detailCartListView.Margin = New System.Windows.Forms.Padding(2)
        Me.detailCartListView.Name = "detailCartListView"
        Me.detailCartListView.Size = New System.Drawing.Size(558, 343)
        Me.detailCartListView.TabIndex = 1
        Me.detailCartListView.UseCompatibleStateImageBehavior = False
        Me.detailCartListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nom"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prix"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Quantité"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Description"
        Me.ColumnHeader7.Width = 571
        '
        'cartDetailTitleLabel
        '
        Me.cartDetailTitleLabel.AutoSize = True
        Me.cartDetailTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartDetailTitleLabel.Location = New System.Drawing.Point(232, 15)
        Me.cartDetailTitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cartDetailTitleLabel.Name = "cartDetailTitleLabel"
        Me.cartDetailTitleLabel.Size = New System.Drawing.Size(271, 31)
        Me.cartDetailTitleLabel.TabIndex = 0
        Me.cartDetailTitleLabel.Text = "Détail de votre panier"
        '
        'articlePanel
        '
        Me.articlePanel.AutoScroll = True
        Me.articlePanel.Location = New System.Drawing.Point(41, 82)
        Me.articlePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.articlePanel.Name = "articlePanel"
        Me.articlePanel.Size = New System.Drawing.Size(748, 431)
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
        Me.menuPanel.Location = New System.Drawing.Point(109, 28)
        Me.menuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(548, 35)
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
        Me.menuBoissonsButton.Location = New System.Drawing.Point(381, 1)
        Me.menuBoissonsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.menuBoissonsButton.Name = "menuBoissonsButton"
        Me.menuBoissonsButton.Size = New System.Drawing.Size(87, 34)
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
        Me.menuMarcheButton.Margin = New System.Windows.Forms.Padding(2)
        Me.menuMarcheButton.Name = "menuMarcheButton"
        Me.menuMarcheButton.Size = New System.Drawing.Size(80, 34)
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
        Me.menuSurgelesButton.Location = New System.Drawing.Point(467, 1)
        Me.menuSurgelesButton.Margin = New System.Windows.Forms.Padding(2)
        Me.menuSurgelesButton.Name = "menuSurgelesButton"
        Me.menuSurgelesButton.Size = New System.Drawing.Size(81, 34)
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
        Me.menuFraisButton.Location = New System.Drawing.Point(80, 1)
        Me.menuFraisButton.Margin = New System.Windows.Forms.Padding(2)
        Me.menuFraisButton.Name = "menuFraisButton"
        Me.menuFraisButton.Size = New System.Drawing.Size(64, 34)
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
        Me.menuEpicerieSaleeButton.Location = New System.Drawing.Point(144, 1)
        Me.menuEpicerieSaleeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.menuEpicerieSaleeButton.Name = "menuEpicerieSaleeButton"
        Me.menuEpicerieSaleeButton.Size = New System.Drawing.Size(117, 34)
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
        Me.menuEpicerieSucreeButton.Location = New System.Drawing.Point(260, 1)
        Me.menuEpicerieSucreeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.menuEpicerieSucreeButton.Name = "menuEpicerieSucreeButton"
        Me.menuEpicerieSucreeButton.Size = New System.Drawing.Size(122, 34)
        Me.menuEpicerieSucreeButton.TabIndex = 6
        Me.menuEpicerieSucreeButton.Text = "Epicerie Sucrée"
        Me.menuEpicerieSucreeButton.UseVisualStyleBackColor = False
        '
        'affGridPanel
        '
        Me.affGridPanel.BackColor = System.Drawing.Color.DarkGray
        Me.affGridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.affGridPanel.Controls.Add(Me.ShapeContainer3)
        Me.affGridPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.affGridPanel.Location = New System.Drawing.Point(750, 28)
        Me.affGridPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.affGridPanel.Name = "affGridPanel"
        Me.affGridPanel.Size = New System.Drawing.Size(40, 36)
        Me.affGridPanel.TabIndex = 2
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(38, 34)
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
        Me.affListPanel.BackColor = System.Drawing.Color.LightGray
        Me.affListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.affListPanel.Controls.Add(Me.ShapeContainer2)
        Me.affListPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.affListPanel.Location = New System.Drawing.Point(712, 28)
        Me.affListPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.affListPanel.Name = "affListPanel"
        Me.affListPanel.Size = New System.Drawing.Size(40, 36)
        Me.affListPanel.TabIndex = 1
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(38, 34)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Enabled = False
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 6
        Me.LineShape5.X2 = 43
        Me.LineShape5.Y1 = 35
        Me.LineShape5.Y2 = 35
        '
        'LineShape4
        '
        Me.LineShape4.Enabled = False
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 6
        Me.LineShape4.X2 = 43
        Me.LineShape4.Y1 = 26
        Me.LineShape4.Y2 = 26
        '
        'LineShape3
        '
        Me.LineShape3.Enabled = False
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 6
        Me.LineShape3.X2 = 43
        Me.LineShape3.Y1 = 17
        Me.LineShape3.Y2 = 17
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 6
        Me.LineShape2.X2 = 43
        Me.LineShape2.Y1 = 8
        Me.LineShape2.Y2 = 8
        '
        'cartPanel
        '
        Me.cartPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartPanel.Controls.Add(Me.cartTotalPriceLabel)
        Me.cartPanel.Controls.Add(Me.cartMinPriceLabel)
        Me.cartPanel.Controls.Add(Me.cartValidationButton)
        Me.cartPanel.Controls.Add(Me.cartListView)
        Me.cartPanel.Controls.Add(Me.cartSaveButton)
        Me.cartPanel.Controls.Add(Me.cartSuppressionButton)
        Me.cartPanel.Controls.Add(Me.cartDetailButton)
        Me.cartPanel.Controls.Add(Me.cartListButton)
        Me.cartPanel.Location = New System.Drawing.Point(826, 70)
        Me.cartPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.cartPanel.Name = "cartPanel"
        Me.cartPanel.Size = New System.Drawing.Size(184, 518)
        Me.cartPanel.TabIndex = 4
        '
        'cartTotalPriceLabel
        '
        Me.cartTotalPriceLabel.AutoSize = True
        Me.cartTotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartTotalPriceLabel.ForeColor = System.Drawing.Color.DimGray
        Me.cartTotalPriceLabel.Location = New System.Drawing.Point(8, 353)
        Me.cartTotalPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cartTotalPriceLabel.Name = "cartTotalPriceLabel"
        Me.cartTotalPriceLabel.Size = New System.Drawing.Size(119, 26)
        Me.cartTotalPriceLabel.TabIndex = 6
        Me.cartTotalPriceLabel.Text = "Total : 56 €"
        '
        'cartMinPriceLabel
        '
        Me.cartMinPriceLabel.AutoSize = True
        Me.cartMinPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cartMinPriceLabel.Location = New System.Drawing.Point(134, 362)
        Me.cartMinPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cartMinPriceLabel.Name = "cartMinPriceLabel"
        Me.cartMinPriceLabel.Size = New System.Drawing.Size(50, 13)
        Me.cartMinPriceLabel.TabIndex = 8
        Me.cartMinPriceLabel.Text = "(min 20€)"
        '
        'cartValidationButton
        '
        Me.cartValidationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartValidationButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartValidationButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartValidationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartValidationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartValidationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartValidationButton.Location = New System.Drawing.Point(10, 381)
        Me.cartValidationButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cartValidationButton.Name = "cartValidationButton"
        Me.cartValidationButton.Size = New System.Drawing.Size(166, 24)
        Me.cartValidationButton.TabIndex = 2
        Me.cartValidationButton.Text = "Payer"
        Me.cartValidationButton.UseVisualStyleBackColor = True
        '
        'cartListView
        '
        Me.cartListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.cartListView.LargeImageList = Me.ImageList1
        Me.cartListView.Location = New System.Drawing.Point(0, -1)
        Me.cartListView.Name = "cartListView"
        Me.cartListView.Size = New System.Drawing.Size(185, 351)
        Me.cartListView.SmallImageList = Me.ImageList1
        Me.cartListView.TabIndex = 0
        Me.cartListView.UseCompatibleStateImageBehavior = False
        Me.cartListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Articles"
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Prix"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qte"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "carambar.jpg")
        Me.ImageList1.Images.SetKeyName(1, "cerise.jpg")
        Me.ImageList1.Images.SetKeyName(2, "coca.jpg")
        Me.ImageList1.Images.SetKeyName(3, "evian.jpg")
        Me.ImageList1.Images.SetKeyName(4, "lait.jpg")
        Me.ImageList1.Images.SetKeyName(5, "litchi.jpg")
        Me.ImageList1.Images.SetKeyName(6, "malabar.jpg")
        Me.ImageList1.Images.SetKeyName(7, "orange.jpg")
        Me.ImageList1.Images.SetKeyName(8, "poisson_pane.jpg")
        Me.ImageList1.Images.SetKeyName(9, "pomme - Copie.jpg")
        Me.ImageList1.Images.SetKeyName(10, "pomme.jpg")
        Me.ImageList1.Images.SetKeyName(11, "saucisson.jpg")
        Me.ImageList1.Images.SetKeyName(12, "saumon.jpg")
        Me.ImageList1.Images.SetKeyName(13, "steak.JPG")
        '
        'cartSaveButton
        '
        Me.cartSaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartSaveButton.Location = New System.Drawing.Point(11, 468)
        Me.cartSaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cartSaveButton.Name = "cartSaveButton"
        Me.cartSaveButton.Size = New System.Drawing.Size(166, 23)
        Me.cartSaveButton.TabIndex = 7
        Me.cartSaveButton.Text = "Sauvegarder"
        Me.cartSaveButton.UseVisualStyleBackColor = True
        '
        'cartSuppressionButton
        '
        Me.cartSuppressionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartSuppressionButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartSuppressionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartSuppressionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartSuppressionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartSuppressionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartSuppressionButton.Location = New System.Drawing.Point(10, 440)
        Me.cartSuppressionButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cartSuppressionButton.Name = "cartSuppressionButton"
        Me.cartSuppressionButton.Size = New System.Drawing.Size(166, 26)
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
        Me.cartDetailButton.Location = New System.Drawing.Point(10, 409)
        Me.cartDetailButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cartDetailButton.Name = "cartDetailButton"
        Me.cartDetailButton.Size = New System.Drawing.Size(166, 28)
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
        Me.cartListButton.Location = New System.Drawing.Point(10, 494)
        Me.cartListButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cartListButton.Name = "cartListButton"
        Me.cartListButton.Size = New System.Drawing.Size(166, 21)
        Me.cartListButton.TabIndex = 3
        Me.cartListButton.Text = "Mes listes"
        Me.cartListButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 586)
        Me.Controls.Add(Me.headerPanel)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.cartPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Home"
        Me.Text = "Form1"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.centerPanel.ResumeLayout(False)
        Me.centerPanel.PerformLayout()
        Me.savedListPanel.ResumeLayout(False)
        Me.savedListPanel.PerformLayout()
        Me.puPanel.ResumeLayout(False)
        Me.puPanel.PerformLayout()
        Me.validationPaymentPanel.ResumeLayout(False)
        Me.validationPaymentPanel.PerformLayout()
        Me.popUpPanel.ResumeLayout(False)
        Me.popUpPanel.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.detailPopUpPanel.ResumeLayout(False)
        Me.detailPopUpPanel.PerformLayout()
        CType(Me.detailImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.detailCartPanel.ResumeLayout(False)
        Me.detailCartPanel.PerformLayout()
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
    Friend WithEvents cartListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cartMinPriceLabel As System.Windows.Forms.Label
    Friend WithEvents detailCartPanel As System.Windows.Forms.Panel
    Friend WithEvents detailCartListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cartDetailTitleLabel As System.Windows.Forms.Label
    Friend WithEvents cartDetailCancelButton As System.Windows.Forms.Button
    Friend WithEvents savedListPanel As System.Windows.Forms.Panel
    Friend WithEvents loadSavedListButton As System.Windows.Forms.Button
    Friend WithEvents SavedListsTreeView As System.Windows.Forms.TreeView
    Friend WithEvents savedListsCancelButton As System.Windows.Forms.Button
    Friend WithEvents savedListTitleLabel As System.Windows.Forms.Label
    Friend WithEvents deleteSavedListButton As System.Windows.Forms.Button
    Friend WithEvents puPanel As System.Windows.Forms.Panel
    Friend WithEvents puContentLabel As System.Windows.Forms.Label
    Friend WithEvents puCancelButton As System.Windows.Forms.Button
    Friend WithEvents labelAccueil As System.Windows.Forms.Label
End Class
