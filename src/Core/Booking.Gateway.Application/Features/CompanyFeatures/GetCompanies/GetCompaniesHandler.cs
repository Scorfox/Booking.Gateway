using AutoMapper;
using Booking.Gateway.Application.Models.Company;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;

public sealed class GetCompaniesHandler : IRequestHandler<GetCompaniesRequest, GetCompaniesResponse>
{
    private IRequestClient<GetCompaniesList> _requestClient;
    private readonly IMapper _mapper;

    public GetCompaniesHandler(IMapper mapper, IRequestClient<GetCompaniesList> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetCompaniesResponse> Handle(GetCompaniesRequest request, CancellationToken cancellationToken)
    {
        var req = _mapper.Map<GetCompaniesList>(request);
        var response = await _requestClient.GetResponse<GetCompaniesListResult>(req, cancellationToken);

        return new GetCompaniesResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<CompanyGettingDto>>(response.Message.Elements)
        };
    }
}