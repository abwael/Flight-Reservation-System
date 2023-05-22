/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     21/05/2023 10:32:11 PM                       */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AIRCRAFT') and o.name = 'FK_AIRCRAFT_ADDS_UPDA_ADMIN')
alter table AIRCRAFT
   drop constraint FK_AIRCRAFT_ADDS_UPDA_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING_FLIGHT')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING2_PASSENGE')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING2_PASSENGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING3_SEAT')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING3_SEAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_ADD_UPDAT_ADMIN')
alter table FLIGHT
   drop constraint FK_FLIGHT_ADD_UPDAT_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLIGHT') and o.name = 'FK_FLIGHT_FLIES_AIRCRAFT')
alter table FLIGHT
   drop constraint FK_FLIGHT_FLIES_AIRCRAFT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFT')
            and   name  = 'ADDS_UPDATES_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFT.ADDS_UPDATES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING3_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKING')
            and   type = 'U')
   drop table BOOKING
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'ADD_UPDATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.ADD_UPDATE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'FLIES_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.FLIES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PASSENGER')
            and   type = 'U')
   drop table PASSENGER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SEAT')
            and   type = 'U')
   drop table SEAT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   A_EMAIL              varchar(255)         not null,
   A_FNAME              varchar(55)          not null,
   A_LNAME              varchar(55)          not null,
   A_PASSWORD           varchar(55)          not null,
   A_PHONE_NUMBER       varchar(11)          null,
   constraint PK_ADMIN primary key nonclustered (A_EMAIL)
)
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   ID                   int                  not null,
   A_EMAIL              varchar(255)         not null,
   TOTAL_SEATS          int                  not null,
   constraint PK_AIRCRAFT primary key nonclustered (ID)
)
go

/*==============================================================*/
/* Index: ADDS_UPDATES_FK                                       */
/*==============================================================*/
create index ADDS_UPDATES_FK on AIRCRAFT (
A_EMAIL ASC
)
go

/*==============================================================*/
/* Table: BOOKING                                               */
/*==============================================================*/
create table BOOKING (
   FLI_FLIGHT_NUMBER    int                  not null,
   PAS_P_EMAIL          varchar(255)         not null,
   SEA_SEAT_NUMBER      int                  not null,
   P_EMAIL              varchar(255)         null,
   FLIGHT_NUMBER        int                  null,
   SEAT_NUMBER          int                  null,
   constraint PK_BOOKING primary key (FLI_FLIGHT_NUMBER, PAS_P_EMAIL, SEA_SEAT_NUMBER)
)
go

/*==============================================================*/
/* Index: BOOKING_FK                                            */
/*==============================================================*/
create index BOOKING_FK on BOOKING (
FLI_FLIGHT_NUMBER ASC
)
go

/*==============================================================*/
/* Index: BOOKING2_FK                                           */
/*==============================================================*/
create index BOOKING2_FK on BOOKING (
PAS_P_EMAIL ASC
)
go

/*==============================================================*/
/* Index: BOOKING3_FK                                           */
/*==============================================================*/
create index BOOKING3_FK on BOOKING (
SEA_SEAT_NUMBER ASC
)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   FLIGHT_NUMBER        int                  not null,
   ID                   int                  not null,
   A_EMAIL              varchar(255)         not null,
   FLIGHT_DATE          datetime             not null,
   ARRIVAL_TIME         datetime             not null,
   LAUNCHING_TIME       datetime             not null,
   SOURCE_PLACE         varchar(55)          not null,
   DESTINATION_PLACE    varchar(55)          not null,
   SEATS_AVAILABLE      int                  not null,
   constraint PK_FLIGHT primary key nonclustered (FLIGHT_NUMBER)
)
go

/*==============================================================*/
/* Index: FLIES_FK                                              */
/*==============================================================*/
create index FLIES_FK on FLIGHT (
ID ASC
)
go

/*==============================================================*/
/* Index: ADD_UPDATE_FK                                         */
/*==============================================================*/
create index ADD_UPDATE_FK on FLIGHT (
A_EMAIL ASC
)
go

/*==============================================================*/
/* Table: PASSENGER                                             */
/*==============================================================*/
create table PASSENGER (
   P_EMAIL              varchar(255)         not null,
   P_FNAME              varchar(55)          not null,
   P_LNAME              varchar(55)          not null,
   P_PASSWORD           varchar(55)          not null,
   P_PHONE_NUMBER       varchar(11)          not null,
   CREDIT_CARD          varchar(20)          not null,
   constraint PK_PASSENGER primary key nonclustered (P_EMAIL)
)
go

/*==============================================================*/
/* Table: SEAT                                                  */
/*==============================================================*/
create table SEAT (
   SEAT_NUMBER          int                  not null,
   STATUS               varchar(55)          not null,
   CLASS                text                 not null,
   PRICE                int                  not null,
   constraint PK_SEAT primary key nonclustered (SEAT_NUMBER)
)
go


alter table AIRCRAFT
   add constraint FK_AIRCRAFT_ADDS_UPDA_ADMIN foreign key (A_EMAIL)
      references ADMIN (A_EMAIL)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING_FLIGHT foreign key (FLI_FLIGHT_NUMBER)
      references FLIGHT (FLIGHT_NUMBER)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING2_PASSENGE foreign key (PAS_P_EMAIL)
      references PASSENGER (P_EMAIL)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING3_SEAT foreign key (SEA_SEAT_NUMBER)
      references SEAT (SEAT_NUMBER)
go

alter table FLIGHT
   add constraint FK_FLIGHT_ADD_UPDAT_ADMIN foreign key (A_EMAIL)
      references ADMIN (A_EMAIL)
go

alter table FLIGHT
   add constraint FK_FLIGHT_FLIES_AIRCRAFT foreign key (ID)
      references AIRCRAFT (ID)
go

