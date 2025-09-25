# 🚀 TaskList API

API backend per la gestione di task personali e di team, sviluppata in C# con ASP.NET Core.  
Permette di visualizzare/filtrare taskGET, mentre le altre operazioni CRUD sono in fase di sviluppo.

---

## 🏷️ Badge e stato del progetto

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white) 
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-512BD4?logo=dot-net&logoColor=white) 
![Stato](https://img.shields.io/badge/Features-GET_only-yellow)
![Roadmap](https://img.shields.io/badge/CRUD-in%20development-orange) 

---

## 🌟 Features attuali
- ✅ `GET /api/tasks` → lista tutti i task
- ✅ `GET /api/tasks/{id}` → filtra la task per l'id
- ✅ `GET /api/users` → lista tutti gli utenti
- ✅ `GET /api/users/{id}` → filtra l'utente per l'id
- ✅ `GET /api/users/lastname/{lastname}` → filtra l'utente per il proprio cognome (da gestire)
- 🔧`Altre operazioni CRUD` → in sviluppo 

---

## 🔧 Stack
- **Linguaggi:** C#  
- **Framework & Backend:** .NET, ASP.NET Core, Entity Framework  
- **Database:** SQL Server (livello base)  
- **Tools:** Git, Postman/Swagger

---

## 🚧 Roadmap
- Completamento delle operazioni POST, PUT e DELETE  
- Implementazione di autenticazione e autorizzazione con JWT / Identity  

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
