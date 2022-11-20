Module Module1
    Public minutos, Dias, minutosEntrada, minutosSaida
    Function Tempo(ByVal dataentrada As Date, ByVal datasaida As Date, ByVal horaentrada As Date, ByVal horasaida As Date) As Double
        If dataentrada = datasaida Then
            minutos = DateDiff(DateInterval.Minute, horaentrada, horasaida)
        Else
            Dias = DateDiff(DateInterval.Minute, dataentrada, datasaida)
            minutosEntrada = 1440 - (Hour(horaentrada) * 60 + Minute(horaentrada))
            minutosSaida = Hour(horasaida) * 60 + Minute(horasaida)
            minutos = (Dias - 1440) + minutosEntrada + minutosSaida
        End If
        Tempo = minutos
    End Function
End Module