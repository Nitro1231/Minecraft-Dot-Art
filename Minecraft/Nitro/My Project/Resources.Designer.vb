﻿'------------------------------------------------------------------------------
' <auto-generated>
'     이 코드는 도구를 사용하여 생성되었습니다.
'     런타임 버전:4.0.30319.42000
'
'     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
'     이러한 변경 내용이 손실됩니다.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    '클래스에서 자동으로 생성되었습니다.
    '멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    '다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
    '''<summary>
    '''  지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Nitro.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대한 현재 스레드의 CurrentUICulture
        '''  속성을 재정의합니다.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  System.Drawing.Bitmap 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend ReadOnly Property close() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("close", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  white_concrete #d0d6d7
        '''orange_concrete #df6000
        '''magenta_concrete #a9309f
        '''light_blue_concrete #2389c7
        '''yellow_concrete #f1af15
        '''lime_concrete #5faa1a
        '''pink_concrete #d5648e
        '''gray_concrete #36393d
        '''light_gray_concrete #36393d
        '''cyan_concrete #157687
        '''purple_concrete #65209d
        '''blue_concrete #2d2f90
        '''brown_concrete #603b1f
        '''green_concrete #4a5c25
        '''red_concrete #8f2222
        '''black_concrete #080a0f
        '''
        '''concrete 0|#d0d6d7
        '''concrete 1|#df6000
        '''concrete 2|#a9309f
        '''concrete 3|#2389c7
        '''concrete 4|#f1af15
        '''concrete 5|#5faa1a[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        '''</summary>
        Friend ReadOnly Property Concrete() As String
            Get
                Return ResourceManager.GetString("Concrete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  System.Drawing.Bitmap 형식의 지역화된 리소스를 찾습니다.
        '''</summary>
        Friend ReadOnly Property Min() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Min", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  white_terracotta #d3b6a3
        '''orange_terracotta #9f5224
        '''magenta_terracotta #93566b
        '''light_blue_terracotta #6d6a88
        '''yellow_terracotta #b78220
        '''lime_terracotta #677736
        '''pink_terracotta #9f4b4b
        '''gray_terracotta #392a23
        '''light_gray_terracotta #876a62
        '''cyan_terracotta #555a5a
        '''purple_terracotta #744555
        '''blue_terracotta #493a5b
        '''brown_terracotta #4c3223
        '''green_terracotta #4f572e
        '''red_terracotta #913e2f
        '''black_terracotta #271712
        '''terracotta #965d43
        '''
        '''stained_hardened_clay 1|#d3b6a3
        '''stained_hardened_clay 2|#9f5224
        '''[나머지 문자열은 잘림]&quot;;과(와) 유사한 지역화된 문자열을 찾습니다.
        '''</summary>
        Friend ReadOnly Property Terracotta() As String
            Get
                Return ResourceManager.GetString("Terracotta", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
