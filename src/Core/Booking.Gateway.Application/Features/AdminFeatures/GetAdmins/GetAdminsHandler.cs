using AutoMapper;
using Booking.Gateway.Application.Models.Admin;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;

namespace Booking.Gateway.Application.Features.AdminFeatures.GetAdmins;

public sealed class GetAdminsHandler : IRequestHandler<GetAdminsRequest, GetAdminsResponse>
{
    private readonly IMapper _mapper;
    private IRequestClient<GetAdminsRequest> _requestClient;

    public GetAdminsHandler(IMapper mapper, IRequestClient<GetAdminsRequest> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetAdminsResponse> Handle(GetAdminsRequest request, CancellationToken cancellationToken)
    {
        var req = _mapper.Map<GetCompaniesList>(request);
        var response = await _requestClient.GetResponse<GetCompaniesListResult>(req, cancellationToken);

        return new GetAdminsResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<AdminGettingDto>>(response.Message.Elements)
        };
    }
}