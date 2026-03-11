namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class ValidateAsyncRequestBodyConsent
{
    public string AgreedAt { get; }
    public string AgreedBy { get; }
    public IReadOnlyList<string> AgreementKeys { get; }

    public ValidateAsyncRequestBodyConsent(
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

public sealed class ValidateAsyncRequestBodyContactAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ValidateAsyncRequestBodyContactAdminAddressMailing(
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

public sealed class ValidateAsyncRequestBodyContactAdmin
{
    public ValidateAsyncRequestBodyContactAdminAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ValidateAsyncRequestBodyContactAdmin(
        ValidateAsyncRequestBodyContactAdminAddressMailing AddressMailing,
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

public sealed class ValidateAsyncRequestBodyContactBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ValidateAsyncRequestBodyContactBillingAddressMailing(
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

public sealed class ValidateAsyncRequestBodyContactBilling
{
    public ValidateAsyncRequestBodyContactBillingAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ValidateAsyncRequestBodyContactBilling(
        ValidateAsyncRequestBodyContactBillingAddressMailing AddressMailing,
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

public sealed class ValidateAsyncRequestBodyContactRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ValidateAsyncRequestBodyContactRegistrantAddressMailing(
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

public sealed class ValidateAsyncRequestBodyContactRegistrant
{
    public ValidateAsyncRequestBodyContactRegistrantAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ValidateAsyncRequestBodyContactRegistrant(
        ValidateAsyncRequestBodyContactRegistrantAddressMailing AddressMailing,
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

public sealed class ValidateAsyncRequestBodyContactTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ValidateAsyncRequestBodyContactTechAddressMailing(
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

public sealed class ValidateAsyncRequestBodyContactTech
{
    public ValidateAsyncRequestBodyContactTechAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ValidateAsyncRequestBodyContactTech(
        ValidateAsyncRequestBodyContactTechAddressMailing AddressMailing,
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

public sealed class ValidateAsyncRequestBody
{
    public ValidateAsyncRequestBodyConsent Consent { get; }
    public ValidateAsyncRequestBodyContactAdmin? ContactAdmin { get; }
    public ValidateAsyncRequestBodyContactBilling? ContactBilling { get; }
    public ValidateAsyncRequestBodyContactRegistrant? ContactRegistrant { get; }
    public ValidateAsyncRequestBodyContactTech? ContactTech { get; }
    public string Domain { get; }
    public IReadOnlyList<string>? NameServers { get; }
    public int? Period { get; }
    public bool? Privacy { get; }
    public bool? RenewAuto { get; }

    public ValidateAsyncRequestBody(
        ValidateAsyncRequestBodyConsent Consent,
        ValidateAsyncRequestBodyContactAdmin? ContactAdmin,
        ValidateAsyncRequestBodyContactBilling? ContactBilling,
        ValidateAsyncRequestBodyContactRegistrant? ContactRegistrant,
        ValidateAsyncRequestBodyContactTech? ContactTech,
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
