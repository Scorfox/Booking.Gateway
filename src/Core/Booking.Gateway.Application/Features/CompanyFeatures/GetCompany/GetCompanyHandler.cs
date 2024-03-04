using AutoMapper;
using MassTransit;
using MediatR;
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
        // TODO: запрос в Auth
        return new GetCompanyResponse();
    }
}