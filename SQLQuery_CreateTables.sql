CREATE TABLE Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	CONSTRAINT FK_CarsBrand FOREIGN KEY (BrandId)
    REFERENCES Brands(Id),
	CONSTRAINT FK_CarsColor FOREIGN KEY (ColorId)
    REFERENCES Colors(Id),	
)

CREATE TABLE Colors(
	Id int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Brands(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)


INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2012','130','Manual Gasoline'),
	('1','3','2015','110','Automatic Diesel'),
	('2','1','2017','200','Automatic Hybrid'),
	('3','3','2014','100','Manual Diesel');

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Mavi');


INSERT INTO Brands(BrandName)
VALUES
	('Mercedes'),
	('BMW'),
	('Renault');