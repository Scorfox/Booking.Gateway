using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Auth.Requests;
using Otus.Booking.Common.Booking.Contracts.Auth.Responses;

namespace Booking.Gateway.Application.Features.AuthFeatures;

public sealed class AuthenticateHandler : IRequestHandler<AuthenticateRequest, AuthenticateResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<Authenticate> _requestClient;

    public AuthenticateHandler(IMapper mapper, IRequestClient<Authenticate> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<AuthenticateResponse> Handle(AuthenticateRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<AuthenticateResult>
            (_mapper.Map<Authenticate>(request), cancellationToken);
        
        return _mapper.Map<AuthenticateResponse>(response.Message);
    }
}