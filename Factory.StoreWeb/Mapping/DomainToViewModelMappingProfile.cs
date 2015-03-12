﻿using AutoMapper;
using Factory.StoreDomainModule.Entities;
using Factory.StoreWeb.Models;

namespace Factory.StoreWeb.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Shopper, ShopperViewModel>()
                  .ForMember(dest => dest.ShopperId, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.ShopperName, opt => opt.MapFrom(src => src.Name));
        }

    }
}