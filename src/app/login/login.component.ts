import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
loginFormGroup:FormGroup;
  constructor(private formbuilder:FormBuilder) { }

  ngOnInit(): void {
    this.loginFormGroup=this.formbuilder.group({
      userId:['',Validators.required],
      password:['',Validators.required]
    })

  }
  submit(){
    console.log(this.loginFormGroup)
  }
  get valid() { return this.loginFormGroup.controls; }

}
