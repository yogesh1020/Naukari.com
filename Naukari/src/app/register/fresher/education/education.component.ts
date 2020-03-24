import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {
educationFormGroup:FormGroup
  constructor(private formBuilder:FormBuilder , private router:Router) { }

  ngOnInit(): void {
    this.educationFormGroup=this.formBuilder.group({
      qualification:['',Validators.required],
      course:['',Validators.required],
      specialization:['',Validators.required],
      university:['',Validators.required],
      courseType:['',Validators.required],
      passingYear:['',Validators.required],
      skill:['',Validators.required],
      newEducation:this.formBuilder.array([]),
    })
  }
  onAdd()
  {
    const edu=this.educationFormGroup.controls.newEducation as FormArray;
    edu.push(this.formBuilder.group({
      qualification:[],
      course:[],
      specialization:[],
      college:[],
      year:[],
    }))
  }

}
