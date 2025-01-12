
# Event Management System 🎉

Welcome to the **Event Management System**, a comprehensive solution for creating, managing, and tracking events. Built using **C#** for the application logic and **SQL Server** for the backend, this system ensures efficiency and scalability in handling all your event management needs.

---

## Features ✨

- **Event Creation**: Quickly add events with essential details such as name, date, time, and venue.
- **Attendee Registration**: Manage attendee lists, including personal details and event preferences.
- **Schedule Management**: Maintain and update event schedules seamlessly.
- **Reporting**: Generate reports on event attendance, performance, and feedback.
- **User Authentication**: Secure login system for organizers and administrators.
- **Search & Filter**: Find events or attendees using dynamic search and filter options.

---

## Technologies Used 🛠️

- **Frontend**: C# (Windows Forms/WPF) for an intuitive user interface.
- **Backend**: SQL Server for reliable and efficient database management.
- **Additional Tools**: 
  - ADO.NET for database interaction.
  - Visual Studio for development.

---

## Screenshots 📸

Here are some screenshots of the application:  
_Add screenshots of your application's main screens, such as the dashboard, event creation form, and reports._

---

## Installation 🖥️

Follow these steps to get the project running on your local machine:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/EventManagementSystem.git
   cd EventManagementSystem
   ```

2. **Set Up SQL Server**:
   - Import the `DatabaseScript.sql` file into your SQL Server to create the database and tables.

3. **Configure Connection String**:
   - Update the connection string in the `App.config` (Windows Forms) or `appsettings.json` (WPF) file with your SQL Server credentials.

4. **Build and Run**:
   - Open the solution file (`.sln`) in Visual Studio.
   - Build the project to restore dependencies.
   - Run the application.

---

## Usage Guide 📚

1. **Create an Event**: Fill out the event details in the "Create Event" section and save.
2. **Register Attendees**: Navigate to the "Attendee Management" section to add attendees to specific events.
3. **View Reports**: Access event summaries and attendee insights in the "Reports" section.
4. **Edit or Delete Events**: Use the event list to modify or remove existing events.

---

## Database Structure 🗂️

**Tables**:
- `Events`: Stores event details such as name, date, time, and venue.
- `Attendees`: Stores attendee information and their registered events.
- `Users`: Stores organizer and administrator login credentials.

**Relationships**:
- `Attendees` table has a foreign key relationship with the `Events` table.

---

## Contributing 🤝

Contributions are welcome! Follow these steps to contribute:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/YourFeatureName
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add your feature"
   ```
4. Push the branch:
   ```bash
   git push origin feature/YourFeatureName
   ```
5. Submit a pull request.

---

## License 📜

This project is licensed under the [MIT License](LICENSE).
