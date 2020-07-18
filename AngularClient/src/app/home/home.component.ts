import { EmployeeService } from './../employee.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  // tslint:disable-next-line: ban-types
  employees: Object;

  constructor(private data: EmployeeService) { }

  ngOnInit(): void {

  }

  GetEmployees() {
    this.data.getEmployees().subscribe(data => {
      // tslint:disable-next-line: semicolon
      this.employees = data
      console.log(this.employees);
    }
    );
  }

}
