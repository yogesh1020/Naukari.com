import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employment',
  templateUrl: './employment.component.html',
  styleUrls: ['./employment.component.css']
})
export class EmploymentComponent implements OnInit {
empoloymentFormGroup:FormGroup
  constructor(private formBuilder:FormBuilder , private router:Router) { }

  ngOnInit(): void {
    this.empoloymentFormGroup=this.formBuilder.group({
      job:['',Validators.required],
      currentCompany:['',Validators.required],
      salary:['',Validators.required],
      workTime:['',Validators.required],
      location:['',Validators.required],
      notice:['',Validators.required],
      skill:['',Validators.required],
      lastWorking:['',Validators.required],
      newEmployment:this.formBuilder.array([]),
    })
    
  }
  onAdd()
{
  const emp=this.empoloymentFormGroup.controls.newEmployment as FormArray;
  emp.push(this.formBuilder.group({
    employment:[],
  }))
  console.log("hello")
}
submit(){
  this.router.navigateByUrl('education')
}

}
