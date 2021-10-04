import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-logic-test-1',
  templateUrl: './logic-test-1.component.html'
})
export class LogicTest1Component {
  public resultCal: string;
  httpUrl: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') url: string) {
    this.baseUrl = url;
    this.httpUrl = http;
  }

  cal(num) {
    console.log(num);
    this.httpUrl.get<string>(this.baseUrl + 'api/LogicTest1' + '/' + num).subscribe(result => {
      this.resultCal = result;
    }, error => console.error(error));
  }

}

