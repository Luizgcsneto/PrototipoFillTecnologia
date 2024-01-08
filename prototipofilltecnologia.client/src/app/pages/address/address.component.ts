import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Address } from 'src/app/models/Address';
import { AddressService } from 'src/app/services/address.service';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {

  addressForm : FormGroup
  addressList: Address[]
  constructor(public menuService: MenuService,
    public addressService: AddressService,
    public formBuilder: FormBuilder,
    private router: Router) {
  }
  ngOnInit(): void {
    this.menuService.menuSelecionado = 3

    this.addressForm = this.formBuilder.group(
      {
        id: ['',[Validators.required]],
        street: ['',[Validators.required]],
        neighborhood: ['',[Validators.required]],
        number: ['',[Validators.required]],
        city: ['',[Validators.required]],
        state: ['',[Validators.required]],
        country: ['',[Validators.required]]
      })

      this.addressService.GetAllAddress().subscribe(response => {
        this.addressList = response
    }),
    (error) => console.error(error), () => {}

  }

  dadosForm(){
    return this.addressForm.controls
  }

  enviar(){

    var dados = this.dadosForm()
    let item = new Address()
    item.id = 0
    item.street = dados['street'].value
    item.neighborhood = dados['neighborhood'].value
    item.number = dados['number'].value
    item.state = dados['state'].value
    item.city = dados['city'].value
    item.country = dados['country'].value

    this.addressService.CreateAddress(item).subscribe(
      (response: Address) =>{
        this.addressForm.reset()
        window.location.reload()
      }
    ),
    (error) => console.error(error), () => {}

  }








}
