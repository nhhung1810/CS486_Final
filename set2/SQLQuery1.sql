USE master
go
create database CS468_team11_DB_test
GO
use CS468_team11_DB
go
---/////////////////////////////////////////////////////////////



---/////////////////////////////////////////////////////////////
go
use master
go
DROP DATABASE CS468_team11_DB_test

---/////////////////////////////////////////////////////////////

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
					WHERE id = @official OR id = @reserve )
		THROW 50000, 'id not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Official
					WHERE id = @official)
		THROW 50000, 'official not exist', 1;

	IF NOT EXISTS ( SELECT *
					FROM Reserve
					WHERE id = @reserve)
		THROW 50000, 'reserve not exist', 1;

	IF ((SELECT COUNT (*)
				FROM Interview
				WHERE interviewer = @official) > 1) 
		THROW 50000, '1 participant must only interview 1 member', 1;

	IF ((SELECT COUNT (*)
				FROM Interview
				WHERE interviewer = @reserve) > 1) 
		THROW 50000, '1 participant must only interview 1 member', 1;


	INSERT INTO Interview (interviewer, interviewww, score) 
					VALUES (@official, @reserve, @score);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRASACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE addDuet
@official int,
@reserve int,
@score int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW
	IF NOT EXISTS ( SELECT * 
					FROM Participate
					WHERE ID = @interviewerID OR ID = @interviewedID)
		THROW 50000, 'id not exist', 1;

	IF NOT EXISTS (SELECT *
					FROM Official
					WHERE ID = @adderID) 
		THROW 50000, 'only official can choose duet member', 1;

	IF NOT EXISTS (SELECT *
					FROM Reserve
					WHERE ID = @addedID)
		THROW 50000, 'chosen duet member must come from reserve', 1;

	INSERT INTO DuetTable (adderID, addedID) VALUES (@adderID, @addedID);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRASACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE updateInterviewScore
@interviewer int,
@interviewww int,
@score int
AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW
	IF NOT EXISTS ( SELECT * 
					FROM Singer
					WHERE ID = @interviewer OR ID = @interviewww )
		THROW 50000, 'id not exist', 1;

	IF ((SELECT COUNT (*)
				FROM Interview
				WHERE interviewer = @interviewer) > 1) 
		THROW 50000, '1 participant must only interview 1 member', 1;

	UPDATE Interview (interviewer, interviewww, score) VALUES (@interviewer, @interviewww, @score);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRASACTION;
	THROW;
END CATCH;
GO

CREATE OR ALTER PROCEDURE updateDuet
@adderID int,
@addedID int

AS
BEGIN TRANSACTION
BEGIN TRY
	--IF LEGIT INSERT
	--ELSE THROW
	IF NOT EXISTS ( SELECT * 
					FROM Participate
					WHERE ID = @interviewerID OR ID = @interviewedID)
		THROW 50000, 'id not exist', 1;

	IF NOT EXISTS (SELECT *
					FROM Official
					WHERE ID = @adderID) 
		THROW 50000, 'only official can choose duet member', 1;

	IF NOT EXISTS (SELECT *
					FROM Reserve
					WHERE ID = @addedID)
		THROW 50000, 'chosen duet member must come from reserve', 1;

	INSERT INTO DuetTable (adderID, addedID) VALUES (@adderID, @addedID);

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
	ROLLBACK TRASACTION;
	THROW;
END CATCH;
GO