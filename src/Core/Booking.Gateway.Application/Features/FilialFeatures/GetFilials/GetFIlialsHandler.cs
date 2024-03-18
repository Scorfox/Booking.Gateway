using AutoMapper;
using Booking.Gateway.Application.Models.Filial;
using MassTransit;
using MediatR;
using Otus.Booking.Common.Booking.Contracts.Filial.Requests;
using Otus.Booking.Common.Booking.Contracts.Filial.Responses;

namespace Booking.Gateway.Application.Features.FilialFeatures.GetFilials;

public sealed class GetFilialsHandler : IRequestHandler<GetFilialsRequest, GetFilialsResponse>
{
    private readonly IMapper _mapper;
    private IRequestClient<GetFilialsList> _requestClient;

    public GetFilialsHandler(IMapper mapper, IRequestClient<GetFilialsList> requestClient)
    {
        _mapper = mapper;
        _requestClient = requestClient;
    }

    public async Task<GetFilialsResponse> Handle(GetFilialsRequest request, CancellationToken cancellationToken)
    {
        var req = _mapper.Map<GetFilialsList>(request);
        var response = await _requestClient.GetResponse<GetFilialsListResult>(req, cancellationToken);

        return new GetFilialsResponse
        {
            Offset = request.Offset, 
            TotalCount = response.Message.Elements.Count, 
            Count = request.Count,
            Items = _mapper.Map<List<FilialGettingDto>>(response.Message.Elements)
        };
    }
}