import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DepartmentsRoutingModule } from './departments-routing.module';
import { DepartmentsComponent } from './departments.component';
import { AddEditDepartmentsComponent } from './add-edit-departments/add-edit-departments.component';


@NgModule({
  declarations: [
    DepartmentsComponent,
    AddEditDepartmentsComponent
  ],
  imports: [
    CommonModule,
    DepartmentsRoutingModule
  ]
})
export class DepartmentsModule { }
