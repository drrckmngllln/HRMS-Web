import { Component, OnInit } from '@angular/core';
import { Departments } from 'src/app/core/models/departments';
import { DepartmentsService } from '../departments.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-department-add-edit',
  templateUrl: './department-add-edit.component.html',
  styleUrls: ['./department-add-edit.component.scss']
})
export class DepartmentAddEditComponent {

  department = new FormGroup({
    name: new FormControl('', Validators.required),
    id: new FormControl('', Validators.required)
  })

  constructor(private depService: DepartmentsService) { }

  onSubmit(){
    this.depService.createDepartments(this.department.value).subscribe({

    })
  }
}
