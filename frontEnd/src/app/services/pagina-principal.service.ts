import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

const apiUrl: string = 'https://localhost:44309/api/Categoria/GetCategorias'

@Injectable({
  providedIn: 'root'
})
export class PaginaPrincipalService {

  // constructor(private http: HttpClient) { }

  // obtenerDatos() {
  //   return this.http.get(apiUrl);
  // } 
}
