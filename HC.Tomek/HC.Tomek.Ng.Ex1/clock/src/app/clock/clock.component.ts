import { Component, OnInit, Input } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { Subscription } from "rxjs/Subscription";

@Component({
  selector: 'app-clock',
  templateUrl: './clock.component.html',
  styleUrls: ['./clock.component.css']
})
export class ClockComponent implements OnInit {
  public clockTime: Date;
  private subscription: Subscription;
  constructor() { }

  ngOnInit() {
    const timer = Observable.timer(0, 500);
    this.subscription = timer.subscribe(t => {
      this.clockTime = new Date();
    });
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
