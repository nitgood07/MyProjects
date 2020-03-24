export interface ILeave{
    id:number,
    jan:string,
    feb:string,
    mar:string,
    apr:string,
    may:string,
    jun:string,
    jul:string,
    aug:string,
    sep:string,
    oct:string,
    nov:string,
    dec:string,
    Approved:string,
    LeaveId:number,
    EmployeeName:string,
    EmployeeEmail:string,
    ManagerName:string,
    ManagerEmail:string,
    GrantedLeaves:number,
    AvailedLeaves:number
}

export interface ILeavesForAMonth{
    id:number,
    StartDate:string,
    EndDate:string,
    Approved:string,
    LeaveId:number,
    EmployeeName:string,
    EmployeeEmail:string,
    ManagerName:string,
    ManagerEmail:string,
    GrantedLeaves:number,
    AvailedLeaves:number
}