(
REM Input CSV File
echo orders.csv
REM Table name
echo orders
REM SQL Query
echo select count^(*^) from orders;
REM Output CSV file
echo output.csv
) > query.script 
type query.script | query.exe