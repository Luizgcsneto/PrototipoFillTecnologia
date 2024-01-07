import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ImobileComponent } from "./imobile.component";

const routes: Routes =[
  {
    path: '',
    component: ImobileComponent,
  }
]
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})


export class ImobileRoutingModule {}
