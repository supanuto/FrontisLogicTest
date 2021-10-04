import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LogicTest1Component } from './logic-test-1/logic-test-1.component';
import { LogicTest3Component } from './logic-test-3/logic-test-3.component';
import { LogicTest4Component } from './logic-test-4/logic-test-4.component';
import { LogicTest6Component } from './logic-test-6/logic-test-6.component';
import { LogicTest7Component } from './logic-test-7/logic-test-7.component';
import { LogicTest2Component } from './logic-test-2/logic-test-2.component';
import { LogicTest5Component } from './logic-test-5/logic-test-5.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LogicTest1Component,
    LogicTest3Component,
    LogicTest4Component,
    LogicTest6Component,
    LogicTest7Component,
    LogicTest2Component,
    LogicTest5Component
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'logic-test-1', component: LogicTest1Component },
      { path: 'logic-test-2', component: LogicTest2Component },
      { path: 'logic-test-3', component: LogicTest3Component },
      { path: 'logic-test-4', component: LogicTest4Component },
      { path: 'logic-test-5', component: LogicTest5Component },
      { path: 'logic-test-6', component: LogicTest6Component },
      { path: 'logic-test-7', component: LogicTest7Component },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
