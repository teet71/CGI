import {Component, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Router } from '@angular/Router';
import {FormControl} from '@angular/forms';
import {animate, state, style, transition, trigger} from '@angular/animations';

@Component({
  selector: 'FilmTable',
  templateUrl: './FilmTable.html',
  styleUrls: ['./FilmTable.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})

export class FilmTable implements OnInit {
  columnsToDisplay: string[] = ['Title', 'Category', 'Year of release', 'Rating'];
  expandedElement = null;
  myControl = new FormControl('');
  movies = [];
  categories = [];
  moviesFiltered;
  selectedCategories = [];
  description="";
  searchTerm: "";
  url;

  constructor(private http: HttpClient, private router: Router){
    this.url = router.url;
    this.http.get(this.url+"Film").toPromise().then(data => {
        if (data.hasOwnProperty('movies')) {
             for (let i in data['movies']){
               this.movies.push(data['movies'][i])
             }
             this.categories = data['categories']
        }
        this.moviesFiltered = this.movies;
      }
    ).catch();
  }
  ngOnInit(){
  }

  search(): void {
    let term = this.searchTerm;

    let categories = this.selectedCategories;
    this.moviesFiltered = this.movies.filter(function(tag) {
      return (((term==null) || tag.title.indexOf(term) >= 0) && (categories.length == 0 || categories.indexOf(tag.categoryId) >= 0));
    });
  }

  clickCheckBox(checked, category){
    if (checked) {
      this.selectedCategories.push(category.id);
    }
    else {
      this.selectedCategories.splice(this.selectedCategories.indexOf(category.id), 1);
    }
    this.search();
  }

  getCategory(id): string {
    return this.categories.find(category => category.id == id).name;
}
  getDescription(id){
    this.http.get(this.url+"Film/Index/"+id).toPromise().then(data => {
      this.description = data.toString();
    }
    );
  }
}
