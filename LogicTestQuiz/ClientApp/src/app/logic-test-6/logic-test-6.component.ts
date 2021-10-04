import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-logic-test-6',
  templateUrl: './logic-test-6.component.html'
})
export class LogicTest6Component {
  public resultCal: string = '0.00';
  httpUrl: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') url: string) {
    this.baseUrl = url;
    this.httpUrl = http;

  }

  //cal(num) {
  //  console.log(num);
  //  this.httpUrl.post<string>(this.baseUrl + 'api/LogicTest6' + '/' + num).subscribe(result => {
  //    this.resultCal = result;
  //  }, error => console.error(error));
  //}

  getResultCal(num: any): Observable<HttpResponse<any>> {
    console.log(num);
    const body = JSON.stringify({
      calInput: num
    });
    console.log(body);
    const _headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' })
    return this.httpUrl.post<any>(this.baseUrl + 'api/LogicTest6', body,
      {
        headers: _headers,
        observe: 'response'
      }
    );
  }

  cal(num: any) {

    this.getResultCal(num).subscribe(res => {
      if (res.body) {
        this.resultCal = res.body;
      }
    },
      err => {
        throw err;
      });
  }

}

