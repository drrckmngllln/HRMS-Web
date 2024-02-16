import { Component, OnInit } from '@angular/core';
import { DepartmentsService } from './departments.service';
import { Departments } from 'src/app/core/models/departments';

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.scss']
})
export class DepartmentsComponent implements OnInit {

  departments: Departments[] = [];

  constructor(private departmentService: DepartmentsService) { }

  ngOnInit(): void {
    this.getDepartments();
  }

  getDepartments() {
    this.departmentService.getDepartments().subscribe({
      next: response => this.departments = response
      // next: response => console.log(response)
      
    })
  }

}
