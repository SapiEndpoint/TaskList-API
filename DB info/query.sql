
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE users (
        id_user int IDENTITY(1,1) PRIMARY KEY,
        first_name varchar(255) NOT NULL,
        last_name varchar(255) NOT NULL
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'task_management' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE task_management (
        id_task int IDENTITY(1,1) PRIMARY KEY,
        id_user int NOT NULL,
        task varchar(255) NOT NULL,
        task_status bit NOT NULL DEFAULT 0,
        FOREIGN KEY (id_user) REFERENCES users(id_user)
    );
END
GO

INSERT INTO users(first_name, last_name) VALUES 
('Luka', '  '),
('Andrea', 'Marcin'),
('Enrison', 'Olihood');

INSERT INTO task_management(id_user, task, task_status) VALUES 
(1, 'Read a book', 0),
(2, 'Studing history', 1),
(3, 'Drawing', 1),
(2, 'Call Marcus for job', 0),
(1, 'Create an API project', 1),
(3, 'Learn c#', 0);
