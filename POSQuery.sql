CREATE DATABASE POS; 

USE POS;

CREATE TABLE "Users" (
    "ID" int IDENTITY(1,1) PRIMARY KEY,
    "Username" varchar(40) NOT NULL,
    "Password" varchar(40) NOT NULL
);

CREATE TABLE "Countries" (
    "ID" int IDENTITY(1,1) PRIMARY KEY,
    "Name" varchar(40) NOT NULL,
    "Vat" int NOT NULL
);

CREATE TABLE "Articles" (
    "ID" int IDENTITY(1,1) PRIMARY KEY,
    "Name" varchar(40) NOT NULL,
    "Price" decimal(18,2) NOT NULL
);

CREATE TABLE "CountryArticle" (
    "ID" int IDENTITY(1,1) PRIMARY KEY,
    "CountryID" int FOREIGN KEY REFERENCES Countries(ID),
    "ArticleID" int FOREIGN KEY REFERENCES Articles(ID)
);

CREATE TABLE "Payslip" (
    "ID" int IDENTITY(1,1) PRIMARY KEY,
    "DatePayslip" date NOT NULL,
    "Total" decimal(18,2),
	"TotalVAT" decimal(18,2),
);


CREATE TABLE "PayslipArticle" (
    "ID" int IDENTITY(1,1) PRIMARY KEY,
    "CountryArticleID" int FOREIGN KEY REFERENCES CountryArticle(ID),
    "PayslipID" int FOREIGN KEY REFERENCES Payslip(ID),
	"Quantity" int NOT NULL
);

INSERT "Articles" VALUES
('Hleb', '50.00'),
('Zacin', '60.00'),
('So', '49.99'),
('Secer', '69.99'),
('Kifla', '29.99'),
('Kikiriki', '45.00'),
('Smoki', '39.99'),
('Koka-kola', '105.00'),
('Knjaz Milos', '45.00'),
('Semenke', '40.00'),
('Cips', '55.00'),
('Zvake', '2.00'),
('Kafa', '55.00'),
('Cokoladno mleko', '60.00'),
('Bombone', '70.00'),
('Maramice', '39.99'),
('Jelen pivo', '70.00'),
('Lav pivo', '80.00'),
('Zajecarsko pivo', '60.00')


INSERT "Countries" VALUES
('Srbija', '18'),
('Hrvatska', '20'),
('Crna Gora', '19'),
('Makedonija', '21')

INSERT "CountryArticle" VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(1, 16),
(1, 17),
(1, 18),
(1, 19),
(2, 1),
(2, 2),
(2, 5),
(2, 6),
(2, 8),
(2, 9),
(2, 10),
(2, 13),
(2, 14),
(2, 15),
(2, 18),
(3, 1),
(3, 7),
(3, 8),
(3, 9),
(3, 10),
(3, 12),
(3, 13),
(3, 17),
(3, 18),
(3, 19),
(4, 1),
(4, 2),
(4, 3),
(4, 4),
(4, 5),
(4, 7),
(4, 8),
(4, 9),
(4, 10),
(4, 15),
(4, 16),
(4, 17),
(4, 19)

INSERT "Users" VALUES
('Admin', '1'),
('Tina', '123'),
('Pera', '123')

INSERT "Payslip" VALUES
('5/3/2018', 0.00, 0.00)

INSERT "PayslipArticle" VALUES
(1,1,5),
(2,1,3),
(3,1,1),
(7,1,2),
(10,1,1),
(12,1,1),
(15,1,1),
(19,1,2)




SELECT Articles.Name, Countries.Name FROM CountryArticle inner join Countries on CountryArticle.CountryID = Countries.ID inner join Articles on CountryArticle.ArticleID = Articles.ID;

SELECT Articles.Name as article_name, Countries.Name as country_name, PayslipArticle.Quantity
FROM PayslipArticle inner join CountryArticle on PayslipArticle.CountryArticleID = CountryArticle.ID
inner join Articles on CountryArticle.CountryID = Articles.ID 
inner join Countries on CountryArticle.ArticleID = Articles.ID where PayslipID=1;

select c.name as country, a.name as article, a.Price as price, pa.Quantity as quantity, (price*quantity) as total from PayslipArticle as pa, 
												Countries as c,
												Articles as a,
												CountryArticle as ca
		where pa.PayslipID=1 and pa.CountryArticleID = ca.ID and ca.CountryID = c.id and ca.ArticleID = a.ID;
		 

INSERT INTO Payslip (DatePayslip) VALUES ('1/3/2018')
SELECT ID FROM Payslip WHERE DatePayslip = '30/3/2018';

Select * from Payslip 

SELECT CountryArticleID FROM dbo.PayslipArticle WHERE (PayslipID = 33)

SELECT PayslipArticle.ID, PayslipArticle.CountryArticleID, PayslipArticle.PayslipID, PayslipArticle.Quantity 
FROM PayslipArticle inner join CountryArticle on PayslipArticle.CountryArticleID = CountryArticle.ID 
where (CountryArticle.CountryID = 3)

SELECT * FROM Payslip as ps, PayslipArticle as pa
inner join CountryArticle on pa.CountryArticleID = CountryArticle.ID 
where CountryArticle.CountryID = 1;


--SElect PayslipArticle.* from PayslipArticle, CountryArticle where CountryArticle.CountryID = 1 group by PayslipArticle.PayslipID;
--select Payslip.*, (SELECT  from Countries whre) as country from Payslip where


SELECT * FROM Payslip where DatePayslip BETWEEN '5/3/2018' and '15/3/2018';

SELECT * FROM Payslip where DatePayslip <= convert(date,'12/3/2018') or DatePayslip >= convert(date,'20/3/2018')

SELECT TOP 20 PERCENT * FROM CountryArticle where CountryID = 1



select TOP 10 * from Articles where Articles.ID IN (select MAX(Articles.ID) from CountryArticle, PayslipArticle, Articles where CountryArticle.CountryID=1 and CountryArticle.ID = PayslipArticle.CountryArticleID and CountryArticle.ArticleID = Articles.ID GROUP BY Articles.Name)

select SUM(PayslipArticle.Quantity) as total, Articles.Name from CountryArticle, PayslipArticle, Articles where CountryArticle.CountryID=1 and CountryArticle.ID = PayslipArticle.CountryArticleID and CountryArticle.ArticleID = Articles.ID GROUP BY Articles.Name


select * from Articles where Articles.ID IN (select MAX(Articles.ID) from PayslipArticle, CountryArticle, Articles where CountryArticle.ID = PayslipArticle.CountryArticleID and CountryArticle.ArticleID = Articles.ID GROUP BY Articles.Name HAVING SUM(PayslipArticle.Quantity) >= 1) 

select SUM(PayslipArticle.Quantity) as total, Articles.Name from PayslipArticle, CountryArticle, Articles where CountryArticle.ID = PayslipArticle.CountryArticleID and CountryArticle.ArticleID = Articles.ID GROUP BY Articles.Name HAVING SUM(PayslipArticle.Quantity) >= 1


select * from Articles where Articles.ID NOT IN (select CountryArticle.ArticleID from PayslipArticle, CountryArticle where CountryArticle.ID = PayslipArticle.CountryArticleID) 



select * from Payslip where Payslip.ID IN (select Payslip.ID from Payslip, PayslipArticle, CountryArticle where PayslipArticle.PayslipID = Payslip.ID and CountryArticle.ID = PayslipArticle.CountryArticleID and CountryArticle.CountryID=1 GROUP BY Payslip.ID)

select MAX(Payslip.Total), MAX(Payslip.TotalVAT), Payslip.ID from Payslip, PayslipArticle, CountryArticle where PayslipArticle.PayslipID = Payslip.ID and CountryArticle.ID = PayslipArticle.CountryArticleID and CountryArticle.CountryID=1 GROUP BY Payslip.ID



ALTER DATABASE POS  
Modify Name = POSRename; 