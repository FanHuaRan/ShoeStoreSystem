/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2017/2/6 12:34:22                            */
/*==============================================================*/


drop table if exists Customer;

drop table if exists Region;

drop table if exists Sale;

drop table if exists Season;

drop table if exists Shoe;

drop table if exists Stock;

drop table if exists StockCompany;

drop table if exists Store;

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer
(
   CustomerId           bigint not null auto_increment,
   CustomerName         varchar(20) not null,
   Phone                varchar(15) not null,
   Score                float not null,
   primary key (CustomerId)
);

alter table Customer comment '可以针对积分在销售表中增加触发器';

/*==============================================================*/
/* Table: Region                                                */
/*==============================================================*/
create table Region
(
   RegionId             int not null auto_increment,
   RegionName           varchar(50) not null,
   RegionAddress        varchar(50) not null,
   primary key (RegionId)
);

/*==============================================================*/
/* Table: Sale                                                  */
/*==============================================================*/
create table Sale
(
   SaleId               bigint not null auto_increment,
   CustomerId           bigint,
   Phone                varchar(15),
   SaleTime             datetime not null,
   TotalPrice           float,
   primary key (SaleId)
);

/*==============================================================*/
/* Table: Season                                                */
/*==============================================================*/
create table Season
(
   SeasonId             int not null auto_increment,
   SeasonName           varchar(10) not null,
   primary key (SeasonId)
);

alter table Season comment '并不是单纯的季节，而是包括全季、春夏等';

/*==============================================================*/
/* Table: Shoe                                                  */
/*==============================================================*/
create table Shoe
(
   ShoeId               bigint not null auto_increment,
   SeasonId             int not null,
   SaleId               bigint,
   StockId              bigint,
   ThingId              int not null,
   Color                varchar(10) not null,
   Size                 smallint not null,
   Price                float not null,
   IsSell               tinyint not null,
   SellPrice            float,
   primary key (ShoeId)
);

alter table Shoe comment 'IsSell:0 未售 1代售';

/*==============================================================*/
/* Table: Stock                                                 */
/*==============================================================*/
create table Stock
(
   StockId              bigint not null auto_increment,
   StockCompanyId       int not null,
   StockTime            datetime not null,
   StockCount           int not null,
   primary key (StockId)
);

/*==============================================================*/
/* Table: StockCompany                                          */
/*==============================================================*/
create table StockCompany
(
   StockCompanyId       int not null auto_increment,
   StockCompanyName     varchar(30) not null,
   primary key (StockCompanyId)
);

/*==============================================================*/
/* Table: Store                                                 */
/*==============================================================*/
create table Store
(
   StoreId              bigint not null auto_increment,
   ShoeId               bigint not null,
   RegionId             int not null,
   MoreInfo             varchar(50),
   primary key (StoreId)
);

alter table Sale add constraint FK_Reference_5 foreign key (CustomerId)
      references Customer (CustomerId) on delete restrict on update restrict;

alter table Shoe add constraint FK_Reference_3 foreign key (SeasonId)
      references Season (SeasonId) on delete restrict on update restrict;

alter table Shoe add constraint FK_Reference_4 foreign key (SaleId)
      references Sale (SaleId) on delete restrict on update restrict;

alter table Shoe add constraint FK_Reference_7 foreign key (StockId)
      references Stock (StockId) on delete restrict on update restrict;

alter table Stock add constraint FK_Reference_6 foreign key (StockCompanyId)
      references StockCompany (StockCompanyId) on delete restrict on update restrict;

alter table Store add constraint FK_Reference_1 foreign key (ShoeId)
      references Shoe (ShoeId) on delete restrict on update restrict;

alter table Store add constraint FK_Reference_2 foreign key (RegionId)
      references Region (RegionId) on delete restrict on update restrict;

