using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Filial.Requests;

namespace Booking.Gateway.Application.Features.FilialFeatures.CreateFilial;

public sealed class CreateFilialHandler : IRequestHandler<CreateFilialRequest, CreateFilialResponse>
{
    private readonly IRequestClient<ContractRequests.CreateFilial> _requestFilial;
    private readonly IMapper _mapper;

    public CreateFilialHandler(IMapper mapper, IRequestClient<ContractRequests.CreateFilial> requestFilial)
    {
        _mapper = mapper;
        _requestFilial = requestFilial;

    }
    
    public async Task<CreateFilialResponse> Handle(CreateFilialRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestFilial.GetResponse<CreateFilialResult>(_mapper.Map<ContractRequests.CreateFilial>(request), cancellationToken);
        return _mapper.Map<CreateFilialResponse>(response.Message);
    }
}