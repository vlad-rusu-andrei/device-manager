import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Device } from '../interfaces/device';

@Injectable({
  providedIn: 'root',
})
export class DeviceService {
  private URL = "http://localhost:5124/api/v1";

  constructor(private http : HttpClient) {}

  getDevices() : Observable<Device[]> {
    console.log(this.URL);
    return this.http.get<Device[]>(`${this.URL}/devices`);
  }

  getDevice(id : number){
    return this.http.get(`${this.URL}/devices/${id}`)
  }

  addDevice(device : any){
    return this.http.post(`${this.URL}/devices`, device);
  }

  updateDevice(device : any, id : number){
    return this.http.post(`${this.URL}/devices/${id}`, device);
  }

  deleteDevice(id : number){
    return this.http.delete(`${this.URL}/devices/${id}`);
  }
}
