import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LeaveOverviewComponent } from './leave-overview/leave-overview.component';
import { LeavesForAMonthComponent } from './leaves-for-amonth/leaves-for-amonth.component';
import { LeavesForAnEmployeeComponent } from './leaves-for-an-employee/leaves-for-an-employee.component';



export const routes: Routes = [
    {path:'', component:LeaveOverviewComponent, pathMatch:'full'},
    {path:'leave-overview', component:LeaveOverviewComponent},
    {path: 'leave-for-a-month', component:LeavesForAMonthComponent},
    {path:'leave-for-an-employee', component:LeavesForAnEmployeeComponent},
    {path:'**', component:LeaveOverviewComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
