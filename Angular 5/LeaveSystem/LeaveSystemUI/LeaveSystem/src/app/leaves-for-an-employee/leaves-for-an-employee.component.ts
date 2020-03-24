import { Component, OnInit } from '@angular/core';
import {LeavesService} from '../leaves.service';
import { DataService } from '../data.service';
import { envSelectedValue } from '../DropDown';

@Component({
  selector: 'app-leaves-for-an-employee',
  templateUrl: './leaves-for-an-employee.component.html',
  styleUrls: ['./leaves-for-an-employee.component.less']
})
export class LeavesForAnEmployeeComponent implements OnInit {

  public leavesFromService =[];

  private EmployeeId:number;

  private selectedValueObj = envSelectedValue;
  
  constructor(private _leaveService:LeavesService) { }

  ngOnInit() {
    //this._dataService.currentEmployee.subscribe(emp => this.EmployeeId = emp);
   // this.EmployeeId = this._dataService.getEmployee();
    //console.log(this.EmployeeId);
    this._leaveService.getLeavesForAnEmployee(this.selectedValueObj.employeeId)
      .subscribe(data => this.leavesFromService = data);
  }

  ngAfterContentChecked () {
    this._leaveService.getLeavesForAnEmployee(this.selectedValueObj.employeeId)
      .subscribe(data => this.leavesFromService = data);
  }
}
