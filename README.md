# 🚀 TaskList API

API backend per la gestione di task personali e di team, sviluppata in C# con ASP.NET Core.  
Permette di visualizzare/filtrare task o utenti con GET e aggiungere nuovi elementi con POST, completo di validazione dei dati tramite Data Annotations. 
Le operazioni PUT e DELETE sono in sviluppo.

---

## 🏷️ Badge e stato del progetto

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white) 
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-512BD4?logo=dot-net&logoColor=white) 
![Stato](https://img.shields.io/badge/Features-GET_only-yellow)
![Roadmap](https://img.shields.io/badge/CRUD-in%20development-orange) 

---

## 🌟 Features attuali
- ✅ `GET /tasks` → lista tutti i task
- ✅ `GET /tasks/{id}` → filtra la task per l'id
- ✅ `GET /users` → lista tutti gli utenti
- ✅ `GET /users/{id}` → filtra l'utente per l'id
- ✅ `GET /users/lastname/{lastname}` → filtra l'utente per il proprio cognome (da gestire)
- ✅ `Exists` → controllo esistenza task o utente per id
- ✅ Gestione `NotFound` nei controller con `if` di controllo
- ✅ `POST /users`, `POST /tasks` → creazione nuovi record con validazione dati tramite Data Annotations
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
- Aggiunto metodo **POST** in interfacce, repository e controller con supporto `[FromBody]`
- Creati **DTO** per la gestione dei dati in input e configurata la mappatura con **AutoMapper**
- Implementata **validazione dei dati** tramite **Data Annotations** con messaggi d’errore personalizzati
- Aggiornata richiesta **GET /users** per includere anche `IdUser` nella risposta

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