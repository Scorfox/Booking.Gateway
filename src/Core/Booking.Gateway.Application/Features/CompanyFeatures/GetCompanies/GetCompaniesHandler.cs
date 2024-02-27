using AutoMapper;
using Booking.Gateway.Application.Models.Company;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;

public sealed class GetCompaniesHandler : IRequestHandler<GetCompaniesRequest, GetCompaniesResponse>
{
    private IRequestClient<GetCompaniesList> _requestCompanies;
    private readonly IMapper _mapper;

    public GetCompaniesHandler(IMapper mapper, IRequestClient<GetCompaniesList> reqCompanies)
    {
        _mapper = mapper;
        _requestCompanies = reqCompanies;
    }

    public async Task<GetCompaniesResponse> Handle(GetCompaniesRequest request, CancellationToken cancellationToken)
    {
        var req = _mapper.Map<GetCompaniesList>(request);
        var response =

            await _requestCompanies.GetResponse<GetCompaniesListResult>(req, cancellationToken);

        return new GetCompaniesResponse
        {
            Offset = request.Offset, TotalCount = response.Message.Companies.Count, Count = request.Count,
            Items = response.Message.Companies.Select(elm=>_mapper.Map<CompanyGettingDto>(elm)).ToList()
        };
    }
}