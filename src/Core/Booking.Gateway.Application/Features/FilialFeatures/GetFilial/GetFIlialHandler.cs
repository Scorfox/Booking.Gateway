using AutoMapper;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;
using ContractRequests = Otus.Booking.Common.Booking.Contracts.Filial.Requests;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilial;

public sealed class GetFilialHandler : IRequestHandler<GetFilialRequest, GetFilialResponse>
{
    private readonly IMapper _mapper;
    private readonly IRequestClient<ContractRequests.GetFilialId> _requestFilial;

    public GetFilialHandler(IMapper mapper, IRequestClient<ContractRequests.GetFilialId> requestFilial)
    {
        _mapper = mapper;
        _requestFilial = requestFilial;
    }

    public async Task<GetFilialResponse> Handle(GetFilialRequest request, CancellationToken cancellationToken)
    {
        // TODO: запрос в Auth
        return new GetFilialResponse();
    }
}