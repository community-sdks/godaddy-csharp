namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class ContactsValidateAsyncRequestBodyContactAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ContactsValidateAsyncRequestBodyContactAdminAddressMailing(
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

public sealed class ContactsValidateAsyncRequestBodyContactAdmin
{
    public ContactsValidateAsyncRequestBodyContactAdminAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ContactsValidateAsyncRequestBodyContactAdmin(
        ContactsValidateAsyncRequestBodyContactAdminAddressMailing AddressMailing,
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

public sealed class ContactsValidateAsyncRequestBodyContactBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ContactsValidateAsyncRequestBodyContactBillingAddressMailing(
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

public sealed class ContactsValidateAsyncRequestBodyContactBilling
{
    public ContactsValidateAsyncRequestBodyContactBillingAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ContactsValidateAsyncRequestBodyContactBilling(
        ContactsValidateAsyncRequestBodyContactBillingAddressMailing AddressMailing,
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

public sealed class ContactsValidateAsyncRequestBodyContactPresenceAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ContactsValidateAsyncRequestBodyContactPresenceAddressMailing(
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

public sealed class ContactsValidateAsyncRequestBodyContactPresence
{
    public ContactsValidateAsyncRequestBodyContactPresenceAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ContactsValidateAsyncRequestBodyContactPresence(
        ContactsValidateAsyncRequestBodyContactPresenceAddressMailing AddressMailing,
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

public sealed class ContactsValidateAsyncRequestBodyContactRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ContactsValidateAsyncRequestBodyContactRegistrantAddressMailing(
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

public sealed class ContactsValidateAsyncRequestBodyContactRegistrant
{
    public ContactsValidateAsyncRequestBodyContactRegistrantAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ContactsValidateAsyncRequestBodyContactRegistrant(
        ContactsValidateAsyncRequestBodyContactRegistrantAddressMailing AddressMailing,
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

public sealed class ContactsValidateAsyncRequestBodyContactTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public ContactsValidateAsyncRequestBodyContactTechAddressMailing(
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

public sealed class ContactsValidateAsyncRequestBodyContactTech
{
    public ContactsValidateAsyncRequestBodyContactTechAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public ContactsValidateAsyncRequestBodyContactTech(
        ContactsValidateAsyncRequestBodyContactTechAddressMailing AddressMailing,
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

public sealed class ContactsValidateAsyncRequestBody
{
    public ContactsValidateAsyncRequestBodyContactAdmin? ContactAdmin { get; }
    public ContactsValidateAsyncRequestBodyContactBilling? ContactBilling { get; }
    public ContactsValidateAsyncRequestBodyContactPresence? ContactPresence { get; }
    public ContactsValidateAsyncRequestBodyContactRegistrant? ContactRegistrant { get; }
    public ContactsValidateAsyncRequestBodyContactTech? ContactTech { get; }
    public IReadOnlyList<string> Domains { get; }
    public string? EntityType { get; }

    public ContactsValidateAsyncRequestBody(
        ContactsValidateAsyncRequestBodyContactAdmin? ContactAdmin,
        ContactsValidateAsyncRequestBodyContactBilling? ContactBilling,
        ContactsValidateAsyncRequestBodyContactPresence? ContactPresence,
        ContactsValidateAsyncRequestBodyContactRegistrant? ContactRegistrant,
        ContactsValidateAsyncRequestBodyContactTech? ContactTech,
        IReadOnlyList<string> Domains,
        string? EntityType
    )
    {
        this.ContactAdmin = ContactAdmin;
        this.ContactBilling = ContactBilling;
        this.ContactPresence = ContactPresence;
        this.ContactRegistrant = ContactRegistrant;
        this.ContactTech = ContactTech;
        this.Domains = Domains;
        this.EntityType = EntityType;
    }
}
