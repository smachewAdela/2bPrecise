import { Component, Inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {
  public employeeId: string;
  public empData: employeeData;


  constructor(private route: ActivatedRoute,
    http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    route.params.subscribe(p => {
      this.employeeId = p['id'];

      console.log(this.employeeId);
      console.log(p);

      http.get<employeeData>(baseUrl + 'api/Employee/' + this.employeeId).subscribe(result => {
        this.empData = result;
      }, error => console.error(error));

    });

  }

}

interface employeeData {
  firstName: string;
  lastName: string;
  position: string;
  id: number;
}
