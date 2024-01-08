import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from 'src/app/models/User';
import { MenuService } from 'src/app/services/menu.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  userForm : FormGroup;
  constructor(public menuService: MenuService,
    public formBuilder: FormBuilder,
    public userService : UserService,
    private router: Router) {


  }

  ngOnInit(): void {
    this.menuService.menuSelecionado = 4

    this.userForm = this.formBuilder.group(
      {
        email: ['',[Validators.required,Validators.email]],
        password: ['',[Validators.required]],
        cpf: ['',[Validators.required]]
      })
  }

  dadosForm(){
    return this.userForm.controls
  }

  enviar(){

    var dados = this.dadosForm()
    let item = new User()
    item.email = dados['email'].value
    item.password = dados['password'].value
    item.cpf = dados['cpf'].value

    this.userService.CreateUser(item).subscribe(
      (response: User) =>{
        this.userForm.reset()
        window.location.reload()
      }
    ),
    (error) => console.error(error), () => {}
  }

}
