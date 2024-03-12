import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Author } from './models/Author';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Library';
  authors : Author[] = [ 
    new Author(1, 'J. K. Rowling'),
    new Author(2, 'Andrzej Sapkowski'),
    new Author(3, 'Olga Tokarczuk'),
  ];
}
