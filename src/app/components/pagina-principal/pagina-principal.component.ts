import { Component, OnInit } from '@angular/core';
import { PaginaPrincipalService } from 'src/app/services/pagina-principal.service';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.component.html',
  styleUrls: ['./pagina-principal.component.css']
})
export class PaginaPrincipalComponent implements OnInit {
    datos: any[] = [];

  constructor(private paginaPrincipalService: PaginaPrincipalService) { }

  async ngOnInit() {
  //  this.datos = await this.paginaPrincipalService.obtenerDatos();
  }
}
