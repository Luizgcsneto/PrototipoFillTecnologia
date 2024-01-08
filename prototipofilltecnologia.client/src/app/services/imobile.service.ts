import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Imobile } from '../models/Imobile';

@Injectable({
  providedIn: 'root'
})
export class ImobileService {

  constructor(private httpClient : HttpClient) { }

  private readonly baseUrl = 'https://localhost:7214/api'

  CreateImobile(imobile : Imobile){
    return this.httpClient.post<Imobile>(`${this.baseUrl}/CreateImobile`,imobile)
  }

  GetAllImobiles(){
    return this.httpClient.get<Imobile[]>(`${this.baseUrl}/GetAllImobiles`)
  }

  GetAddressById(id: number){
    return this.httpClient.get<Imobile>(`${this.baseUrl}/GetAddressById/${id}`)
  }

  UpdateImobile(imobile : Imobile){
    return this.httpClient.put<Imobile>(`${this.baseUrl}/UpdateImobile`,imobile)
  }


}
