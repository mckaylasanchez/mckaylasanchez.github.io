<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picStartup = New System.Windows.Forms.PictureBox()
        Me.btnSearchOrder = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnRestaurant = New System.Windows.Forms.Button()
        Me.grpManager = New System.Windows.Forms.GroupBox()
        Me.grpEmployee = New System.Windows.Forms.GroupBox()
        CType(Me.picStartup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpManager.SuspendLayout()
        Me.grpEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(989, 112)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 37)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(317, 110)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(528, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Sanchez Pizzeria Information System "
        '
        'picStartup
        '
        Me.picStartup.Image = CType(resources.GetObject("picStartup.Image"), System.Drawing.Image)
        Me.picStartup.Location = New System.Drawing.Point(29, 38)
        Me.picStartup.Name = "picStartup"
        Me.picStartup.Size = New System.Drawing.Size(250, 211)
        Me.picStartup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStartup.TabIndex = 17
        Me.picStartup.TabStop = False
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.Location = New System.Drawing.Point(488, 199)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.Size = New System.Drawing.Size(131, 41)
        Me.btnSearchOrder.TabIndex = 18
        Me.btnSearchOrder.Text = "Search Order"
        Me.btnSearchOrder.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(81, 83)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(131, 39)
        Me.btnCustomer.TabIndex = 19
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(78, 58)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(131, 39)
        Me.btnEmployee.TabIndex = 20
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnRestaurant
        '
        Me.btnRestaurant.Location = New System.Drawing.Point(78, 118)
        Me.btnRestaurant.Name = "btnRestaurant"
        Me.btnRestaurant.Size = New System.Drawing.Size(131, 39)
        Me.btnRestaurant.TabIndex = 21
        Me.btnRestaurant.Text = "Restaurant"
        Me.btnRestaurant.UseVisualStyleBackColor = True
        '
        'grpManager
        '
        Me.grpManager.BackColor = System.Drawing.SystemColors.Window
        Me.grpManager.Controls.Add(Me.btnEmployee)
        Me.grpManager.Controls.Add(Me.btnRestaurant)
        Me.grpManager.Location = New System.Drawing.Point(175, 321)
        Me.grpManager.Name = "grpManager"
        Me.grpManager.Size = New System.Drawing.Size(302, 195)
        Me.grpManager.TabIndex = 22
        Me.grpManager.TabStop = False
        Me.grpManager.Text = "Manager"
        '
        'grpEmployee
        '
        Me.grpEmployee.BackColor = System.Drawing.SystemColors.Window
        Me.grpEmployee.Controls.Add(Me.btnCustomer)
        Me.grpEmployee.Location = New System.Drawing.Point(632, 321)
        Me.grpEmployee.Name = "grpEmployee"
        Me.grpEmployee.Size = New System.Drawing.Size(302, 195)
        Me.grpEmployee.TabIndex = 23
        Me.grpEmployee.TabStop = False
        Me.grpEmployee.Text = "Employees"
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1173, 740)
        Me.Controls.Add(Me.grpEmployee)
        Me.Controls.Add(Me.grpManager)
        Me.Controls.Add(Me.btnSearchOrder)
        Me.Controls.Add(Me.picStartup)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Startup"
        Me.Text = "Startup"
        CType(Me.picStartup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpManager.ResumeLayout(False)
        Me.grpEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picStartup As PictureBox
    Friend WithEvents btnSearchOrder As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnRestaurant As Button
    Friend WithEvents grpManager As GroupBox
    Friend WithEvents grpEmployee As GroupBox
End Class
