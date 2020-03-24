import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule , ReactiveFormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { FresherComponent } from './register/fresher/fresher.component';
import { ProfessionalComponent } from './register/professional/professional.component';
import { EducationComponent } from './register/fresher/education/education.component';
import { EmploymentComponent } from './register/professional/employment/employment.component';

const routes = [
  { path:'login',component:LoginComponent},
  {path:'register' , component:RegisterComponent},
  {path:'fresher' , component:FresherComponent},
  {path:'professional' , component:ProfessionalComponent},
  {path:'education' , component:EducationComponent},
  {path:'employment' , component:EmploymentComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    FresherComponent,
    ProfessionalComponent,
    EducationComponent,
    EmploymentComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
