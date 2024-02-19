import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Departments } from 'src/app/core/models/departments';

@Injectable({
  providedIn: 'root'
})
export class DepartmentsService {
  baseUrl = 'https://localhost:5001/api/'

  constructor(private http: HttpClient) { }

  getDepartments() {
    return this.http.get<Departments[]>(this.baseUrl + 'departments/');
  }

  createDepartments() {
    
  }

  mapDepartment(items: Departments) {
    return {
      name: items.name
    }
  }
}
