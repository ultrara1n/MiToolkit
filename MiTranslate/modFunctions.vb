Imports System.IO
Imports System.Security.Cryptography

Public Class returnData
    Public Shared androidVersion As String
    Public Shared androidAPI As String
End Class

Module modFunctions
    Public Function MD5FileHash(ByVal sFile As String) As String
        Dim MD5 As New MD5CryptoServiceProvider
        Dim Hash As Byte()
        Dim Result As String = ""
        Dim Tmp As String = ""

        Dim FN As New FileStream(sFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        MD5.ComputeHash(FN)
        FN.Close()

        Hash = MD5.Hash
        For i As Integer = 0 To Hash.Length - 1
            Tmp = Hex(Hash(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Result += Tmp
        Next
        Return Result
    End Function

    Function checkADB()
        'Prüfen ob ADB Gerät immer noch verbunden ist
        Dim processCheckADB As New Process()
        Dim infoCheckADB As New ProcessStartInfo("adb/adb.exe", "devices -l")
        With infoCheckADB
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardOutput = True
        End With
        processCheckADB.StartInfo = infoCheckADB
        processCheckADB.Start()
        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = processCheckADB.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        'Ergebnis etwas anpassen damit es genutzt werden kann
        Dim result() As String = Split(sOutput, vbCrLf)
        'Array durchlaufen um zu schauen ob Gerät verbunden ist
        For Each output As String In result
            If (output.Contains("product")) Then
                'Gerät gefunden
                Dim modelinfos() As String = Split(output, ":")
                checkADB = modelinfos(3)
            End If
        Next
    End Function

    Function getADBInfos()
        Dim processDeviceInformation As New Process()
        Dim infoDeviceInformation As New ProcessStartInfo("adb/adb.exe", "shell getprop")
        With infoDeviceInformation
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardOutput = True
        End With
        processDeviceInformation.StartInfo = infoDeviceInformation
        processDeviceInformation.Start()
        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = processDeviceInformation.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        returnData.androidVersion = filterDeviceInfo(sOutput, "ro.build.version.release")
        returnData.androidAPI = filterDeviceInfo(sOutput, "ro.build.version.sdk")
    End Function

    Function filterDeviceInfo(ByVal completeInfo As String, ByVal infoWanted As String)
        'Kompletten Dump durchlaufen um gewollte Infos zu erhalten
        Dim infoArray() As String = Split(completeInfo, vbCrLf)
        For Each infoPart As String In infoArray
            If (infoPart.Contains(infoWanted)) Then
                'Nach Doppelpunkt splitten
                Dim concreteInfo() As String = Split(infoPart, ": ")
                '[ und ] löschen
                Dim readyInfo As String = Replace(concreteInfo(1), "[", "")
                filterDeviceInfo = Replace(readyInfo, "]", "")
            End If
        Next

        Return filterDeviceInfo
    End Function
End Module