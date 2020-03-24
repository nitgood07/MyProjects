import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//import { FormsMoudle } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LeaveOverviewComponent } from './leave-overview/leave-overview.component';
import {HttpClientModule} from '@angular/common/http';
import { LeavesService } from './leaves.service';
import { DataService } from './data.service';
import { LeaveViewsComponent } from './leave-views/leave-views.component';
import { LeavesForAMonthComponent } from './leaves-for-amonth/leaves-for-amonth.component';
import { LeavesForAnEmployeeComponent } from './leaves-for-an-employee/leaves-for-an-employee.component';



@NgModule({
  declarations: [
    AppComponent,
    LeaveOverviewComponent,
    LeaveViewsComponent,
    LeavesForAMonthComponent,
    LeavesForAnEmployeeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    //FormsMoudle
  ],
  providers: [LeavesService,DataService],
  bootstrap: [AppComponent]
})
export class AppModule { 

}


