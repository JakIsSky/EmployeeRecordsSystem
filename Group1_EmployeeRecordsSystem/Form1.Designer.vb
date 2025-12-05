<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPosition = New System.Windows.Forms.TextBox()
        Me.TextBoxSalary = New System.Windows.Forms.TextBox()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.DataGridViewRecord = New System.Windows.Forms.DataGridView()
        Me.TextBoxHiddenId = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.Location = New System.Drawing.Point(12, 28)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(302, 48)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCreate.Location = New System.Drawing.Point(31, 222)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(108, 35)
        Me.ButtonCreate.TabIndex = 3
        Me.ButtonCreate.Text = "CREATE"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(145, 263)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 35)
        Me.ButtonDelete.TabIndex = 5
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(145, 222)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(108, 35)
        Me.ButtonUpdate.TabIndex = 6
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRead.Location = New System.Drawing.Point(31, 263)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(108, 35)
        Me.ButtonRead.TabIndex = 7
        Me.ButtonRead.Text = "READ"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Salary:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Department:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(123, 103)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxName.TabIndex = 12
        '
        'TextBoxPosition
        '
        Me.TextBoxPosition.Location = New System.Drawing.Point(123, 126)
        Me.TextBoxPosition.Name = "TextBoxPosition"
        Me.TextBoxPosition.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxPosition.TabIndex = 13
        '
        'TextBoxSalary
        '
        Me.TextBoxSalary.Location = New System.Drawing.Point(123, 150)
        Me.TextBoxSalary.Name = "TextBoxSalary"
        Me.TextBoxSalary.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxSalary.TabIndex = 14
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(123, 174)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(232, 20)
        Me.TextBoxDepartment.TabIndex = 15
        '
        'DataGridViewRecord
        '
        Me.DataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRecord.Location = New System.Drawing.Point(31, 305)
        Me.DataGridViewRecord.Name = "DataGridViewRecord"
        Me.DataGridViewRecord.Size = New System.Drawing.Size(503, 150)
        Me.DataGridViewRecord.TabIndex = 16
        '
        'TextBoxHiddenId
        '
        Me.TextBoxHiddenId.Location = New System.Drawing.Point(400, 272)
        Me.TextBoxHiddenId.Name = "TextBoxHiddenId"
        Me.TextBoxHiddenId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHiddenId.TabIndex = 17
        Me.TextBoxHiddenId.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 486)
        Me.Controls.Add(Me.TextBoxHiddenId)
        Me.Controls.Add(Me.DataGridViewRecord)
        Me.Controls.Add(Me.TextBoxDepartment)
        Me.Controls.Add(Me.TextBoxSalary)
        Me.Controls.Add(Me.TextBoxPosition)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPosition As TextBox
    Friend WithEvents TextBoxSalary As TextBox
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents DataGridViewRecord As DataGridView
    Friend WithEvents TextBoxHiddenId As TextBox
End Class
