using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Models;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.GetTable;

public sealed class GetTableHandler : IRequestHandler<GetTableRequest, GetTableResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetTableById> _tableFilial;

    public GetTableHandler(IMapper mapper, IRequestClient<ContractRequests.GetTableById> tableFilial)
    {
        _mapper = mapper;
        _tableFilial = tableFilial;
    }

    public async Task<GetTableResponse> Handle(GetTableRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Auth
        return new GetTableResponse();
    }
}