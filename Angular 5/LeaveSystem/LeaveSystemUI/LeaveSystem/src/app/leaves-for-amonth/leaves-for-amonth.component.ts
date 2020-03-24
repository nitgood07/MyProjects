import { Component, OnInit, ɵɵcontainerRefreshEnd } from '@angular/core';
import {LeavesService} from '../leaves.service';
import { DataService } from '../data.service';
import { envSelectedValue } from '../DropDown';

@Component({
  selector: 'app-leaves-for-amonth',
  templateUrl: './leaves-for-amonth.component.html',
  styleUrls: ['./leaves-for-amonth.component.less']
})
export class LeavesForAMonthComponent implements OnInit {

  public leavesFromService = [];

  public month:number;
  private selectedValueObj = envSelectedValue;

  constructor(private _leaveService: LeavesService) { }

  ngOnInit() {
    //get selected month from leave-view component via data service.
    //this._dataService.currentMonth.subscribe(month => this.month = month);
    //this.month = this._dataService.getMonth();
    //console.log("Here");
    this._leaveService.getLeavesForAMonth(this.selectedValueObj.month)
      .subscribe(data => this.leavesFromService = data);
  }

  ngAfterContentChecked () {
    this._leaveService.getLeavesForAMonth(this.selectedValueObj.month)
      .subscribe(data => this.leavesFromService = data);
  }

}
