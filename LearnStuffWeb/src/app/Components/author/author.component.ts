import { Component } from '@angular/core';
import { Author } from '../../Models/Author';
import { AuthorService } from '../../Services/author.service';

@Component({
  selector: 'app-author',
  standalone: true,
  imports: [],
  templateUrl: './author.component.html',
  styleUrl: './author.component.css'
})
export class AuthorComponent {
  authors : Author[];

  constructor(private authorService: AuthorService) {
    this.authors = authorService.getData();
  }
}
