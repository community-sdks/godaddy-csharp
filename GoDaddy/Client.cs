using CommunitySdks.GoDaddy.Http;
using CommunitySdks.GoDaddy.Services;

namespace CommunitySdks.GoDaddy;

public sealed class Client
{
    private readonly ApiClient _apiClient;
    private readonly AbuseService _abuse;
    private readonly AftermarketService _aftermarket;
    private readonly AgreementsService _agreements;
    private readonly AnsService _ans;
    private readonly AuctionsService _auctions;
    private readonly CertificatesService _certificates;
    private readonly CountriesService _countries;
    private readonly DomainsService _domains;
    private readonly OrdersService _orders;
    private readonly ParkingService _parking;
    private readonly ShoppersService _shoppers;
    private readonly SubscriptionsService _subscriptions;

    public Client(Config? config = null, ITransport? transport = null)
    {
        _apiClient = new ApiClient(config ?? new Config(), transport);
        _abuse = new AbuseService(_apiClient);
        _aftermarket = new AftermarketService(_apiClient);
        _agreements = new AgreementsService(_apiClient);
        _ans = new AnsService(_apiClient);
        _auctions = new AuctionsService(_apiClient);
        _certificates = new CertificatesService(_apiClient);
        _countries = new CountriesService(_apiClient);
        _domains = new DomainsService(_apiClient);
        _orders = new OrdersService(_apiClient);
        _parking = new ParkingService(_apiClient);
        _shoppers = new ShoppersService(_apiClient);
        _subscriptions = new SubscriptionsService(_apiClient);
    }

    public ApiClient ApiClient() => _apiClient;

    public AbuseService Abuse() => _abuse;

    public AftermarketService Aftermarket() => _aftermarket;

    public AgreementsService Agreements() => _agreements;

    public AnsService Ans() => _ans;

    public AuctionsService Auctions() => _auctions;

    public CertificatesService Certificates() => _certificates;

    public CountriesService Countries() => _countries;

    public DomainsService Domains() => _domains;

    public OrdersService Orders() => _orders;

    public ParkingService Parking() => _parking;

    public ShoppersService Shoppers() => _shoppers;

    public SubscriptionsService Subscriptions() => _subscriptions;
}
