using AutoMapper;
using Booking.Gateway.Application.Features.ClientFeatures.GetClient;
using Booking.Gateway.Application.Features.CompanyFeatures.CreateCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.DeleteCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompanies;
using Booking.Gateway.Application.Features.CompanyFeatures.GetCompany;
using Booking.Gateway.Application.Features.CompanyFeatures.UpdateCompany;
using Booking.Gateway.Application.Models.Company;
using Otus.Booking.Common.Booking.Contracts.Company.Models;
using Otus.Booking.Common.Booking.Contracts.Company.Requests;
using Otus.Booking.Common.Booking.Contracts.Company.Responses;
using Otus.Booking.Common.Booking.Contracts.User.Requests;
using Otus.Booking.Common.Booking.Contracts.User.Responses;
using CompanyGettingDto = Booking.Gateway.Application.Models.Company.CompanyGettingDto;

namespace Booking.Gateway.Application.Mappings;

public sealed class CompanyMapper : Profile
{
    public CompanyMapper()
    {
        CreateMap<CreateCompanyRequest, CreateCompany>();
        CreateMap<CreateCompanyResult, CreateCompanyResponse>();

        CreateMap<DeleteCompanyRequest, DeleteCompany>();
        CreateMap<DeleteCompanyResult, DeleteCompanyResponse>();

        CreateMap<GetCompaniesRequest, GetCompaniesList>();
        CreateMap<Otus.Booking.Common.Booking.Contracts.Company.Models.CompanyGettingDto, CompanyGettingDto>();

        CreateMap<UpdateCompanyRequest, UpdateCompany>();
        CreateMap<UpdateCompanyResult, UpdateCompanyResponse>();

        CreateMap<GetCompanyRequest, GetCompanyById>();
        CreateMap<GetCompanyResult, GetCompanyResponse>();
    }
}