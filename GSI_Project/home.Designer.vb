﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.cartLabel = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.separateurShapeContainer = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.validationPaymentPanel = New System.Windows.Forms.Panel()
        Me.paymentTotalLabel = New System.Windows.Forms.Label()
        Me.paymentNbProdLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentTitleLabel = New System.Windows.Forms.Label()
        Me.paidButton = New System.Windows.Forms.Button()
        Me.cancelPaidButton = New System.Windows.Forms.Button()
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
        Me.cartPanel = New System.Windows.Forms.Panel()
        Me.cartSaveButton = New System.Windows.Forms.Button()
        Me.cartTotalPriceLabel = New System.Windows.Forms.Label()
        Me.cartSuppressionButton = New System.Windows.Forms.Button()
        Me.cartDetailButton = New System.Windows.Forms.Button()
        Me.cartListButton = New System.Windows.Forms.Button()
        Me.cartValidationButton = New System.Windows.Forms.Button()
        Me.cartListView = New System.Windows.Forms.ListView()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.titlePopUpLabel = New System.Windows.Forms.Label()
        Me.contentPopUpLabel = New System.Windows.Forms.Label()
        Me.cancelPopUpButton = New System.Windows.Forms.Button()
        Me.popUpPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.validPopUpButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.headerPanel.SuspendLayout()
        Me.centerPanel.SuspendLayout()
        Me.validationPaymentPanel.SuspendLayout()
        Me.affGridPanel.SuspendLayout()
        Me.affListPanel.SuspendLayout()
        Me.cartPanel.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuPanel.SuspendLayout()
        Me.popUpPanel.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
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
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1348, 86)
        Me.headerPanel.TabIndex = 2
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
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(860, 23)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(96, 40)
        Me.searchButton.TabIndex = 1
        Me.searchButton.Text = "Rechercher"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.searchTextBox.Font = New System.Drawing.Font("Roboto Lt", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.Location = New System.Drawing.Point(271, 23)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(594, 40)
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
        Me.centerPanel.Controls.Add(Me.popUpPanel)
        Me.centerPanel.Controls.Add(Me.menuPanel)
        Me.centerPanel.Controls.Add(Me.validationPaymentPanel)
        Me.centerPanel.Controls.Add(Me.affGridPanel)
        Me.centerPanel.Controls.Add(Me.affListPanel)
        Me.centerPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.centerPanel.Location = New System.Drawing.Point(0, 85)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(1103, 642)
        Me.centerPanel.TabIndex = 3
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
        Me.validationPaymentPanel.Location = New System.Drawing.Point(271, 179)
        Me.validationPaymentPanel.Name = "validationPaymentPanel"
        Me.validationPaymentPanel.Size = New System.Drawing.Size(535, 0)
        Me.validationPaymentPanel.TabIndex = 9
        Me.validationPaymentPanel.Visible = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(274, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 39)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "56 €"
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
        'menuSurgelesButton
        '
        Me.menuSurgelesButton.BackColor = System.Drawing.Color.LightGray
        Me.menuSurgelesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menuSurgelesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.menuSurgelesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.menuSurgelesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.menuSurgelesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuSurgelesButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuSurgelesButton.Location = New System.Drawing.Point(623, 1)
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
        Me.menuBoissonsButton.Location = New System.Drawing.Point(508, 1)
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
        Me.menuEpicerieSucreeButton.Location = New System.Drawing.Point(347, 1)
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
        Me.menuEpicerieSaleeButton.Location = New System.Drawing.Point(192, 1)
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
        Me.menuFraisButton.Location = New System.Drawing.Point(107, 1)
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
        Me.menuMarcheButton.Location = New System.Drawing.Point(1, 1)
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
        Me.cartPanel.Location = New System.Drawing.Point(1102, 86)
        Me.cartPanel.Name = "cartPanel"
        Me.cartPanel.Size = New System.Drawing.Size(246, 638)
        Me.cartPanel.TabIndex = 4
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
        'cartTotalPriceLabel
        '
        Me.cartTotalPriceLabel.AutoSize = True
        Me.cartTotalPriceLabel.Font = New System.Drawing.Font("Roboto", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartTotalPriceLabel.ForeColor = System.Drawing.Color.DimGray
        Me.cartTotalPriceLabel.Location = New System.Drawing.Point(41, 435)
        Me.cartTotalPriceLabel.Name = "cartTotalPriceLabel"
        Me.cartTotalPriceLabel.Size = New System.Drawing.Size(154, 34)
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
        'cartListButton
        '
        Me.cartListButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cartListButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cartListButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartListButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cartListButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartListButton.Location = New System.Drawing.Point(14, 608)
        Me.cartListButton.Name = "cartListButton"
        Me.cartListButton.Size = New System.Drawing.Size(222, 26)
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
        Me.cartValidationButton.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartValidationButton.Location = New System.Drawing.Point(14, 469)
        Me.cartValidationButton.Name = "cartValidationButton"
        Me.cartValidationButton.Size = New System.Drawing.Size(222, 30)
        Me.cartValidationButton.TabIndex = 2
        Me.cartValidationButton.Text = "Valider"
        Me.cartValidationButton.UseVisualStyleBackColor = True
        '
        'cartListView
        '
        Me.cartListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cartListView.Location = New System.Drawing.Point(0, -1)
        Me.cartListView.Name = "cartListView"
        Me.cartListView.Size = New System.Drawing.Size(246, 434)
        Me.cartListView.TabIndex = 1
        Me.cartListView.UseCompatibleStateImageBehavior = False
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.Location = New System.Drawing.Point(12, 6)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(221, 90)
        Me.logoPictureBox.TabIndex = 4
        Me.logoPictureBox.TabStop = False
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
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(730, 43)
        Me.menuPanel.TabIndex = 10
        '
        'titlePopUpLabel
        '
        Me.titlePopUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.titlePopUpLabel.AutoSize = True
        Me.titlePopUpLabel.BackColor = System.Drawing.Color.Transparent
        Me.titlePopUpLabel.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlePopUpLabel.ForeColor = System.Drawing.Color.White
        Me.titlePopUpLabel.Location = New System.Drawing.Point(35, 15)
        Me.titlePopUpLabel.Name = "titlePopUpLabel"
        Me.titlePopUpLabel.Size = New System.Drawing.Size(461, 37)
        Me.titlePopUpLabel.TabIndex = 3
        Me.titlePopUpLabel.Text = "Suppression de tous les produits"
        '
        'contentPopUpLabel
        '
        Me.contentPopUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contentPopUpLabel.AutoSize = True
        Me.contentPopUpLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contentPopUpLabel.ForeColor = System.Drawing.Color.White
        Me.contentPopUpLabel.Location = New System.Drawing.Point(80, 88)
        Me.contentPopUpLabel.Name = "contentPopUpLabel"
        Me.contentPopUpLabel.Size = New System.Drawing.Size(372, 24)
        Me.contentPopUpLabel.TabIndex = 10
        Me.contentPopUpLabel.Text = "Voulez-vous supprimer tous les produit ?"
        '
        'cancelPopUpButton
        '
        Me.cancelPopUpButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cancelPopUpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelPopUpButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancelPopUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelPopUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cancelPopUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelPopUpButton.Font = New System.Drawing.Font("Roboto Lt", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelPopUpButton.Location = New System.Drawing.Point(30, 3)
        Me.cancelPopUpButton.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.cancelPopUpButton.Name = "cancelPopUpButton"
        Me.cancelPopUpButton.Size = New System.Drawing.Size(217, 36)
        Me.cancelPopUpButton.TabIndex = 10
        Me.cancelPopUpButton.Text = "Annuler"
        Me.cancelPopUpButton.UseVisualStyleBackColor = False
        '
        'popUpPanel
        '
        Me.popUpPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.popUpPanel.ColumnCount = 1
        Me.popUpPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.Controls.Add(Me.contentPopUpLabel, 0, 1)
        Me.popUpPanel.Controls.Add(Me.titlePopUpLabel, 0, 0)
        Me.popUpPanel.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.popUpPanel.Location = New System.Drawing.Point(302, 211)
        Me.popUpPanel.Name = "popUpPanel"
        Me.popUpPanel.RowCount = 3
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.popUpPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.popUpPanel.Size = New System.Drawing.Size(532, 188)
        Me.popUpPanel.TabIndex = 12
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
        Me.validPopUpButton.Font = New System.Drawing.Font("Roboto Lt", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validPopUpButton.Location = New System.Drawing.Point(300, 3)
        Me.validPopUpButton.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.validPopUpButton.Name = "validPopUpButton"
        Me.validPopUpButton.Size = New System.Drawing.Size(217, 36)
        Me.validPopUpButton.TabIndex = 10
        Me.validPopUpButton.Text = "Oui"
        Me.validPopUpButton.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.cancelPopUpButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.validPopUpButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 137)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(526, 48)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.headerPanel)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.cartPanel)
        Me.Name = "home"
        Me.Text = "Form1"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        Me.centerPanel.ResumeLayout(False)
        Me.validationPaymentPanel.ResumeLayout(False)
        Me.validationPaymentPanel.PerformLayout()
        Me.affGridPanel.ResumeLayout(False)
        Me.affListPanel.ResumeLayout(False)
        Me.cartPanel.ResumeLayout(False)
        Me.cartPanel.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuPanel.ResumeLayout(False)
        Me.popUpPanel.ResumeLayout(False)
        Me.popUpPanel.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
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

End Class
