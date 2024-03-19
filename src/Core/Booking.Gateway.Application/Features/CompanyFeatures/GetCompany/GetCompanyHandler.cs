using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;

public sealed class GetCompanyHandler : IRequestHandler<GetCompanyRequest, GetCompanyResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetCompanyById> _requestClient;

    public GetCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.GetCompanyById> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetCompanyResponse> Handle(GetCompanyRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestClient.GetResponse<GetCompanyResult>
            (_mapper.Map<ContractRequests.GetCompanyById>(request), cancellationToken);
        
        return _mapper.Map<GetCompanyResponse>(response.Message);
    }
}