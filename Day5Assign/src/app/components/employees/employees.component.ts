import { Component, OnInit } from '@angular/core';
import Employees from '../../models/Employee';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
  employees: Employees[];
  showForm: boolean = false;
  emp: Employees;
  constructor() {
    this.employees = [];
    this.emp = {
      eid: '',
      ename: '',
      joindate: {},
      salary: null,
      desig: ''
    };
  }

  ngOnInit(): void {
    this.employees.push(
      {
        eid: '1001',
        ename: 'John',
        joindate: new Date(),
        salary: 12000,
        desig: 'SDE'
      },
      {
        eid: '1002',
        ename: 'Paul',
        joindate: new Date(),
        salary: 19000,
        desig: 'SDE'
      },
      {
        eid: '1003',
        ename: 'Jack',
        joindate: new Date(),
        salary: 1000000,
        desig: 'CEO'
      }
    );
  }

  onSubmit(f: NgForm) {
    if (f.valid) {
      this.employees.unshift(f.value);
      this.emp = {
        eid: '',
        ename: '',
        joindate: {},
        salary: null,
        desig: ''
      };
      this.showForm = false;
    } else {
      alert('Cannot Submit');
    }
  }
}
