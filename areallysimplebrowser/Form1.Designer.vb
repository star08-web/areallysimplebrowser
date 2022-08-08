<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.url = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.searchstring = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webView
        '
        Me.webView.AllowExternalDrop = True
        Me.webView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webView.CreationProperties = Nothing
        Me.webView.DefaultBackgroundColor = System.Drawing.Color.White
        Me.webView.Location = New System.Drawing.Point(0, 49)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(1349, 528)
        Me.webView.TabIndex = 0
        Me.webView.ZoomFactor = 1.0R
        '
        'url
        '
        Me.url.Location = New System.Drawing.Point(34, 14)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(535, 27)
        Me.url.TabIndex = 1
        Me.url.Text = "google.it"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "url"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(586, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1228, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "🏠"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1284, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 27)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "?"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'searchstring
        '
        Me.searchstring.Location = New System.Drawing.Point(814, 10)
        Me.searchstring.Name = "searchstring"
        Me.searchstring.Size = New System.Drawing.Size(351, 27)
        Me.searchstring.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(1172, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "🔎"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(755, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 577)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.searchstring)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.url)
        Me.Controls.Add(Me.webView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Browser Window"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents url As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents searchstring As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
End Class
