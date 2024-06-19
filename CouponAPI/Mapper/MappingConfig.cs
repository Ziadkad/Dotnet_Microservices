using AutoMapper;
using CouponAPI.DTO;
using CouponAPI.Models;

namespace CouponAPI.Mapper;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<Coupon, CouponDTO>().ReverseMap();
        });
        return mappingConfig;
    }
}