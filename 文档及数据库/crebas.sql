drop table Customer;

drop table "Order";

drop table Region;

drop table Shoe;

drop table ShoeItem;

drop table Stock;

drop table Store;

create table Customer (
CustomerId           INTEGER                        not null,
CustomerName         VARCHAR(20),
Phone                VARCHAR(15)                    not null,
Score                FLOAT                          not null,
primary key (CustomerId)
);

create table "Order" (
OrderId              INTEGER                        not null,
CustomerId           INTEGER,
SaleTime             DATE                           not null,
TotalPrice           FLOAT                          not null,
primary key (OrderId),
foreign key (CustomerId)
      references Customer (CustomerId)
);

create table Region (
RegionId             INTEGER                        not null,
RegionName           VARCHAR(50)                    not null,
RegionAddress        VARCHAR(50)                    not null,
primary key (RegionId)
);

create table Stock (
StockId              INTEGER                        not null,
StockTime            DATE                           not null,
StockCount           INTEGER                        not null,
StockCompany         VARCHAR(30),
primary key (StockId)
);

create table Shoe (
ShoeId               INTEGER                        not null,
StockId              INTEGER,
ThingId              INTEGER                        not null,
OriginMoney          FLOAT                          not null,
Price                FLOAT                          not null,
Gender               SMALLINT                       not null,
Season               VARCHAR(20)                    not null,
ShoeType             VARCHAR(20)                    not null,
primary key (ShoeId),
foreign key (StockId)
      references Stock (StockId)
);

create table ShoeItem (
ShoeItemId           INTEGER                        not null,
OrderId              INTEGER,
ShoeId               INTEGER,
IsSell               SMALLINT                       not null,
Color                VARCHAR(10)                    not null,
"Size"               SMALLINT                       not null,
SellPrice            FLOAT                          not null,
primary key (ShoeItemId),
foreign key (OrderId)
      references "Order" (OrderId),
foreign key (ShoeId)
      references Shoe (ShoeId)
);

create table Store (
StoreId              INTEGER                        not null,
ShoeItemId           INTEGER,
RegionId             INTEGER,
MoreInfo             VARCHAR(50),
primary key (StoreId),
foreign key (ShoeItemId)
      references ShoeItem (ShoeItemId),
foreign key (RegionId)
      references Region (RegionId)
);

