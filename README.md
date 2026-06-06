EventEase – Event Booking System

EventEase is a modern web application built with ASP.NET Core MVC that allows users to manage venues, events, and bookings efficiently. The system is designed to provide a clean interface for organizing events and tracking reservations.

Part1

🚀 Features

🎟️ Manage Events (Create, Edit, Delete, View)

🏢 Manage Venues with capacity tracking

📅 Booking system with event & venue linking

🖼️ Image support for events and venues

📊 Display upcoming events

📌 Booking tracking dashboard

🔒 Privacy page included

☁️ Deployed on Microsoft Azure

🛠️ Technologies Used

ASP.NET Core MVC

Entity Framework Core

SQL Server / Azure SQL Database

Bootstrap 5

HTML, CSS, JavaScript

Microsoft Azure App Service

🗄️ Database Structure

The system includes the following main tables:

Venue -
VenueId,
VenueName,
Location,
Capacity,
ImageUrl

Event -
EventId,
EventName,
EventDate,
Description,
VenueId

Booking -
BookingId,
EventId,
VenueId,
BookingDate

🌐 Live Demo

👉 (https://eventease-app-promisekarabo-bahkhmcpamdqfxbe.southafricanorth-01.azurewebsites.net/)

## Part 2 Updates

This version of the EventEase Booking System includes the following enhancements:

### Azure Blob Storage Integration

- Images for venues and events are now uploaded and stored in Azure Blob Storage.
- 
- This replaces the previous method of using static image URLs.
- 
- Users can create, update, and view images directly from Azure storage.

### Error Handling and Validation

- Prevents double booking of the same venue on the same date.
- 
- Prevents deletion of venues and events linked to active bookings.
- 
- Displays user-friendly error messages when validation fails.
- 
- Ensures the application does not crash on invalid input.

### Enhanced Display (Booking View)

- A new database view (BookingDetailsView) was created using SQL.
- 
- This view joins Bookings, Events, and Venues tables.
- 
- Provides a consolidated and detailed booking display for users.

### Search Functionality

- Users can search bookings using:

  - Booking ID
    
  - Event Name
    
- Improves usability and efficiency for booking management.



# EventEase Booking System – POE Part 3

## Overview

EventEase is an ASP.NET Core MVC web application developed for managing venues, events, and bookings. Part 3 of the project focuses on implementing advanced filtering functionality, improving database structure using lookup tables, and enhancing the booking management interface.

The system uses:

* ASP.NET Core MVC
* Entity Framework Core
* Azure SQL Database
* Azure Blob Storage
* Azure App Service
* GitHub Version Control



# Features Implemented in Part 3

## 1. Event Type Lookup Table

A new `EventTypes` table was created to normalize event categories and improve filtering functionality.

Predefined event types include:

* Conference
* Wedding
* Concert
* Workshop
* Birthday
* Corporate

The `Events` table was updated with an `EventTypeId` foreign key relationship.

---

## 2. Advanced Booking Filtering

The Booking Details View was enhanced with advanced filtering functionality.

Users can now filter bookings by:

* Event Type
* Start Date
* End Date
* Venue Availability

This improves usability for booking specialists and allows faster access to relevant booking records.

---

## 3. Enhanced Booking Details View

The booking display was expanded using a SQL View (`BookingDetailsView`) that joins:

* Bookings
* Events
* Venues
* EventTypes

This provides a consolidated display of booking information in a single interface.

Displayed information includes:

* Booking details
* Customer information
* Event information
* Event type
* Venue information
* Venue availability

---

## 4. Azure SQL Database Updates

The database schema was updated using Entity Framework Core migrations.

Changes include:

* Creation of the `EventTypes` table
* Foreign key relationship between Events and EventTypes
* Updated SQL View for filtering support

---

## 5. Azure Deployment

The updated Part 3 application was deployed to Azure App Service.

The deployed application includes:

* Advanced filtering
* Updated SQL database
* Azure Blob Storage integration
* Updated booking interface

---

# Technologies Used

## ASP.NET Core MVC

Used to build the web application using the MVC architectural pattern.

## Entity Framework Core

Used for database access, migrations, and model relationships.

## Azure SQL Database

Cloud-hosted relational database used for storing application data.

## Azure Blob Storage

Used for storing uploaded venue and event images.

## Azure App Service

Used to deploy and host the web application online.

## GitHub

Used for version control and source code management.

---

⚙️ How to Run Locally

Clone the repository

git clone https://github.com/Promisekhoza534/EventEaseBookingSystem.git

Open in Visual Studio

Update appsettings.json connection string

Run migrations:

Update-Database

Press F5 to run the app

☁️ Deployment

The application is deployed using:

Azure Web App Service

Azure SQL Database

👨‍💻 Author

Promise karabo Khoza

Developed as part of a web development project.

📄 License

This project is for educational purposes
