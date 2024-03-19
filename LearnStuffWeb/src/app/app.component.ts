import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AuthorComponent } from './Components/author/author.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, AuthorComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

}
