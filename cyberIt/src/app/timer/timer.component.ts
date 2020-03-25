import { Component, OnInit ,Input} from '@angular/core';

@Component({
  selector: 'app-timer',
  templateUrl: './timer.component.html',
  styleUrls: ['./timer.component.css']
})
export class TimerComponent implements OnInit {
  @Input() init:number=0;
  public counter:number = 7200; 
  constructor() { }
  action:boolean = false;
  ngOnInit(): void {
    
  }

  startCoundown(){
    
if(this.action==true){
      this.doCountdown();
      }
        
  }
  endCountdown(){
    
  }
  doCountdown(){
    setTimeout(() => {
      this.counter = this.counter - 1; 
    }, 1000);
    this.processCount()
  }
  processCount(){
    var totle = this.counter
    console.log("count is" , this.counter)
    if(this.counter==0){
      console.log("counter End")
    }
    else{
      this.doCountdown()
    }
  }
}
