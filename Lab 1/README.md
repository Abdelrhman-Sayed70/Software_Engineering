# Lap 1
# Link Your Program With Oracle Database
### `Import Oracle Libraries`
```cs
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
```
### `Identify Database Connection Locally`
```cs
string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
OracleConnection conn;
```
### `Connect Database`
```cs
// They are written in the function you want to access database in
conn = new OracleConnection(ordb);
conn.Open();
```

### `Write Command`
```cs
OracleCommand cmd = new OracleCommand();
cmd.Connection = conn;
cmd.CommandText = "select ActorID from Actors";
cmd.CommandType = CommandType.Text;
```

### `Excute Command`
```cs
OracleDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    comboBox1.Items.Add(reader[0]);
}
```

### `Close Database Connection`
```cs
conn.Dispose();
```
