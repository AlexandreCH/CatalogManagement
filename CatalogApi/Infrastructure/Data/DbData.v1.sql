
begin transaction;

delete from Article;
delete from Category;

-- 1, "High Tech"
-- 2, "Téléphonie", 1
-- 3, "Android", 2
-- 4, "iOS", 2
-- 5, "PC", 1
-- 6, "Ecrans", 1
-- 7, "Ecran PC", 6
-- 8, "Ecran TV", 6
-- 9, "Electroménager"
-- 10, "Frigo", 9
-- 11, "Lave vaisselle", 9


insert into Category (Id, Name) values (1, 'High Tech');
insert into Category (Id, Name, CategoryId) values (2, 'Téléphonie', 1);
insert into Category (Id, Name, CategoryId) values (3, 'Android', 2);
insert into Category (Id, Name, CategoryId) values (4, 'iOS', 2);
insert into Category (Id, Name, CategoryId) values (5, 'PC', 1);
insert into Category (Id, Name, CategoryId) values (6, 'Ecrans', 1);
insert into Category (Id, Name, CategoryId) values (7, 'Ecran PC', 6);
insert into Category (Id, Name, CategoryId) values (8, 'Ecran TV', 6);
insert into Category (Id, Name) values (9, 'Electroménager');
insert into Category (Id, Name, CategoryId) values (10, 'Frigo', 9);
insert into Category (Id, Name, CategoryId) values (11, 'Lave vaisselle', 9);

-- 1, "Samsung S20", 3, 10, 600, 800
-- 2, "Xiaomi", 3, 10, 250, 299.99
-- 3, "iPhone 14", 4, 8, 900, 1200
-- 4, "Pc Gamer", 5, 2, 1800, 2000
-- 5, "Kindle", 6, 0, 150, 180
-- 6, "Lenovo 27 pouces", 7, 3, 250, 330
-- 7, "Samsung The Frame", 8, 10, 1400, 1500
-- 8, "Frigo Electrolux", 10, 5, 800, 1000
-- 9, "Whirlpool", 11, 5, 450, 550


insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell) 
    values (1, 3, 'Samsung Galaxy S20', 10, 600, 800);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (2, 3, 'Xiaomi', 10, 250, 299.99);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (3, 4, 'iPhone 14', 8, 900, 1200);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (4, 5, 'Pc Gamer', 2, 1800, 2000);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (5, 6, 'Kindle', 0, 150, 180);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (6, 7, 'Lenovo 27 pouces', 3, 250, 330);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (7, 8, 'Samsung The Frame', 10, 1400, 1500);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (8, 10, 'Frigo Electrolux', 5, 800, 1000);
insert into Article (Id, CategoryId, Name, Stock, PriceBuy, PriceSell)
    values (9, 11, 'Whirlpool', 5, 450, 550);

commit transaction;
```



