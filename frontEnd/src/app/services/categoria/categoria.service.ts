import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Categoria } from 'src/app/models/categoria/categoria';

const apiUrl: string = 'https://localhost:44309/api/Categoria/GetCategorias'

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Categoria[]> {
    return this.http.get<Categoria[]>(apiUrl);
  }
}
