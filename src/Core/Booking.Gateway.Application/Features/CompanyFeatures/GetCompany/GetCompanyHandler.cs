using AutoMapper;
using Booking.Gateway.Application.Models.Company;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;

public sealed class GetCompanyHandler : IRequestHandler<GetCompanyRequest, GetCompanyResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetCompanyById> _requestCompany;

    public GetCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.GetCompanyById> requestCompany)
    {
        _mapper = mapper;
        _requestCompany = requestCompany;
    }

    public async Task<GetCompanyResponse> Handle(GetCompanyRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestCompany.GetResponse<GetCompanyResult>
            (_mapper.Map<ContractRequests.GetCompanyById>(request), cancellationToken);
        return _mapper.Map<GetCompanyResponse>(response.Message);
    }
}