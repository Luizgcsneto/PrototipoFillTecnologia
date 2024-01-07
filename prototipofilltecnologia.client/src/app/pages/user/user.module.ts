import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';
import { UserComponent } from './user.component';
import { UserRoutingModule } from './user-routing.module';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule(
  {
    providers: [],
    declarations: [UserComponent],
    imports: [CommonModule,
      UserRoutingModule,
      NavbarModule,
      SidebarModule,
      ReactiveFormsModule
    ]
  }
)


export class UserModule {}
