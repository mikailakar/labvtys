create database foy5 ON PRIMARY
(
NAME = vtys_data,
FILENAME = 'D:\vtys\foy5\vtysdata.mdf',
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)
LOG ON
(
NAME = vtys_log,
FILENAME = 'D:\vtys\foy5\vtysdata.ldf',
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)