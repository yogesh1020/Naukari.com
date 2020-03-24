import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder } from '@angular/forms'
 
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  constructor( private formbuilder:FormBuilder) { }

  ngOnInit(): void {
    
  }

}
