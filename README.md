# 🎉 Yalla Bena Web API 🚀

The **Yalla Bena Web API** is an exciting backend built using **.NET Core Web Api** that powers the entire functionality of the **Yalla Bena** travel app. This API serves as the backbone for managing user data, preferences, bookings, and personalized travel recommendations. The goal is to create an unforgettable travel experience for our users! 🌍✈️

## 🔑 Key Features

- **👤 User Management:** Effortlessly handle user registration, login, and profile updates for a smooth user experience.
- **💡 Preference Management:** Empower users to set and update their travel preferences, such as budget, destinations, and activity types.
- **🏨 Booking System:** Streamline the process of booking hotels, transportation, and activities, all in one place!
- **🤖 Recommendation Engine:** Leverage cutting-edge machine learning models (KNN) to deliver personalized recommendations that enhance each user's travel planning experience.
- **🔔 Real-time Notifications:** Keep users updated with instant notifications regarding bookings and itinerary changes for a seamless journey.

## 🛠️ Technologies Used

- **Backend:** Built with **.NET Core Web Api**, providing a RESTful Web API to handle the core operations of the app.
- **Database:** **SQL Server** to securely store and manage all data, including user profiles, preferences, and bookings.
- **Machine Learning:** Integrating the **KNN (K-Nearest Neighbors)** algorithm for intelligent, personalized recommendations based on user preferences and past activities.
- **Security:** Robust authentication and data encryption protocols ensure safe and secure user interactions and data privacy. 🔒

## 🗂️ API Endpoints

### 1. **User Endpoints**

- **POST /api/accounts/register**  
  Register a new user to start their travel adventure.
  
- **POST /api/accounts/login**  
  Login a user and return a JWT token for secure authentication.

- **GET /api/users/{id}**  
  Retrieve the profile of a user by their ID for easy access to personal details.

### 2. **Preference Endpoints**

- **GET /api/preferences/{userId}**  
  Fetch the travel preferences of a user to provide personalized recommendations.

- **POST /api/preferences/{userId}**  
  Update the preferences for a specific user to ensure a tailored travel experience.

### 3. **Booking Endpoints**

- **POST /api/bookings**  
  Create a new booking for hotels, transportation, or activities.

- **GET /api/bookings/{userId}**  
  Get a list of all bookings made by a specific user, making travel planning easier.

### 4. **Activity Management:**
- **/api/activities**
- **/api/activities/{id}**


### 5. Payment Management:
 -  **/api/payments**

### 6. Real-time Notifications:
 - **/api/notifications**

### 7. Monitoring:
 - **/api/monitoring**

## 🛠️Technology Stack

**Backend:** ASP.NET Core MVC
**Database:** SQL Server
**Security**: Robust authentication and data encryption



## 🚀 How to Get Started

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Bishoybotros/YalabenaApi.git

2. **Install Dependencies:** Open the project in Visual Studio, restore NuGet packages, and set up your project.
   ### Packages:
- AutoMapper
- BCrypt.Net-Next
- FluentValidation
- Microsoft.AspNetCore.SignalR
- Microsoft.Data.SqlClient
- Microsoft.IdentityModel.Tokens
- Moq
- Newtonsoft.Json
- Swashbuckle.AspNetCore
- xunit

4. **Set Up SQL Server:** Ensure that SQL Server is installed and the database is properly configured. The database schema is available in the Data/ folder.

5. **Run the Application:** Start the application from Visual Studio, and the API will be up and running, ready to serve your front-end app.

## 🧑‍💻 How to Use the API
Authentication: All sensitive routes require a JWT token for secure access. Tokens are provided after a successful login.

## 👥 Contributing
We welcome contributions! If you're interested in improving the API or adding new features, feel free to fork the repository, make changes, and submit a pull request. Make sure to follow the existing coding standards and guidelines.

📜 License
This project is licensed under the MIT License. See the LICENSE.md file for more information.


