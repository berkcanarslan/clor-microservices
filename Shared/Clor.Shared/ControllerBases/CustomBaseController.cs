using Clor.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Clor.Shared.ControllerBases;

public class CustomBaseController : ControllerBase
{
    public IActionResult CreateActionResultInstance<T>(Response<T> response)
    {
        return new ObjectResult(response)
        {
            StatusCode = response.StatusCode
        };
    }
}