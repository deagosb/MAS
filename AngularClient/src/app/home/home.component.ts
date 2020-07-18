import { Employee } from './../../assets/Employee';
import { EmployeeService } from './../employee.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  // tslint:disable-next-line: ban-types
  employees: Employee[];
  employee: Employee;
  showList = false;
  employeeId = '';


  constructor(private data: EmployeeService) { }

  ngOnInit(): void {

  }

  GetEmployees() {
    this.Reset()
    if (this.employeeId.length > 0) {
      this.data.getEmployeeById(this.employeeId).subscribe(data => {
        this.employee = data;
        console.log(this.employee);
      }
      );
      this.showList = false;
    }
    else {
      this.data.getEmployees().subscribe(data => {
        this.employees = data;
        console.log(this.employees);
      }
      );
      this.showList = true;
    }
  }

  Reset() {
    if (this.employee != null) {
      this.employee = null;
    }
    if (this.employees != null) {
      this.employees = null;
    }
  }

}
