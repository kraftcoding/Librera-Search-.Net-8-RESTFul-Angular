import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LibreraSearchsListComponent } from './components/LibreraSearch-list/LibreraSearch-list.component';
import { LibreraSearchDetailsComponent } from './components/LibreraSearch-details/LibreraSearch-details.component';
import { AddLibreraSearchComponent } from './components/add-LibreraSearch/add-LibreraSearch.component';

const routes: Routes = [
  { path: '', redirectTo: 'LibreraSearchs', pathMatch: 'full' },
  { path: 'LibreraSearchs', component: LibreraSearchsListComponent },
  { path: 'LibreraSearchs/:id', component: LibreraSearchDetailsComponent },
  { path: 'add', component: AddLibreraSearchComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
