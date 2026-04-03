import { Component, OnInit } from '@angular/core';
import { DeviceService } from '../../services/device-service';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { Device } from '../../interfaces/device';



@Component({
  selector: 'app-devices',
  imports: [CommonModule],
  templateUrl: './devices.html',
  styleUrl: './devices.css',
})
export class DeviceComponent implements OnInit{

    // async call so data arrives correctly to be rendered
    devices$!: Observable<Device[]>;

    constructor(private deviceService : DeviceService) {}

    ngOnInit(): void {
      this.devices$ = this.deviceService.getDevices();
    }
  
}
