use master
go
create database CS486_team11_DB
go
use CS486_team11_DB
go

create table Singers(
    id int not null PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
)

go

create table Song(
    id int NOT NULL PRIMARY KEY,
    name NVARCHAR(100) NOT null,
    number int check(number in (1, 2, 3)) -- only in 1, 2, 3
)

go


-- Note: Interview chi cho ep3 va cau 3
create table Interview(
    interviewer int NOT NULL REFERENCES Singers(id),
    interviewee int not null REFERENCES Singers(id),
    score int not null
)


go

create table performance(
    singerid int not null REFERENCES Singers(id),
    songid int not null REFERENCES song(id)
)

create table qualify(
	singerid int not null REFERENCES Singers(id)
)


alter table Singers
add isOfficial int, check (isOfficial=0 or isOfficial=1)
go

INSERT INTO Singers(id, Name, isOfficial) VALUES
	('1', 'Aladin',  '0'),
	('2', 'Cui Yuefeng', '0'),
	('3', 'Dai Chen', '0'),
	('4', 'Dong Pan', '1')
INSERT INTO Song(id, name) VALUES
	('1', 'La Gloire a Mes Genoux'),
	('2', 'Standchen'),
	('3', 'Moscow Nights'),
	('4', 'Ache'),
	('5', 'I, I'),
	('6', 'Caruso'),
	('7', 'That Time'),
	('8', 'Funicul, Funicul'),
	('9', 'Can,t Help Falling in Love'),
	('10', 'To Roam About'),
	('11', 'One Day of the Spring')
INSERT INTO Performance(singerid, songid) VALUES
	(1, 1),
	(3, 1),
	(4, 2),
	(4, 2),
	(1, 3),
	(2, 3),
	(2, 4),
	(3, 4),
	(4, 4)
-- INSERT INTO Interview(Interviewer, Interviewee, Score) VALUES
-- 	('19', '33', '10'),
-- 	('19', '22', '4'),
-- 	('19', '15', '7'),
-- 	('7', '10', '6'),
-- 	('7', '3', '3'),
-- 	('7', '8', '10'),
-- 	('4', '32', '5'),
-- 	('4', '27', '3'),
-- 	('4', '25', '9'),
-- 	('13', '35', '10'),
-- 	('13', '29', '5'),
-- 	('13', '16', '5'),
-- 	('23', '9', '4'),
-- 	('23', '36', '10'),
-- 	('23', '20', '7'),
-- 	('28', '31', '6'),
-- 	('28', '12', '3'),
-- 	('28', '32', '9')

go
Select STRING_AGG(s.name, ',') as singers, Song.name as Song_name from Performance as p
join singers as s on s.id = p.singerid
join Song on Song.id = p.songid
GROUP by p.songid


go
use master
go
drop database CS486_team11_DB