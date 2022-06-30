# Final exercise for the course Transact SQL and MS SQL SErver database implementation

## Exercise 1.
Develop a stored procedure that checks if the data for the new date appeared in the
source table. If the new data appeared, reload them to target table.
If we already have data for the last date in the source table, we write the message
"The data on the last report date is synchronized" to the calling program.

## Exercise 2. 
Refine the procedure as follows:
The procedure should reconcile the checksum of the values of all the indicators
for the last date in the source and reconcile with the checksum of values of all
indicators for the same date in target table.
If there is a difference in the checksum, it will overwrite the data for the last date.
If there is a match, display the message "Data on the last date of the report is synchronized.
Note that you cannot compare to NULL.

## Exercise 3.
Refine the procedure as follows:
The procedure should work with the last available date in the source by default.
But if you specify a specific date, it should check it.
You can implement this by adding an input parameter to the procedure.
So, for example, if you pass NULL as a parameter, the procedure can work in standard mode
and process the last available date in the source table.
If a certain date comes in as a parameter, it can work with it.
