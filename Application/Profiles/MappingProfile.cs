using Application.Features.Categories.Queries.GetCategoriesList.DTOs;
using Application.Features.Categories.Queries.GetCategoriesListWithTrips.DTOs;
using Application.Features.Organizations.Queries.GetOrganizationList.DTOs;
using Application.Features.Organizations.Queries.GetOrganizationListWithTrips.DTOs;
using Application.Features.Trips.Queries.GetTripDetail.DTOs;
using Application.Features.Trips.Queries.GetTripList.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Trip, TripsListResponse>();
            CreateMap<Trip, TripDetailResponse>();
            CreateMap<Category, TripCategoryResponse>();
            CreateMap<Organization, TripOrganizationResponse>();
            CreateMap<Image, TripImageResponse>();
            CreateMap<Package, TripPackageResponse>();
            CreateMap<Category, CategoryListResponse>();
            CreateMap<Category, CategoryTripListResponse>();
            CreateMap<Trip, CategoryTripResponse>();
            CreateMap<Organization, OrganizationListResponse>();
            CreateMap<Organization, OrganizationTripListResponse>();
            CreateMap<Trip, OrganizationTripResponse>();
        }
    }
}
