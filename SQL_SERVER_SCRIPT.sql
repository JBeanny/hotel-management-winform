IF DB_ID('HotelManagement') IS NULL
    CREATE DATABASE HotelManagement;

USE HotelManagement;

IF (NOT EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
          AND TABLE_NAME = 'Rooms'
)
   )
    CREATE TABLE [HotelManagement].[dbo].[Rooms]
    (
        [id] [int] IDENTITY(1, 1) NOT NULL PRIMARY KEY,
        [name] [varchar](max) NOT NULL,
        [charge_fee] [float] NOT NULL
    )