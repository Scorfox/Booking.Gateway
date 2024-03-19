using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Filial.Requests;

namespace Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;

public sealed class CreateFilialHandler : IRequestHandler<CreateFilialRequest, CreateFilialResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.CreateFilial> _requestClient;

    public CreateFilialHandler(IMapper mapper, IRequestClient<ContractRequests.CreateFilial> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }
    
    public async Task<CreateFilialResponse> Handle(CreateFilialRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<CreateFilialResult>
            (_mapper.Map<ContractRequests.CreateFilial>(request), cancellationToken);
        
        return _mapper.Map<CreateFilialResponse>(response.Message);
    }
}