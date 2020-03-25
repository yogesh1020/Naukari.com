import { Component,OnDestroy,Input,SimpleChanges, OnInit} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: [ './app.component.css' ]
})
export class AppComponent implements OnInit {
  action: any[];
  value: any;
  runing: boolean = false;
  title(title: any) {
    throw new Error("Method not implemented.");
  }
  ngOnInit(){
    this.action = [
      {id:1,name:"coding"},
      {id:2,name:"document"}
    ]
  }
  
  
  select(event:any){
    this.value= event.target.value
    console.log(this.value)

}

start(){
  this.runing = !this.runing
  console.log(this.runing)

  if(this.runing){

  }
}

 
  
}