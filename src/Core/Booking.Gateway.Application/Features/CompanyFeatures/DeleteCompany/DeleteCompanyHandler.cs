using AutoMapper;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Company.Requests;

namespace Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;

public sealed class DeleteCompanyHandler : IRequestHandler<DeleteCompanyRequest, DeleteCompanyResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.DeleteCompany> _requestCompany;

    public DeleteCompanyHandler(IMapper mapper, IRequestClient<ContractRequests.DeleteCompany> requestCompany)
    {
        _mapper = mapper;
        _requestCompany = requestCompany;
    }

    public async Task<DeleteCompanyResponse> Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
    {
        await _requestCompany.GetResponse<DeleteCompanyResult>
            (_mapper.Map<ContractRequests.DeleteCompany>(request), cancellationToken);

        return new DeleteCompanyResponse { Id = request.Id };
    }
}