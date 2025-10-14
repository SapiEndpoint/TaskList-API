# 🚀 TaskList API

API backend per la gestione di task personali e di team, sviluppata in C# con ASP.NET Core.  
Permette di visualizzare/filtrare task o utenti con GET e aggiungere nuovi elementi con POST, completo di validazione dei dati tramite Data Annotations. 
Le operazioni PUT e DELETE sono in sviluppo.

---

## 🏷️ Badge e stato del progetto

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white) 
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-512BD4?logo=dot-net&logoColor=white) 
![Roadmap](https://img.shields.io/badge/CRUD-in%20development-orange) 

---

## 🌟 Features attuali
- ✅ `GET /tasks` → lista tutti i task
- ✅ `GET /tasks/{id}` → filtra la task per l'id
- ✅ `GET /tasks/user/{userId}` → filtra i task per id utente **(nuovo)**
- ✅ `GET /users` → lista tutti gli utenti
- ✅ `GET /users/{id}` → filtra l'utente per l'id
- ✅ `GET /users/lastname/{lastname}` → filtra l'utente per il proprio cognome (da gestire)
- ✅ Controllo esistenza task o utente per id (`Exists`)
- ✅ Gestione `NotFound` e liste vuote nei controller **(nuovo)**
- ✅ `POST /users`, `POST /tasks` → creazione nuovi record con validazione dati tramite Data Annotations e `ModelState.IsValid` **(aggiornato)**
- ✅ Implementato `CreatedAtAction` per le azioni POST **(nuovo)**
- ✅ Risposte JSON standardizzate con messaggi personalizzati (`NotFound`, `null`, ecc.) **(nuovo)**
- 🧩 Gestione DTO e mapping con AutoMapper
- 🔧 `PUT`, `DELETE` → in sviluppo

---

## 🔧 Stack
- **Linguaggi:** C#  
- **Framework & Backend:** .NET, ASP.NET Core, Entity Framework  
- **Database:** SQL Server (livello base)  
- **Tools:** Git, Postman/Swagger

---

## 🧩 Implementazioni recenti
- **UserController:** validazione input, routing aggiornato (`[Route("user")]`, `[HttpGet("/users")]`), gestione liste vuote e risposte JSON standardizzate
- **TaskController:** nuove azioni GET/POST, refactoring metodi, validazione input e `CreatedAtAction`, rinominata azione `GetTaskByUserId` → `GetTaskByUser`
- **ITask:** estensione interfaccia per gestione task utente, aggiunta metodo `GetTaskByUser`
- **TaskRepository:** refactoring metodi per coerenza con interfaccia, rinominato `GetTaskByUserId` → `GetTaskByUser`

---

## 🚧 Roadmap
- ✅ Completamento del metodo POST con DTO, mapping e validazione
- 🔧 Implementazione PUT e DELETE
- 🔐 Autenticazione e autorizzazione con JWT / Identity

---

## 🧠 Tecnologie e concetti chiave
- ASP.NET Core MVC
- Entity Framework Core
- AutoMapper
- DTO Pattern
- Data Annotations (Validazione lato server)
- Standardizzazione risposte JSON

---

## ⚙️ Installazione e avvio
1. Clona il repository:
```bash
git clone https://github.com/tuo-username/TaskList.git
```

2. Entra nella cartella del progetto:
```bash
cd TaskList
```

3. Ripristina i pacchetti NuGet:
```bash
dotnet restore
```

4. Avvia l’applicazione:
```bash
dotnet run
```