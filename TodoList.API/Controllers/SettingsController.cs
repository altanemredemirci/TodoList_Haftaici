﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.API.Repositories.Abstract;
using TodoList.Core.Models;

namespace TodoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsModelRepository _settingsRepository;

        public SettingsController(ISettingsModelRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSettings()
        {
            var result = await _settingsRepository.GetSingleAsync(x => x.Id == 1);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddSettings([FromBody] SettingsModel model)
        {
            var result = await _settingsRepository.InsertAsync(model);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSettings([FromBody] SettingsModel model)
        {
            var result = await _settingsRepository.UpdateAsync(model);

            return Ok(result);
        }
    }
}
