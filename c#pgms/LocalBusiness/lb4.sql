select users.name as CustomerName,email as CustomerEmail,mobile as CustomerContact,city as CustomerCity,location as CustomerLocation,address as CustomerAddress,zipcode as CustomerZipcode,servicebooking.Id as bookid,servicebooking.description as Problem from users cross join servicebooking where roleid = 1;
select * from services;
Insert into services(name,description,status)Values('test','tetinn','I');
select * from services;
