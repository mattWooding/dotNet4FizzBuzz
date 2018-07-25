
Option Explicit On
Option Strict On

Imports System
Imports TKMW.NumberGame.Interfaces

Namespace TKMW.NumberGame.NumberProviders

    
    Public Class NumberProviderRandom implements INumberProvider

        private lowestNumber as int
        private highestNumber as int
        private howMany as int
        private currentPosition as int
        private myRandom as Random

    	Public Sub New()
            Initialize()
    	End Sub

        Private Sub Initialize() 
            currentPosition = 0
            myRandom = new Random(System.DateTime.Now.Milliseconds)
            howMany = myRandom.Next(0, 100)
            lowestNumber = 1
            highestNumber = 100
        End Sub

        Public Function Next() as bool implements Next
            dim ret as bool = currentPosition < howMany
            currentPosition += 1
            return ret
        End Function

        Public Function TheNumber() as int implements TheNumber
            return myRandom.Next(lowestNumber, highestNumber)
        End Function

        Public Sub Reset() implements Reset
            Initialize()
        End Sub

    End Class

End Namespace