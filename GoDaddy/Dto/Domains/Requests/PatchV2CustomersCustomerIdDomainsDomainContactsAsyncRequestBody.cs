namespace CommunitySdks.GoDaddy.Dto.Domains.Requests;

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminAddressMailing(
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminMetadata
{

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminMetadata(

    )
    {
    }
}

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdmin
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
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminAddressMailing AddressMailing { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminMetadata? Metadata { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdmin(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminAddressMailing AddressMailing,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdminMetadata? Metadata
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingAddressMailing(
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingMetadata
{

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingMetadata(

    )
    {
    }
}

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBilling
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
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingAddressMailing AddressMailing { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingMetadata? Metadata { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBilling(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingAddressMailing AddressMailing,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBillingMetadata? Metadata
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantAddressMailing(
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantMetadata
{

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantMetadata(

    )
    {
    }
}

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrant
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
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantMetadata? Metadata { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrant(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantAddressMailing AddressMailing,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrantMetadata? Metadata
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechAddressMailing
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string City { get; }
    public string Country { get; }
    public string PostalCode { get; }
    public string State { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechAddressMailing(
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechMetadata
{

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechMetadata(

    )
    {
    }
}

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTech
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
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechAddressMailing AddressMailing { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechMetadata? Metadata { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTech(
        string Encoding,
        string NameFirst,
        string? NameMiddle,
        string NameLast,
        string? Organization,
        string? JobTitle,
        string Email,
        string Phone,
        string? Fax,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechAddressMailing AddressMailing,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTechMetadata? Metadata
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContacts
{
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdmin? Admin { get; }
    public string? AdminId { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBilling? Billing { get; }
    public string? BillingId { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrant? Registrant { get; }
    public string? RegistrantId { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTech? Tech { get; }
    public string? TechId { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContacts(
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsAdmin? Admin,
        string? AdminId,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsBilling? Billing,
        string? BillingId,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsRegistrant? Registrant,
        string? RegistrantId,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContactsTech? Tech,
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

public sealed class PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBody
{
    public string? IdentityDocumentId { get; }
    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContacts? Contacts { get; }

    public PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBody(
        string? IdentityDocumentId,
        PatchV2CustomersCustomerIdDomainsDomainContactsAsyncRequestBodyContacts? Contacts
    )
    {
        this.IdentityDocumentId = IdentityDocumentId;
        this.Contacts = Contacts;
    }
}
