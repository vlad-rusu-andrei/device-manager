import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../interfaces/user';

@Injectable({
  providedIn: 'root',
})

export class UserService {
  private URL = "http://localhost:5124/api/v1";

  constructor(private http : HttpClient) {}

  getUsers() : Observable<User[]> {
    return this.http.get<User[]>(`${this.URL}/users`);
  }

  getUser(id : number){
    return this.http.get(`${this.URL}/users/${id}`)
  }

  addUser(user : any){
    return this.http.post(`${this.URL}/users`, user);
  }

  updateUser(user : any, id : number){
    return this.http.post(`${this.URL}/users/${id}`, user);
  }

  deleteUser(id : number){
    return this.http.delete(`${this.URL}/users/${id}`);
  }
}
