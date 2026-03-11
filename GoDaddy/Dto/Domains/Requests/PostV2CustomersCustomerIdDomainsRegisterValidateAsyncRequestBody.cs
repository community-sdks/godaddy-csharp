namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyConsent
{
    public IReadOnlyList<string> AgreementKeys { get; }
    public int Price { get; }
    public string Currency { get; }
    public bool? RegistryPremiumPricing { get; }
    public string AgreedBy { get; }
    public string AgreedAt { get; }
    public string? ClaimToken { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyConsent(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdmin
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
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdmin(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdminMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBilling
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
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBilling(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBillingMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrant
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
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrant(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrantMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTech
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
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTech(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTechMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContacts
{
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdmin? Admin { get; }
    public string? AdminId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBilling? Billing { get; }
    public string? BillingId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrant? Registrant { get; }
    public string? RegistrantId { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTech? Tech { get; }
    public string? TechId { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContacts(
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsAdmin? Admin,
        string? AdminId,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsBilling? Billing,
        string? BillingId,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsRegistrant? Registrant,
        string? RegistrantId,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContactsTech? Tech,
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

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyMetadata
{

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBody
{
    public string Domain { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyConsent Consent { get; }
    public int? Period { get; }
    public IReadOnlyList<string>? NameServers { get; }
    public bool? RenewAuto { get; }
    public bool? Privacy { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContacts? Contacts { get; }
    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBody(
        string Domain,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyConsent Consent,
        int? Period,
        IReadOnlyList<string>? NameServers,
        bool? RenewAuto,
        bool? Privacy,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyContacts? Contacts,
        PostV2CustomersCustomerIdDomainsRegisterValidateAsyncRequestBodyMetadata? Metadata
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
