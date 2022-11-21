import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-simplecalculator',
  templateUrl: './simplecalculator.component.html',
  styleUrls: ['./simplecalculator.component.css']
})
export class SimplecalculatorComponent implements OnInit {

  num1:number|any
  num2:number|any
  opr:number|any
  calculate:number|any
  constructor() { }

  ngOnInit(): void {
  }
  Cal():void{
   switch(this.opr){
                 case '+': this.calculate=this.num1+this.num2;
                 break;
                 case '-' : this.calculate=this.num1-this.num2;
                 break;
                 case '*' : this.calculate=this.num1*this.num2;
                 break;
                 case '/' :this.calculate=this.num1/this.num2;
                 break;
                 default: console.log("Invalid Input");
                 break;
   }
  }

}
