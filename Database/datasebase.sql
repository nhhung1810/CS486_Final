use master
go
create database CS486_team11_DB
go
use CS486_team11_DB
go

create table Singer(
    id int not null PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
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
    interviewer int NOT NULL REFERENCES SInger(id),
    interviewww int not null REFERENCES singer(id),
    score int not null
)

--
create table official(
    singerid int not null REFERENCES singer(id),
    isOfficial int CHECK(isOfficial in (1, 0))
)

go

create table performance(
    singerid int not null REFERENCES singer(id),
    songid int not null REFERENCES song(id)
)

go
use master
go
drop DATABASE CS486_team11_DB

