import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { DepartmentsComponent } from './departments.component';
import { DepartmentAddEditComponent } from './department-add-edit/department-add-edit.component';

const routes: Routes = [
  {path: '', component: DepartmentsComponent},
  {path: ':create', component: DepartmentAddEditComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class DepartmentRoutingModule { }
