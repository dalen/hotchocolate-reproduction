using HotChocolate.Data.Filters;

namespace HotChocolateIdFilter.Types;

public class BooksFilterInput : FilterInputType<Book>
{
    protected override void Configure(IFilterInputTypeDescriptor<Book> descriptor)
    {
        descriptor.Field(e => e.Id).Type<IdOperationFilterInputType>();
    }
}