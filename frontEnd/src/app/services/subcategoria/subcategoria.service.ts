import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Subcategoria } from 'src/app/models/subcategoria/subcategoria';

const apiUrl: string = 'https://localhost:44309/api/Subcategoria/GetSubcategorias'

@Injectable({
  providedIn: 'root'
})
export class SubcategoriaService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Subcategoria[]> {
    return this.http.get<Subcategoria[]>(apiUrl);
  }
}
