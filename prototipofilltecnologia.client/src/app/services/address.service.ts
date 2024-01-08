import { Injectable } from '@angular/core';
import { Address } from '../models/Address';
import { environment } from 'src/environment';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AddressService {

  constructor(private httpClient : HttpClient) { }

  private readonly baseUrl = environment['endpoint']

  UpdateAddress(address: Address){
    return this.httpClient.put<Address>(`${this.baseUrl}/UpdateAddress`,address)
  }

  CreateAddress(address : Address){
    return this.httpClient.post<Address>(`${this.baseUrl}/CreateAddress`,
    address)
  }

  GetAllAddress(){
    return this.httpClient.get<Address[]>(`${this.baseUrl}/GetAllAddress`)
  }

  GetAddressById(id: number){
    return this.httpClient.get<Address>(`${this.baseUrl}/GetAddressById/${id}`)
  }


}
