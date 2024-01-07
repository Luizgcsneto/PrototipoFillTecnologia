import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  constructor(private router: Router,
    public menuService: MenuService) { }

  ngOnInit(): void {
  }

  selectMenu(menu:number){
    switch(menu)
    {
      case 1:
        this.router.navigate(['/dashboard'])
      break
      case 2:
        this.router.navigate(['/imobile'])
      break
      case 3:
        this.router.navigate(['/address'])
      break
      case 4:
        this.router.navigate(['/user'])
      break
      default:
        break
    }

    this.menuService.menuSelecionado = menu
  }

}
