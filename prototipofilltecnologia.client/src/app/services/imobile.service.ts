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
    return this.httpClient.post<Imobile>(`${this.baseUrl}/CreateImobile`,
    imobile)
  }
}
