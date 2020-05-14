# FYP-SignChat Maintenance System
SignChat Maintenance System is a Windows Forms App develop in Microsoft Visual Studio. System administrator can easily manage SignChat account in this application.
## Installation
1. Checkout SignChat Maintenance System repository. 
   ```
   $ git clone https://github.com/eching0519/FYP-SignChatMaintenanceSystem.git
   ```
2. Update value of server IP `server=0.0.0.0`, database id `user id=signchat`, password `Password=password` and database name `database=sign_chat` of the connection string in `App.config`.
```
<add name="database" connectionString="metadata=res://*/database.csdl|res://*/database.ssdl|res://*/database.msl;provider=MySql.Data.MySqlClient;provider connection string=&quot;server=0.0.0.0;user id=signchat;Password=password;database=sign_chat&quot;" providerName="System.Data.EntityClient" />
```
