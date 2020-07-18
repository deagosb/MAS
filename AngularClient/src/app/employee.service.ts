import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../assets/Employee';


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  getEmployees() {
    return this.http.get<Employee[]>('http://localhost:65504/api/employee/');
  }

  getEmployeeById(employeeId: string) {
    return this.http.get<Employee>('http://localhost:65504/api/employee/' + employeeId);
  }

}

