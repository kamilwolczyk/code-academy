import { Component, OnInit } from '@angular/core';
import { Person } from 'app/person/models/person';
import { PersonService } from 'app/person/services/person.service';

@Component({
  selector: 'app-list-modal',
  templateUrl: './list-modal.component.html',
  styleUrls: ['./list-modal.component.css']
})
export class ListModalComponent implements OnInit {
  personList: Person[];
  constructor(private personService: PersonService) { }

  ngOnInit() {
     this.personList = this.personService.getPersons();
  }
}
