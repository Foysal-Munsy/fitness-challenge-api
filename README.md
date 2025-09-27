# Fitness Challenge API

A fitness tracking REST API built with **ASP.NET Web API**, **Entity Framework (Code-First)**, and **MS SQL Server**, following **3-tier architecture** and **SOLID principles**.

---

## Tech Stack
- **Backend:** ASP.NET Web API  
- **ORM:** Entity Framework Core (Code-First)  
- **Database:** MS SQL Server  
- **Architecture:** 3-Tier (DAL, BLL, Application Layer)  
- **Principles:** SOLID, Clean Code  

---

## Features & Endpoints

### Users
- `GET    /api/users/all` → Get all users  
- `POST   /api/users/create` → Create user  
- `GET    /api/users/{id}` → Get user by ID  
- `PATCH  /api/users/update/{id}` → Update user  
- `DELETE /api/users/delete/{id}` → Delete user  
- `GET    /api/users/bmi/{id}` → Calculate BMI  
- `GET    /api/users/recommendation/{id}` → Workout recommendation based on BMI  
- `GET    /api/users/leaderboard` → Leaderboard by calories burned  
- `GET    /api/users/goal-status/{id}` → Check daily calories goal  

### Workouts
- `GET    /api/workouts/all` → Get all workouts  
- `GET    /api/workouts/filter?from=YYYY-MM-DD&to=YYYY-MM-DD` → Filter by date  

---

## API Testing (Postman Screenshots)

**BMI**  
![BMI](https://github.com/Foysal-Munsy/Foysal-Munsy/blob/main/fitness-challenge-api-readme-supported-image/bmi.png?raw=true)

**Workout Filtering**  
![Filtering](https://github.com/Foysal-Munsy/Foysal-Munsy/blob/main/fitness-challenge-api-readme-supported-image/filtering.png?raw=true)

**Goal Status**  
![Goal Status](https://github.com/Foysal-Munsy/Foysal-Munsy/blob/main/fitness-challenge-api-readme-supported-image/goal-status.png?raw=true)

**Leaderboard**  
![Leaderboard](https://github.com/Foysal-Munsy/Foysal-Munsy/blob/main/fitness-challenge-api-readme-supported-image/leaderboard.png?raw=true)

**Recommendation**  
![Recommendation](https://github.com/Foysal-Munsy/Foysal-Munsy/blob/main/fitness-challenge-api-readme-supported-image/recommendation.png?raw=true)

---

## Plan
- Add **advanced features** (e.g., analytics, streak tracking, custom challenges)  
- Extend API for **frontend integration** (since it follows MVC pattern)  
- Improve **recommendation system** with more parameters  
