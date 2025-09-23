/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists(select 1 from dbo.RoomTypes)
BEGIN 

    INSERT INTO dbo.RoomTypes (Title, Description, Price)
    VALUES   ('Standard Room', 'A cozy room with a queen bed, flat-screen TV, and free Wi-Fi.', 89.99)
            ,('Deluxe Room', 'Spacious room with a king bed, mini-fridge, and city view.',129.50)
            ,('Executive Suite', 'Includes a living area, workspace, and premium bath amenities.', 199.99)
            ,('Family Room', 'Perfect for families. Two queen beds, sofa, and kitchenette.', 159.99)
            ,('Presidential Suite', 'Luxurious suite with panoramic views, jacuzzi, and butler service.',399.99)

END

if not exists(select 1 from dbo.Rooms)
BEGIN

/* Capture Ids*/
    DECLARE @roomId1 int;
    DECLARE @roomId2 int;
    DECLARE @roomId3 int;
    DECLARE @roomId4 int;
    DECLARE @roomId5 int;


    select @roomId1 = Id from dbo.RoomTypes where title = 'Standard Room';
    select @roomId2 = Id from dbo.RoomTypes where title = 'Deluxe Room';
    select @roomId3 = Id from dbo.RoomTypes where title = 'Executive Suite';
    select @roomId4 = Id from dbo.RoomTypes where title = 'Family Room';
    select @roomId5 = Id from dbo.RoomTypes where title = 'Presidential Suite';

    INSERT INTO dbo.Rooms (RoomNumber,RoomTypeId)
    VALUES   ('101', @roomId1)
            ,('102', @roomId1)
            ,('201', @roomId2)
            ,('202', @roomId2)
            ,('301', @roomId3)
            ,('401', @roomId4)
            ,('402', @roomId4)
            ,('501', @roomId5)
END 

