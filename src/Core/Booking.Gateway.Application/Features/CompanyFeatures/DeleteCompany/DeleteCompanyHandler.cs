using AutoMapper;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;

public sealed class DeleteCompanyHandler : IRequestHandler<DeleteCompanyRequest, DeleteCompanyResponse>
{
    private readonly IMapper _mapper;

    public DeleteCompanyHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<DeleteCompanyResponse> Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        return new DeleteCompanyResponse();
    }
}