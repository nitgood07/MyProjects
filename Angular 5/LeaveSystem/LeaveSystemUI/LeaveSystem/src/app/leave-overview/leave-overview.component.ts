import { Component, OnInit } from '@angular/core';
import { LeavesService } from '../leaves.service';



@Component({
  selector: 'app-leave-overview',
  templateUrl: './leave-overview.component.html',
  styleUrls: ['./leave-overview.component.less']
})
export class LeaveOverviewComponent implements OnInit {

  public leavesFromService = [];
    
  constructor(private _leaveService: LeavesService) { }

  ngOnInit() {
      this._leaveService.getLeaves()
          .subscribe(data => this.leavesFromService = data); 
      //console.log(this.leavesFromService);
  }

  public LeaveClass(month:string): boolean {
    console.log(month);
    if(month == "Y"){
      return false;
    }
      return true;
  }
 

}
