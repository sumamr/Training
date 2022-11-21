select users.name,email,mobile,city,location,address,zipcode
        , services.name as ProviderName
from users
      cross join services
where users.roleid = 2