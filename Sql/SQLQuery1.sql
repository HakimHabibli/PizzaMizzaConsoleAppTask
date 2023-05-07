CREATE DATABASE Pizzamizza
Use Pizzamizza
--+
Create Table Categories(
Id int primary key identity ,
Name varchar(50)
)
Create Table Pizzas(
Id int primary key identity,
Name varchar(50),
Description varchar(max),
CategorieId int ,
 Foreign key (CategorieId)  references Categories(Id)
)
-------------
Create Table Images(
Id int primary key identity,
Name int , 
PizzaId int ,
 Foreign key(PizzaId) references Pizzas(Id)

)
-------------
Create Table PizzaTypes(
Id int primary key identity,
PizzaId int,
TypeId int,
 Foreign key (PizzaId) references Pizzas(Id),
 Foreign key (TypeId) references Types(Id)
)
--+
 Create Table Types(
Id int primary key identity,
 Name varchar(30),
 Icon varchar(max)
 )

------------

Create Table PizzaInnergredient(
Id int primary key identity,
PizzaId int ,
InnergredientId int,
 Foreign key(InnergredientId) references Innergredients(Id),
 Foreign key (PizzaId) references Pizzas(Id)
)
--+
Create Table Innergredients(
Id int primary key identity,
Name int 
)

------------
Create Table Prices(
Id int primary key identity,
Price int ,
PizzaId int ,
SizeId int ,
CurrencyId int,
 Foreign key (SizeId) references Sizes(Id),
 Foreign key (CurrencyId) references Currencies(Id),
 Foreign key (PizzaId) references Pizzas(Id)
)
--+
Create Table Sizes(
Id int primary key identity,
Size varchar(20),
SizeValue int
)
--+
Create Table Currencies(
Id int primary key identity,
Name varchar(max)
)

ALTER TABLE Innergredients
ALTER COLUMN Name nvarchar(30);