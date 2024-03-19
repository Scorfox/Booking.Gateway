using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;

public sealed class UpdateCompanyHandler : IRequestHandler<UpdateCompanyRequest, UpdateCompanyResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.UpdateCompany> _requestCompany;

    public UpdateCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.UpdateCompany> requestCompany)
    {
        _mapper = mapper;
        _requestCompany = requestCompany;
    }
    
    public async Task<UpdateCompanyResponse> Handle(UpdateCompanyRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestCompany.GetResponse<UpdateCompanyResult>
            (_mapper.Map<ContractRequests.UpdateCompany>(request), cancellationToken);
        
        return _mapper.Map<UpdateCompanyResponse>(response.Message);
    }
}