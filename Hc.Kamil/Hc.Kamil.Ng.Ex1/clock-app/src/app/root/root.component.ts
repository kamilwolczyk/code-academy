import { ClockConfiguration, ClockType } from '../clock/clockConfiguration';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './root.component.html',
  styleUrls: ['./root.component.css']
})
export class RootComponent implements OnInit {
  firstClock: ClockConfiguration;
  secondClock: ClockConfiguration;
  thirdClock: ClockConfiguration;

  constructor() { }

  ngOnInit() {
    this.firstClock = new ClockConfiguration(true, ClockType.Large);
    this.secondClock = new ClockConfiguration(true, ClockType.Medium);
    this.thirdClock = new ClockConfiguration(false, ClockType.Small);
  }

}
