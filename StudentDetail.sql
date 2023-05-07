create table StudentDetails
{
Student ID int Primary key identity,
StudentName varchar (50) not null,
StudentAddress nvarchar(100) not null,
City varchar(20) not null,
Phone numeric (10,0)not null,
DateOfBirth date not null,
gender varchar(10)not null,
qualification varchar(50) not null,
studentImage nvarchar(500)not null;
} 