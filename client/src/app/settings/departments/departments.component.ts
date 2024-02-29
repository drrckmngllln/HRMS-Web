import {Component, OnInit} from '@angular/core';
import {Departments} from "../../core/models/departments";
import {DepartmentsService} from "./departments.service";

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.scss']
})
export class DepartmentsComponent implements OnInit{
  departments: Departments[] = [];

  constructor(private departmentService: DepartmentsService) {
  }
  ngOnInit(): void {
    this.getDepartments();
  }

  getDepartments(){
    this.departmentService.loadRecords().subscribe({
      next: result => this.departments = result
    })
  }

}
