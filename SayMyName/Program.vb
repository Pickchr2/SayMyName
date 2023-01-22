'Christopher Pickens
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/pickchr2/SayMyName.git

Option Explicit On
Option Strict On

Imports System

Module Program
    Sub Main(args As String())
        Dim userName As String

        Console.WriteLine("Hello. Please enter your name below to enter a contest to win 42 Bitcoin!")
        userName = Console.ReadLine
        Console.WriteLine("Sorry " + userName + ", no luck this time.")
    End Sub
End Module
