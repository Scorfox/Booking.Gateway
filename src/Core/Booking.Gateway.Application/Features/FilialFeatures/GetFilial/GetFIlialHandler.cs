using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Filial.Requests;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilial;

public sealed class GetFilialHandler : IRequestHandler<GetFilialRequest, GetFilialResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetFilialById> _requestClient;

    public GetFilialHandler(IMapper mapper, IRequestClient<ContractRequests.GetFilialById> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetFilialResponse> Handle(GetFilialRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetFilialResult>
            (_mapper.Map<ContractRequests.GetFilialById>(request), cancellationToken);
        
        return _mapper.Map<GetFilialResponse>(response.Message);
    }
}