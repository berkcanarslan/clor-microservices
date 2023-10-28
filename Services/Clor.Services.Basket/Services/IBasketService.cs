using Clor.Services.Basket.Dtos;
using Clor.Shared.Dtos;

namespace Clor.Services.Basket.Services;

public interface IBasketService
{
    Task<Response<BasketDto>> GetBasket(string userId);
    Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
    Task<Response<bool>> Delete(string userId);
}