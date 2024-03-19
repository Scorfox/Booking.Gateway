using Booking.Gateway.Application.Common;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;

public sealed record DeleteCompanyRequest : RequestById, IRequest<DeleteCompanyResponse>;