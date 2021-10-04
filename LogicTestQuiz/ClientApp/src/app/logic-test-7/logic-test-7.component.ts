import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-logic-test-7',
  templateUrl: './logic-test-7.component.html'
})
export class LogicTest7Component {
  public resultCal: string;
  httpUrl: HttpClient;
  baseUrl: string;

  public q1: string = 'List<string> excludeList = new List<string> { "bike","boat","car"};';
  public q2: string = 'List<string> sentense = new List<string> {"I love bikes","I have boat and car","I no have truck"};';
  public q3: string = 'var includeList = sentense.Where(m => !excludeList.Any(r => m.Contains(r)));';

  constructor(http: HttpClient, @Inject('BASE_URL') url: string) {
    this.baseUrl = url;
    this.httpUrl = http;
    this.httpUrl.get<string>(this.baseUrl + 'api/LogicTest7').subscribe(result => {
      this.resultCal = result;
    }, error => console.error(error));
  }

}

