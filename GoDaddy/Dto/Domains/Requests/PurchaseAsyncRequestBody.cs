namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PurchaseAsyncRequestBodyConsent
{
    public string AgreedAt { get; }
    public string AgreedBy { get; }
    public IReadOnlyList<string> AgreementKeys { get; }

    public PurchaseAsyncRequestBodyConsent(
        string AgreedAt,
        string AgreedBy,
        IReadOnlyList<string> AgreementKeys
    )
    {
        this.AgreedAt = AgreedAt;
        this.AgreedBy = AgreedBy;
        this.AgreementKeys = AgreementKeys;
    }
}

public sealed class PurchaseAsyncRequestBodyContactAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PurchaseAsyncRequestBodyContactAdminAddressMailing(
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

public sealed class PurchaseAsyncRequestBodyContactAdmin
{
    public PurchaseAsyncRequestBodyContactAdminAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public PurchaseAsyncRequestBodyContactAdmin(
        PurchaseAsyncRequestBodyContactAdminAddressMailing AddressMailing,
        string Email,
        string? Fax,
        string? JobTitle,
        string NameFirst,
        string NameLast,
        string? NameMiddle,
        string? Organization,
        string Phone
    )
    {
        this.AddressMailing = AddressMailing;
        this.Email = Email;
        this.Fax = Fax;
        this.JobTitle = JobTitle;
        this.NameFirst = NameFirst;
        this.NameLast = NameLast;
        this.NameMiddle = NameMiddle;
        this.Organization = Organization;
        this.Phone = Phone;
    }
}

public sealed class PurchaseAsyncRequestBodyContactBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PurchaseAsyncRequestBodyContactBillingAddressMailing(
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

public sealed class PurchaseAsyncRequestBodyContactBilling
{
    public PurchaseAsyncRequestBodyContactBillingAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public PurchaseAsyncRequestBodyContactBilling(
        PurchaseAsyncRequestBodyContactBillingAddressMailing AddressMailing,
        string Email,
        string? Fax,
        string? JobTitle,
        string NameFirst,
        string NameLast,
        string? NameMiddle,
        string? Organization,
        string Phone
    )
    {
        this.AddressMailing = AddressMailing;
        this.Email = Email;
        this.Fax = Fax;
        this.JobTitle = JobTitle;
        this.NameFirst = NameFirst;
        this.NameLast = NameLast;
        this.NameMiddle = NameMiddle;
        this.Organization = Organization;
        this.Phone = Phone;
    }
}

public sealed class PurchaseAsyncRequestBodyContactRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PurchaseAsyncRequestBodyContactRegistrantAddressMailing(
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

public sealed class PurchaseAsyncRequestBodyContactRegistrant
{
    public PurchaseAsyncRequestBodyContactRegistrantAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public PurchaseAsyncRequestBodyContactRegistrant(
        PurchaseAsyncRequestBodyContactRegistrantAddressMailing AddressMailing,
        string Email,
        string? Fax,
        string? JobTitle,
        string NameFirst,
        string NameLast,
        string? NameMiddle,
        string? Organization,
        string Phone
    )
    {
        this.AddressMailing = AddressMailing;
        this.Email = Email;
        this.Fax = Fax;
        this.JobTitle = JobTitle;
        this.NameFirst = NameFirst;
        this.NameLast = NameLast;
        this.NameMiddle = NameMiddle;
        this.Organization = Organization;
        this.Phone = Phone;
    }
}

public sealed class PurchaseAsyncRequestBodyContactTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PurchaseAsyncRequestBodyContactTechAddressMailing(
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

public sealed class PurchaseAsyncRequestBodyContactTech
{
    public PurchaseAsyncRequestBodyContactTechAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public PurchaseAsyncRequestBodyContactTech(
        PurchaseAsyncRequestBodyContactTechAddressMailing AddressMailing,
        string Email,
        string? Fax,
        string? JobTitle,
        string NameFirst,
        string NameLast,
        string? NameMiddle,
        string? Organization,
        string Phone
    )
    {
        this.AddressMailing = AddressMailing;
        this.Email = Email;
        this.Fax = Fax;
        this.JobTitle = JobTitle;
        this.NameFirst = NameFirst;
        this.NameLast = NameLast;
        this.NameMiddle = NameMiddle;
        this.Organization = Organization;
        this.Phone = Phone;
    }
}

public sealed class PurchaseAsyncRequestBody
{
    public PurchaseAsyncRequestBodyConsent Consent { get; }
    public PurchaseAsyncRequestBodyContactAdmin? ContactAdmin { get; }
    public PurchaseAsyncRequestBodyContactBilling? ContactBilling { get; }
    public PurchaseAsyncRequestBodyContactRegistrant? ContactRegistrant { get; }
    public PurchaseAsyncRequestBodyContactTech? ContactTech { get; }
    public string Domain { get; }
    public IReadOnlyList<string>? NameServers { get; }
    public int? Period { get; }
    public bool? Privacy { get; }
    public bool? RenewAuto { get; }

    public PurchaseAsyncRequestBody(
        PurchaseAsyncRequestBodyConsent Consent,
        PurchaseAsyncRequestBodyContactAdmin? ContactAdmin,
        PurchaseAsyncRequestBodyContactBilling? ContactBilling,
        PurchaseAsyncRequestBodyContactRegistrant? ContactRegistrant,
        PurchaseAsyncRequestBodyContactTech? ContactTech,
        string Domain,
        IReadOnlyList<string>? NameServers,
        int? Period,
        bool? Privacy,
        bool? RenewAuto
    )
    {
        this.Consent = Consent;
        this.ContactAdmin = ContactAdmin;
        this.ContactBilling = ContactBilling;
        this.ContactRegistrant = ContactRegistrant;
        this.ContactTech = ContactTech;
        this.Domain = Domain;
        this.NameServers = NameServers;
        this.Period = Period;
        this.Privacy = Privacy;
        this.RenewAuto = RenewAuto;
    }
}
