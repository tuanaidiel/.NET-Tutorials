var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/users/{userId}/posts/{slug}", (int userId, string slug) => {
    return $"User ID: {userId}, Post ID: {slug}";
});

app.MapGet("/products/{id:int:min(0)}", (int id) => {
    return $"Product: ID {id}";
});

app.MapGet("/report/{year?}", (int? year = 2016) => {
    return $"Year: {year}";
});

app.MapGet("/files/{*filePath}", (string filePath) => {
    return filePath;
});

app.MapGet("/search", (string? q, int page = 1) => {
    return $"Searching for {q} on page {page}";
});

app.MapGet("store/{category}/{productId:int?}/{*extraPath}", (string category, int? productId, string? extraPath, bool inStock = true) => {
    return $"The product is in {category} category with {productId} and {extraPath}";
});

app.Run();
