
Option Explicit On
Option Strict On

Imports System
Imports TKMW.NumberGame.Interfaces

Namespace Global.TKMW.NumberGame.NumberProviders
 
    Public Class NumberProviderRandom : implements INumberProvider

        private lowestNumber as Integer
        private highestNumber as Integer
        private howMany as Integer
        private currentPosition as Integer
        private myRandom as Random

        Public Sub New()
            Initialize()
        End Sub

        Private Sub Initialize() 
            currentPosition = 0
            myRandom = new Random(System.DateTime.Now.Millisecond)
            howMany = myRandom.Next(0, 100)
            lowestNumber = 1
            highestNumber = 100
        End Sub

        Public Function GetNext() as boolean implements INumberProvider.Next
            dim ret as boolean = currentPosition < howMany
            currentPosition += 1
            return ret
        End Function

        Public ReadOnly Property TheNumber() as Integer implements INumberProvider.TheNumber
            Get
                return myRandom.Next(lowestNumber, highestNumber)
            End Get
        End Property

        Public Sub Reset() implements INumberProvider.Reset
            Initialize()
        End Sub

    End Class

End Namespace