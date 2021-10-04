import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-logic-test-3',
  templateUrl: './logic-test-3.component.html'
})
export class LogicTest3Component {
  public resultCal: string;
  httpUrl: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') url: string) {
    this.baseUrl = url;
    this.httpUrl = http;
  }

}

