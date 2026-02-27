using System.Text.Json.Nodes;
using CommunitySdks.GoDaddy.Http;
using CommunitySdks.GoDaddy.Tests.Support;

namespace CommunitySdks.GoDaddy.Tests;

public sealed class GeneratedServicesTests
{
    [Fact]
    public async Task EveryServiceMethodBuildsARequest()
    {
        var transport = new TestTransport();
        var client = new Client(new Config { ApiKey = "key", ApiSecret = "secret", MaxRetries = 0 }, transport);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeabuseGetTickets = transport.Requests.Count;
        await client.Abuse().GetTicketsAsync("sample", true, "sample", "sample", "sample", "sample", 1, 1, CancellationToken.None);
        var requestabuseGetTickets = transport.Requests[beforeabuseGetTickets];
        Assert.Equal("GET", requestabuseGetTickets.Method);
        Assert.Equal("sso-key key:secret", requestabuseGetTickets.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestabuseGetTickets.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeabuseCreateTicket = transport.Requests.Count;
        await client.Abuse().CreateTicketAsync(JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestabuseCreateTicket = transport.Requests[beforeabuseCreateTicket];
        Assert.Equal("POST", requestabuseCreateTicket.Method);
        Assert.Equal("sso-key key:secret", requestabuseCreateTicket.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestabuseCreateTicket.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeabuseGetTicketInfo = transport.Requests.Count;
        await client.Abuse().GetTicketInfoAsync("sample", CancellationToken.None);
        var requestabuseGetTicketInfo = transport.Requests[beforeabuseGetTicketInfo];
        Assert.Equal("GET", requestabuseGetTicketInfo.Method);
        Assert.Equal("sso-key key:secret", requestabuseGetTicketInfo.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestabuseGetTicketInfo.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeabuseGetTicketsV2 = transport.Requests.Count;
        await client.Abuse().GetTicketsV2Async("sample", true, "sample", "sample", "sample", "sample", 1, 1, CancellationToken.None);
        var requestabuseGetTicketsV2 = transport.Requests[beforeabuseGetTicketsV2];
        Assert.Equal("GET", requestabuseGetTicketsV2.Method);
        Assert.Equal("sso-key key:secret", requestabuseGetTicketsV2.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestabuseGetTicketsV2.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeabuseCreateTicketV2 = transport.Requests.Count;
        await client.Abuse().CreateTicketV2Async(JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestabuseCreateTicketV2 = transport.Requests[beforeabuseCreateTicketV2];
        Assert.Equal("POST", requestabuseCreateTicketV2.Method);
        Assert.Equal("sso-key key:secret", requestabuseCreateTicketV2.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestabuseCreateTicketV2.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeabuseGetTicketInfoV2 = transport.Requests.Count;
        await client.Abuse().GetTicketInfoV2Async("sample", CancellationToken.None);
        var requestabuseGetTicketInfoV2 = transport.Requests[beforeabuseGetTicketInfoV2];
        Assert.Equal("GET", requestabuseGetTicketInfoV2.Method);
        Assert.Equal("sso-key key:secret", requestabuseGetTicketInfoV2.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestabuseGetTicketInfoV2.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeaftermarketGetListings = transport.Requests.Count;
        await client.Aftermarket().GetListingsAsync("sample", new[] { "sample" }, new[] { "sample" }, "sample", "sample", 1, 1, CancellationToken.None);
        var requestaftermarketGetListings = transport.Requests[beforeaftermarketGetListings];
        Assert.Equal("GET", requestaftermarketGetListings.Method);
        Assert.Equal("sso-key key:secret", requestaftermarketGetListings.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestaftermarketGetListings.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeaftermarketDeleteListings = transport.Requests.Count;
        await client.Aftermarket().DeleteListingsAsync(new[] { "sample" }, CancellationToken.None);
        var requestaftermarketDeleteListings = transport.Requests[beforeaftermarketDeleteListings];
        Assert.Equal("DELETE", requestaftermarketDeleteListings.Method);
        Assert.Equal("sso-key key:secret", requestaftermarketDeleteListings.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestaftermarketDeleteListings.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeaftermarketAddExpiryListings = transport.Requests.Count;
        await client.Aftermarket().AddExpiryListingsAsync(new[] { "sample" }, CancellationToken.None);
        var requestaftermarketAddExpiryListings = transport.Requests[beforeaftermarketAddExpiryListings];
        Assert.Equal("POST", requestaftermarketAddExpiryListings.Method);
        Assert.Equal("sso-key key:secret", requestaftermarketAddExpiryListings.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestaftermarketAddExpiryListings.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeagreementsGet = transport.Requests.Count;
        await client.Agreements().GetAsync(new[] { "sample" }, "header-value", "header-value", CancellationToken.None);
        var requestagreementsGet = transport.Requests[beforeagreementsGet];
        Assert.Equal("GET", requestagreementsGet.Method);
        Assert.Equal("sso-key key:secret", requestagreementsGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestagreementsGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansSearchANSName = transport.Requests.Count;
        await client.Ans().SearchANSNameAsync("sample", "sample", "sample", "sample", 1, 1, CancellationToken.None);
        var requestansSearchANSName = transport.Requests[beforeansSearchANSName];
        Assert.Equal("GET", requestansSearchANSName.Method);
        Assert.Equal("sso-key key:secret", requestansSearchANSName.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansSearchANSName.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansRegisterAgent = transport.Requests.Count;
        await client.Ans().RegisterAgentAsync(JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestansRegisterAgent = transport.Requests[beforeansRegisterAgent];
        Assert.Equal("POST", requestansRegisterAgent.Method);
        Assert.Equal("sso-key key:secret", requestansRegisterAgent.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansRegisterAgent.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansResolveANSName = transport.Requests.Count;
        await client.Ans().ResolveANSNameAsync(JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestansResolveANSName = transport.Requests[beforeansResolveANSName];
        Assert.Equal("POST", requestansResolveANSName.Method);
        Assert.Equal("sso-key key:secret", requestansResolveANSName.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansResolveANSName.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansGetAgent = transport.Requests.Count;
        await client.Ans().GetAgentAsync("sample", CancellationToken.None);
        var requestansGetAgent = transport.Requests[beforeansGetAgent];
        Assert.Equal("GET", requestansGetAgent.Method);
        Assert.Equal("sso-key key:secret", requestansGetAgent.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansGetAgent.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansValidateRegistration = transport.Requests.Count;
        await client.Ans().ValidateRegistrationAsync("sample", CancellationToken.None);
        var requestansValidateRegistration = transport.Requests[beforeansValidateRegistration];
        Assert.Equal("POST", requestansValidateRegistration.Method);
        Assert.Equal("sso-key key:secret", requestansValidateRegistration.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansValidateRegistration.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansVerifyDnsRecords = transport.Requests.Count;
        await client.Ans().VerifyDnsRecordsAsync("sample", CancellationToken.None);
        var requestansVerifyDnsRecords = transport.Requests[beforeansVerifyDnsRecords];
        Assert.Equal("POST", requestansVerifyDnsRecords.Method);
        Assert.Equal("sso-key key:secret", requestansVerifyDnsRecords.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansVerifyDnsRecords.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansGetAgentIdentityCertificateByAgentId = transport.Requests.Count;
        await client.Ans().GetAgentIdentityCertificateByAgentIdAsync("sample", CancellationToken.None);
        var requestansGetAgentIdentityCertificateByAgentId = transport.Requests[beforeansGetAgentIdentityCertificateByAgentId];
        Assert.Equal("GET", requestansGetAgentIdentityCertificateByAgentId.Method);
        Assert.Equal("sso-key key:secret", requestansGetAgentIdentityCertificateByAgentId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansGetAgentIdentityCertificateByAgentId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansSubmitAgentIdentityCsrByAgentId = transport.Requests.Count;
        await client.Ans().SubmitAgentIdentityCsrByAgentIdAsync("sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestansSubmitAgentIdentityCsrByAgentId = transport.Requests[beforeansSubmitAgentIdentityCsrByAgentId];
        Assert.Equal("POST", requestansSubmitAgentIdentityCsrByAgentId.Method);
        Assert.Equal("sso-key key:secret", requestansSubmitAgentIdentityCsrByAgentId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansSubmitAgentIdentityCsrByAgentId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansGetAgentServerCertificateByAgentId = transport.Requests.Count;
        await client.Ans().GetAgentServerCertificateByAgentIdAsync("sample", CancellationToken.None);
        var requestansGetAgentServerCertificateByAgentId = transport.Requests[beforeansGetAgentServerCertificateByAgentId];
        Assert.Equal("GET", requestansGetAgentServerCertificateByAgentId.Method);
        Assert.Equal("sso-key key:secret", requestansGetAgentServerCertificateByAgentId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansGetAgentServerCertificateByAgentId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansSubmitAgentServerCsrByAgentId = transport.Requests.Count;
        await client.Ans().SubmitAgentServerCsrByAgentIdAsync("sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestansSubmitAgentServerCsrByAgentId = transport.Requests[beforeansSubmitAgentServerCsrByAgentId];
        Assert.Equal("POST", requestansSubmitAgentServerCsrByAgentId.Method);
        Assert.Equal("sso-key key:secret", requestansSubmitAgentServerCsrByAgentId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansSubmitAgentServerCsrByAgentId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansGetAgentCsrStatusByAgentId = transport.Requests.Count;
        await client.Ans().GetAgentCsrStatusByAgentIdAsync("sample", "sample", CancellationToken.None);
        var requestansGetAgentCsrStatusByAgentId = transport.Requests[beforeansGetAgentCsrStatusByAgentId];
        Assert.Equal("GET", requestansGetAgentCsrStatusByAgentId.Method);
        Assert.Equal("sso-key key:secret", requestansGetAgentCsrStatusByAgentId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansGetAgentCsrStatusByAgentId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeansGetAgentEvents = transport.Requests.Count;
        await client.Ans().GetAgentEventsAsync("header-value", "sample", "sample", 1, CancellationToken.None);
        var requestansGetAgentEvents = transport.Requests[beforeansGetAgentEvents];
        Assert.Equal("GET", requestansGetAgentEvents.Method);
        Assert.Equal("sso-key key:secret", requestansGetAgentEvents.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestansGetAgentEvents.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeauctionsPlaceBids = transport.Requests.Count;
        await client.Auctions().PlaceBidsAsync("sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestauctionsPlaceBids = transport.Requests[beforeauctionsPlaceBids];
        Assert.Equal("POST", requestauctionsPlaceBids.Method);
        Assert.Equal("sso-key key:secret", requestauctionsPlaceBids.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestauctionsPlaceBids.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateCreate = transport.Requests.Count;
        await client.Certificates().CertificateCreateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestcertificatesCertificateCreate = transport.Requests[beforecertificatesCertificateCreate];
        Assert.Equal("POST", requestcertificatesCertificateCreate.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateCreate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateCreate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateValidate = transport.Requests.Count;
        await client.Certificates().CertificateValidateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestcertificatesCertificateValidate = transport.Requests[beforecertificatesCertificateValidate];
        Assert.Equal("POST", requestcertificatesCertificateValidate.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateValidate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateValidate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateGet = transport.Requests.Count;
        await client.Certificates().CertificateGetAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateGet = transport.Requests[beforecertificatesCertificateGet];
        Assert.Equal("GET", requestcertificatesCertificateGet.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateActionRetrieve = transport.Requests.Count;
        await client.Certificates().CertificateActionRetrieveAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateActionRetrieve = transport.Requests[beforecertificatesCertificateActionRetrieve];
        Assert.Equal("GET", requestcertificatesCertificateActionRetrieve.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateActionRetrieve.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateActionRetrieve.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateResendEmail = transport.Requests.Count;
        await client.Certificates().CertificateResendEmailAsync("sample", "sample", CancellationToken.None);
        var requestcertificatesCertificateResendEmail = transport.Requests[beforecertificatesCertificateResendEmail];
        Assert.Equal("POST", requestcertificatesCertificateResendEmail.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateResendEmail.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateResendEmail.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateAlternateEmailAddress = transport.Requests.Count;
        await client.Certificates().CertificateAlternateEmailAddressAsync("sample", new[] { "sample" }, CancellationToken.None);
        var requestcertificatesCertificateAlternateEmailAddress = transport.Requests[beforecertificatesCertificateAlternateEmailAddress];
        Assert.Equal("POST", requestcertificatesCertificateAlternateEmailAddress.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateAlternateEmailAddress.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateAlternateEmailAddress.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateResendEmailAddress = transport.Requests.Count;
        await client.Certificates().CertificateResendEmailAddressAsync("sample", "sample", new[] { "sample" }, CancellationToken.None);
        var requestcertificatesCertificateResendEmailAddress = transport.Requests[beforecertificatesCertificateResendEmailAddress];
        Assert.Equal("POST", requestcertificatesCertificateResendEmailAddress.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateResendEmailAddress.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateResendEmailAddress.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateEmailHistory = transport.Requests.Count;
        await client.Certificates().CertificateEmailHistoryAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateEmailHistory = transport.Requests[beforecertificatesCertificateEmailHistory];
        Assert.Equal("GET", requestcertificatesCertificateEmailHistory.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateEmailHistory.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateEmailHistory.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateCallbackDelete = transport.Requests.Count;
        await client.Certificates().CertificateCallbackDeleteAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateCallbackDelete = transport.Requests[beforecertificatesCertificateCallbackDelete];
        Assert.Equal("DELETE", requestcertificatesCertificateCallbackDelete.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateCallbackDelete.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateCallbackDelete.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateCallbackGet = transport.Requests.Count;
        await client.Certificates().CertificateCallbackGetAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateCallbackGet = transport.Requests[beforecertificatesCertificateCallbackGet];
        Assert.Equal("GET", requestcertificatesCertificateCallbackGet.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateCallbackGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateCallbackGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateCallbackReplace = transport.Requests.Count;
        await client.Certificates().CertificateCallbackReplaceAsync("sample", "sample", CancellationToken.None);
        var requestcertificatesCertificateCallbackReplace = transport.Requests[beforecertificatesCertificateCallbackReplace];
        Assert.Equal("PUT", requestcertificatesCertificateCallbackReplace.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateCallbackReplace.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateCallbackReplace.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateCancel = transport.Requests.Count;
        await client.Certificates().CertificateCancelAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateCancel = transport.Requests[beforecertificatesCertificateCancel];
        Assert.Equal("POST", requestcertificatesCertificateCancel.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateCancel.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateCancel.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateDownload = transport.Requests.Count;
        await client.Certificates().CertificateDownloadAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateDownload = transport.Requests[beforecertificatesCertificateDownload];
        Assert.Equal("GET", requestcertificatesCertificateDownload.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateDownload.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateDownload.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateReissue = transport.Requests.Count;
        await client.Certificates().CertificateReissueAsync("sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestcertificatesCertificateReissue = transport.Requests[beforecertificatesCertificateReissue];
        Assert.Equal("POST", requestcertificatesCertificateReissue.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateReissue.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateReissue.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateRenew = transport.Requests.Count;
        await client.Certificates().CertificateRenewAsync("sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestcertificatesCertificateRenew = transport.Requests[beforecertificatesCertificateRenew];
        Assert.Equal("POST", requestcertificatesCertificateRenew.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateRenew.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateRenew.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateRevoke = transport.Requests.Count;
        await client.Certificates().CertificateRevokeAsync("sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestcertificatesCertificateRevoke = transport.Requests[beforecertificatesCertificateRevoke];
        Assert.Equal("POST", requestcertificatesCertificateRevoke.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateRevoke.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateRevoke.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateSitesealGet = transport.Requests.Count;
        await client.Certificates().CertificateSitesealGetAsync("sample", "sample", "sample", CancellationToken.None);
        var requestcertificatesCertificateSitesealGet = transport.Requests[beforecertificatesCertificateSitesealGet];
        Assert.Equal("GET", requestcertificatesCertificateSitesealGet.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateSitesealGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateSitesealGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateVerifydomaincontrol = transport.Requests.Count;
        await client.Certificates().CertificateVerifydomaincontrolAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateVerifydomaincontrol = transport.Requests[beforecertificatesCertificateVerifydomaincontrol];
        Assert.Equal("POST", requestcertificatesCertificateVerifydomaincontrol.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateVerifydomaincontrol.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateVerifydomaincontrol.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateGetEntitlement = transport.Requests.Count;
        await client.Certificates().CertificateGetEntitlementAsync("sample", true, CancellationToken.None);
        var requestcertificatesCertificateGetEntitlement = transport.Requests[beforecertificatesCertificateGetEntitlement];
        Assert.Equal("GET", requestcertificatesCertificateGetEntitlement.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateGetEntitlement.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateGetEntitlement.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateCreateV2 = transport.Requests.Count;
        await client.Certificates().CertificateCreateV2Async(JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestcertificatesCertificateCreateV2 = transport.Requests[beforecertificatesCertificateCreateV2];
        Assert.Equal("POST", requestcertificatesCertificateCreateV2.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateCreateV2.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateCreateV2.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesCertificateDownloadEntitlement = transport.Requests.Count;
        await client.Certificates().CertificateDownloadEntitlementAsync("sample", CancellationToken.None);
        var requestcertificatesCertificateDownloadEntitlement = transport.Requests[beforecertificatesCertificateDownloadEntitlement];
        Assert.Equal("GET", requestcertificatesCertificateDownloadEntitlement.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesCertificateDownloadEntitlement.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesCertificateDownloadEntitlement.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesGetCustomerCertificatesByCustomerId = transport.Requests.Count;
        await client.Certificates().GetCustomerCertificatesByCustomerIdAsync("sample", 1, 1, CancellationToken.None);
        var requestcertificatesGetCustomerCertificatesByCustomerId = transport.Requests[beforecertificatesGetCustomerCertificatesByCustomerId];
        Assert.Equal("GET", requestcertificatesGetCustomerCertificatesByCustomerId.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesGetCustomerCertificatesByCustomerId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesGetCustomerCertificatesByCustomerId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesGetCertificateDetailByCertIdentifier = transport.Requests.Count;
        await client.Certificates().GetCertificateDetailByCertIdentifierAsync("sample", "sample", CancellationToken.None);
        var requestcertificatesGetCertificateDetailByCertIdentifier = transport.Requests[beforecertificatesGetCertificateDetailByCertIdentifier];
        Assert.Equal("GET", requestcertificatesGetCertificateDetailByCertIdentifier.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesGetCertificateDetailByCertIdentifier.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesGetCertificateDetailByCertIdentifier.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesGetDomainInformationByCertificateId = transport.Requests.Count;
        await client.Certificates().GetDomainInformationByCertificateIdAsync("sample", "sample", CancellationToken.None);
        var requestcertificatesGetDomainInformationByCertificateId = transport.Requests[beforecertificatesGetDomainInformationByCertificateId];
        Assert.Equal("GET", requestcertificatesGetDomainInformationByCertificateId.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesGetDomainInformationByCertificateId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesGetDomainInformationByCertificateId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesGetDomainDetailsByDomain = transport.Requests.Count;
        await client.Certificates().GetDomainDetailsByDomainAsync("sample", "sample", "sample", CancellationToken.None);
        var requestcertificatesGetDomainDetailsByDomain = transport.Requests[beforecertificatesGetDomainDetailsByDomain];
        Assert.Equal("GET", requestcertificatesGetDomainDetailsByDomain.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesGetDomainDetailsByDomain.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesGetDomainDetailsByDomain.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesGetAcmeExternalAccountBinding = transport.Requests.Count;
        await client.Certificates().GetAcmeExternalAccountBindingAsync("sample", CancellationToken.None);
        var requestcertificatesGetAcmeExternalAccountBinding = transport.Requests[beforecertificatesGetAcmeExternalAccountBinding];
        Assert.Equal("GET", requestcertificatesGetAcmeExternalAccountBinding.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesGetAcmeExternalAccountBinding.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesGetAcmeExternalAccountBinding.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesRetrieveSslByDomainReseller = transport.Requests.Count;
        await client.Certificates().RetrieveSslByDomainResellerAsync(1, 1, "sample", new[] { "sample" }, "sample", "sample", CancellationToken.None);
        var requestcertificatesRetrieveSslByDomainReseller = transport.Requests[beforecertificatesRetrieveSslByDomainReseller];
        Assert.Equal("GET", requestcertificatesRetrieveSslByDomainReseller.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesRetrieveSslByDomainReseller.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesRetrieveSslByDomainReseller.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecertificatesRetrieveSslByDomainSubscriptionReseller = transport.Requests.Count;
        await client.Certificates().RetrieveSslByDomainSubscriptionResellerAsync("sample", 1, 1, "sample", new[] { "sample" }, "sample", "sample", CancellationToken.None);
        var requestcertificatesRetrieveSslByDomainSubscriptionReseller = transport.Requests[beforecertificatesRetrieveSslByDomainSubscriptionReseller];
        Assert.Equal("GET", requestcertificatesRetrieveSslByDomainSubscriptionReseller.Method);
        Assert.Equal("sso-key key:secret", requestcertificatesRetrieveSslByDomainSubscriptionReseller.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcertificatesRetrieveSslByDomainSubscriptionReseller.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecountriesGetCountries = transport.Requests.Count;
        await client.Countries().GetCountriesAsync("sample", CancellationToken.None);
        var requestcountriesGetCountries = transport.Requests[beforecountriesGetCountries];
        Assert.Equal("GET", requestcountriesGetCountries.Method);
        Assert.Equal("sso-key key:secret", requestcountriesGetCountries.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcountriesGetCountries.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforecountriesGetCountry = transport.Requests.Count;
        await client.Countries().GetCountryAsync("sample", "sample", CancellationToken.None);
        var requestcountriesGetCountry = transport.Requests[beforecountriesGetCountry];
        Assert.Equal("GET", requestcountriesGetCountry.Method);
        Assert.Equal("sso-key key:secret", requestcountriesGetCountry.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestcountriesGetCountry.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsList = transport.Requests.Count;
        await client.Domains().ListAsync("header-value", new[] { "sample" }, new[] { "sample" }, 1, "sample", new[] { "sample" }, "sample", CancellationToken.None);
        var requestdomainsList = transport.Requests[beforedomainsList];
        Assert.Equal("GET", requestdomainsList.Method);
        Assert.Equal("sso-key key:secret", requestdomainsList.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsList.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetAgreement = transport.Requests.Count;
        await client.Domains().GetAgreementAsync(new[] { "sample" }, true, "header-value", true, CancellationToken.None);
        var requestdomainsGetAgreement = transport.Requests[beforedomainsGetAgreement];
        Assert.Equal("GET", requestdomainsGetAgreement.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetAgreement.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetAgreement.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsAvailable = transport.Requests.Count;
        await client.Domains().AvailableAsync("sample", "sample", true, CancellationToken.None);
        var requestdomainsAvailable = transport.Requests[beforedomainsAvailable];
        Assert.Equal("GET", requestdomainsAvailable.Method);
        Assert.Equal("sso-key key:secret", requestdomainsAvailable.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsAvailable.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsAvailableBulk = transport.Requests.Count;
        await client.Domains().AvailableBulkAsync(new[] { "sample" }, "sample", CancellationToken.None);
        var requestdomainsAvailableBulk = transport.Requests[beforedomainsAvailableBulk];
        Assert.Equal("POST", requestdomainsAvailableBulk.Method);
        Assert.Equal("sso-key key:secret", requestdomainsAvailableBulk.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsAvailableBulk.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsContactsValidate = transport.Requests.Count;
        await client.Domains().ContactsValidateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", "sample", CancellationToken.None);
        var requestdomainsContactsValidate = transport.Requests[beforedomainsContactsValidate];
        Assert.Equal("POST", requestdomainsContactsValidate.Method);
        Assert.Equal("sso-key key:secret", requestdomainsContactsValidate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsContactsValidate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPurchase = transport.Requests.Count;
        await client.Domains().PurchaseAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPurchase = transport.Requests[beforedomainsPurchase];
        Assert.Equal("POST", requestdomainsPurchase.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPurchase.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPurchase.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsSchema = transport.Requests.Count;
        await client.Domains().SchemaAsync("sample", CancellationToken.None);
        var requestdomainsSchema = transport.Requests[beforedomainsSchema];
        Assert.Equal("GET", requestdomainsSchema.Method);
        Assert.Equal("sso-key key:secret", requestdomainsSchema.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsSchema.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsValidate = transport.Requests.Count;
        await client.Domains().ValidateAsync(JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestdomainsValidate = transport.Requests[beforedomainsValidate];
        Assert.Equal("POST", requestdomainsValidate.Method);
        Assert.Equal("sso-key key:secret", requestdomainsValidate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsValidate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsSuggest = transport.Requests.Count;
        await client.Domains().SuggestAsync("header-value", "sample", "sample", "sample", new[] { "sample" }, new[] { "sample" }, 1, 1, 1, 1, CancellationToken.None);
        var requestdomainsSuggest = transport.Requests[beforedomainsSuggest];
        Assert.Equal("GET", requestdomainsSuggest.Method);
        Assert.Equal("sso-key key:secret", requestdomainsSuggest.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsSuggest.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsTlds = transport.Requests.Count;
        await client.Domains().TldsAsync(CancellationToken.None);
        var requestdomainsTlds = transport.Requests[beforedomainsTlds];
        Assert.Equal("GET", requestdomainsTlds.Method);
        Assert.Equal("sso-key key:secret", requestdomainsTlds.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsTlds.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsCancel = transport.Requests.Count;
        await client.Domains().CancelAsync("sample", CancellationToken.None);
        var requestdomainsCancel = transport.Requests[beforedomainsCancel];
        Assert.Equal("DELETE", requestdomainsCancel.Method);
        Assert.Equal("sso-key key:secret", requestdomainsCancel.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsCancel.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGet = transport.Requests.Count;
        await client.Domains().GetAsync("sample", "header-value", CancellationToken.None);
        var requestdomainsGet = transport.Requests[beforedomainsGet];
        Assert.Equal("GET", requestdomainsGet.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsUpdate = transport.Requests.Count;
        await client.Domains().UpdateAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsUpdate = transport.Requests[beforedomainsUpdate];
        Assert.Equal("PATCH", requestdomainsUpdate.Method);
        Assert.Equal("sso-key key:secret", requestdomainsUpdate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsUpdate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsUpdateContacts = transport.Requests.Count;
        await client.Domains().UpdateContactsAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsUpdateContacts = transport.Requests[beforedomainsUpdateContacts];
        Assert.Equal("PATCH", requestdomainsUpdateContacts.Method);
        Assert.Equal("sso-key key:secret", requestdomainsUpdateContacts.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsUpdateContacts.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsCancelPrivacy = transport.Requests.Count;
        await client.Domains().CancelPrivacyAsync("sample", "header-value", CancellationToken.None);
        var requestdomainsCancelPrivacy = transport.Requests[beforedomainsCancelPrivacy];
        Assert.Equal("DELETE", requestdomainsCancelPrivacy.Method);
        Assert.Equal("sso-key key:secret", requestdomainsCancelPrivacy.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsCancelPrivacy.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPurchasePrivacy = transport.Requests.Count;
        await client.Domains().PurchasePrivacyAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPurchasePrivacy = transport.Requests[beforedomainsPurchasePrivacy];
        Assert.Equal("POST", requestdomainsPurchasePrivacy.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPurchasePrivacy.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPurchasePrivacy.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRecordAdd = transport.Requests.Count;
        await client.Domains().RecordAddAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsRecordAdd = transport.Requests[beforedomainsRecordAdd];
        Assert.Equal("PATCH", requestdomainsRecordAdd.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRecordAdd.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRecordAdd.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRecordReplace = transport.Requests.Count;
        await client.Domains().RecordReplaceAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsRecordReplace = transport.Requests[beforedomainsRecordReplace];
        Assert.Equal("PUT", requestdomainsRecordReplace.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRecordReplace.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRecordReplace.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRecordGet = transport.Requests.Count;
        await client.Domains().RecordGetAsync("sample", "sample", "sample", "header-value", 1, 1, CancellationToken.None);
        var requestdomainsRecordGet = transport.Requests[beforedomainsRecordGet];
        Assert.Equal("GET", requestdomainsRecordGet.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRecordGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRecordGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRecordReplaceTypeName = transport.Requests.Count;
        await client.Domains().RecordReplaceTypeNameAsync("sample", "sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsRecordReplaceTypeName = transport.Requests[beforedomainsRecordReplaceTypeName];
        Assert.Equal("PUT", requestdomainsRecordReplaceTypeName.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRecordReplaceTypeName.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRecordReplaceTypeName.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRecordDeleteTypeName = transport.Requests.Count;
        await client.Domains().RecordDeleteTypeNameAsync("sample", "sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsRecordDeleteTypeName = transport.Requests[beforedomainsRecordDeleteTypeName];
        Assert.Equal("DELETE", requestdomainsRecordDeleteTypeName.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRecordDeleteTypeName.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRecordDeleteTypeName.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRecordReplaceType = transport.Requests.Count;
        await client.Domains().RecordReplaceTypeAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsRecordReplaceType = transport.Requests[beforedomainsRecordReplaceType];
        Assert.Equal("PUT", requestdomainsRecordReplaceType.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRecordReplaceType.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRecordReplaceType.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsRenew = transport.Requests.Count;
        await client.Domains().RenewAsync("sample", "header-value", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestdomainsRenew = transport.Requests[beforedomainsRenew];
        Assert.Equal("POST", requestdomainsRenew.Method);
        Assert.Equal("sso-key key:secret", requestdomainsRenew.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsRenew.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsTransferIn = transport.Requests.Count;
        await client.Domains().TransferInAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsTransferIn = transport.Requests[beforedomainsTransferIn];
        Assert.Equal("POST", requestdomainsTransferIn.Method);
        Assert.Equal("sso-key key:secret", requestdomainsTransferIn.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsTransferIn.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsVerifyEmail = transport.Requests.Count;
        await client.Domains().VerifyEmailAsync("sample", "header-value", CancellationToken.None);
        var requestdomainsVerifyEmail = transport.Requests[beforedomainsVerifyEmail];
        Assert.Equal("POST", requestdomainsVerifyEmail.Method);
        Assert.Equal("sso-key key:secret", requestdomainsVerifyEmail.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsVerifyEmail.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsDomain = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsDomainAsync("sample", "sample", "header-value", new[] { "sample" }, CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsDomain = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsDomain];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsDomain.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsDomain.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsDomain.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrant = transport.Requests.Count;
        await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsDeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrant = transport.Requests[beforedomainsDeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrant];
        Assert.Equal("DELETE", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrant.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrant.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainChangeOfRegistrant.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsDomainChangeOfRegistrant = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsDomainChangeOfRegistrantAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsDomainChangeOfRegistrant = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsDomainChangeOfRegistrant];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsDomainChangeOfRegistrant.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsDomainChangeOfRegistrant.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsDomainChangeOfRegistrant.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPatchV2CustomersCustomerIdDomainsDomainDnssecRecords = transport.Requests.Count;
        await client.Domains().PatchV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPatchV2CustomersCustomerIdDomainsDomainDnssecRecords = transport.Requests[beforedomainsPatchV2CustomersCustomerIdDomainsDomainDnssecRecords];
        Assert.Equal("PATCH", requestdomainsPatchV2CustomersCustomerIdDomainsDomainDnssecRecords.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPatchV2CustomersCustomerIdDomainsDomainDnssecRecords.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPatchV2CustomersCustomerIdDomainsDomainDnssecRecords.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDeleteV2CustomersCustomerIdDomainsDomainDnssecRecords = transport.Requests.Count;
        await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainDnssecRecordsAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsDeleteV2CustomersCustomerIdDomainsDomainDnssecRecords = transport.Requests[beforedomainsDeleteV2CustomersCustomerIdDomainsDomainDnssecRecords];
        Assert.Equal("DELETE", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainDnssecRecords.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainDnssecRecords.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainDnssecRecords.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPutV2CustomersCustomerIdDomainsDomainNameServers = transport.Requests.Count;
        await client.Domains().PutV2CustomersCustomerIdDomainsDomainNameServersAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPutV2CustomersCustomerIdDomainsDomainNameServers = transport.Requests[beforedomainsPutV2CustomersCustomerIdDomainsDomainNameServers];
        Assert.Equal("PUT", requestdomainsPutV2CustomersCustomerIdDomainsDomainNameServers.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPutV2CustomersCustomerIdDomainsDomainNameServers.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPutV2CustomersCustomerIdDomainsDomainNameServers.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsDomainPrivacyForwarding = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsDomainPrivacyForwarding = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsDomainPrivacyForwarding];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsDomainPrivacyForwarding.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsDomainPrivacyForwarding.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsDomainPrivacyForwarding.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPatchV2CustomersCustomerIdDomainsDomainPrivacyForwarding = transport.Requests.Count;
        await client.Domains().PatchV2CustomersCustomerIdDomainsDomainPrivacyForwardingAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPatchV2CustomersCustomerIdDomainsDomainPrivacyForwarding = transport.Requests[beforedomainsPatchV2CustomersCustomerIdDomainsDomainPrivacyForwarding];
        Assert.Equal("PATCH", requestdomainsPatchV2CustomersCustomerIdDomainsDomainPrivacyForwarding.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPatchV2CustomersCustomerIdDomainsDomainPrivacyForwarding.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPatchV2CustomersCustomerIdDomainsDomainPrivacyForwarding.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainRedeem = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainRedeemAsync("sample", "sample", "header-value", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainRedeem = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainRedeem];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainRedeem.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainRedeem.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainRedeem.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainRenew = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainRenewAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainRenew = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainRenew];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainRenew.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainRenew.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainRenew.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransfer = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransfer = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransfer];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransfer.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransfer.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransfer.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsDomainTransfer = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsDomainTransferAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsDomainTransfer = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsDomainTransfer];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsDomainTransfer.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsDomainTransfer.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsDomainTransfer.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferValidate = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferValidateAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferValidate = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferValidate];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferValidate.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferValidate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferValidate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInAccept = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInAcceptAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInAccept = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInAccept];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInAccept.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInAccept.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInAccept.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInCancel = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInCancelAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInCancel = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInCancel];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInCancel.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInCancel.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInCancel.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInRestart = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInRestartAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRestart = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInRestart];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRestart.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRestart.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRestart.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInRetry = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferInRetryAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRetry = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferInRetry];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRetry.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRetry.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferInRetry.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferOut = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutAsync("sample", "sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOut = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferOut];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOut.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOut.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOut.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferOutAccept = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutAcceptAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutAccept = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferOutAccept];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutAccept.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutAccept.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutAccept.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferOutReject = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainTransferOutRejectAsync("sample", "sample", "header-value", "sample", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutReject = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainTransferOutReject];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutReject.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutReject.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainTransferOutReject.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDomainsForwardsDelete = transport.Requests.Count;
        await client.Domains().DomainsForwardsDeleteAsync("sample", "sample", CancellationToken.None);
        var requestdomainsDomainsForwardsDelete = transport.Requests[beforedomainsDomainsForwardsDelete];
        Assert.Equal("DELETE", requestdomainsDomainsForwardsDelete.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDomainsForwardsDelete.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDomainsForwardsDelete.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDomainsForwardsGet = transport.Requests.Count;
        await client.Domains().DomainsForwardsGetAsync("sample", "sample", true, CancellationToken.None);
        var requestdomainsDomainsForwardsGet = transport.Requests[beforedomainsDomainsForwardsGet];
        Assert.Equal("GET", requestdomainsDomainsForwardsGet.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDomainsForwardsGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDomainsForwardsGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDomainsForwardsPut = transport.Requests.Count;
        await client.Domains().DomainsForwardsPutAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestdomainsDomainsForwardsPut = transport.Requests[beforedomainsDomainsForwardsPut];
        Assert.Equal("PUT", requestdomainsDomainsForwardsPut.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDomainsForwardsPut.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDomainsForwardsPut.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDomainsForwardsPost = transport.Requests.Count;
        await client.Domains().DomainsForwardsPostAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestdomainsDomainsForwardsPost = transport.Requests[beforedomainsDomainsForwardsPost];
        Assert.Equal("POST", requestdomainsDomainsForwardsPost.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDomainsForwardsPost.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDomainsForwardsPost.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsDomainActions = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsDomainActionsAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsDomainActions = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsDomainActions];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsDomainActions.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsDomainActions.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsDomainActions.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsDeleteV2CustomersCustomerIdDomainsDomainActionsType = transport.Requests.Count;
        await client.Domains().DeleteV2CustomersCustomerIdDomainsDomainActionsTypeAsync("sample", "sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsDeleteV2CustomersCustomerIdDomainsDomainActionsType = transport.Requests[beforedomainsDeleteV2CustomersCustomerIdDomainsDomainActionsType];
        Assert.Equal("DELETE", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainActionsType.Method);
        Assert.Equal("sso-key key:secret", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainActionsType.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsDeleteV2CustomersCustomerIdDomainsDomainActionsType.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsDomainActionsType = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsDomainActionsTypeAsync("sample", "sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsDomainActionsType = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsDomainActionsType];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsDomainActionsType.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsDomainActionsType.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsDomainActionsType.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsNotifications = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsAsync("sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsNotifications = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsNotifications];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsNotifications.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsNotifications.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsNotifications.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsNotificationsOptIn = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsOptInAsync("sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsNotificationsOptIn = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsNotificationsOptIn];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsNotificationsOptIn.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsNotificationsOptIn.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsNotificationsOptIn.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPutV2CustomersCustomerIdDomainsNotificationsOptIn = transport.Requests.Count;
        await client.Domains().PutV2CustomersCustomerIdDomainsNotificationsOptInAsync("sample", new[] { "sample" }, "header-value", CancellationToken.None);
        var requestdomainsPutV2CustomersCustomerIdDomainsNotificationsOptIn = transport.Requests[beforedomainsPutV2CustomersCustomerIdDomainsNotificationsOptIn];
        Assert.Equal("PUT", requestdomainsPutV2CustomersCustomerIdDomainsNotificationsOptIn.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPutV2CustomersCustomerIdDomainsNotificationsOptIn.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPutV2CustomersCustomerIdDomainsNotificationsOptIn.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsNotificationsSchemasType = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsNotificationsSchemasTypeAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsNotificationsSchemasType = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsNotificationsSchemasType];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsNotificationsSchemasType.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsNotificationsSchemasType.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsNotificationsSchemasType.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledge = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledgeAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledge = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledge];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledge.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledge.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsNotificationsNotificationIdAcknowledge.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsRegister = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsRegisterAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsRegister = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsRegister];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsRegister.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsRegister.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsRegister.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2CustomersCustomerIdDomainsRegisterSchemaTld = transport.Requests.Count;
        await client.Domains().GetV2CustomersCustomerIdDomainsRegisterSchemaTldAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2CustomersCustomerIdDomainsRegisterSchemaTld = transport.Requests[beforedomainsGetV2CustomersCustomerIdDomainsRegisterSchemaTld];
        Assert.Equal("GET", requestdomainsGetV2CustomersCustomerIdDomainsRegisterSchemaTld.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2CustomersCustomerIdDomainsRegisterSchemaTld.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2CustomersCustomerIdDomainsRegisterSchemaTld.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsRegisterValidate = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsRegisterValidateAsync("sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsRegisterValidate = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsRegisterValidate];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsRegisterValidate.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsRegisterValidate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsRegisterValidate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2DomainsMaintenances = transport.Requests.Count;
        await client.Domains().GetV2DomainsMaintenancesAsync("header-value", new[] { "sample" }, "sample", "sample", 1, CancellationToken.None);
        var requestdomainsGetV2DomainsMaintenances = transport.Requests[beforedomainsGetV2DomainsMaintenances];
        Assert.Equal("GET", requestdomainsGetV2DomainsMaintenances.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2DomainsMaintenances.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2DomainsMaintenances.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2DomainsMaintenancesMaintenanceId = transport.Requests.Count;
        await client.Domains().GetV2DomainsMaintenancesMaintenanceIdAsync("sample", "header-value", CancellationToken.None);
        var requestdomainsGetV2DomainsMaintenancesMaintenanceId = transport.Requests[beforedomainsGetV2DomainsMaintenancesMaintenanceId];
        Assert.Equal("GET", requestdomainsGetV2DomainsMaintenancesMaintenanceId.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2DomainsMaintenancesMaintenanceId.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2DomainsMaintenancesMaintenanceId.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsGetV2DomainsUsageYyyymm = transport.Requests.Count;
        await client.Domains().GetV2DomainsUsageYyyymmAsync("sample", "header-value", new[] { "sample" }, CancellationToken.None);
        var requestdomainsGetV2DomainsUsageYyyymm = transport.Requests[beforedomainsGetV2DomainsUsageYyyymm];
        Assert.Equal("GET", requestdomainsGetV2DomainsUsageYyyymm.Method);
        Assert.Equal("sso-key key:secret", requestdomainsGetV2DomainsUsageYyyymm.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsGetV2DomainsUsageYyyymm.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPatchV2CustomersCustomerIdDomainsDomainContacts = transport.Requests.Count;
        await client.Domains().PatchV2CustomersCustomerIdDomainsDomainContactsAsync("sample", "sample", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestdomainsPatchV2CustomersCustomerIdDomainsDomainContacts = transport.Requests[beforedomainsPatchV2CustomersCustomerIdDomainsDomainContacts];
        Assert.Equal("PATCH", requestdomainsPatchV2CustomersCustomerIdDomainsDomainContacts.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPatchV2CustomersCustomerIdDomainsDomainContacts.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPatchV2CustomersCustomerIdDomainsDomainContacts.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforedomainsPostV2CustomersCustomerIdDomainsDomainRegenerateAuthCode = transport.Requests.Count;
        await client.Domains().PostV2CustomersCustomerIdDomainsDomainRegenerateAuthCodeAsync("sample", "sample", "header-value", CancellationToken.None);
        var requestdomainsPostV2CustomersCustomerIdDomainsDomainRegenerateAuthCode = transport.Requests[beforedomainsPostV2CustomersCustomerIdDomainsDomainRegenerateAuthCode];
        Assert.Equal("POST", requestdomainsPostV2CustomersCustomerIdDomainsDomainRegenerateAuthCode.Method);
        Assert.Equal("sso-key key:secret", requestdomainsPostV2CustomersCustomerIdDomainsDomainRegenerateAuthCode.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestdomainsPostV2CustomersCustomerIdDomainsDomainRegenerateAuthCode.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeordersList = transport.Requests.Count;
        await client.Orders().ListAsync("header-value", "sample", "sample", "sample", "sample", "sample", "sample", 1, 1, "sample", "header-value", CancellationToken.None);
        var requestordersList = transport.Requests[beforeordersList];
        Assert.Equal("GET", requestordersList.Method);
        Assert.Equal("sso-key key:secret", requestordersList.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestordersList.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeordersGet = transport.Requests.Count;
        await client.Orders().GetAsync("sample", "header-value", "header-value", "header-value", CancellationToken.None);
        var requestordersGet = transport.Requests[beforeordersGet];
        Assert.Equal("GET", requestordersGet.Method);
        Assert.Equal("sso-key key:secret", requestordersGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestordersGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeparkingGetMetrics = transport.Requests.Count;
        await client.Parking().GetMetricsAsync("sample", "sample", "sample", 1, 1, "header-value", CancellationToken.None);
        var requestparkingGetMetrics = transport.Requests[beforeparkingGetMetrics];
        Assert.Equal("GET", requestparkingGetMetrics.Method);
        Assert.Equal("sso-key key:secret", requestparkingGetMetrics.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestparkingGetMetrics.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeparkingGetMetricsByDomain = transport.Requests.Count;
        await client.Parking().GetMetricsByDomainAsync("sample", "sample", "sample", new[] { "sample" }, "sample", "sample", 1, 1, "header-value", CancellationToken.None);
        var requestparkingGetMetricsByDomain = transport.Requests[beforeparkingGetMetricsByDomain];
        Assert.Equal("GET", requestparkingGetMetricsByDomain.Method);
        Assert.Equal("sso-key key:secret", requestparkingGetMetricsByDomain.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestparkingGetMetricsByDomain.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeshoppersCreateSubaccount = transport.Requests.Count;
        await client.Shoppers().CreateSubaccountAsync(JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestshoppersCreateSubaccount = transport.Requests[beforeshoppersCreateSubaccount];
        Assert.Equal("POST", requestshoppersCreateSubaccount.Method);
        Assert.Equal("sso-key key:secret", requestshoppersCreateSubaccount.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestshoppersCreateSubaccount.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeshoppersGet = transport.Requests.Count;
        await client.Shoppers().GetAsync(JsonNode.Parse("""{"sample":true}""")!, new[] { "sample" }, CancellationToken.None);
        var requestshoppersGet = transport.Requests[beforeshoppersGet];
        Assert.Equal("GET", requestshoppersGet.Method);
        Assert.Equal("sso-key key:secret", requestshoppersGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestshoppersGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeshoppersUpdate = transport.Requests.Count;
        await client.Shoppers().UpdateAsync(JsonNode.Parse("""{"sample":true}""")!, JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestshoppersUpdate = transport.Requests[beforeshoppersUpdate];
        Assert.Equal("POST", requestshoppersUpdate.Method);
        Assert.Equal("sso-key key:secret", requestshoppersUpdate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestshoppersUpdate.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeshoppersDelete = transport.Requests.Count;
        await client.Shoppers().DeleteAsync(JsonNode.Parse("""{"sample":true}""")!, "sample", CancellationToken.None);
        var requestshoppersDelete = transport.Requests[beforeshoppersDelete];
        Assert.Equal("DELETE", requestshoppersDelete.Method);
        Assert.Equal("sso-key key:secret", requestshoppersDelete.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestshoppersDelete.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeshoppersGetStatus = transport.Requests.Count;
        await client.Shoppers().GetStatusAsync(JsonNode.Parse("""{"sample":true}""")!, "sample", CancellationToken.None);
        var requestshoppersGetStatus = transport.Requests[beforeshoppersGetStatus];
        Assert.Equal("GET", requestshoppersGetStatus.Method);
        Assert.Equal("sso-key key:secret", requestshoppersGetStatus.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestshoppersGetStatus.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforeshoppersChangePassword = transport.Requests.Count;
        await client.Shoppers().ChangePasswordAsync(JsonNode.Parse("""{"sample":true}""")!, JsonNode.Parse("""{"sample":true}""")!, CancellationToken.None);
        var requestshoppersChangePassword = transport.Requests[beforeshoppersChangePassword];
        Assert.Equal("PUT", requestshoppersChangePassword.Method);
        Assert.Equal("sso-key key:secret", requestshoppersChangePassword.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestshoppersChangePassword.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforesubscriptionsList = transport.Requests.Count;
        await client.Subscriptions().ListAsync("header-value", "header-value", "header-value", new[] { "sample" }, new[] { "sample" }, 1, 1, "sample", CancellationToken.None);
        var requestsubscriptionsList = transport.Requests[beforesubscriptionsList];
        Assert.Equal("GET", requestsubscriptionsList.Method);
        Assert.Equal("sso-key key:secret", requestsubscriptionsList.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestsubscriptionsList.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforesubscriptionsProductGroups = transport.Requests.Count;
        await client.Subscriptions().ProductGroupsAsync("header-value", "header-value", CancellationToken.None);
        var requestsubscriptionsProductGroups = transport.Requests[beforesubscriptionsProductGroups];
        Assert.Equal("GET", requestsubscriptionsProductGroups.Method);
        Assert.Equal("sso-key key:secret", requestsubscriptionsProductGroups.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestsubscriptionsProductGroups.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforesubscriptionsCancel = transport.Requests.Count;
        await client.Subscriptions().CancelAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", "header-value", CancellationToken.None);
        var requestsubscriptionsCancel = transport.Requests[beforesubscriptionsCancel];
        Assert.Equal("DELETE", requestsubscriptionsCancel.Method);
        Assert.Equal("sso-key key:secret", requestsubscriptionsCancel.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestsubscriptionsCancel.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforesubscriptionsGet = transport.Requests.Count;
        await client.Subscriptions().GetAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", "header-value", CancellationToken.None);
        var requestsubscriptionsGet = transport.Requests[beforesubscriptionsGet];
        Assert.Equal("GET", requestsubscriptionsGet.Method);
        Assert.Equal("sso-key key:secret", requestsubscriptionsGet.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestsubscriptionsGet.Url);

        transport.Push(new HttpResponse { StatusCode = 200, Headers = new Dictionary<string, string> { ["content-type"] = "application/json" }, Body = "{}" });
        var beforesubscriptionsUpdate = transport.Requests.Count;
        await client.Subscriptions().UpdateAsync(JsonNode.Parse("""{"sample":true}""")!, "header-value", JsonNode.Parse("""{"sample":true}""")!, "header-value", CancellationToken.None);
        var requestsubscriptionsUpdate = transport.Requests[beforesubscriptionsUpdate];
        Assert.Equal("PATCH", requestsubscriptionsUpdate.Method);
        Assert.Equal("sso-key key:secret", requestsubscriptionsUpdate.Headers["Authorization"]);
        Assert.DoesNotContain("{", requestsubscriptionsUpdate.Url);
    }
}
