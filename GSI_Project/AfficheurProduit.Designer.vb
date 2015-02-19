<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AfficheurProduit
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.labelMarque = New System.Windows.Forms.Label()
        Me.labelRetirer = New System.Windows.Forms.Label()
        Me.labelAjouter = New System.Windows.Forms.Label()
        Me.labelPoids = New System.Windows.Forms.Label()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.labelPrix = New System.Windows.Forms.Label()
        Me.labelPlusInfo = New System.Windows.Forms.LinkLabel()
        Me.labelNomArticle = New System.Windows.Forms.Label()
        Me.boutonRetirer = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.boutonAjouter = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.TextBoxQuantite = New System.Windows.Forms.TextBox()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelMarque
        '
        Me.labelMarque.AutoSize = True
        Me.labelMarque.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMarque.Location = New System.Drawing.Point(137, 53)
        Me.labelMarque.Name = "labelMarque"
        Me.labelMarque.Size = New System.Drawing.Size(29, 28)
        Me.labelMarque.TabIndex = 20
        Me.labelMarque.Text = "m"
        '
        'labelRetirer
        '
        Me.labelRetirer.AutoSize = True
        Me.labelRetirer.BackColor = System.Drawing.Color.LightCoral
        Me.labelRetirer.Enabled = False
        Me.labelRetirer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.labelRetirer.Location = New System.Drawing.Point(144, 190)
        Me.labelRetirer.Name = "labelRetirer"
        Me.labelRetirer.Size = New System.Drawing.Size(20, 28)
        Me.labelRetirer.TabIndex = 22
        Me.labelRetirer.Text = "-"
        '
        'labelAjouter
        '
        Me.labelAjouter.AutoSize = True
        Me.labelAjouter.BackColor = System.Drawing.Color.LightGreen
        Me.labelAjouter.Enabled = False
        Me.labelAjouter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAjouter.Location = New System.Drawing.Point(220, 185)
        Me.labelAjouter.Name = "labelAjouter"
        Me.labelAjouter.Size = New System.Drawing.Size(35, 37)
        Me.labelAjouter.TabIndex = 21
        Me.labelAjouter.Text = "+"
        '
        'labelPoids
        '
        Me.labelPoids.AutoSize = True
        Me.labelPoids.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPoids.Location = New System.Drawing.Point(139, 122)
        Me.labelPoids.Name = "labelPoids"
        Me.labelPoids.Size = New System.Drawing.Size(17, 19)
        Me.labelPoids.TabIndex = 18
        Me.labelPoids.Text = "p"
        '
        'labelDescription
        '
        Me.labelDescription.AutoSize = True
        Me.labelDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescription.Location = New System.Drawing.Point(139, 90)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(17, 19)
        Me.labelDescription.TabIndex = 17
        Me.labelDescription.Text = "d"
        '
        'imageBox
        '
        Me.imageBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imageBox.Image = Global.WindowsApplication1.My.Resources.Resources.pomme___Copie
        Me.imageBox.Location = New System.Drawing.Point(21, 53)
        Me.imageBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(101, 88)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 16
        Me.imageBox.TabStop = False
        '
        'labelPrix
        '
        Me.labelPrix.AutoSize = True
        Me.labelPrix.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrix.Location = New System.Drawing.Point(43, 192)
        Me.labelPrix.Name = "labelPrix"
        Me.labelPrix.Size = New System.Drawing.Size(23, 28)
        Me.labelPrix.TabIndex = 15
        Me.labelPrix.Text = "€"
        '
        'labelPlusInfo
        '
        Me.labelPlusInfo.AutoSize = True
        Me.labelPlusInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelPlusInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlusInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.labelPlusInfo.Location = New System.Drawing.Point(147, 153)
        Me.labelPlusInfo.Name = "labelPlusInfo"
        Me.labelPlusInfo.Size = New System.Drawing.Size(65, 19)
        Me.labelPlusInfo.TabIndex = 14
        Me.labelPlusInfo.TabStop = True
        Me.labelPlusInfo.Text = "+ D'infos"
        '
        'labelNomArticle
        '
        Me.labelNomArticle.AutoSize = True
        Me.labelNomArticle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNomArticle.Location = New System.Drawing.Point(16, 10)
        Me.labelNomArticle.Name = "labelNomArticle"
        Me.labelNomArticle.Size = New System.Drawing.Size(24, 28)
        Me.labelNomArticle.TabIndex = 13
        Me.labelNomArticle.Text = "n"
        '
        'boutonRetirer
        '
        Me.boutonRetirer.FillColor = System.Drawing.Color.LightCoral
        Me.boutonRetirer.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.boutonRetirer.Location = New System.Drawing.Point(137, 187)
        Me.boutonRetirer.Name = "boutonRetirer"
        Me.boutonRetirer.Size = New System.Drawing.Size(32, 33)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.boutonAjouter, Me.boutonRetirer})
        Me.ShapeContainer1.Size = New System.Drawing.Size(269, 239)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'boutonAjouter
        '
        Me.boutonAjouter.FillColor = System.Drawing.Color.LightGreen
        Me.boutonAjouter.FillGradientColor = System.Drawing.Color.ForestGreen
        Me.boutonAjouter.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.boutonAjouter.Location = New System.Drawing.Point(211, 179)
        Me.boutonAjouter.Name = "boutonAjouter"
        Me.boutonAjouter.Size = New System.Drawing.Size(53, 51)
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Location = New System.Drawing.Point(36, 154)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(15, 17)
        Me.LabelStock.TabIndex = 24
        Me.LabelStock.Text = "s"
        '
        'TextBoxQuantite
        '
        Me.TextBoxQuantite.Location = New System.Drawing.Point(112, 154)
        Me.TextBoxQuantite.Name = "TextBoxQuantite"
        Me.TextBoxQuantite.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxQuantite.TabIndex = 25
        '
        'AfficheurProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TextBoxQuantite)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.labelMarque)
        Me.Controls.Add(Me.labelRetirer)
        Me.Controls.Add(Me.labelAjouter)
        Me.Controls.Add(Me.labelPoids)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.labelPrix)
        Me.Controls.Add(Me.labelPlusInfo)
        Me.Controls.Add(Me.labelNomArticle)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AfficheurProduit"
        Me.Size = New System.Drawing.Size(269, 239)
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelMarque As System.Windows.Forms.Label
    Friend WithEvents labelRetirer As System.Windows.Forms.Label
    Friend WithEvents labelAjouter As System.Windows.Forms.Label
    Friend WithEvents labelPoids As System.Windows.Forms.Label
    Friend WithEvents labelDescription As System.Windows.Forms.Label
    Friend WithEvents imageBox As System.Windows.Forms.PictureBox
    Friend WithEvents labelPrix As System.Windows.Forms.Label
    Friend WithEvents labelPlusInfo As System.Windows.Forms.LinkLabel
    Friend WithEvents labelNomArticle As System.Windows.Forms.Label
    Friend WithEvents boutonRetirer As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents boutonAjouter As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LabelStock As System.Windows.Forms.Label
    Friend WithEvents TextBoxQuantite As System.Windows.Forms.TextBox

End Class
