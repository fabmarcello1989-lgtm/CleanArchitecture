# # DigitalPaymentsApi

DigitalPaymentsApi è una Web API sviluppata con .NET 8, progettata per gestire pagamenti digitali e utenti. Il progetto segue i principi della Clean Architecture e utilizza MediatR per implementare il pattern CQRS. L'intera applicazione è containerizzata con Docker e utilizza SQL Server come database relazionale.

---

## 🧱 Architettura

- **.NET 8 Web API**
- **Clean Architecture** (Domain, Application, Infrastructure, API)
- **MediatR** per CQRS (Command/Query Separation)
- **Entity Framework Core** per accesso ai dati
- **SQL Server** come database
- **Docker** e `docker-compose` per orchestrazione

---

## 🚀 Funzionalità

### 👤 Gestione utenti
- `POST /api/users` → Inserisce un nuovo utente
- `GET /api/users` → Restituisce tutti gli utenti

### 💳 Gestione pagamenti
- `GET /api/payments` → Restituisce tutti i pagamenti
- `GET /api/payments/{id}` → Restituisce un pagamento per ID

---

## 🛠️ Avvio rapido

### 1. Clona il repository


git clone https://github.com/tuo-utente/DigitalPaymentsApi.git
cd DigitalPaymentsApi
docker-compose up --build

DigitalPaymentsApi/
├── Controllers/
├── Features/
│   ├── Payments/
│   └── Users/
├── Domain/
├── Application/
├── Infrastructure/
├── Dockerfile
├── docker-compose.yml
└── appsettings.Development.json


Dipendenze principali

Microsoft.EntityFrameworkCore.SqlServer
MediatR
Microsoft.AspNetCore.Authentication.JwtBearer (se usi autenticazione)
Swashbuckle.AspNetCore (Swagger)