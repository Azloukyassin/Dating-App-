import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { MemberListTestsComponent } from './member-list-tests/member-list-tests.component';
import { MemberDetailComponent } from './member-detail/member-detail.component';
import { ListsComponent } from './lists/lists.component';
import { MessageComponent } from './message/message.component';
import { NavComponent } from './nav/nav.component'; 
import { FormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ToastrModule } from 'ngx-toastr';
import { TestCompComponent } from './test-comp/test-comp.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    MemberListTestsComponent,
    MemberDetailComponent,
    ListsComponent,
    MessageComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    TestCompComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HttpClientModule,
    FormsModule,
    BsDropdownModule.forRoot(), 
    ToastrModule.forRoot({
      positionClass:'toast-bottom-right'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
