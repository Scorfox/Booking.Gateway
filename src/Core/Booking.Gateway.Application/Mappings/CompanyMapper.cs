using AutoMapper;
using Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using CompanyGettingDto = Booking.Gateway.Application.Models.Company.CompanyGettingDto;

namespace Booking.Gateway.Application.Mappings;

public sealed class CompanyMapper : Profile
{
    public CompanyMapper()
    {
        // Create
        CreateMap<CreateCompanyRequest, CreateCompany>();
        CreateMap<CreateCompanyResult, CreateCompanyResponse>();
        
        // Read
        CreateMap<GetCompanyRequest, GetCompanyById>();
        CreateMap<GetCompanyResult, GetCompanyResponse>();
        
        CreateMap<GetCompaniesRequest, GetCompaniesList>();
        CreateMap<Otus.Booking.Common.Booking.Contracts.Company.Models.CompanyGettingDto, CompanyGettingDto>();

        // Update
        CreateMap<UpdateCompanyRequest, UpdateCompany>();
        CreateMap<UpdateCompanyResult, UpdateCompanyResponse>();
        
        // Delete
        CreateMap<DeleteCompanyRequest, DeleteCompany>();
        CreateMap<DeleteCompanyResult, DeleteCompanyResponse>();
    }
}