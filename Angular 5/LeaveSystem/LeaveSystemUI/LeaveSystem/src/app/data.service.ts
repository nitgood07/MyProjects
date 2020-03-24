import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class DataService {


  private monthSource = new BehaviorSubject(1);
  currentMonth = this.monthSource.asObservable();

  private employeeSource = new BehaviorSubject(1);
  currentEmployee = this.employeeSource.asObservable();

  constructor() { }

  changeMonth(mon:number){
    this.monthSource.next(mon);
  }

  changeEmployee(employee:number){
    this.employeeSource.next(employee);
  }
 
}
