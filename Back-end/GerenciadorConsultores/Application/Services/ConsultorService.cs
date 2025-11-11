using System;

public class ConsultorService
{
    private readonly HttpClient _httpClient;
    private readonly ConsultorRepository _consultorRepository;

    public ConsultorService(HttpClient httpClient, ConsultorRepository consultorRepository)
    {
        _httpClient = httpClient;
        _consultorRepository = consultorRepository;
    }
}
