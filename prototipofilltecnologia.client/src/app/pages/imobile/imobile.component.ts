import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Imobile } from 'src/app/models/Imobile';
import { ImobileService } from 'src/app/services/imobile.service';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-imobile',
  templateUrl: './imobile.component.html',
  styleUrls: ['./imobile.component.css']
})
export class ImobileComponent implements OnInit {

  imobileForm : FormGroup;
  imobiles : Imobile[]
  constructor(
    public menuService: MenuService,
    public formBuilder: FormBuilder,
    public imobileService: ImobileService,
    private router: Router) {

  }

  ngOnInit(): void {
    this.menuService.menuSelecionado = 2

    this.imobileForm = this.formBuilder.group(
      {
        title: ['',[Validators.required]],
        district: ['',[Validators.required]],
        numberRooms: ['',[Validators.required]],
        businessType: ['',[Validators.required]],
        price: ['',[Validators.required]]
      })

        this.imobileService.GetAllImobiles().subscribe(response => {
          this.imobiles = response
      }),
      (error) => console.error(error), () => {}
  }

  dadosForm(){
    return this.imobileForm.controls
  }

  enviar(){

    var dados = this.dadosForm()
    let item = new Imobile()
    item.id = 0
    item.title = dados['title'].value
    item.district = dados['district'].value
    item.numberRooms = dados['numberRooms'].value
    item.businessType = dados['businessType'].value
    item.address.Id = 0
    item.address.City = ""
    item.address.State = ""
    item.address.Street = ""
    item.address.Country = ""
    item.address.Number = 0
    item.address.Neighborhood = ""


    this.imobileService.CreateImobile(item).subscribe(
      (response: Imobile) =>{
        this.imobileForm.reset()
        alert("Imóvel cadastrado com sucesso")
        this.router.navigate(['/dashboard'])
      }
    ),
    (error) => console.error(error), () => {}

  }

}
