# Presidio_Data_Migration
## Data Migration Task
# Task 1- MonoApp - 3-Tier Monolithic Application

## Overview

MonoApp is a 3-tier monolithic application that consists of:
- **Frontend**: An ASP.NET Core MVC application.
- **Backend**: An ASP.NET Core Web API.
- **Database**: SQL Server.

This application will later be migrated to a microservices architecture using Docker, where the frontend service will be public, and both backend and database will be private and connect with each other.

## Project Structure

MonoApp/ │ ├── Frontend/ # ASP.NET Core MVC frontend │ ├── Controllers/ # MVC Controllers │ ├── Views/ # MVC Views │ ├── wwwroot/ # Static files (CSS, JS, images) │ ├── Program.cs # Entry point for the frontend │ └── ... # Other frontend files │ ├── Backend/ # ASP.NET Core Web API backend │ ├── Controllers/ # API Controllers │ ├── Models/ # Data models │ ├── Services/ # Business logic services │ ├── Data/ # Database context │ ├── Program.cs # Entry point for the backend │ └── ... # Other backend files │ └── Shared/ # Shared library (models, services) ├── Models/ # Shared models (e.g., Item) ├── Services/ # Shared services 

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Docker](https://www.docker.com/products/docker-desktop) (for the microservices migration)




