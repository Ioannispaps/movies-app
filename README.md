# Movies App

Full-stack εφαρμογή ταινιών.

## Τεχνολογίες
- ASP.NET Core Web API (.NET 10)
- Clean Architecture (Core, Application, Infrastructure, API)
- CQRS με MediatR
- Entity Framework Core + SQLite
- React (Vite)

## Πώς να τρέξει

Backend:

    dotnet run --project Movies.API

(τρέχει στο http://localhost:5012)

Frontend:

    cd movies-web
    npm install
    npm run dev

(τρέχει στο http://localhost:5173)

## Endpoints
- GET /api/movies
- POST /api/movies

## Επόμενα βήματα
- Delete και Update
- Validation
- Αναζήτηση ανά σκηνοθέτη
