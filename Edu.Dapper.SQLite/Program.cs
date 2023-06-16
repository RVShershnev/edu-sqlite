using Edu.Domains;
using Dapper;
using Microsoft.Data.Sqlite;

string DbPath = "blogging.db";
Console.WriteLine(DbPath);

await using var connection = new SqliteConnection($"Data Source={DbPath}");

var sql = "SELECT * FROM Blogs WHERE BlogId =1";

var results = await connection.QueryAsync<Blog>(sql);

foreach (var item in results)
{
    Console.WriteLine($"{item.Id} {item.Title}");
}