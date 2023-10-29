
Module ModConverts

    Public Function ByteArrayToHEXString(ByVal BytAry() As Byte) As String

        Dim RetStr As String = ""

        Dim ParaBytes As List(Of Byte) = BytAry.ToList

        For Each ParaByte As Byte In ParaBytes
            Dim T_RetStr As String = Conversion.Hex(ParaByte)

            If T_RetStr.Length < 2 Then
                T_RetStr = "0" + T_RetStr
            End If

            RetStr += T_RetStr

        Next

        Return RetStr.ToLower

    End Function
    Public Function HEXStringToByteArray(ByVal HEXStr As String) As Byte()

        Dim TempBytlist As List(Of Byte) = New List(Of Byte)

        If MessageIsHEXString(HEXStr) Then
            If HEXStr.Length Mod 2 > 0 Then
                HEXStr += "0"
            End If

            For i As Integer = 0 To HEXStr.Length - 1 Step 2

                Dim TStr As String = HEXStr.Substring(i, 2)
                TempBytlist.Add(Convert.ToByte(TStr, 16))

            Next

            Return TempBytlist.ToArray()
        Else
            Return TempBytlist.ToArray()
        End If

    End Function
    Function StringToHEXString(ByVal Input As String) As String
        Dim Output As String = ""
        For i As Integer = 0 To Input.Length - 1
            Dim Temp As String = Input.Substring(i, 1)
            Output += Hex(Asc(Temp))
        Next
        Return Output
    End Function

    Function HEXStringToString(ByVal HEXStr As String) As String
        If Not MessageIsHEXString(HEXStr) Then
            Return ""
        End If

        Return Text.Encoding.ASCII.GetString(HEXStringToByteArray(HEXStr))

    End Function

    Public Function HEXStringToULongList(ByVal HEXStr As String) As List(Of ULong)

        Dim InputBytes As List(Of Byte) = New List(Of Byte)

        If MessageIsHEXString(HEXStr) Then
            InputBytes = HEXStringToByteArray(HEXStr).ToList
        Else
            InputBytes = Text.Encoding.ASCII.GetBytes(HEXStr).ToList
        End If

        While InputBytes.Count Mod 8 <> 0
            InputBytes.Insert(0, &H0)
        End While

        InputBytes.Reverse()

        Dim T_ULongList As List(Of ULong) = New List(Of ULong)

        For i As Integer = 0 To InputBytes.Count - 1 Step 8
            T_ULongList.Add(BitConverter.ToUInt64(InputBytes.ToArray, i))
        Next

        Return T_ULongList

    End Function

    Public Function ULongListToHEXString(ByVal ULongList As List(Of ULong)) As String

        Dim HEXBytes As List(Of Byte) = New List(Of Byte)

        Dim AllZero As Boolean = True
        For Each UL As ULong In ULongList

            If UL > 0 Then
                AllZero = False
            End If

            HEXBytes.AddRange(BitConverter.GetBytes(UL))
        Next

        If AllZero Then
            Return ""
        End If

        HEXBytes.Reverse()

        While HEXBytes(0) = &H0 And HEXBytes.Count > 0
            HEXBytes.RemoveAt(0)
        End While

        Return ByteArrayToHEXString(HEXBytes.ToArray)

    End Function

    Public Function MessageIsHEXString(ByVal Message As String, Optional ByVal Length As Integer = -1) As Boolean

        If Length = -1 Then
            If Message.Length Mod 2 <> 0 Then
                Return False
            End If
        Else
            If Message.Length <> Length * 2 Then
                Return False
            End If
        End If

        Dim CharAry() As Char = Message.ToUpper.ToCharArray

        For Each Chr As Char In CharAry
            Select Case Chr
                Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "A"c, "B"c, "C"c, "D"c, "E"c, "F"c
                Case Else
                    Return False
            End Select

        Next

        Return True

    End Function

    Public Function GetXFromScript(ByVal Script As String, Optional ByVal OP_Code As ClsScriptEntry.E_OP_Code = ClsScriptEntry.E_OP_Code.OP_HASH160) As String
        Dim T_ScriptList As List(Of ClsScriptEntry) = ClsBitcoinTransaction.ConvertLockingScriptStrToList(Script)
        Return GetXFromScript(T_ScriptList, OP_Code)
    End Function

    Public Function GetXFromScript(ByVal ScriptList As List(Of ClsScriptEntry), Optional ByVal OP_Code As ClsScriptEntry.E_OP_Code = ClsScriptEntry.E_OP_Code.OP_HASH160) As String

        For i As Integer = 0 To ScriptList.Count - 1
            Dim OP_SE As ClsScriptEntry = ScriptList(i)

            If OP_Code = ClsScriptEntry.E_OP_Code.LockTime Then

                Dim KeyCode As Integer = OP_SE.Key

                Select Case KeyCode
                    Case 82 To 96 ' ClsScriptEntry.E_OP_Code.OP_2 to ClsScriptEntry.E_OP_Code.OP_16, ClsScriptEntry.E_OP_Code.LockTime
                        Return IntToHex(KeyCode - 80, 1, False)
                    Case -8
                        Return OP_SE.ValueHex
                End Select

            Else
                If OP_SE.Key = OP_Code Then
                    Return OP_SE.ValueHex
                End If
            End If

        Next

        Return ""

    End Function


End Module
