using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.FeatureDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public FeaturesController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.GetAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            _featureService.Add(value);
            return Ok("Öne Çıkan Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.GetById(id);
            _featureService.Delete(value);
            return Ok("Öne Çıkan Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.GetById(id);
            return Ok(_mapper.Map<GetFeatureDto>(value));
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var value = _mapper.Map<Feature>(updateFeatureDto);
            _featureService.Update(value);
            return Ok("Öne Çıkan Bilgisi Güncellendi");
        }
    }
}
