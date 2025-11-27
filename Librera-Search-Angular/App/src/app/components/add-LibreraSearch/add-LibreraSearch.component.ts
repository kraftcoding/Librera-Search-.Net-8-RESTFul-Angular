import { Component } from '@angular/core';
import { LibreraSearch } from 'src/app/models/LibreraSearch.model';
import { LibreraSearchService } from 'src/app/services/LibreraSearch.service';

@Component({
  selector: 'app-add-LibreraSearch',
  templateUrl: './add-LibreraSearch.component.html',
  styleUrls: ['./add-LibreraSearch.component.css'],
})
export class AddLibreraSearchComponent {
  LibreraSearch: LibreraSearch = {
    title: '',
    description: '',
    published: false
  };
  submitted = false;

  constructor(private LibreraSearchService: LibreraSearchService) {}

  saveLibreraSearch(): void {
    const data = {
      title: this.LibreraSearch.title,
      description: this.LibreraSearch.description
    };

    this.LibreraSearchService.create(data).subscribe({
      next: (res) => {
        console.log(res);
        this.submitted = true;
      },
      error: (e) => console.error(e)
    });
  }

  newLibreraSearch(): void {
    this.submitted = false;
    this.LibreraSearch = {
      title: '',
      description: '',
      published: false
    };
  }
}
