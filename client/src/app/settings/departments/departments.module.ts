import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DepartmentsComponent } from './departments.component';
import { RouterModule } from '@angular/router';
import { DepartmentRoutingModule } from './department-routing.module';



@NgModule({
  declarations: [
    DepartmentsComponent
  ],
  
  imports: [
    CommonModule,
    DepartmentRoutingModule
  ]
})
export class DepartmentsModule { }
