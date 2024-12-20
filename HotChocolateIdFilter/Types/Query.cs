namespace HotChocolateIdFilter.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new Book(1, "C# in depth.", new Author("Jon Skeet"));

    [UsePaging]
    [UseFiltering]
    public static List<Book> GetBooks()
        => [
            new Book(1, "C# in depth.", new Author("Jon Skeet")),
            new Book(2, "C# in depth 2.", new Author("Jon Skeet Jr"))
        ];
}
