
namespace CommunitySdks.GoDaddy.Dto.Shoppers.Requests;

public sealed class CreateSubaccountAsyncRequest
{
    public CreateSubaccountAsyncRequestSubaccount Subaccount { get; }

    public CreateSubaccountAsyncRequest(
        CreateSubaccountAsyncRequestSubaccount Subaccount
    )
    {
        this.Subaccount = Subaccount;
    }
}
