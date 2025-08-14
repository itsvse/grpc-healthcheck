using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Sw.Grpc.HealthCheck;
public static class GrpcEndpointRouteBuilderExtensions
{
    /// <summary>
    /// MapGrpcHealthCheckService
    /// </summary>
    /// <param name="endpoints"></param>
    /// <returns></returns>
    public static GrpcServiceEndpointConventionBuilder MapGrpcHealthCheckService(this IEndpointRouteBuilder endpoints) {
        return endpoints.MapGrpcService<HealthCheckService>();
    }
}
