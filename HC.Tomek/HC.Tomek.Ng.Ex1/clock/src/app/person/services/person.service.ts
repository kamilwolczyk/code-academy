import { Injectable } from '@angular/core';
import { Person } from "app/person/models/person";

@Injectable()
export class PersonService {
  private persons: Person[];
  constructor() {
    this.persons = [
      new Person('Tomek', 'Lewandowski', 504563838),
      new Person('Kamil', 'Wolczyk', 689324121)
    ];
  }
  getPersons(): Person[]{
    return this.persons;
  }

}
