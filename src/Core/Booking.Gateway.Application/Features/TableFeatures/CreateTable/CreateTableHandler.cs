using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Table.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Table.Requests;

namespace Booking.Gateway.Application.Features.TableFeatures.CreateTable;

public sealed class CreateTableHandler : IRequestHandler<CreateTableRequest, CreateTableResponse>
{
    private readonly IRequestClient<ContractRequests.CreateTable> _requestTable;
    private readonly IMapper _mapper;

    public CreateTableHandler(IMapper mapper, IRequestClient<ContractRequests.CreateTable> requestTable)
    {
        _mapper = mapper;
        _requestTable = requestTable;
    }
    
    public async Task<CreateTableResponse> Handle(CreateTableRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestTable.GetResponse<CreateTableResult>(_mapper.Map<ContractRequests.CreateTable>(request), cancellationToken);
        return _mapper.Map<CreateTableResponse>(response.Message);
    }
}