namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyConsent
{
    public IReadOnlyList<string> AgreementKeys { get; }
    public int Price { get; }
    public string Currency { get; }
    public bool? RegistryPremiumPricing { get; }
    public string AgreedBy { get; }
    public string AgreedAt { get; }
    public string? ClaimToken { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyConsent(
        IReadOnlyList<string> AgreementKeys,
        int Price,
        string Currency,
        bool? RegistryPremiumPricing,
        string AgreedBy,
        string AgreedAt,
        string? ClaimToken
    )
    {
        this.AgreementKeys = AgreementKeys;
        this.Price = Price;
        this.Currency = Currency;
        this.RegistryPremiumPricing = RegistryPremiumPricing;
        this.AgreedBy = AgreedBy;
        this.AgreedAt = AgreedAt;
        this.ClaimToken = ClaimToken;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminAddressMailing(
        string Address1,
        string? Address2,
        string City,
        string Country,
        string PostalCode,
        string State
    )
    {
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.City = City;
        this.Country = Country;
        this.PostalCode = PostalCode;
        this.State = State;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdmin
{
    public string Encoding { get; }
    public string NameFirst { get; }
    public string? NameMiddle { get; }
    public string NameLast { get; }
    public string? Organization { get; }
    public string? JobTitle { get; }
    public string Email { get; }
    public string Phone { get; }
    public string? Fax { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdmin(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdminMetadata? Metadata
    )
    {
        this.Encoding = Encoding;
        this.NameFirst = NameFirst;
        this.NameMiddle = NameMiddle;
        this.NameLast = NameLast;
        this.Organization = Organization;
        this.JobTitle = JobTitle;
        this.Email = Email;
        this.Phone = Phone;
        this.Fax = Fax;
        this.AddressMailing = AddressMailing;
        this.Metadata = Metadata;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingAddressMailing(
        string Address1,
        string? Address2,
        string City,
        string Country,
        string PostalCode,
        string State
    )
    {
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.City = City;
        this.Country = Country;
        this.PostalCode = PostalCode;
        this.State = State;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBilling
{
    public string Encoding { get; }
    public string NameFirst { get; }
    public string? NameMiddle { get; }
    public string NameLast { get; }
    public string? Organization { get; }
    public string? JobTitle { get; }
    public string Email { get; }
    public string Phone { get; }
    public string? Fax { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBilling(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBillingMetadata? Metadata
    )
    {
        this.Encoding = Encoding;
        this.NameFirst = NameFirst;
        this.NameMiddle = NameMiddle;
        this.NameLast = NameLast;
        this.Organization = Organization;
        this.JobTitle = JobTitle;
        this.Email = Email;
        this.Phone = Phone;
        this.Fax = Fax;
        this.AddressMailing = AddressMailing;
        this.Metadata = Metadata;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantAddressMailing(
        string Address1,
        string? Address2,
        string City,
        string Country,
        string PostalCode,
        string State
    )
    {
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.City = City;
        this.Country = Country;
        this.PostalCode = PostalCode;
        this.State = State;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrant
{
    public string Encoding { get; }
    public string NameFirst { get; }
    public string? NameMiddle { get; }
    public string NameLast { get; }
    public string? Organization { get; }
    public string? JobTitle { get; }
    public string Email { get; }
    public string Phone { get; }
    public string? Fax { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrant(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrantMetadata? Metadata
    )
    {
        this.Encoding = Encoding;
        this.NameFirst = NameFirst;
        this.NameMiddle = NameMiddle;
        this.NameLast = NameLast;
        this.Organization = Organization;
        this.JobTitle = JobTitle;
        this.Email = Email;
        this.Phone = Phone;
        this.Fax = Fax;
        this.AddressMailing = AddressMailing;
        this.Metadata = Metadata;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechAddressMailing(
        string Address1,
        string? Address2,
        string City,
        string Country,
        string PostalCode,
        string State
    )
    {
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.City = City;
        this.Country = Country;
        this.PostalCode = PostalCode;
        this.State = State;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTech
{
    public string Encoding { get; }
    public string NameFirst { get; }
    public string? NameMiddle { get; }
    public string NameLast { get; }
    public string? Organization { get; }
    public string? JobTitle { get; }
    public string Email { get; }
    public string Phone { get; }
    public string? Fax { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTech(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTechMetadata? Metadata
    )
    {
        this.Encoding = Encoding;
        this.NameFirst = NameFirst;
        this.NameMiddle = NameMiddle;
        this.NameLast = NameLast;
        this.Organization = Organization;
        this.JobTitle = JobTitle;
        this.Email = Email;
        this.Phone = Phone;
        this.Fax = Fax;
        this.AddressMailing = AddressMailing;
        this.Metadata = Metadata;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContacts
{
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdmin? Admin { get; }
    public string? AdminId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBilling? Billing { get; }
    public string? BillingId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrant? Registrant { get; }
    public string? RegistrantId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTech? Tech { get; }
    public string? TechId { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContacts(
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsAdmin? Admin,
        string? AdminId,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsBilling? Billing,
        string? BillingId,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsRegistrant? Registrant,
        string? RegistrantId,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContactsTech? Tech,
        string? TechId
    )
    {
        this.Admin = Admin;
        this.AdminId = AdminId;
        this.Billing = Billing;
        this.BillingId = BillingId;
        this.Registrant = Registrant;
        this.RegistrantId = RegistrantId;
        this.Tech = Tech;
        this.TechId = TechId;
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBody
{
    public string AuthCode { get; }
    public int? Period { get; }
    public bool? RenewAuto { get; }
    public bool? Privacy { get; }
    public string? IdentityDocumentId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyConsent Consent { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContacts? Contacts { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBody(
        string AuthCode,
        int? Period,
        bool? RenewAuto,
        bool? Privacy,
        string? IdentityDocumentId,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyConsent Consent,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyContacts? Contacts,
        PostV2CustomersCustomerIdDomainsDomainTransferAsyncRequestBodyMetadata? Metadata
    )
    {
        this.AuthCode = AuthCode;
        this.Period = Period;
        this.RenewAuto = RenewAuto;
        this.Privacy = Privacy;
        this.IdentityDocumentId = IdentityDocumentId;
        this.Consent = Consent;
        this.Contacts = Contacts;
        this.Metadata = Metadata;
    }
}
