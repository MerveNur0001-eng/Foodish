using AutoMapper;
using Foodish.BusinessLayer.Abstract;
using Foodish.DtoLayer.Dtos.AboutDtos;
using Foodish.DtoLayer.Dtos.SilderDtos;
using Foodish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Foodish.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAboutService _aboutService;

        public AboutsController(IMapper mapper, IAboutService aboutService)
        {
            _mapper = mapper;
            _aboutService = aboutService;
        }

        public IActionResult AboutList()
        {
            var values = _aboutService.TGetAll();
            return View(_mapper.Map<List<ResultAboutDto>>(values));

        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<About>(createAboutDto);
            _aboutService.TInsert(value);
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return View(_mapper.Map<GetByIdAboutDto>(value));

        }
        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var values = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(values);
            return RedirectToAction("AboutList");
        }
    }
}

