create database foy4 ON PRIMARY
(
NAME = vtys_data,
FILENAME = 'D:\vtys\foy4\vtysdata.mdf',
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)
LOG ON
(
NAME = vtys_log,
FILENAME = 'D:\vtys\foy4\vtysdata.ldf',
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)