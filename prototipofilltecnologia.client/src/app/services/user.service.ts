import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient : HttpClient) { }

  private readonly baseUrl = 'https://localhost:7214/api/Users/api'

  CreateUser(user: User)
  {
    return this.httpClient.post<User>(`${this.baseUrl}/CreateUser`,user);
  }


}
