create database vtysdeneme ON PRIMARY
(
NAME = vtys_data,
FILENAME = 'D:\vtys\denemedev\vtysdata.mdf',
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)
LOG ON
(
NAME = vtys_log,
FILENAME = 'D:\vtys\denemedev\vtysdata.ldf',
SIZE = 8MB,
MAXSIZE = unlimited,
FILEGROWTH = 10%
)