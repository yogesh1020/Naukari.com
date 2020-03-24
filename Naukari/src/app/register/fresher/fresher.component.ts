import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fresher',
  templateUrl: './fresher.component.html',
  styleUrls: ['./fresher.component.css']
})
export class FresherComponent implements OnInit {
fresherFormGroup:FormGroup
  constructor(private formBuilder:FormBuilder , private router:Router) { }

  ngOnInit(): void {
    this.fresherFormGroup = this.formBuilder.group({
      name:['',Validators.required],
      emailId:['', Validators.required, Validators.pattern(/[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}/) ],
      password:['',Validators.minLength(6)],
      mobile:['',Validators.required],
      location:['',Validators.required],
      country:['',Validators.required],
      cityName:['',Validators.required],
      check:['',Validators.required]
    })
  }
  submit(){
      this.router.navigateByUrl('education')
    }    
}



