import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { clsMonth, clsEmployee, clsViewType, envSelectedValue } from '../DropDown';
import { DataService } from '../data.service';




@Component({
  selector: 'app-leave-views',
  templateUrl: './leave-views.component.html',
  styleUrls: ['./leave-views.component.less']
})
export class LeaveViewsComponent implements OnInit {

  private _leaveViewOptions: clsViewType[] = [
      {name: "Leaves Overview", value:"Leave Overview"},
      {name: "Leaves for a Month", value:"Leaves for a Month"},
      {name: "Leaves for an Employee", value:"Leaves for an Employee"}
    ]

    private _months:clsMonth[] = [
      {id:1,value:"Jan"},
      {id:2,value:"Feb"},
      {id:3,value:"Mar"},
      {id:4,value:"Apr"},
      {id:5,value:"May"},
      {id:6,value:"Jun"},
      {id:7,value:"Jul"},
      {id:8,value:"Aug"},
      {id:9,value:"Sep"},
      {id:10,value:"Oct"},
      {id:11,value:"Nov"},
      {id:12,value:"Dec"}
    ]

    //TODO populate this list form DB
    private _employees:clsEmployee[] = [
      {id:1,name:"Nitin"},
      {id:2,name:"Ramesh"},
      {id:3,name:"Praveen"},
      {id:4,name:"Sunil"},
      {id:7,name:"Namita"}
    ]


    private showMonth:boolean = false;
    private showEmployee:boolean = false;
    
    private month:number;
    private employee:number;

    private selectedValueObj = envSelectedValue;
    

  constructor(private _router:Router) { }

  ngOnInit() {
     
  }

  ChangedValue(selectedValue){

    switch(selectedValue){
      case "Leaves Overview":
        //hide month and employee ddlbs
        this.showMonth = false;
        this.showEmployee = false;
        this._router.navigateByUrl('/leave-overview');
        break;
      case "Leaves for a Month":
        this.ShowMonth();
        //this._router.navigateByUrl('/leave-for-a-month');
        break;
      case "Leaves for an Employee":
        this.ShowEmployee();
        //this._router.navigateByUrl('/leave-for-an-employee');
        break;
      default:
        this._router.navigateByUrl('/leave-overview');
        break;
    }
   // console.log(selectValue);
  }

  ShowMonth(){
    this.showMonth = true;
    this.showEmployee = false;
  }

  ShowEmployee(){
    this.showEmployee = true;
    this.showMonth =false;
  }

  ChangeMonth(selectedValue){
    //this._dataService.changeMonth(selectedValue);
    //this._dataService.setMonth(selectedValue);
    if(selectedValue != undefined){
      this.selectedValueObj.month = selectedValue;
      console.log(this.selectedValueObj.month);
    }
    this._router.navigateByUrl('/leave-for-a-month');
  }

  ChangeEmployee(selectedValue){
    //this._dataService.changeEmployee(selectedValue);
    if(selectedValue != undefined){
      this.selectedValueObj.employeeId = selectedValue;
      console.log(this.selectedValueObj.employeeId)
    }
    this._router.navigateByUrl('/leave-for-an-employee');
  }

}
