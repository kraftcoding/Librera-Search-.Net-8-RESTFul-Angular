import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddLibreraSearchComponent } from './components/add-LibreraSearch/add-LibreraSearch.component';
import { LibreraSearchDetailsComponent } from './components/LibreraSearch-details/LibreraSearch-details.component';
import { LibreraSearchsListComponent } from './components/LibreraSearch-list/LibreraSearch-list.component';

@NgModule({
  declarations: [
    AppComponent,
    AddLibreraSearchComponent,
    LibreraSearchDetailsComponent,
    LibreraSearchsListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
