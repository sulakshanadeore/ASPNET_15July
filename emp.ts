export class Employee
{
    _empid:number | undefined;
    _empname:string | undefined;
    _salary:number | undefined;
    //void printDetails()
printDetails():void
{
    // var empid=101;//inferred datatyoe
    // console.log(empid);
    // empid=123;
    console.log(this._empid);
    console.log(this._empname);
    console.log(this._salary)
}
acceptData(empno:number,ename:string,sal:number):void
{
// var empno:number=102;
// console.log(empno);
this._empid=empno;
this._empname=ename;
this._salary=sal;
}


}

// var empobj=new Employee();

// empobj.acceptData(123,"Akshay",45000);
// empobj.printDetails();