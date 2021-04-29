import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
   model:any={}
   loggedin:boolean;
  constructor(private AccountService: AccountService) { }

  ngOnInit(): void {
  }
  login()
  {
    this.AccountService.login(this.model).subscribe(response => {
      console.log(response);
      this.loggedin=true;
    })
  }

}
