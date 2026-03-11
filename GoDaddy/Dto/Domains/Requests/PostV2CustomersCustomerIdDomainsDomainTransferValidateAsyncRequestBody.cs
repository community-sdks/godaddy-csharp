namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyConsent
{
    public IReadOnlyList<string> AgreementKeys { get; }
    public int Price { get; }
    public string Currency { get; }
    public bool? RegistryPremiumPricing { get; }
    public string AgreedBy { get; }
    public string AgreedAt { get; }
    public string? ClaimToken { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyConsent(
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdmin
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
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdmin(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdminMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBilling
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
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBilling(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBillingMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrant
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
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrant(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrantMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechAddressMailing(
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTech
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
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechAddressMailing AddressMailing { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTech(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechAddressMailing AddressMailing,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTechMetadata? Metadata
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContacts
{
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdmin? Admin { get; }
    public string? AdminId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBilling? Billing { get; }
    public string? BillingId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrant? Registrant { get; }
    public string? RegistrantId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTech? Tech { get; }
    public string? TechId { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContacts(
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsAdmin? Admin,
        string? AdminId,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsBilling? Billing,
        string? BillingId,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsRegistrant? Registrant,
        string? RegistrantId,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContactsTech? Tech,
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

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyMetadata
{

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyMetadata(

    )
    {
    }
}

public sealed class PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBody
{
    public string AuthCode { get; }
    public int? Period { get; }
    public bool? RenewAuto { get; }
    public bool? Privacy { get; }
    public string? IdentityDocumentId { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyConsent Consent { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContacts? Contacts { get; }
    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyMetadata? Metadata { get; }

    public PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBody(
        string AuthCode,
        int? Period,
        bool? RenewAuto,
        bool? Privacy,
        string? IdentityDocumentId,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyConsent Consent,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyContacts? Contacts,
        PostV2CustomersCustomerIdDomainsDomainTransferValidateAsyncRequestBodyMetadata? Metadata
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
