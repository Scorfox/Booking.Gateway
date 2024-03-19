using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;

public sealed record GetCompaniesRequest : RequestWithPagination, IRequest<GetCompaniesResponse>;