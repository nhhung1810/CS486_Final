use master
go
create database CS486_team11_DB
go
use CS486_team11_DB
go

create table Singers(
    id int not null PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
	isOfficial int CHECK(isOfficial in (1, 0))
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

--

create table official(
    singerid int not null REFERENCES Singers(id),
    isOfficial int CHECK(isOfficial in (1, 0))
)

go

create table performance(
    singerid int not null REFERENCES Singers(id),
    songid int not null REFERENCES song(id)
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
	(19, 1),
	(33, 1),
	(7, 2),
	(8, 2),
	(4, 3),
	(25, 3),
	(13, 4),
	(35,4)
INSERT INTO Interview(Interviewer, Interviewee, Score) VALUES
	('19', '33', '10'),
	('19', '22', '4'),
	('19', '15', '7'),
	('7', '10', '6'),
	('7', '3', '3'),
	('7', '8', '10'),
	('4', '32', '5'),
	('4', '27', '3'),
	('4', '25', '9'),
	('13', '35', '10'),
	('13', '29', '5'),
	('13', '16', '5'),
	('23', '9', '4'),
	('23', '36', '10'),
	('23', '20', '7'),
	('28', '31', '6'),
	('28', '12', '3'),
	('28', '32', '9')

---/////////////////////////////////////////////////////////////////////////
GO
CREATE OR ALTER PROCEDURE addInterview
@official int,
@reserve int,
@score int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW

	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @official AND isOfficial = 1)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @reserve AND isOfficial = 0)
		THROW 50000, 'reserve not exist', 1;

	IF ((SELECT COUNT (*)
				FROM Interview
				WHERE interviewer = @official) > 0) 
		THROW 50000, '1 participant must only interview 1 member', 1;

	IF ((SELECT COUNT (*)
				FROM Interview
				WHERE interviewer = @reserve) > 0) 
		THROW 50000, '1 participant must only interview 1 member', 1;


	INSERT INTO Interview (interviewer, interviewee, score) 
					VALUES (@official, @reserve, @score);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE addDuet
@official int,
@reserve int,
@songid int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW
	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @official AND isOfficial = 1)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @reserve AND isOfficial = 0)
		THROW 50000, 'reserve not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Song
					WHERE id = @songid)
		THROW 50000, 'song not exist', 1;

	IF ((SELECT COUNT (*)
				FROM performance
				WHERE singerid = @official) > 0) 
		THROW 50000, '1 participant must only sing 1 song', 1;

	IF ((SELECT COUNT (*)
				FROM performance
				WHERE singerid = @reserve) > 0) 
		THROW 50000, '1 participant must only sing 1 song', 1;


	INSERT INTO performance (singerid, songid) 
			VALUES	(@official, @songid), 
					(@reserve, @songid);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE updateInterviewScore
@official int,
@reserve int,
@score int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW

	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @official AND isOfficial = 1)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @reserve AND isOfficial = 0)
		THROW 50000, 'reserve not exist', 1;


	UPDATE Interview 
	SET score = @score
	WHERE interviewer = @official AND interviewee = @reserve;

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE addPerformance
@singerid int,
@songid int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW
	IF NOT EXISTS ( SELECT *
					FROM Singers
					WHERE id = @singerid )
		THROW 50000, 'singer not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Song
					WHERE id = @songid)
		THROW 50000, 'song not exist', 1;

	INSERT INTO performance (singerid, songid) 
			VALUES	(@singerid, @songid);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE addSong
@id int,
@name NVARCHAR(100),
@number int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW
	IF EXISTS ( SELECT *
					FROM Song
					WHERE id = @id )
		THROW 50000, 'song id already exist', 1;

	IF EXISTS ( SELECT *
					FROM Song
					WHERE name = @name)
		THROW 50000, 'song name already exist', 1;

	INSERT INTO Song (id, name, number) 
			VALUES	(@id, @name, @number);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION;
	THROW;
END CATCH;
GO

SELECT * FROM Song

EXEC addSong 12, Hello, 1


---//////////////////////////////////////////////////////////////////////////////////////////////////////////

use master
go
drop DATABASE CS486_team11_DB