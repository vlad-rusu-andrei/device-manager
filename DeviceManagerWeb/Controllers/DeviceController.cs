using DeviceManager.manager.dto;
using DeviceManager.manager.entity;
using DeviceManager.manager.service;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerWeb.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly DeviceService _deviceService;

        public DeviceController(DeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        // GET users api/v1/devices
        [HttpGet]
        public IActionResult GetAllDevices()
        {
            return Ok(_deviceService.GetAllDevices());
        }

        // GET user api/v1/devices/400
        [HttpGet("{id}")]
        public IActionResult GetDevice(uint id)
        {
            var device = _deviceService.GetDeviceById(id);
            if (device == null) return NotFound();

            return Ok(device);
        }

        // POST user api/v1/devices
        [HttpPost]
        public IActionResult AddDevice(Device device)
        {
            _deviceService.AddDevice(device);
            return Ok(device);
        }

        // POST update device api/v1/devices/400
        [HttpPost("{id}")]
        public IActionResult UpdateDevice(DeviceDTO device)
        {
            _deviceService.UpdateDevice(device);
            return Ok();
        }

        // DELETE user api/v1/devices/400
        [HttpDelete]
        public IActionResult DeleteDevice(uint id)
        {
            _deviceService.DeleteDevice(id);
            return Ok();
        }
    }
}
