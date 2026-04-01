using DeviceManager.manager.dto;
using DeviceManager.manager.entity;
using DeviceManager.manager.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.service
{
    public class DeviceService
    {
        private readonly DeviceManagerDbContext _dbContext;

        public DeviceService(DeviceManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Device> GetAllDevices()
        {
            return _dbContext.Devices.ToList();
        }

        //user may not exist
        public Device? GetDeviceById(uint Id)
        {
            return _dbContext.Devices.FirstOrDefault(u => u.Id == Id);
        }

        public void AddDevice(Device device)
        {
            _dbContext.Devices.Add(device);
            _dbContext.SaveChanges();
        }

        public void UpdateDevice(DeviceDTO device)
        {
            var dbDevice = _dbContext.Devices.FirstOrDefault(u => u.Id == device.Id);

            if (dbDevice == null) return;

            if(device.Name != null) dbDevice.Name = device.Name;
            if(device.Manufacturer  != null) dbDevice.Manufacturer = device.Manufacturer;
            if(device.Type.HasValue) dbDevice.Type = device.Type.Value;
            if(device.Os != null) dbDevice.Os = device.Os;
            if(device.Osversion != null) dbDevice.Osversion = device.Osversion;
            if(device.Processor != null) dbDevice.Processor = device.Processor;
            if(device.Ram.HasValue) dbDevice.Ram = device.Ram.Value;
            if(device.Description  != null) dbDevice.Description = device.Description;

            _dbContext.SaveChanges();
        }

        public void DeleteDevice(uint Id)
        {
            var device = _dbContext.Devices.FirstOrDefault(u => u.Id == Id);

            if (device == null) return;

            _dbContext.Devices.Remove(device);
            _dbContext.SaveChanges();
        }
    }
}
