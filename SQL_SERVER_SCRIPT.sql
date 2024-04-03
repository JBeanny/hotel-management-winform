IF DB_ID('HotelManagement') IS NULL
BEGIN
    CREATE DATABASE HotelManagement;

    WHILE DB_ID('HotelManagement') IS NULL
    BEGIN
        WAITFOR DELAY '00:00:01'; -- Wait for 1 second
        IF DB_ID('HotelManagement') IS NOT NULL
            BREAK;
    END
END;

USE HotelManagement;

IF (NOT EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
          AND TABLE_NAME = 'Rooms'
)
   )
    CREATE TABLE [dbo].[Rooms](
	    [id] [varchar](max) NOT NULL,
	    [name] [varchar](max) NOT NULL,
	    [charge_fee] [float] NOT NULL
    ) 

IF (NOT EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
          AND TABLE_NAME = 'Reservations'
)
   )
    CREATE TABLE [dbo].[Reservations](
	    [id] [varchar](max) NOT NULL,
	    [roomId] [varchar](max) NOT NULL,
	    [guestId] [varchar](50) NOT NULL,
	    [startDate] [datetime] NOT NULL,
	    [endDate] [datetime] NOT NULL,
	    [checkIn] [varchar](50) NOT NULL
    )


IF (NOT EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
          AND TABLE_NAME = 'Guests'
)
   )
    CREATE TABLE [dbo].[Guests](
	    [id] [varchar](max) NOT NULL,
	    [name] [varchar](50) NOT NULL,
	    [contact] [varchar](50) NOT NULL,
	    [gender] [nchar](10) NOT NULL
    )

IF (NOT EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
          AND TABLE_NAME = 'Users'
)
   )
    CREATE TABLE [dbo].[Users](
	    [id] [varchar](max) NOT NULL,
	    [username] [varchar](50) NOT NULL,
	    [password] [varchar](max) NOT NULL,
	    [createdDateTime] [datetime] NOT NULL
    )