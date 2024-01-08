import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ImobileComponent } from './imobile.component';
import { ImobileRoutingModule } from './imobile-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';


@NgModule(
  {
    providers: [],
    declarations: [
      ImobileComponent
    ],
    imports: [CommonModule,
      ImobileRoutingModule,
      NavbarModule,
      SidebarModule,
      ReactiveFormsModule
    ]
  }
)

export class ImobileModule {}
