using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;

public sealed class GetCompaniesHandler : IRequestHandler<GetCompaniesRequest, GetCompaniesResponse>
{
    private readonly IMapper _mapper;

    public GetCompaniesHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetCompaniesResponse> Handle(GetCompaniesRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new GetCompaniesResponse();
    }
}