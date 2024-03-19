using AutoMapper;
using Booking.Gateway.Application.Models.Company;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;

public sealed class GetCompaniesHandler : IRequestHandler<GetCompaniesRequest, GetCompaniesResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<GetCompaniesList> _requestClient;

    public GetCompaniesHandler(IMapper mapper, IRequestClient<GetCompaniesList> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetCompaniesResponse> Handle(GetCompaniesRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetCompaniesListResult>
            (_mapper.Map<GetCompaniesList>(request), cancellationToken);

        return new GetCompaniesResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<CompanyGettingDto>>(response.Message.Elements)
        };
    }
}