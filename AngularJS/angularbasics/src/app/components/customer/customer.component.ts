import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  customers:Customer[]=[]
  constructor() { }

  ngOnInit(): void {
    this.customers=[
      {
        id:1,
        name:'Suma',
        email:'suma@gmail.com',
        mobile:7204830895,
        location:'Channapatna'

      },
      {
        id:2,
        name:'Zayba',
        email:'zayba@gmail.com',
        mobile:8861495075,
        location:'Ramanagara'

      },
      {
        id:3,
        name:'Iqra',
        email:'iqra@gmail.com',
        mobile:9964626038,
        location:'Bangalore'
      }
    ]
  }

}
