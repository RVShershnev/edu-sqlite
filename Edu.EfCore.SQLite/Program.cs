using Edu.EfCore.SqlLite;
using Microsoft.EntityFrameworkCore;

await using var db = new BloggingContext();

var result = from blog in db.Blogs
             where blog.Id == 1
             select blog;

await foreach (var item in result.AsAsyncEnumerable())
{
    Console.WriteLine($"{item.Id} {item.Title}");
}