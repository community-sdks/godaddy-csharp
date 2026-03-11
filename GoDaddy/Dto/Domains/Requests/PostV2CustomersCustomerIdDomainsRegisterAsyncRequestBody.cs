namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyConsent
{
    public IReadOnlyList<string> AgreementKeys { get; }
    public int Price { get; }
    public string Currency { get; }
    public bool? RegistryPremiumPricing { get; }
    public string AgreedBy { get; }
    public string AgreedAt { get; }
    public string? ClaimToken { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyConsent(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdmin
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
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdmin(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdminMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBilling
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
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBilling(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBillingMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrant
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
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrant(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrantMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTech
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
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTech(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTechMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContacts
{
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdmin? Admin { get; }
    public string? AdminId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBilling? Billing { get; }
    public string? BillingId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrant? Registrant { get; }
    public string? RegistrantId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTech? Tech { get; }
    public string? TechId { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContacts(
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsAdmin? Admin,
        string? AdminId,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsBilling? Billing,
        string? BillingId,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsRegistrant? Registrant,
        string? RegistrantId,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContactsTech? Tech,
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBody
{
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyConsent Consent { get; }
    public int? Period { get; }
    public IReadOnlyList<string>? NameServers { get; }
    public bool? RenewAuto { get; }
    public bool? Privacy { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContacts? Contacts { get; }
    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBody(
        string Domain,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyConsent Consent,
        int? Period,
        IReadOnlyList<string>? NameServers,
        bool? RenewAuto,
        bool? Privacy,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyContacts? Contacts,
        PostV2CustomersCustomerIdDomainsRegisterAsyncRequestBodyMetadata? Metadata
    )
    {
        this.Domain = Domain;
        this.Consent = Consent;
        this.Period = Period;
        this.NameServers = NameServers;
        this.RenewAuto = RenewAuto;
        this.Privacy = Privacy;
        this.Contacts = Contacts;
        this.Metadata = Metadata;
    }
}
