import {Injectable, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Departments} from "../../core/models/departments";
import {environment} from "../../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class DepartmentsService{
  baseApi = environment.apiUrl;
  constructor(private http:HttpClient) { }
  loadRecords(){
    return this.http.get<Departments[]>(this.baseApi + 'departments')
  }
}
