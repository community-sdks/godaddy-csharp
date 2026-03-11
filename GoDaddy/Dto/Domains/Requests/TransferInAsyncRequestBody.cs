namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class TransferInAsyncRequestBodyConsent
{
    public string AgreedAt { get; }
    public string AgreedBy { get; }
    public IReadOnlyList<string> AgreementKeys { get; }

    public TransferInAsyncRequestBodyConsent(
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

public sealed class TransferInAsyncRequestBodyContactAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public TransferInAsyncRequestBodyContactAdminAddressMailing(
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

public sealed class TransferInAsyncRequestBodyContactAdmin
{
    public TransferInAsyncRequestBodyContactAdminAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public TransferInAsyncRequestBodyContactAdmin(
        TransferInAsyncRequestBodyContactAdminAddressMailing AddressMailing,
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

public sealed class TransferInAsyncRequestBodyContactBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public TransferInAsyncRequestBodyContactBillingAddressMailing(
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

public sealed class TransferInAsyncRequestBodyContactBilling
{
    public TransferInAsyncRequestBodyContactBillingAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public TransferInAsyncRequestBodyContactBilling(
        TransferInAsyncRequestBodyContactBillingAddressMailing AddressMailing,
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

public sealed class TransferInAsyncRequestBodyContactRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public TransferInAsyncRequestBodyContactRegistrantAddressMailing(
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

public sealed class TransferInAsyncRequestBodyContactRegistrant
{
    public TransferInAsyncRequestBodyContactRegistrantAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public TransferInAsyncRequestBodyContactRegistrant(
        TransferInAsyncRequestBodyContactRegistrantAddressMailing AddressMailing,
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

public sealed class TransferInAsyncRequestBodyContactTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public TransferInAsyncRequestBodyContactTechAddressMailing(
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

public sealed class TransferInAsyncRequestBodyContactTech
{
    public TransferInAsyncRequestBodyContactTechAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public TransferInAsyncRequestBodyContactTech(
        TransferInAsyncRequestBodyContactTechAddressMailing AddressMailing,
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

public sealed class TransferInAsyncRequestBody
{
    public string AuthCode { get; }
    public TransferInAsyncRequestBodyConsent Consent { get; }
    public int? Period { get; }
    public bool? Privacy { get; }
    public bool? RenewAuto { get; }
    public TransferInAsyncRequestBodyContactAdmin? ContactAdmin { get; }
    public TransferInAsyncRequestBodyContactBilling? ContactBilling { get; }
    public TransferInAsyncRequestBodyContactRegistrant? ContactRegistrant { get; }
    public TransferInAsyncRequestBodyContactTech? ContactTech { get; }

    public TransferInAsyncRequestBody(
        string AuthCode,
        TransferInAsyncRequestBodyConsent Consent,
        int? Period,
        bool? Privacy,
        bool? RenewAuto,
        TransferInAsyncRequestBodyContactAdmin? ContactAdmin,
        TransferInAsyncRequestBodyContactBilling? ContactBilling,
        TransferInAsyncRequestBodyContactRegistrant? ContactRegistrant,
        TransferInAsyncRequestBodyContactTech? ContactTech
    )
    {
        this.AuthCode = AuthCode;
        this.Consent = Consent;
        this.Period = Period;
        this.Privacy = Privacy;
        this.RenewAuto = RenewAuto;
        this.ContactAdmin = ContactAdmin;
        this.ContactBilling = ContactBilling;
        this.ContactRegistrant = ContactRegistrant;
        this.ContactTech = ContactTech;
    }
}
