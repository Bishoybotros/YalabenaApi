# 🎉 Yalla Bena Web API 🚀

The **Yalla Bena Web API** is an exciting backend built using **.NET Core MVC** that powers the entire functionality of the **Yalla Bena** travel app. This API serves as the backbone for managing user data, preferences, bookings, and personalized travel recommendations. The goal is to create an unforgettable travel experience for our users! 🌍✈️

## 🔑 Key Features

- **👤 User Management:** Effortlessly handle user registration, login, and profile updates for a smooth user experience.
- **💡 Preference Management:** Empower users to set and update their travel preferences, such as budget, destinations, and activity types.
- **🏨 Booking System:** Streamline the process of booking hotels, transportation, and activities, all in one place!
- **🤖 Recommendation Engine:** Leverage cutting-edge machine learning models (KNN) to deliver personalized recommendations that enhance each user's travel planning experience.
- **🔔 Real-time Notifications:** Keep users updated with instant notifications regarding bookings and itinerary changes for a seamless journey.

## 🛠️ Technologies Used

- **Backend:** Built with **.NET Core MVC**, providing a RESTful Web API to handle the core operations of the app.
- **Database:** **SQL Server** to securely store and manage all data, including user profiles, preferences, and bookings.
- **Machine Learning:** Integrating the **KNN (K-Nearest Neighbors)** algorithm for intelligent, personalized recommendations based on user preferences and past activities.
- **Security:** Robust authentication and data encryption protocols ensure safe and secure user interactions and data privacy. 🔒

## 🗂️ API Endpoints

### 1. **User Endpoints**

- **POST /api/users/register**  
  Register a new user to start their travel adventure.
  
- **POST /api/users/login**  
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

### 4. **Recommendation Endpoints**

- **GET /api/recommendations/{userId}**  
  Fetch dynamic, personalized travel recommendations based on a user's preferences. Whether it's hotels, transport, or activities, we've got it covered! 🌟

## 📂 Project Structure

The backend API is organized in a clean, modular structure to ensure maintainability and scalability:

