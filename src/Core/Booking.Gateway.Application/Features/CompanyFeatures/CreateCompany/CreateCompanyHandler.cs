using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;

public sealed class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResponse>
{
    private readonly IRequestClient<ContractRequests.CreateCompany> _requestCompany;
    private readonly IMapper _mapper;

    public CreateCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.CreateCompany> requestCompany)
    {
        _mapper = mapper;
        _requestCompany = requestCompany;

    }
    
    public async Task<CreateCompanyResponse> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
    {
        var response = await _requestCompany.GetResponse<CreateCompanyResult>(_mapper.Map<ContractRequests.CreateCompany>(request), cancellationToken);
        return _mapper.Map<CreateCompanyResponse>(response.Message);
    }
}