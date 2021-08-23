import { Component, OnInit } from '@angular/core';
import { Employee } from '../emp';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
greet:string="Hello All";
edata:Employee=new Employee();

  constructor() { this.displaydata();}

  ngOnInit(): void {
  }
displaydata():void
{
  this.edata.acceptData(234,"Gauri Iyer",3444);
this.edata.printDetails();

}


}
