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

  createDepartments(department: Departments) {
    return this.http.post<Departments>(this.baseUrl + 'create', department);
  }

  mapDepartment(items: Departments) {
    return {
      name: items.name
    }
  }
}