Module MyAppHelper
    Private _menuclicked As ObjectMenu
    Private _uploadLocation As String
    Private _serverTcpAddressForChat As String
    Private _serverTcpPortForChat As Int32

    Public Property MenuClicked
        Set(value)
            _menuclicked = value
        End Set
        Get
            Return _menuclicked
        End Get
    End Property

    Public Property UploadLocation As String
        Get
            Return _uploadLocation
        End Get
        Set(value As String)
            _uploadLocation = value
        End Set
    End Property

    Public Property ServerTcpAddressForChat As String
        Get
            Return _serverTcpAddressForChat
        End Get
        Set(value As String)
            _serverTcpAddressForChat = value
        End Set
    End Property

    Public Property ServerTcpPortForChat As Int32
        Get
            Return _serverTcpPortForChat
        End Get
        Set(value As Int32)
            _serverTcpPortForChat = value
        End Set
    End Property

    Public Function NothingString(val) As String
        If val = Nothing Then
            Return ""
        Else
            Return val.ToString()
        End If
    End Function


    '---------------------------------------------
    Class ObjectMenu
        Private _id As Int32
        Public _menuTag, _menuText, _formName As String
        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property MenuTag As String
            Get
                Return _menuTag
            End Get
            Set(value As String)
                _menuTag = value
            End Set
        End Property

        Public Property MenuText As String
            Get
                Return _menuText
            End Get
            Set(value As String)
                _menuText = value
            End Set
        End Property

        Public Property FormName As String
            Get
                Return _formName
            End Get
            Set(value As String)
                _formName = value
            End Set
        End Property
    End Class
End Module
