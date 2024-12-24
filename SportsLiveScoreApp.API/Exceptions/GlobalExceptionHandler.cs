using Microsoft.AspNetCore.Diagnostics;
using SportsLiveScoreApp.API.Utilities;

namespace SportsLiveScoreApp.API.Exceptions
{
    internal sealed class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var errorDetails = new ErrorDetails
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                ErrorMessage = "Server Error"
            };

            httpContext.Response.StatusCode = errorDetails.StatusCode;

            await httpContext.Response.WriteAsJsonAsync(errorDetails, cancellationToken);

            return true;
        }
    }
}
