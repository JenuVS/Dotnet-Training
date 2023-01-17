using Npgsql;

var cs = "Host=localhost;Username=postgres;Password=password;Database=testdb";

using var con = new NpgsqlConnection(cs);
con.Open();

/*var sql = "SELECT version()";

using var cmd = new NpgsqlCommand(sql, con);

var version = cmd.ExecuteScalar().ToString();
Console.WriteLine($"PostgreSQL version: {version}");*/

using var cmd = new NpgsqlCommand();
cmd.Connection = con;

cmd.CommandText = "DROP TABLE IF EXISTS cars";
cmd.ExecuteNonQuery();

cmd.CommandText = @"CREATE TABLE cars(id SERIAL PRIMARY KEY,
        name VARCHAR(255), price INT)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo',29000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bentley',350000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',21000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Hummer',41400)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volkswagen',21600)";
cmd.ExecuteNonQuery();

Console.WriteLine("Table cars created");

string sql = "SELECT * FROM cars";
using var cmd1 = new NpgsqlCommand(sql, con);

using NpgsqlDataReader rdr = cmd.ExecuteReader();
Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),10}");

while (rdr.Read())
{
    Console.WriteLine($"{rdr.GetInt32(0),-4} {rdr.GetString(1),-10} {rdr.GetInt32(2),10}");
}