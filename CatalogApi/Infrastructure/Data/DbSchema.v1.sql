begin transaction;

drop table Category;

create table Category (
-- Item  
  [Id] int primary key not null default 1
, [CategoryId] int null
, [Name] nvarchar(50) not null default ('New Category')
);

-- Articles

drop table Article;

create table Article (
-- Item  
-- Item  
  [Id] int primary key not null default 1
, [CategoryId] int not null
, [Name] nvarchar(50) not null default ('New Article')
-- Specifics
, [Stock] int default (0)
, [PriceBuy] real default (0)
, [PriceSell] real default (0)
);

commit transaction;