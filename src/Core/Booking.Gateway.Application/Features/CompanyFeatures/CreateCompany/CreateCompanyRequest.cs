using Booking.Gateway.Application.Models.Company;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;

public sealed record CreateCompanyRequest : BaseCompanyDto, IRequest<CreateCompanyResponse> { }