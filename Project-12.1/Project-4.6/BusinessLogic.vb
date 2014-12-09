Public Class BusinessLogic

    Private NumCompleted As Integer
    Private PricePaid As Decimal
    Private Shared EmpPay As Decimal

    ' Define variables for summary totals
    Private Shared TotalComplete As Integer
    Private Shared TotalPay As Decimal
    Private Shared TotalWorkers As Integer
    Private Shared Avg As Decimal

    Private InvData As String = "Invalid Data. Please try again."

    ' Parameterized Constructor
    Sub New(ByVal NumIn As Integer)

        Number = NumIn
        CalcPrice()
        CalcPay()
        AddToTotals()
        Average()

    End Sub

    Property Number() As Integer
        Get
            Return NumCompleted
        End Get

        Set(value As Integer)
            If value >= 0 Then
                NumCompleted = value
            End If
        End Set
    End Property

    Shared ReadOnly Property Pay() As Decimal
        Get
            Return EmpPay
        End Get
    End Property

    Shared Property CompleteSummary() As Integer
        Get
            Return TotalComplete
        End Get
        Set(value As Integer)
            If value >= 0 Then
                TotalComplete = value
            End If
        End Set
    End Property

    Shared ReadOnly Property PaySummary() As Decimal
        Get
            Return TotalPay
        End Get
    End Property

    Shared Property WorkersSummary() As Integer
        Get
            Return TotalWorkers
        End Get
        Set(value As Integer)
            If value >= 0 Then
                TotalWorkers = value
            End If
        End Set
    End Property

    Shared ReadOnly Property AvgSummary() As Decimal
        Get
            Return Avg
        End Get
    End Property



    Protected Sub CalcPrice()

        Select Case NumCompleted
            Case Is >= 600
                PricePaid = 0.65
            Case 400 To 599
                PricePaid = 0.6
            Case 200 To 399
                PricePaid = 0.55
            Case 1 To 199
                PricePaid = 0.5
            Case Else
                MessageBox.Show(InvData, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MainForm.PiecesTextBox.Focus()
        End Select

    End Sub

    Protected Sub CalcPay()

        EmpPay = NumCompleted * PricePaid

    End Sub

    Protected Sub AddToTotals()

        TotalPay += EmpPay
        TotalComplete += NumCompleted
        TotalWorkers += 1

    End Sub

    Protected Sub Average()

        ' Calculate the average payout
        Avg = TotalPay / TotalWorkers

    End Sub
End Class
