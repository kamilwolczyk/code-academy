import { Component, OnInit } from '@angular/core';
import { Person } from 'app/person/models/person';
import { PersonService } from 'app/person/services/person.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  personTable1: Person[];
  constructor(private personService: PersonService){}
  ngOnInit() {

    this.personTable1 = this.personService.getPersons();
  }
}

