using Microsoft.Data.Sqlite;

string Path = "blogging.db";

Console.WriteLine(Path);

await using var connection = new SqliteConnection($"Data Source={Path}");

await connection.OpenAsync();

await using var cmd = new SqliteCommand($"SELECT * FROM Blogs WHERE BlogId = 1", connection);
await using var dataReader = await cmd.ExecuteReaderAsync();

while (await dataReader.ReadAsync())
{
    Console.Write(dataReader["Id"]);
    Console.Write(" ");
    Console.Write(dataReader["Title"]);
}