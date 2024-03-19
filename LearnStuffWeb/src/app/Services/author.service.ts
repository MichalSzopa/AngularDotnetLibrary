import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Author } from '../Models/Author';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  constructor(private http: HttpClient) {}

  public getData(): Array<Author> {
    let authors = new Array<Author>;
    try {
      this.http.get<Array<Author>>('http://localhost:5020/api/Author').subscribe((data: Array<Author>) => { authors = data });
    }
    catch {
    }
    return [ 
      new Author(1, 'J. K. Rowling'),
      new Author(2, 'FrontendMock'),
    ];;
  }

  public addAuthor(authorName: String) {
    try {
      this.http.post<String>('http://localhost:5020/api/Author', authorName);
    }
    catch {
    }
  }
  
}
