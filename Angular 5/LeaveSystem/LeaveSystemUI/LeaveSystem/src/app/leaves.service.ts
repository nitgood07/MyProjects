import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ILeave, ILeavesForAMonth } from './Leave';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LeavesService {

  private _url:string = "http://localhost:55581/api/leaves/getallleaves";

  private _urlLeaveForAMonth:string = "http://localhost:55581/api/leaves/GetLeavesForAMonth?month=";

  private _urlLeaveForAnEmployee:string = "http://localhost:55581/api/leaves/GetLeavesForAnEmployee?employeeid=";

  constructor(private http:HttpClient) { }

  getLeaves():Observable<ILeave[]>{
    //console.log(this._url);
    return this.http.get<ILeave[]>(this._url);
  }

  //get leaves for a month
  getLeavesForAMonth(Month:Number):Observable<ILeavesForAMonth[]>{
    return this.http.get<ILeavesForAMonth[]>(this._urlLeaveForAMonth+Month);
  }

  //get leaves for an emplyoee
  getLeavesForAnEmployee(EmployeeId:Number):Observable<ILeavesForAMonth[]>{
    return this.http.get<ILeavesForAMonth[]>(this._urlLeaveForAnEmployee+EmployeeId);
  }
}
