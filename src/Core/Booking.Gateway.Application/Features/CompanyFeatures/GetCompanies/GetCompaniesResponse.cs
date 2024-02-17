using Booking.Gateway.Application.Common;
using Booking.Gateway.Application.Models.Company;

namespace Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;

public record GetCompaniesResponse : ResponseWithPagination<CompanyGettingDto> { }