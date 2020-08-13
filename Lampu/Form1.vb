Public Class FormLampu

    Sub HidupkanLampu()
        'Menampilkan citra "Lampu Hidup"
        gbrLampuHidup.Visible = True

        'Menyembunyikan citra "Lampu Mati"
        gbrLampuMati.Visible = False

        'Mengubah teks label
        labelStatusLampu.Text = "Hidup"
    End Sub

    Sub MatikanLampu()
        'Menampilkan citra "Lampu Mati"
        gbrLampuMati.Visible = True

        'Menyembunyikan citra "Lampu Hidup"
        gbrLampuHidup.Visible = False

        'Mengubah teks label
        labelStatusLampu.Text = "Mati"
    End Sub

    Private Sub tombolTukarLampu_Click(sender As Object, e As EventArgs) Handles tombolTukarLampu.Click
        'Membalik status lampu
        If gbrLampuHidup.Visible = True Then
            MatikanLampu()
        Else
            HidupkanLampu()
        End If
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class
