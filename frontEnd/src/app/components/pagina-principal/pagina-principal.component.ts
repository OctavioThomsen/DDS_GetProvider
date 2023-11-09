import { Component, OnInit } from '@angular/core';
import { PaginaPrincipalService } from 'src/app/services/pagina-principal/pagina-principal.service';
import { CategoriaService } from 'src/app/services/categoria/categoria.service';
import { Categoria } from 'src/app/models/categoria/categoria';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.component.html',
  styleUrls: ['./pagina-principal.component.css']
})
export class PaginaPrincipalComponent implements OnInit {
    categorias: Categoria[] = [];

  constructor(
    private http: HttpClient,
    private paginaPrincipalService: PaginaPrincipalService,
    private categoriaService: CategoriaService) { }

  ngOnInit()
  {
    this.getAllCategorias();
   }

  getAllCategorias() {
    this.categoriaService.getAll().subscribe(categorias => {
      console.log(categorias);
    });
    
  }

  buscar() {
    throw console.error("Sin implementar.");
    
  }
}

