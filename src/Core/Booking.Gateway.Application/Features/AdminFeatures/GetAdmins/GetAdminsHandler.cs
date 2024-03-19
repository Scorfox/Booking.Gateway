using AutoMapper;
using Booking.Gateway.Application.Models.Admin;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.User.Requests;
using Otus.Booking.Common.Booking.Contracts.User.Responses;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmins;

public sealed class GetAdminsHandler : IRequestHandler<GetAdminsRequest, GetAdminsResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<GetAdminsRequest> _requestClient;

    public GetAdminsHandler(IMapper mapper, IRequestClient<GetAdminsRequest> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetAdminsResponse> Handle(GetAdminsRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetUsersListResult>
            (_mapper.Map<GetUsersList>(request), cancellationToken);

        return new GetAdminsResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<AdminGettingDto>>(response.Message.Elements)
        };
    }
}