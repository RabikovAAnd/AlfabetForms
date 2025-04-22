Public Class Form1
    Dim draggedItem As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Заполнение исходного списка случайными словами
        Dim words As String() = {"Апельсин", "Банан", "Груша", "Виноград", "Яблоко"}
        Dim rnd As New Random()
        For Each word In words.OrderBy(Function(w) rnd.Next())
            ListBoxSource.Items.Add(word)
        Next
    End Sub

    Private Sub ListBoxSource_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBoxSource.MouseDown
        If ListBoxSource.SelectedItem IsNot Nothing Then
            draggedItem = ListBoxSource.SelectedItem.ToString()
            DoDragDrop(draggedItem, DragDropEffects.Move)
        End If
    End Sub

    Private Sub ListBoxTarget_DragEnter(sender As Object, e As DragEventArgs) Handles ListBoxTarget.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub ListBoxTarget_DragDrop(sender As Object, e As DragEventArgs) Handles ListBoxTarget.DragDrop
        Dim item As String = e.Data.GetData(DataFormats.Text).ToString()
        If Not ListBoxTarget.Items.Contains(item) Then
            ListBoxTarget.Items.Add(item)
            ListBoxSource.Items.Remove(item)
        End If
    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Dim sorted = ListBoxTarget.Items.Cast(Of String)().OrderBy(Function(w) w).ToArray()
        Dim original = ListBoxTarget.Items.Cast(Of String)().ToArray()

        If sorted.SequenceEqual(original) Then
            MessageBox.Show("Правильно! Слова отсортированы по алфавиту.")
        Else
            MessageBox.Show("Неправильно! Попробуйте ещё раз.")
        End If
    End Sub
End Class
