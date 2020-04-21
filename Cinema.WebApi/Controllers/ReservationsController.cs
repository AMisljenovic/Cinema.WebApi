﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cinema.WebApi.Configuration;
using Cinema.WebApi.Interfaces;
using Cinema.WebApi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(Constants.CorsPolicy)]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationRepository<Reservation> _dataRepository;

        public ReservationsController(IReservationRepository<Reservation> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet("{repertoryId}")]
        public async Task<IActionResult> Get(string repertoryId)
        {
            if (!Guid.TryParse(repertoryId, out var parsedId))
            {
                return BadRequest("Invalid repertory id");
            }

            return Ok( await _dataRepository.GetByRepertory(repertoryId));
        }

        [HttpGet("{repertoryId}/{userId}")]
        public async Task<IActionResult> GetByRepertoryAndUser(string repertoryId, string userId)
        {
            if (!Guid.TryParse(userId, out var parsedId))
            {
                return BadRequest("Invalid user id");
            }

            if (!Guid.TryParse(userId, out var parsedUserId))
            {
                return BadRequest("Invalid user id");
            }

            return Ok(await _dataRepository.GetByRepertoryAndUser(repertoryId, userId));
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUser(string userId)
        {
            if (!Guid.TryParse(userId, out var parsedId))
            {
                return BadRequest("Invalid user id");
            }

            return Ok(await _dataRepository.GetByUser(userId));
        }

        [HttpPost]
        public async Task<IActionResult> Post(List<Reservation> tickets)
        {
            await _dataRepository.Add(tickets);

            return Ok();
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Put([FromBody] Reservation ticket)
        {
            await _dataRepository.Update(ticket);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteReservations([FromBody] string[] reservationsIds)
        {
            await _dataRepository.DeleteByIds(reservationsIds);

            return Ok();
        }

        [HttpDelete("{repertoryId}")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> Delete(string repertoryId)
        {
            if (!Guid.TryParse(repertoryId, out var parsedId))
            {
                return BadRequest("Invalid repertory id");
            }
            await _dataRepository.Delete(repertoryId);

            return Ok();
        }
    }
}
