import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatypes',
  templateUrl: './datatypes.component.html',
  styleUrls: ['./datatypes.component.css']
})
export class DatatypesComponent implements OnInit {

  constructor() {
    console.log('helloo');
   }
   counter:number=0;

  ngOnInit(): void {
    console.log('Datatypes:constructor')
  }
  greet():string{
    return 'Happy Deepavali'
  }
  buttonClicked():number{
    this.counter=this.counter+1;
    return this.counter;
  }
  
course:string='Angular'
duration:number=20
isRegistered:boolean=true
credit:number=3.5
courses:string[]=['HTML','CSS','C#']
anytype:any='AnyThing can be assigned to this variable'
student={
    id:1,
    name:'Suma',
    location:'Channapatna'
}
students=[
{
    id:1,
    name:'Yash',
    location:'Yelanka'
},
{
    id:2,
    name:'Ilakkiya',
    location:'Madurai'
}
]

}
