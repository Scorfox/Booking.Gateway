using AutoMapper;
using Booking.Gateway.Application.Features.FilialFeatures.GetFilial;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Filial.Requests;
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
        var response = await _requestCompany.GetResponse<GetCompanyRequest>(_mapper.Map<GetCompanyById>(request));
        return _mapper.Map<GetCompanyResponse>(response.Message);
    }
}