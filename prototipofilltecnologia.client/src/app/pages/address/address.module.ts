import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { AddressRoutingModule } from './address-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';
import { AddressComponent } from './address.component';

@NgModule(
  {
    providers: [],
    declarations: [AddressComponent],
    imports: [CommonModule,
      AddressRoutingModule,
      NavbarModule,
      SidebarModule,
      ReactiveFormsModule
    ]
  }
)

export class AddressModule {}
