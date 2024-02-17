using Booking.Gateway.Application.Models.Company;
using MediatR;

namespace Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;

public sealed record UpdateCompanyRequest : BaseCompanyDto, IRequest<UpdateCompanyResponse>
{
    public Guid Id { get; set; }
}