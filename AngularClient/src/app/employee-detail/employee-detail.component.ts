import { Component, OnInit, Input } from '@angular/core';
import { Employee } from '../../assets/Employee';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: ['./employee-detail.component.scss']
})
export class EmployeeDetailComponent implements OnInit {

  @Input() employee: Employee;

  constructor() { }

  ngOnInit(): void {
  }

}
