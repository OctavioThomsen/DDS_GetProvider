import { Component, OnInit } from '@angular/core';
import { CategoriaService } from 'src/app/services/categoria/categoria.service';
import { Categoria } from 'src/app/models/categoria/categoria';
import { Marca } from 'src/app/models/marca/marca';
import { MarcaService } from 'src/app/services/marca/marca.service';
import { Subcategoria } from 'src/app/models/subcategoria/subcategoria';
import { SubcategoriaService } from 'src/app/services/subcategoria/subcategoria.service';
import { Producto } from 'src/app/models/producto/producto';
import { ProductoService } from 'src/app/services/producto/producto.service';
import { Modelo } from 'src/app/models/modelo/modelo';
import { ModeloService } from 'src/app/services/modelo/modelo.service';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.component.html',
  styleUrls: ['./pagina-principal.component.css']
})
export class PaginaPrincipalComponent implements OnInit {
    categorias: Categoria[] = [];
    subcategorias: Subcategoria[] = [];
    productos: Producto[] = [];
    marcas: Marca[] = [];
    modelos: Modelo[] = [];

    busqueda: number = 0;

  constructor(
    private categoriaService: CategoriaService,
    private subcategoriaService: SubcategoriaService,
    private productoService: ProductoService,
    private marcaService: MarcaService,
    private modeloService: ModeloService) 
    { }

  ngOnInit()
  {
    this.getAllCategorias();
    this.getAllSubcategorias();
    this.getAllProductos();
    this.getAllMarcas();
    this.getAllModelos();
   }

  getAllCategorias() {
    this.categoriaService.getAll().subscribe(categorias => {
      this.categorias = categorias
      console.log(categorias);
    });
  }

  getAllSubcategorias() {
    this.subcategoriaService.getAll().subscribe(subcategorias => {
      this.subcategorias = subcategorias
      console.log(subcategorias);
    });
  }

  getAllProductos() {
    this.productoService.getAll().subscribe(productos => {
      this.productos = productos
      console.log(productos);
    });
  }

  getAllMarcas() {
    this.marcaService.getAll().subscribe(marcas => {
      this.marcas = marcas
      console.log(marcas);
    });
  }

  getAllModelos() {
    this.modeloService.getAll().subscribe(modelos => {
      this.modelos = modelos
      console.log(modelos);
    });
  }

  buscar() {
    this.busqueda = 1;
  }
}

