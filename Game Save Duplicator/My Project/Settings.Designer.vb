﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Destination Folder Path Selected")>  _
        Public Property DesFol() As String
            Get
                Return CType(Me("DesFol"),String)
            End Get
            Set
                Me("DesFol") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game1() As String
            Get
                Return CType(Me("Game1"),String)
            End Get
            Set
                Me("Game1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game2() As String
            Get
                Return CType(Me("Game2"),String)
            End Get
            Set
                Me("Game2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game3() As String
            Get
                Return CType(Me("Game3"),String)
            End Get
            Set
                Me("Game3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game4() As String
            Get
                Return CType(Me("Game4"),String)
            End Get
            Set
                Me("Game4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game5() As String
            Get
                Return CType(Me("Game5"),String)
            End Get
            Set
                Me("Game5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game6() As String
            Get
                Return CType(Me("Game6"),String)
            End Get
            Set
                Me("Game6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game7() As String
            Get
                Return CType(Me("Game7"),String)
            End Get
            Set
                Me("Game7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game8() As String
            Get
                Return CType(Me("Game8"),String)
            End Get
            Set
                Me("Game8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game9() As String
            Get
                Return CType(Me("Game9"),String)
            End Get
            Set
                Me("Game9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game10() As String
            Get
                Return CType(Me("Game10"),String)
            End Get
            Set
                Me("Game10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath1() As String
            Get
                Return CType(Me("GamePath1"),String)
            End Get
            Set
                Me("GamePath1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath2() As String
            Get
                Return CType(Me("GamePath2"),String)
            End Get
            Set
                Me("GamePath2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath3() As String
            Get
                Return CType(Me("GamePath3"),String)
            End Get
            Set
                Me("GamePath3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath4() As String
            Get
                Return CType(Me("GamePath4"),String)
            End Get
            Set
                Me("GamePath4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath5() As String
            Get
                Return CType(Me("GamePath5"),String)
            End Get
            Set
                Me("GamePath5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath6() As String
            Get
                Return CType(Me("GamePath6"),String)
            End Get
            Set
                Me("GamePath6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath7() As String
            Get
                Return CType(Me("GamePath7"),String)
            End Get
            Set
                Me("GamePath7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath8() As String
            Get
                Return CType(Me("GamePath8"),String)
            End Get
            Set
                Me("GamePath8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath9() As String
            Get
                Return CType(Me("GamePath9"),String)
            End Get
            Set
                Me("GamePath9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath10() As String
            Get
                Return CType(Me("GamePath10"),String)
            End Get
            Set
                Me("GamePath10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game11() As String
            Get
                Return CType(Me("Game11"),String)
            End Get
            Set
                Me("Game11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game12() As String
            Get
                Return CType(Me("Game12"),String)
            End Get
            Set
                Me("Game12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game13() As String
            Get
                Return CType(Me("Game13"),String)
            End Get
            Set
                Me("Game13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game14() As String
            Get
                Return CType(Me("Game14"),String)
            End Get
            Set
                Me("Game14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game15() As String
            Get
                Return CType(Me("Game15"),String)
            End Get
            Set
                Me("Game15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game16() As String
            Get
                Return CType(Me("Game16"),String)
            End Get
            Set
                Me("Game16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game17() As String
            Get
                Return CType(Me("Game17"),String)
            End Get
            Set
                Me("Game17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game18() As String
            Get
                Return CType(Me("Game18"),String)
            End Get
            Set
                Me("Game18") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game19() As String
            Get
                Return CType(Me("Game19"),String)
            End Get
            Set
                Me("Game19") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Data")>  _
        Public Property Game20() As String
            Get
                Return CType(Me("Game20"),String)
            End Get
            Set
                Me("Game20") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath11() As String
            Get
                Return CType(Me("GamePath11"),String)
            End Get
            Set
                Me("GamePath11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath12() As String
            Get
                Return CType(Me("GamePath12"),String)
            End Get
            Set
                Me("GamePath12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath13() As String
            Get
                Return CType(Me("GamePath13"),String)
            End Get
            Set
                Me("GamePath13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath14() As String
            Get
                Return CType(Me("GamePath14"),String)
            End Get
            Set
                Me("GamePath14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath15() As String
            Get
                Return CType(Me("GamePath15"),String)
            End Get
            Set
                Me("GamePath15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath16() As String
            Get
                Return CType(Me("GamePath16"),String)
            End Get
            Set
                Me("GamePath16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath17() As String
            Get
                Return CType(Me("GamePath17"),String)
            End Get
            Set
                Me("GamePath17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath18() As String
            Get
                Return CType(Me("GamePath18"),String)
            End Get
            Set
                Me("GamePath18") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath19() As String
            Get
                Return CType(Me("GamePath19"),String)
            End Get
            Set
                Me("GamePath19") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("No Game Folder Path Selected")>  _
        Public Property GamePath20() As String
            Get
                Return CType(Me("GamePath20"),String)
            End Get
            Set
                Me("GamePath20") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Game_Save_Duplicator.My.MySettings
            Get
                Return Global.Game_Save_Duplicator.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace