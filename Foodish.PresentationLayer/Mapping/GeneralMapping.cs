using AutoMapper;
using Foodish.EntityLayer.Concrete;
using Foodish.DtoLayer.Dtos.AboutDtos;
using Foodish.DtoLayer.Dtos.SilderDtos;
using Foodish.DtoLayer.Dtos.ReviewDtos;

namespace Foodish.PresentationLayer.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<GetByIdAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            CreateMap<ResultSliderDto,Slider>().ReverseMap();
            CreateMap<CreateSliderDto,Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto,Slider>().ReverseMap();
            CreateMap<UpdateSliderDto,Slider>().ReverseMap();
            CreateMap<ResultReviewDto, Review>().ReverseMap();
        }
    }
}
