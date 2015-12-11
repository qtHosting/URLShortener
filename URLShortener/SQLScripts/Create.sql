CREATE DATABASE db_URL_SHORTENER;

CREATE TABLE tblUsers
(
	intUserID int primary key identity(1,1),
	vcFirstName varchar(100) not null,
	vcLastName varchar(100) not null,
	vcUserName varchar(200) not null,
	vcEmail varchar(250) not null,
	vcPassword varchar(200) not null,
	vcSalt varchar(20) not null,
	intActive int not null default 0
);

CREATE TABLE tblLoginHistory
(
	intHistoryID int primary key identity(1,1),
	intUserID int foreign key references tblUsers(intUserID),
	dtDateLoginAttempt DateTime default getdate(),
	vcIPAddress varchar(60) not null,
	intActive int not null default 1
);

CREATE TABLE tblEmailVerification
(
	intEmailVerificationID int primary key identity(1,1),
	vcEmailKey varchar(30) not null,
	dtDateTimeRequest datetime not null default getdate(),
	dtDateTimeVerified datetime null default null,
	intActive int default 0
);

CREATE TABLE tblResetPassword
(
	intResetPasswordID int primary key identity(1,1),
	vcResetKey varchar(200),
	intUserID int foreign key references tblUsers(intUserID),
	vcIPAddress varchar(60) not null,
	dtDateTimeRequested datetime not null default getdate(),
	dtDateTimeReset datetime null default null,
	intActive int not null default 1
);

CREATE TABLE tblAPIKeys
(
	intAPIID int primary key identity(1,1),
	vcAPIKey varchar(75),
	intUserID int foreign key references tblUsers(intUserID),
	intActive int not null default 0
);

CREATE TABLE tblURLS
(
	intURLID int primary key identity(1,1),
	vcURL varchar(max) not null,
	intAPIID int foreign key references tblAPIKeys(intAPIID),
	intActive int not null default 1
);

CREATE TABLE tblAccessHistory
(
	intAccessID int primary key identity(1,1),
	intURLID int foreign key references tblURLS(intURLID),
	dtDateVisited datetime not null default getdate(),
	vcIPAddress varchar(45) not null,
	intActive int not null default 1
);