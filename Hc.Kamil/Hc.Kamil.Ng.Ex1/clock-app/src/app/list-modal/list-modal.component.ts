import { PersonService } from '../persons/services/person.service';
import { Component, OnInit } from '@angular/core';
import { Person } from "app/persons/models/person";

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
