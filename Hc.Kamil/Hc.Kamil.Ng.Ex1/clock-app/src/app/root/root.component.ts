import { Person } from '../persons/models/person';
import { ClockConfiguration, ClockType } from '../clock/clockConfiguration';
import { Component, OnInit } from '@angular/core';
import { PersonService } from "app/persons/services/person.service";

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

  constructor(private personService: PersonService) { }

  ngOnInit() {
    this.firstClock = new ClockConfiguration(true, ClockType.Large);
    this.secondClock = new ClockConfiguration(true, ClockType.Medium);
    this.thirdClock = new ClockConfiguration(false, ClockType.Small);

    this.samplePersonCollection = this.personService.getPersons();
  }

}
