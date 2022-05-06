create database QuanLyQuanCafe
go
use QuanLyQuanCafe
go

/*
Food
Table
FoodCategory
Account
Bill
BillInfo
*/

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống', -- Trống || co nguoi
)
go
create table Account
(
		UserName nvarchar(100) primary key,
		DisplayName nvarchar(100) not null default N'Đoàn Quang Huy',
		PassWord nvarchar(1000) not null default 0,
		Type int not null default 0 -- 1:admin || 0: staff
)
go
create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
go
create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0
	Foreign key (idCategory) references FoodCategory(id)
)
go
create table Bill
(
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DateCheckOut Date,
	idTable int not null,
	status int not null default 0 -- 1: thanh toan && 0: chua thanh toan
	Foreign key (idTable) references TableFood(id)
)
go
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0
	Foreign key (idBill) references Bill(id),
	Foreign key (idFood) references Food(id)
)
go