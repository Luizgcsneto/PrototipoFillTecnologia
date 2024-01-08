import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/User';
import { environment } from 'src/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient : HttpClient) { }

  private readonly baseUrl = environment['endpointUser']

  CreateUser(user: User)
  {
    return this.httpClient.post<User>(`${this.baseUrl}/CreateUser`,user);
  }


}
