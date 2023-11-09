import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Modelo } from 'src/app/models/modelo/modelo'; 

const apiUrl: string = 'https://localhost:44309/api/Modelo/GetModelos'

@Injectable({
  providedIn: 'root'
})
export class ModeloService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Modelo[]> {
    return this.http.get<Modelo[]>(apiUrl);
  }
}
