import { Component, OnInit } from '@angular/core';

import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginService } from '../../services/login.service';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm : FormGroup;

  constructor(public formBuilder: FormBuilder,
    private router: Router,
    private loginService : LoginService,
    public authService: AuthService) { }

  ngOnInit(): void
  {

    this.loginForm = this.formBuilder.group(
      {
        email: ['',[Validators.required,Validators.email]],
        password: ['',[Validators.required]]
      }
    )
  }

  get dadosForm()
  {
    return this, this.loginForm.controls;
  }

  loginUser()
  {
    this.loginService.login(this.dadosForm["email"].value, this.dadosForm["password"].value).subscribe(
      token => {
        this.authService.setToken(token)
        this.authService.setEmailUser(this.dadosForm["email"].value)
        this.authService.usuarioAutenticado(true)
        alert("Login Realizado com sucesso")
        this.router.navigate(['/dashboard'])
      },
      err => {
        alert("ocorreu um erro")
      }

    )
  }
}
