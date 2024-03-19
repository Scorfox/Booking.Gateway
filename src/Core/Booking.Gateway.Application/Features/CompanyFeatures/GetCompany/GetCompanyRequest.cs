using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;

public sealed record GetCompanyRequest : RequestById, IRequest<GetCompanyResponse>;