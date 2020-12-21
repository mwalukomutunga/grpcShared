using Microsoft.AspNetCore.Builder;

namespace Listing
{
    public class EndPoints
    {

        public static void AddEndpoints(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGrpcService<GreeterService>();
        }
    }
}