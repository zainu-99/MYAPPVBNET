Imports System.IO
Imports Newtonsoft.Json.Linq
Public Class FormSplashScreen
    Dim AppPath As String = Application.StartupPath()
    Private Sub FormSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDesignColorReset()
        GetDesignColor()
        SetDesignColor()
        SetConfig()
    End Sub

    Sub SetConfig()
        StrConnectionDB = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" & AppPath & "\MYAPP.mdf"";Integrated Security=True;Connect Timeout=30"
        'StrConnectionDB = "Data Source=SQLEXPRESS;Initial Catalog=MYAPP;User ID=sa;Password=123"
        UploadLocation = "\\10.80.1.3\d_sharing\Jay\file_attach\"

        ServerTcpAddressForChat = "localhost"
        ServerTcpPortForChat = 9797
    End Sub


    Sub setDesignColorReset()
        DesignColorReset.ButtonAdd = System.Drawing.Color.Teal
        DesignColorReset.ButtonEdit = System.Drawing.Color.DarkOrange
        DesignColorReset.ButtonSave = System.Drawing.Color.LightSeaGreen
        DesignColorReset.ButtonDelete = System.Drawing.Color.DodgerBlue
        DesignColorReset.ButtonRefesh = System.Drawing.Color.Crimson
        DesignColorReset.ButtonText = System.Drawing.Color.White

        'Main Form
        DesignColorReset.PanelHeader = FormMain.PanelHeader.BackColor
        DesignColorReset.PanelTitle = FormMain.PanelTitle.BackColor
        DesignColorReset.PanelProfile = FormMain.PanelProfile.BackColor

        'DataGridView
        DesignColorReset.dgv_AlternatingRowsDefaultCellStyle = Color.FromArgb(247, 255, 253)

        'MenuStrip
        DesignColorReset.ItemHover = ColorLibrary.PrimaryColor
        DesignColorReset.ItemOdd = Color.FromArgb(51, 133, 166)
        DesignColorReset.ItemEven = Color.FromArgb(51, 133, 159)
        DesignColorReset.ItemForeColor = Color.White
        DesignColorReset.PanelMenuBackground = FormMain.PanelMenu.BackColor

        'Text Color
        DesignColorReset.TextForeColor = FormMain.LabelRefresh.ForeColor
    End Sub
    Sub GetDesignColor()
        Dim varType As Type = GetType(DesignColor)
        For Each fi As System.Reflection.FieldInfo In varType.GetFields()
            If Not CheckPropIsExist(fi.Name) Then
                AddProperty(fi.Name, fi.GetValue(Color.Transparent), GetType(Color))
                My.MySettings.Default.Reload()
            End If
        Next
    End Sub

    Sub SetDesignColor()
        Dim varType As Type = GetType(DesignColor)
        For Each fi As System.Reflection.FieldInfo In varType.GetFields()
            fi.SetValue(Color.Transparent, My.Settings.Item(fi.Name))
        Next
    End Sub



    Function CheckPropIsExist(ByVal propertyName As String) As Boolean
        Try
            Dim val = My.Settings.Item(propertyName)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub AddProperty(ByVal propertyName As String,
      ByVal defaultValue As Color, ByVal propertyType As Type)
        Dim providerName As String = "LocalFileSettingsProvider"

        Dim attributes As New Configuration.SettingsAttributeDictionary()
        Dim attr As New Configuration.UserScopedSettingAttribute()
        attributes.Add(attr.TypeId(), attr)

        Dim prop As New Configuration.SettingsProperty(
      New Configuration.SettingsProperty(propertyName, propertyType,
     My.MySettings.Default.Providers(providerName), False, defaultValue,
     Configuration.SettingsSerializeAs.String, attributes, False, False))
        My.MySettings.Default.Properties.Add(prop)
    End Sub



End Class