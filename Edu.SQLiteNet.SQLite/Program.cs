using Edu.Domains;
using SQLite;

string DbPath = "blogging.db";
Console.WriteLine(DbPath);
var db = new SQLiteAsyncConnection(DbPath);

var result = from blog in db.Table<Blog>()
             where blog.Id == 1
             select blog;

foreach(var item in await result.ToListAsync())
{
    Console.WriteLine($"{item.Id} {item.Title}");
}