import { Injectable } from '@angular/core';
import {Corona} from '../models/corona'

@Injectable({
  providedIn: 'root'
})
export class CoronaService {

  coronaList:Corona[]=[]
  constructor() { }
  addCorona(corona:Corona):Corona[]{
    this.coronaList.push(corona)
    return this.coronaList
  }
  getCoronaList():Corona[]{
    return this.coronaList
  }
  // delete(corona:Corona):void{
  //   let cor=this.coronaList.find(x=>x.code===corona.code);

  //   let index=this.coronaList.indexOf(cor,0);

  //   this.cor.splice(index,1);
    
     
  // }
 
}
