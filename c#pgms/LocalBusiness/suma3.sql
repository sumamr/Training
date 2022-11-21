select users.name as ServiceProviderName
        , services.name as ServiceName,description,status
from users
      cross join services
where users.roleid = 3