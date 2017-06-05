import { Person } from '../persons/models/person';
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
  samplePersonCollection: Person[];

  constructor() { }

  ngOnInit() {
    this.firstClock = new ClockConfiguration(true, ClockType.Large);
    this.secondClock = new ClockConfiguration(true, ClockType.Medium);
    this.thirdClock = new ClockConfiguration(false, ClockType.Small);

    this.samplePersonCollection = [
      new Person('Kamil', 'Wolczyk', '12345678'),
      new Person('Jan', 'Boruc', '85472645'),
      new Person('Wieslaw', 'Wszywska', '812351542'),
      new Person('Ziutek', 'Zul', '32145678'),
      new Person('Zosia', 'Samosia', '369828424'),
    ];
  }

}
