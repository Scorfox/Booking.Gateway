using AutoMapper;
using Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;

namespace Booking.Gateway.Application.Mappings;

public sealed class CompanyMapper : Profile
{
    public CompanyMapper()
    {
        CreateMap<CreateCompanyRequest, CreateCompany>();
        CreateMap<CreateCompanyResult, CreateCompanyResponse>();

        CreateMap<UpdateCompanyRequest, UpdateCompany>();
        CreateMap<UpdateCompanyResult, UpdateCompanyResponse>();
    }
}