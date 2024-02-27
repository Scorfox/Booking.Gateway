using AutoMapper;
using MassTransit;
using MediatR;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;

public sealed class DeleteCompanyHandler : IRequestHandler<DeleteCompanyRequest, DeleteCompanyResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.DeleteCompany> _requestCompany;

    public DeleteCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.DeleteCompany> requestCompany)
    {
        _requestCompany = requestCompany;
        _mapper = mapper;
    }

    public async Task<DeleteCompanyResponse> Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Booking.Auth
        await _requestCompany.GetResponse<ContractRequests.DeleteCompany>(
            _mapper.Map<ContractRequests.DeleteCompany>(request), cancellationToken);

        return new DeleteCompanyResponse{Id = request.Id};
    }
}