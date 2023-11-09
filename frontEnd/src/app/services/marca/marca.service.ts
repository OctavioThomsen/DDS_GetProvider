import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Marca } from 'src/app/models/marca/marca';

const apiUrl: string = 'https://localhost:44309/api/Marca/GetMarcas'

@Injectable({
  providedIn: 'root'
})
export class MarcaService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Marca[]> {
    return this.http.get<Marca[]>(apiUrl);
  }
}
