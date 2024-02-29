using AutoMapper;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Models;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;

public sealed class GetCompanyHandler : IRequestHandler<GetCompanyRequest, GetCompanyResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetCompanyId> _requestCompany;

    public GetCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.GetCompanyId> requestCompany)
    {
        _mapper = mapper;
        _requestCompany = requestCompany;
    }

    public async Task<GetCompanyResponse> Handle(GetCompanyRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestCompany.GetResponse<FullCompanyDto>(_mapper.Map<ContractRequests.GetCompanyId>(request));
        return _mapper.Map<GetCompanyResponse>(response.Message);
    }
}