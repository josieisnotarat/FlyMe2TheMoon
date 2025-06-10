-- --------------------------------------------------------------------------------
-- Name: Josephine Wooldridge
 
-- Stored Procedures: FlyMe2theMoon
-- Note: individually, these procedures work perfectly. there's a bunch of syntax 
-- errors when putting them all in one file, however.
-- --------------------------------------------------------------------------------

-- --------------------------------------------------------------------------------
-- Add Customer
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspAddCustomer
	 @intPassengerID			AS INTEGER OUTPUT
    ,@strFirstName				AS VARCHAR(255)
    ,@strLastName				AS VARCHAR(255)
    ,@strAddress				AS VARCHAR(255)
    ,@intCity					AS VARCHAR(255) 
    ,@intStateID				AS INTEGER 
    ,@strZip					AS VARCHAR(255)
    ,@strPhoneNumber			AS VARCHAR(255)
    ,@strEmail					AS VARCHAR(255)
	,@strLoginID				AS VARCHAR(255)
	,@strPassword				AS VARCHAR(255)
	,@dtmDateofBirth			AS DATETIME
       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
    SELECT @intPassengerID = MAX(intPassengerID) + 1 
    FROM TPassengers (TABLOCKX) -- lock table until end of transaction
    -- default to 1 if table is empty
    SELECT @intPassengerID = COALESCE(@intPassengerID, 1)
    INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail, strPassengerLoginID, strPassengerPassword, dtmDateOfBirth)
    VALUES (@intPassengerID, @strFirstName, @strLastName, @strAddress, @intCity, @intStateID, @strZip, @strPhoneNumber, @strEmail, @strLoginID, @strPassword, @dtmDateofBirth)
COMMIT TRANSACTION
GO

-- --------------------------------------------------------------------------------
-- Delete Attendant Employees
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspDeleteAttendantEmployees
@intAttendantID as integer
	       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION  
    Delete  FROM TEmployees
	WHERE  intAttendantID = @intAttendantID
COMMIT TRANSACTION
GO

-- --------------------------------------------------------------------------------
-- Delete Attendant Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspDeleteAttendantFlights
@intAttendantID	AS INTEGER  
           
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
    Delete  FROM TAttendantFlights
	WHERE  intAttendantID = @intAttendantID

COMMIT TRANSACTION
GO

-- --------------------------------------------------------------------------------
-- Delete Attendants
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspDeleteAttendants
@intAttendantID				AS INTEGER      
       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
    Delete  FROM TAttendants
	WHERE  intAttendantID = @intAttendantID

COMMIT TRANSACTION
GO

-- --------------------------------------------------------------------------------
-- Delete Pilot Employees
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspDeletePilotEmployees
@intPilotID as integer
	       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
    Delete  FROM TEmployees
	WHERE  intPilotID = @intPilotID

COMMIT TRANSACTION
GO


-- --------------------------------------------------------------------------------
-- Delete Pilot Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspDeletePilotFlights
@intPilotID				AS INTEGER     
       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
    Delete  FROM TPilotFlights
	WHERE  intPilotID = @intPilotID

COMMIT TRANSACTION
GO


-- --------------------------------------------------------------------------------
-- Delete Pilots
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspDeletePilots
@intPilotID		AS INTEGER      
       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
    Delete  FROM TPilots
	WHERE  intPilotID = @intPilotID

COMMIT TRANSACTION
GO


-- --------------------------------------------------------------------------------
-- Update Passenger
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspUpdatePassenger
	@intPassengerID			AS INTEGER OUTPUT
    ,@strFirstName				AS VARCHAR(255)
    ,@strLastName				AS VARCHAR(255)
    ,@strAddress				AS VARCHAR(255)
    ,@strCity					AS VARCHAR(255) 
    ,@intStateID				AS INTEGER 
    ,@strZip					AS VARCHAR(255)
    ,@strPhoneNumber			AS VARCHAR(255)
    ,@strEmail					AS VARCHAR(255)
	,@strLoginID				AS VARCHAR(255)
	,@strPassword				AS VARCHAR(255)
	,@dtmDateOfBirth			AS DATETIME
       
AS
SET XACT_ABORT ON --terminate and rollback if any errors
BEGIN TRANSACTION
  
   Update TPassengers Set 
    strFirstName = @strFirstName, 
    strLastName = @strLastName,
    strAddress = @strAddress,
    strCity = @strCity, 
    intStateID = @intStateID,
    strZip = @strZip,
    strPhoneNumber = @strPhoneNumber,
    strEmail = @strEmail,  
	strPassengerLoginID = @strLoginID,
	strPassengerPassword = @strPassword,
	dtmDateOfBirth = @dtmDateOfBirth
			
	WHERE  intPassengerID = @intPassengerID
COMMIT TRANSACTION
GO


-- --------------------------------------------------------------------------------
-- Get Attendant Future Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetAttendantFutureFlights(@intCurrentAttendantID as Integer)
AS 
BEGIN
SELECT *
FROM TFlights
JOIN TAttendantFlights
ON TFlights.intFlightID = TAttendantFlights.intFlightID
JOIN TAttendants 
ON TAttendantFlights.intAttendantID = TAttendants.intAttendantID
JOIN TPlanes 
ON TFlights.intPlaneID = TPlanes.intPlaneID
JOIN TPlaneTypes 
ON TPlanes.intPlaneTypeID = TPlaneTypes.intPlaneTypeID
WHERE TAttendants.intAttendantID = @intCurrentAttendantID AND TFlights.dtmFlightDate > Getdate()	

END;



-- --------------------------------------------------------------------------------
-- Get Attendant Past Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetAttendantPastFlights(@intCurrentAttendantID as Integer)
AS 
BEGIN
SELECT *
FROM TFlights
JOIN TAttendantFlights
ON TFlights.intFlightID = TAttendantFlights.intFlightID
JOIN TAttendants 
ON TAttendantFlights.intAttendantID = TAttendants.intAttendantID
JOIN TPlanes 
ON TFlights.intPlaneID = TPlanes.intPlaneID
JOIN TPlaneTypes 
ON TPlanes.intPlaneTypeID = TPlaneTypes.intPlaneTypeID
WHERE TAttendants.intAttendantID = @intCurrentAttendantID AND TFlights.dtmFlightDate < Getdate()	

END;



-- --------------------------------------------------------------------------------
-- Get Customer Future Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetCustomerFutureFlights(@intCurrentPassengerID as Integer)
AS 
BEGIN
SELECT *
FROM TFlights
JOIN TFlightPassengers
ON TFlights.intFlightID = TFlightPassengers.intFlightID
JOIN TPassengers
ON TFlightPassengers.intPassengerID = TPassengers.intPassengerID
JOIN TPlanes 
ON TFlights.intPlaneID = TPlanes.intPlaneID 
JOIN TPlaneTypes 
ON TPlanes.intPlaneTypeID = TPlaneTypes.intPlaneTypeID
WHERE TPassengers.intPassengerID = @intCurrentPassengerID AND TFlights.dtmFlightDate > GETDATE()

END;



-- --------------------------------------------------------------------------------
-- Get Customer Past Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetCustomerPastFlights(@intCurrentPassengerID as Integer)
AS 
BEGIN
SELECT *
FROM TFlights
JOIN TFlightPassengers
ON TFlights.intFlightID = TFlightPassengers.intFlightID
JOIN TPassengers
ON TFlightPassengers.intPassengerID = TPassengers.intPassengerID
JOIN TPlanes 
ON TFlights.intPlaneID = TPlanes.intPlaneID 
JOIN TPlaneTypes 
ON TPlanes.intPlaneTypeID = TPlaneTypes.intPlaneTypeID
WHERE TPassengers.intPassengerID = @intCurrentPassengerID AND TFlights.dtmFlightDate < GETDATE()

END;



-- --------------------------------------------------------------------------------
-- Get Pilot Future Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetPilotFutureFlights(@intCurrentPilotID as Integer)
AS 
BEGIN
SELECT *
FROM TFlights
JOIN TPilotFlights
ON TFlights.intFlightID = TPilotFlights.intFlightID
JOIN TPilots 
ON TPilotFlights.intPilotID = TPilots.intPilotID
JOIN TPlanes 
ON TFlights.intPlaneID = TPlanes.intPlaneID
JOIN TPlaneTypes 
ON TPlanes.intPlaneTypeID = TPlaneTypes.intPlaneTypeID                                                     
WHERE TPilots.intPilotID = @intCurrentPilotID AND TFlights.dtmFlightDate > Getdate()		

END;



-- --------------------------------------------------------------------------------
-- Get Pilot Past Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetPilotPastFlights(@intCurrentPilotID as Integer)
AS 
BEGIN
SELECT *
FROM TFlights
JOIN TPilotFlights
ON TFlights.intFlightID = TPilotFlights.intFlightID
JOIN TPilots 
ON TPilotFlights.intPilotID = TPilots.intPilotID
JOIN TPlanes 
ON TFlights.intPlaneID = TPlanes.intPlaneID
JOIN TPlaneTypes 
ON TPlanes.intPlaneTypeID = TPlaneTypes.intPlaneTypeID                                                     
WHERE TPilots.intPilotID = @intCurrentPilotID AND TFlights.dtmFlightDate < Getdate()		

END;



-- --------------------------------------------------------------------------------
-- Get Future Flights
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspGetFutureFlights
AS 
BEGIN
SELECT TF.intFlightID as FlightID, TF.dtmFlightDate AS FlightDate, TF.dtmTimeofDeparture AS DepartureTime, TFA.strAirportCity AS FromAirport, TTA.strAirportCity AS ToAirport
FROM TFlights AS TF
JOIN TAirports AS TFA 
ON TF.intFromAirportID = TFA.intAirportID
JOIN TAirports AS TTA 
ON TF.intToAirportID = TTA.intAirportID
WHERE TF.dtmFlightDate > GETDATE()

END;



-- --------------------------------------------------------------------------------
-- Max Flight Passenger ID
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspMaxFlightPassengerID
AS 
BEGIN
SELECT MAX(intFlightPassengerID) + 1 AS intNextPrimaryKey  FROM TFlightPassengers

END;


-- --------------------------------------------------------------------------------
-- Max Passenger ID
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspMaxPassengerID
AS 
BEGIN
SELECT MAX(intPassengerID) + 1 AS intNextPrimaryKey FROM TPassengers

END;



-- --------------------------------------------------------------------------------
-- Passenger Info
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspPassengerInfo(@intCurrentPassengerID AS Integer)
AS 
BEGIN
SELECT intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail, strPassengerLoginID, strPassengerPassword, dtmDateOfBirth 
FROM TPassengers Where intPassengerID = @intCurrentPassengerID

END;


-- --------------------------------------------------------------------------------
-- States
-- --------------------------------------------------------------------------------
CREATE PROCEDURE uspStates
AS 
BEGIN
SELECT intStateID, strState FROM TStates

END;


