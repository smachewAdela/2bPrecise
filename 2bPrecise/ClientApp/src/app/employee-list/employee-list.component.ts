import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html'
})
export class EmployeeListComponent {

  public employees: employee[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<employee[]>(baseUrl + 'api/Employee/list').subscribe(result => {
      this.employees = result;
      console.log(this.employees);
    }, error => console.error(error));
  }

}

interface employee {
  firstName: string;
  lastName: string;
  position: string;
  id: number;
}
