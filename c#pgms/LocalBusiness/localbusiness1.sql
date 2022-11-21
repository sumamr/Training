insert into users values('mouna','m@gmail.com',1234,'rmg','cpt','bng',12345,123,1,'2022-09-02');
select * from users;
select users.name,users.Id as UserId,email,mobile,city,location,address,zipcode,serviceprovider.Id as SPID, services.name as ServiceName,services.Id as ServiceId,description from users cross join services,serviceprovider where users.roleid=3;
select * from servicebooking;
