using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Filial.Requests;

namespace Booking.Gateway.Application.Features.FilialFeatures.UpdateFilial;

public sealed class UpdateFilialHandler : IRequestHandler<UpdateFilialRequest, UpdateFilialResponse>
{
    private readonly IRequestClient<ContractRequests.UpdateFilial> _requestFilial;
    private readonly IMapper _mapper;

    public UpdateFilialHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateFilial> requestFilial)
    {
        _mapper = mapper;
        _requestFilial = requestFilial;

    }
    
    public async Task<UpdateFilialResponse> Handle(UpdateFilialRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestFilial.GetResponse<UpdateFilialResult>(_mapper.Map<ContractRequests.UpdateFilial>(request), cancellationToken);
        return _mapper.Map<UpdateFilialResponse>(response.Message);
    }
}