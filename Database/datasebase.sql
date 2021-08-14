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

create table Songs(
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
    songid int not null REFERENCES songs(id)
)


alter table Singers
add isOfficial int, check (isOfficial=0 or isOfficial=1)
go

INSERT INTO Singers(id, Name, isOfficial) VALUES
	('1', 'Aladin',  '0'),
	('2', 'Cui Yuefeng', '0'),
	('3', 'Dai Chen', '0'),
	('4', 'Dong Pan', '1'),
	('5', 'Fang Xiaodong', '0'),
	('6', 'Guo Hongxu',  '0'),
	('7', 'He Liangchen',  '1'),
	('8', 'He Yilin',  '1'),
	('9', 'Hu Chaozheng',  '0'),
	('10', 'Hu Hao',  '0'),
	('11', 'Huang Mingyu',  '0'),
	('12', 'Liu Quanjun',  '0'),
	('13', 'Liu Yan', '1'),
	('14', 'Mao Er',  '0'),
	('15', 'Song Yuhang', '0'),
	('16', 'Wang Jiaxin',  '0'),
	('17', 'Wang Minhui', '0'),
	('18', 'Wang Shang',  '0'),
	('19', 'Xu Junsho',  '1'),
	('20', 'Xu Kai',  '0'),
	('21', 'Yang Haochen','0'),
	('22', 'Yin Haolun', '0'),
	('23', 'Yin Yuke',  '1'),
	('24', 'Yu Hua ', '0'),
	('25', 'Yuan Guangquan',  '0'),
	('26', 'Zha Xidunzhu',  '0'),
	('27', 'Zhang Bojun',  '0'),
	('28', 'Zhang Yingxi', '1'),
	('29', 'Zhao Chaofan', '0'),
	('30', 'Zhao Fanjia', '0'),
	('31', 'Zhao Yi',  '0'),
	('32', 'Zhao Yue', '1'),
	('33', 'Zhen Qiyuan','1'),
	('34', 'Zheng Yibin', '0'),
	('35', 'Zhao Qi', '0'),
	('36', 'Zhou Shiyuan', '0')

INSERT INTO Songs(id, name) VALUES
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
	('11', 'One Day of the Spring'),
	('12', 'Who am I Indeed'),
	('13', 'How Far I`ll Go'),
	('14', 'Harled`s Song About Love'),
	('15', 'The Power of the Time'),
	('16', 'Musica Che Resta'),
	('17', 'By the Water')
INSERT INTO Performance(singerid, songid) VALUES
	(19,1),
	(33,1),
	(7,2),
	(8,2),
	(4,3),
	(25,3),
	(13,4),
	(35,4),
	(23,5),
	(36,5),
	(28,6),
	(32,6),
	(19,7),
	(33,7),
	(28,8),
	(32,8),
	(4,9),
	(25,9),
	(14,10),
	(6,10),
	(7,11),
	(8,11),
	(3,11),
	(7,12),
	(8,12),
	(13,12),
	(19,13),
	(33,13),
	(18,13),
	(19,14),
	(33,14),
	(9,14),
	(28,15),
	(32,15),
	(6,15),
	(28,16),
	(32,16),
	(31,16)
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

go

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

-- EXEC addSong 12, Hello, 1

-- Select STRING_AGG(s.name, ',') as singers, Song.name as Song_name from Performance as p
-- join singers as s on s.id = p.singerid
-- join Song on Song.id = p.songid
-- where p.songid in (
-- 	select songid from performance as p
-- 	group by p.songid
-- 	having count(p.singerid) = 3
-- )
-- GROUP by p.songid



---//////////////////////////////////////////////////////////////////////////////////////////////////////////


-- go
-- use master
-- go
-- drop DATABASE cs486_team11_DB 




