import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Data } from '@angular/router';

@Component({
  selector: 'app-employeetemplateformdemo',
  templateUrl: './employeetemplateformdemo.component.html',
  styleUrls: ['./employeetemplateformdemo.component.css']
})
export class EmployeetemplateformdemoComponent implements OnInit {

  regEmp:any[]=[]
  display: boolean=false;
  constructor() { }

  ngOnInit(): void {
  }
  register(data:NgForm):void{
    console.log('register')
    console.log(data.value)
    console.log('Name: ' +data.value.name)
    console.log('Name:using control ' +data.controls['name'].value)
    this.regEmp.push(data.value)
  }
  clear(data:NgForm):void{
    data.resetForm()
  }
  edit(data:NgForm):void{
    this.display=true;
  }
   delete(id:any):void{
    let emp=this.regEmp.find(x=>x.id===id);

    let index=this.regEmp.indexOf(emp,0);

    this.regEmp.splice(index,1);
    
     
  }
 

}
