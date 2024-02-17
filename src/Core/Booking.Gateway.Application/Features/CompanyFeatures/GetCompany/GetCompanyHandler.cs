using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;

public sealed class GetCompanyHandler : IRequestHandler<GetCompanyRequest, GetCompanyResponse>
{
    private readonly IMapper _mapper;

    public GetCompanyHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetCompanyResponse> Handle(GetCompanyRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetCompanyResponse();
    }
}