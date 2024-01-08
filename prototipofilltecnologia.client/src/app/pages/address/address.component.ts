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
  addresses: Address[]
  constructor(public menuService: MenuService,
    public addressService: AddressService,
    public formBuilder: FormBuilder,
    private router: Router) {
  }
  ngOnInit(): void {
    this.menuService.menuSelecionado = 3

    this.addressForm = this.formBuilder.group(
      {
        Id: ['',[Validators.required]],
        Street: ['',[Validators.required]],
        Neighborhood: ['',[Validators.required]],
        Number: ['',[Validators.required]],
        City: ['',[Validators.required]],
        State: ['',[Validators.required]],
        Country: ['',[Validators.required]]
      })

      this.addressService.GetAllAddress().subscribe(
        response =>{
          this.addresses = response
        }
      ),
      (error) => console.error(error), () => {}
  }

  dadosForm(){
    return this.addressForm.controls
  }

  enviar(){

    var dados = this.dadosForm()
    let item = new Address()
    item.Id = 0
    item.Street = dados['Street'].value
    item.Neighborhood = dados['Neighborhood'].value
    item.Number = dados['Number'].value
    item.State = dados['State'].value
    item.City = dados['City'].value
    item.Country = dados['Country'].value

    this.addressService.CreateAddress(item).subscribe(
      (response: Address) =>{
        this.addressForm.reset()
        alert("Endereço cadastrado com sucesso")
        this.router.navigate(['/dashboard'])
      }
    ),
    (error) => console.error(error), () => {}

  }








}
