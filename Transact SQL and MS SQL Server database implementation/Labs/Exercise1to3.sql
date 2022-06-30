/*
	Exercise 1. Develop a stored procedure that checks if the data for the new date appeared in the
source table. If the new data appeared, reload them to target table.
If we already have data for the last date in the source table, we write the message
"The data on the last report date is synchronized" to the calling program.

	Exercise 2. Refine the procedure as follows:
The procedure should reconcile the checksum of the values of all the indicators
for the last date in the source and reconcile with the checksum of values of all
indicators for the same date in target table.
If there is a difference in the checksum, it will overwrite the data for the last date.
If there is a match, display the message "Data on the last date of the report is synchronized.
Note that you cannot compare to NULL.

	Exercise 3. Refine the procedure as follows:
The procedure should work with the last available date in the source by default.
But if you specify a specific date, it should check it.
You can implement this by adding an input parameter to the procedure.
So, for example, if you pass NULL as a parameter, the procedure can work in standard mode
and process the last available date in the source table.
If a certain date comes in as a parameter, it can work with it.
*/

USE PracticeMSSQL
GO

DROP PROCEDURE IF EXISTS Istochnik.usp_NewDateDataSynconizer

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Exercise 1.
CREATE PROCEDURE Istochnik.usp_NewDateDataSynconizer
					 @dtDateToCheck date
AS
-- two date variables to seach new data in a range of dates;
DECLARE	@dtMaxDate date,	-- MAX date in the source table;
		@dtLastDate date;	-- MAX date in the target table;

--	Exercise 3.
-- There are two ways to implement Ex.3: 1) IF...ELSE...; 2) SET @var = ISNULL((...),(,,,));

--IF @dtDateToCheck IS NULL
--	SET @dtMaxDate = (SELECT MAX(dtEndDate) FROM Istochnik.TableSource)
--ELSE 
--	SET @dtMaxDate = @dtDateToCheck
SET @dtMaxDate = ISNULL((@dtDateToCheck),(SELECT MAX(dtEndDate) FROM Istochnik.TableSource));
SELECT @dtLastDate = MAX(dtReportDate) FROM NashaBaza.OurTable;

BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	IF @dtLastDate <> @dtMaxDate
--alternative IF @dtMaxDate NOT IN (SELECT dtReportDate FROM NashaBaza.OurTable)
		BEGIN -- Exercise 2 - while cycle below.
			WHILE
				ISNULL((SELECT SUM(vProcent) FROM NashaBaza.OurTable
				WHERE dtReportDate = @dtMaxDate),0)
				<>
				(SELECT SUM(nValue) FROM Istochnik.TableSource
				WHERE dtEndDate = @dtMaxDate AND vPeriodType LIKE 'm') -- ignore quaterly data
			BEGIN
				DELETE FROM NashaBaza.OurTable WHERE dtReportDate = @dtMaxDate
				INSERT INTO NashaBaza.OurTable
					(nCanonId, dtReportDate, nTerOtdelenie, nTerPodrazdel, vProcent)
					SELECT	nPokazatelId AS nCanonId,
							dtEndDate AS dtReportDate,
							CAST(LEFT(vTerritoryId,2) AS INT) AS nTerOtdelenie,
							CAST(RIGHT(vTerritoryId,4) AS INT) AS nTerPodrazdel,
							nValue AS vProcent
					FROM Istochnik.TableSource AS i
						WHERE i.dtEndDate BETWEEN DATEADD(DD, 01, @dtLastDate) AND @dtMaxDate
						AND vPeriodType LIKE 'm'
			END
		END
	ELSE PRINT N'The monthly data on the last report date for ' + 
				CAST(@dtMaxDate AS nvarchar(10)) + ' is synchronized';

END
GO

-- Test
--EXEC Istochnik.usp_NewDateDataSynconizer NULL