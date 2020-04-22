import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import {RouterModule, Router} from '@angular/Router';
import { APP_BASE_HREF } from '@angular/common';
import { FilmTable } from './FilmTable';
import {BrowserAnimationsModule} from
    '@angular/platform-browser/animations';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { MatInputModule} from '@angular/material/input';
import {MatAutocompleteModule} from '@angular/material/autocomplete'
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatTableModule} from '@angular/material/table'


@NgModule({
  declarations: [
    FilmTable
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([]),
    FormsModule,
    BrowserAnimationsModule,
    MatInputModule,
    MatAutocompleteModule,
    ReactiveFormsModule,
    MatCheckboxModule,
    MatTableModule
  ],
  providers: [{ provide: APP_BASE_HREF, useValue : '/' }],
  bootstrap: [FilmTable]
})
export class AppModule { }
