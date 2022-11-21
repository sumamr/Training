import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employee:any=[]
  displaySal:boolean=false
  loaded:boolean=false
  constructor() { }

  ngOnInit(): void {
    this.employee=[
      {
        code:1,
        name:'Suma',
        dept:'IT',
        desg:'Developer',
        sal:350000
      },
      {
        code:2,
        name:'Ilakkiya',
        dept:'IT',
        desg:'Software Engineer',
        sal:500000
      },
      {
        code:3,
        name:'Zayba',
        dept:'HR',
        desg:'Analyst',
        sal:250000
      },
      {
        code:4,
        name:'Iqra',
        dept:'Admin',
        desg:'Executive',
        sal:300000
      }
    ]
    this.loaded=true
  }

}
