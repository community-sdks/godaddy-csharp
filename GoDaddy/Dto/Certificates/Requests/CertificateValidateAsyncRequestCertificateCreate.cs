namespace CommunitySdks.GoDaddy.Dto.Certificates.Requests;

public sealed class CertificateValidateAsyncRequestCertificateCreateContact
{
    public string Email { get; }
    public string? JobTitle { get; }
    public string NameFirst { get; }
    public string NameLast { get; }
    public string? NameMiddle { get; }
    public string Phone { get; }
    public string? Suffix { get; }

    public CertificateValidateAsyncRequestCertificateCreateContact(
        string Email,
        string? JobTitle,
        string NameFirst,
        string NameLast,
        string? NameMiddle,
        string Phone,
        string? Suffix
    )
    {
        this.Email = Email;
        this.JobTitle = JobTitle;
        this.NameFirst = NameFirst;
        this.NameLast = NameLast;
        this.NameMiddle = NameMiddle;
        this.Phone = Phone;
        this.Suffix = Suffix;
    }
}

public sealed class CertificateValidateAsyncRequestCertificateCreateOrganizationAddress
{
    public string Address1 { get; }
    public string? Address2 { get; }
    public string? City { get; }
    public string Country { get; }
    public string? PostalCode { get; }
    public string? State { get; }

    public CertificateValidateAsyncRequestCertificateCreateOrganizationAddress(
        string Address1,
        string? Address2,
        string? City,
        string Country,
        string? PostalCode,
        string? State
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

public sealed class CertificateValidateAsyncRequestCertificateCreateOrganization
{
    public CertificateValidateAsyncRequestCertificateCreateOrganizationAddress? Address { get; }
    public string? AssumedName { get; }
    public string Name { get; }
    public string Phone { get; }
    public string? RegistrationAgent { get; }
    public string? RegistrationNumber { get; }

    public CertificateValidateAsyncRequestCertificateCreateOrganization(
        CertificateValidateAsyncRequestCertificateCreateOrganizationAddress? Address,
        string? AssumedName,
        string Name,
        string Phone,
        string? RegistrationAgent,
        string? RegistrationNumber
    )
    {
        this.Address = Address;
        this.AssumedName = AssumedName;
        this.Name = Name;
        this.Phone = Phone;
        this.RegistrationAgent = RegistrationAgent;
        this.RegistrationNumber = RegistrationNumber;
    }
}

public sealed class CertificateValidateAsyncRequestCertificateCreate
{
    public string? CallbackUrl { get; }
    public string? CommonName { get; }
    public CertificateValidateAsyncRequestCertificateCreateContact Contact { get; }
    public string Csr { get; }
    public bool? IntelVPro { get; }
    public CertificateValidateAsyncRequestCertificateCreateOrganization? Organization { get; }
    public int Period { get; }
    public string ProductType { get; }
    public string? RootType { get; }
    public string? SlotSize { get; }
    public IReadOnlyList<string>? SubjectAlternativeNames { get; }

    public CertificateValidateAsyncRequestCertificateCreate(
        string? CallbackUrl,
        string? CommonName,
        CertificateValidateAsyncRequestCertificateCreateContact Contact,
        string Csr,
        bool? IntelVPro,
        CertificateValidateAsyncRequestCertificateCreateOrganization? Organization,
        int Period,
        string ProductType,
        string? RootType,
        string? SlotSize,
        IReadOnlyList<string>? SubjectAlternativeNames
    )
    {
        this.CallbackUrl = CallbackUrl;
        this.CommonName = CommonName;
        this.Contact = Contact;
        this.Csr = Csr;
        this.IntelVPro = IntelVPro;
        this.Organization = Organization;
        this.Period = Period;
        this.ProductType = ProductType;
        this.RootType = RootType;
        this.SlotSize = SlotSize;
        this.SubjectAlternativeNames = SubjectAlternativeNames;
    }
}
