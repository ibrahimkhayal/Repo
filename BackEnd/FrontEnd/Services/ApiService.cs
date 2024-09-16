using FrontEnd.Models;

public class ApiService
{
    private readonly HttpClient _client;

    public ApiService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<ProductViewModel>> GetProductViewModelsAsync()
    {
        var response = await _client.GetAsync("http://localhost:5076/api/Products/");
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<ProductViewModel>>();
    }

    public async Task<ProductViewModel> GetProductViewModelByIdAsync(int id)
    {
        var response = await _client.GetAsync($"http://localhost:5076/api/Products/{id}");
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ProductViewModel>();
    }

    public async Task CreateProductViewModelAsync(ProductViewModel ProductViewModel)
    {
        var response = await _client.PostAsJsonAsync("http://localhost:5076/api/Products/", ProductViewModel);
        response.EnsureSuccessStatusCode();
    }

    public async Task UpdateProductViewModelAsync(int id, ProductViewModel ProductViewModel)
    {
        var response = await _client.PutAsJsonAsync($"http://localhost:5076/api/Products/{id}", ProductViewModel);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteProductViewModelAsync(int id)
    {
        var response = await _client.DeleteAsync($"http://localhost:5076/api/Products/{id}");
        response.EnsureSuccessStatusCode();
    }
}
