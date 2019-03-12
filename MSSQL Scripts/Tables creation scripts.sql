create table Animals 
	(DocEntry int NOT NULL PRIMARY KEY IDENTITY(1,1), AnimalName nvarchar(150) NOT NULL, AnimalType nvarchar(100) NOT NULL, DateOfAdmission DateTime)



select * from Animals

insert into Animals values ('www', 'wwwq', '1998-01-01 23:59:59.997')


drop table Animals

