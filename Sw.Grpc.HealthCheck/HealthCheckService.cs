using Grpc.Core;
using Grpc.Health.V1;

namespace Sw.Grpc.HealthCheck;

public class HealthCheckService : Health.HealthBase
{
    private static readonly HealthCheckResponse _serving = new() { Status = HealthCheckResponse.Types.ServingStatus.Serving };

    public override Task<HealthCheckResponse> Check(HealthCheckRequest request, ServerCallContext context)
    {
        //检查逻辑...
        return Task.FromResult(_serving);
    }

    public override async Task Watch(HealthCheckRequest request, IServerStreamWriter<HealthCheckResponse> responseStream, ServerCallContext context)
    {
        //检查逻辑...
        await responseStream.WriteAsync(_serving);
    }
}
