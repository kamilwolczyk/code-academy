import { Injectable } from '@angular/core';
import { Person } from "app/persons/models/person";

@Injectable()
export class PersonService {
  private persons: Person[];

  constructor() {
    this.persons = [
      new Person('Kamil', 'Wolczyk', '12345678'),
      new Person('Jan', 'Boruc', '85472645'),
      new Person('Wieslaw', 'Wszywska', '812351542'),
      new Person('Ziutek', 'Zul', '32145678'),
      new Person('Zosia', 'Samosia', '369828424'),
    ];
  }

  getPersons(): Person[] {
    return this.persons;
  }

}
