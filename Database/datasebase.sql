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
					FROM Singer
					WHERE id = @official AND isOfficial = 1)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Singer
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
					FROM Singer
					WHERE id = @official AND isOfficial = 1)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Singer
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
					FROM Singer
					WHERE id = @official AND isOfficial = 1)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Singer
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
