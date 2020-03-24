import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-timer',
  templateUrl: './timer.component.html',
  styleUrls: ['./timer.component.css']
})
export class TimerComponent implements OnInit {
  @Input() time:number= null;
  public conter:number = 0;

  ngOnInit(): void {

  }
  start(){
      if( this.time <= 7200){
        this.conter=this.time;
        this.count();
      }

  }
  count(){
    setTimeout(() => {
      this.conter = this.conter+1;
      this.processCount();
    }, 1000);
  }
processCount(){
  console.log(this.conter)
}
}
