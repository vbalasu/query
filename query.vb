Imports System
Public Module modmain

'''''''''''SAMPLE SCRIPT'''''''''''''
'.mode csv
'.import orders.csv orders
'.headers on
'.once output.csv
'select * from orders;
'.quit

   Sub Main()
	 Dim InputCsvFile As String, tablename As String, query As String, OutputCsvFile As String
	 Console.WriteLine ("Path to input CSV File?	[eg. c:\orders.csv]")
	 InputCsvFile = Console.Readline ()
	 Console.WriteLine (InputCsvFile)
	 Console.WriteLine ("Table name?	[eg. orders]")
	 tablename = Console.Readline ()
	 Console.Writeline (tablename)
	 Console.WriteLine ("SQL Query?	[eg. SELECT * from orders;]")
	 query = Console.Readline ()
	 Console.Writeline (query)
	 Console.WriteLine ("Path to output CSV file?	[eg. c:\output.csv]")
	 OutputCsvFile = Console.Readline ()
	 Console.Writeline (OutputCsvFile)
	 QueryCsv (InputCsvFile, tablename, query, OutputCsvFile)
	 Console.Writeline ("Done")
   End Sub
   
   'Usage: QueryCsv "c:\orders.csv", "orders", "SELECT COUNT(*) FROM ORDERS;", "c:\output.csv"
    Sub QueryCsv(InputCsvFile As String, tablename As String, query As String, OutputCsvFile As String)
    Console.Writeline ("1")
        Dim script As String, newline As String
		newline = Chr(13) & Chr(10)
		script = ".mode csv" & newline
    Console.Writeline ("2")
		script = script & ".import " & InputCsvFile & " " & tablename & newline
    Console.Writeline ("3")
		script = script & ".headers on" & newline
    Console.Writeline ("4")
		script = script & ".once " & OutputCsvFile & newline
    Console.Writeline ("5")
		script = script & query & newline
    Console.Writeline ("7")
		script = script & ".quit" & newline
    Console.Writeline ("8")
		Dim sh As Object, sqlite As Object
		sh = CreateObject("Wscript.shell")
    Console.Writeline ("9")
		sqlite = sh.Exec("sqlite3.exe")
    Console.Writeline ("10")
		sqlite.stdin.Write(script)
    Console.Writeline ("11")
    Console.Writeline ("12")
    End Sub

End Module



