import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router} from '@angular/router'
@Component({
  selector: 'app-professional',
  templateUrl: './professional.component.html',
  styleUrls: ['./professional.component.css']
})
export class ProfessionalComponent implements OnInit {
  professionalFromGroup:FormGroup;
  constructor(private frombuilder:FormBuilder , private router:Router) { }

  ngOnInit(): void {
    this.professionalFromGroup = this.frombuilder.group({
      name:['',Validators.required],
      emailId:['',Validators.required,Validators.email],
      password:['',Validators.required],
      mobile:['',Validators.required,Validators.maxLength(10),Validators.minLength(10)],
      exoerience:['',Validators.required],
      check:['',Validators.required]
    })
  }
  submit(){
    this.router.navigateByUrl('/employment')
  }
}
