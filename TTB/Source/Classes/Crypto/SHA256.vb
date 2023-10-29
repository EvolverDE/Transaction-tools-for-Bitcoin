Imports System
Imports System.Security.Cryptography

Public Class SHA256
    Private Shared ReadOnly sha256 As SHA256Managed = New SHA256Managed()

    Public Shared Function Hash(ByVal data As Byte()) As Byte()
        Return sha256.ComputeHash(data)
    End Function

    Public Shared Function DoubleHash(ByVal data As Byte()) As Byte()
        Return sha256.ComputeHash(sha256.ComputeHash(data))
    End Function

    Public Shared Function DoubleHashCheckSum(ByVal data As Byte()) As Byte()
        Dim checksum As Byte() = DoubleHash(data)
        Array.Resize(checksum, 4)
        Return checksum
    End Function

    'Public Shared Function Hash(ByVal hexData As String) As Byte()

    '    Dim h As Hex = New Hex

    '    Dim bytes As Byte() = h.HexToBytes(hexData)
    '    Return Hash(bytes)
    'End Function

    'Public Shared Function DoubleHash(ByVal hexData As String) As Byte()
    '    Dim h As Hex = New Hex
    '    Dim bytes As Byte() = h.HexToBytes(hexData)
    '    Return DoubleHash(bytes)
    'End Function

    'Public Shared Function DoubleHashCheckSum(ByVal hexData As String) As Byte()
    '    Dim h As Hex = New Hex
    '    Dim bytes As Byte() = h.HexToBytes(hexData)
    '    Return DoubleHashCheckSum(bytes)
    'End Function

    Public Shared Function HashMsg(ByVal Msg As String) As Byte()
        Dim MsgBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(Msg)
        Return Hash(MsgBytes)
    End Function

End Class
