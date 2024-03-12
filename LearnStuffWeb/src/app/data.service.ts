import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Author } from './models/Author';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) {}

  getData(): Array<Author> {
    let authors = new Array<Author>;
    this.http.get<Array<Author>>('http://localhost:5020/api/Author').subscribe((data: Array<Author>) => { authors = data });

    return authors;
  }
  
}
