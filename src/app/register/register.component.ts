import { Component, OnInit, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { EventEmitter } from 'node:stream';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model:any={} ; 
  @Output() cancelRegister = new EventEmitter();
  constructor(private accountService:AccountService , private toastr:ToastrService) { }

  ngOnInit(): void {
  }
  register(){

    console.log(this.model); 
  }
  cancel(){
    this.cancelRegister.emit(false); 
  }

}
