namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class UpdateContactsAsyncRequestContactsContactAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public UpdateContactsAsyncRequestContactsContactAdminAddressMailing(
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

public sealed class UpdateContactsAsyncRequestContactsContactAdmin
{
    public UpdateContactsAsyncRequestContactsContactAdminAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public UpdateContactsAsyncRequestContactsContactAdmin(
        UpdateContactsAsyncRequestContactsContactAdminAddressMailing AddressMailing,
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

public sealed class UpdateContactsAsyncRequestContactsContactBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public UpdateContactsAsyncRequestContactsContactBillingAddressMailing(
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

public sealed class UpdateContactsAsyncRequestContactsContactBilling
{
    public UpdateContactsAsyncRequestContactsContactBillingAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public UpdateContactsAsyncRequestContactsContactBilling(
        UpdateContactsAsyncRequestContactsContactBillingAddressMailing AddressMailing,
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

public sealed class UpdateContactsAsyncRequestContactsContactRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public UpdateContactsAsyncRequestContactsContactRegistrantAddressMailing(
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

public sealed class UpdateContactsAsyncRequestContactsContactRegistrant
{
    public UpdateContactsAsyncRequestContactsContactRegistrantAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public UpdateContactsAsyncRequestContactsContactRegistrant(
        UpdateContactsAsyncRequestContactsContactRegistrantAddressMailing AddressMailing,
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

public sealed class UpdateContactsAsyncRequestContactsContactTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public UpdateContactsAsyncRequestContactsContactTechAddressMailing(
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

public sealed class UpdateContactsAsyncRequestContactsContactTech
{
    public UpdateContactsAsyncRequestContactsContactTechAddressMailing AddressMailing { get; }
    public string Email { get; }
    public string? Fax { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string? Organization { get; }
    public string Phone { get; }

    public UpdateContactsAsyncRequestContactsContactTech(
        UpdateContactsAsyncRequestContactsContactTechAddressMailing AddressMailing,
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

public sealed class UpdateContactsAsyncRequestContacts
{
    public UpdateContactsAsyncRequestContactsContactAdmin? ContactAdmin { get; }
    public UpdateContactsAsyncRequestContactsContactBilling? ContactBilling { get; }
    public UpdateContactsAsyncRequestContactsContactRegistrant ContactRegistrant { get; }
    public UpdateContactsAsyncRequestContactsContactTech? ContactTech { get; }

    public UpdateContactsAsyncRequestContacts(
        UpdateContactsAsyncRequestContactsContactAdmin? ContactAdmin,
        UpdateContactsAsyncRequestContactsContactBilling? ContactBilling,
        UpdateContactsAsyncRequestContactsContactRegistrant ContactRegistrant,
        UpdateContactsAsyncRequestContactsContactTech? ContactTech
    )
    {
        this.ContactAdmin = ContactAdmin;
        this.ContactBilling = ContactBilling;
        this.ContactRegistrant = ContactRegistrant;
        this.ContactTech = ContactTech;
    }
}
