using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Filial.Requests;
namespace Booking.Gateway.Application.Features.FilialFeatures.DeleteFilial;

public sealed class DeleteFilialHandler : IRequestHandler<DeleteFilialRequest, DeleteFilialResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.DeleteFilial> _requestClient;

    public DeleteFilialHandler(IMapper mapper, IRequestClient<ContractRequests.DeleteFilial> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<DeleteFilialResponse> Handle(DeleteFilialRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<DeleteFilialResult>
            (_mapper.Map<ContractRequests.DeleteFilial>(request), cancellationToken);
        
        return _mapper.Map<DeleteFilialResponse>(response.Message);
    }
}