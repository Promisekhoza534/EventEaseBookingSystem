EventEase – Event Booking System

EventEase is a modern web application built with ASP.NET Core MVC that allows users to manage venues, events, and bookings efficiently. The system is designed to provide a clean interface for organizing events and tracking reservations.

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

Venue
VenueId
VenueName
Location
Capacity
ImageUrl
Event
EventId
EventName
EventDate
Description
VenueId
Booking
BookingId
EventId
VenueId
BookingDate
🌐 Live Demo

👉 (https://eventease-app-promisekarabo-bahkhmcpamdqfxbe.southafricanorth-01.azurewebsites.net/)

⚙️ How to Run Locally
Clone the repository
git clone https://github.com/yourusername/EventEaseBookingSystem.git
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

Promise Khoza
Developed as part of a web development project.

📄 License

This project is for educational purposes
