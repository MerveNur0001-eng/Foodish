using AutoMapper;
using Foodish.BusinessLayer.Abstract;
using Foodish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Foodish.DtoLayer.Dtos.SilderDtos;
namespace Foodish.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IActionResult SliderList()
        {
            var values = _sliderService.TGetAll();
            return View( _mapper.Map<List<ResultSliderDto>>(values));
            
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var values = _mapper.Map<Slider>(createSliderDto);
            _sliderService.TInsert(values);
            return RedirectToAction("SliderList");
        }

        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = _sliderService.TGetByID(id);
            return View(_mapper.Map<UpdateSliderDto>(value));
            
        }
        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var values = _mapper.Map<Slider>(updateSliderDto);
            _sliderService.TUpdate(values);
            return RedirectToAction("SliderList");
        }
    }
}
