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
