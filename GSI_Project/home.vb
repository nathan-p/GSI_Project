Public Class home

    Enum State
        INIT
        CART
        VALID_CART
    End Enum

    '********************************************************************************
    '*************************** ATTRIBUTES *****************************************
    '********************************************************************************
    Dim myState As State
    Dim nbProduct As Integer
    'Dim ArticleList As New List(Of Article)()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'INITIALISATION DES ATTRIBUTS
        myState = State.INIT
        updateUI()

        'INITIALISATION DE LA LISTE
        ListView1.View = View.Details
        ListView1.Columns.Add("Nom")
        ListView1.Columns.Add("Prix")
        ListView1.Items.Add(New ListViewItem("Produit numéro 1"))
        ListView1.Items.Add(New ListViewItem("Produit numéro 2 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 3 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 4 "))
        ListView1.Items.Add(New ListViewItem("Produit numéro 5 "))
    End Sub


    Private Sub updateUI()
        Select Case myState
            Case State.INIT
                nbProduct = 0
                clearCart()
            Case State.CART

            Case State.VALID_CART

        End Select
    End Sub


    Private Sub clearCart()
        ListView1.Clear()

    End Sub

    Private Sub realisePayment()
        Select Case myState
            Case State.INIT
                nbProduct = 0
                clearCart()
            Case State.CART

            Case State.VALID_CART

        End Select
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





    '********************************************************************************
    '*************************** LISTENER ON CART BUTTON ****************************
    '********************************************************************************
    Private Sub cartValidationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartValidationButton.Click
        '''''''a enlever après
        myState = State.VALID_CART
        ''''''''''
        Select Case myState
            Case State.INIT
                
            Case State.CART

            Case State.VALID_CART
                validationPanel.Visible = True
        End Select
    End Sub

    Private Sub cartDetailButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartDetailButton.Click

    End Sub

    Private Sub cartSuppressionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartSuppressionButton.Click
        clearCart()
    End Sub

    Private Sub cartSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartSaveButton.Click

    End Sub

    Private Sub myListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myListButton.Click

    End Sub


    Private Sub paidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paidButton.Click
        Select Case myState
            Case State.INIT

            Case State.CART

            Case State.VALID_CART
                validationPanel.Visible = False
                realisePayment()
                myState = State.INIT
                updateUI()
        End Select
    End Sub

    Private Sub cancelPaidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelPaidButton.Click
        Select Case myState
            Case State.INIT

            Case State.CART

            Case State.VALID_CART
                validationPanel.Visible = False
        End Select
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
