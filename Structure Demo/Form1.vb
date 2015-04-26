Public Class Form1
    Private objCustomers As New CustomerCollection

    Public Sub DisplayCustomer(customer As Customer)
        'Display the customer details on the form
        txtName.Text = customer.Name
        txtFirstName.Text = customer.FirstName
        txtLastName.Text = customer.LastName
        txtEmail.Text = customer.Email
    End Sub

    Private Sub btnListCustomer_Click(sender As Object, e As EventArgs) Handles btnListCustomer.Click
        'Create some customers
        CreateCustomer("Darrel", "Hilton", _
        "dhilton@somecompany.com")
        CreateCustomer("Frank", "Peoples", _
        "fpeoples@somecompany.com")
        CreateCustomer("Bill", "Scott", _
        "bscott@somecompany.com")
    End Sub

    Public Sub CreateCustomer(firstName As String,
lastName As String, email As String)
        'Declare a Customer object
        Dim objNewCustomer As Customer
        'Create the new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email
        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)
        'Add the new customer to the ListBox control
        lstCustomers.Items.Add(objNewCustomer)
    End Sub

    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If lstCustomers.SelectedIndex <> -1 Then
                Return objCustomers(lstCustomers.SelectedIndex)
            End If
        End Get
    End Property

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If lstCustomers.SelectedIndex = -1 Then
            MessageBox.Show("You must select a customer to delete", "Structure Demo")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete " & _
                        SelectedCustomer.Name & "?", "Structure Demo", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
                    DialogResult.Yes Then

            Dim objCustomerToDelete As Customer = SelectedCustomer

            objCustomers.Remove(objCustomerToDelete)

            lstCustomers.Items.Remove(objCustomerToDelete)
        End If
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        DisplayCustomer(SelectedCustomer)
    End Sub
End Class
